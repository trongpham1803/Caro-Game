using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApp1.SocketData;
namespace WindowsFormsApp1
{
    public class ChessBoardManager
    {
        #region Properties
        private Panel chessBoard;
        private List<Player> player;
        public Panel ChessBoard { get => chessBoard; set => chessBoard = value; }
        public List<Player> Player { get => player; set => player = value; }

        private int currentplayer;
        public int Currentplayer { get => currentplayer; set => currentplayer = value; }

        private List<List<Button>> matrix;
        public List<List<Button>> Matrix { get => matrix; set => matrix = value; }

        private event EventHandler<ButtonClickEvent> playerMarked;
        public event EventHandler<ButtonClickEvent> PlayerMarked
        {
            add
            {
                playerMarked += value;
            }
            remove
            {
                playerMarked -= value;
            }
        }

        private event EventHandler endedGame;
        public event EventHandler EndedGame
        {
            add
            {
                endedGame += value;
            }
            remove
            {
                endedGame -= value;
            }
        }
        private Stack<PlayInfo> playTimeLine;
        public Stack<PlayInfo> PlayTimeLine { get => playTimeLine; set => playTimeLine = value; }

        #endregion

        #region initialize
        public ChessBoardManager(Panel chessboard)
        {
            this.ChessBoard = chessboard;
            this.Player = new List<Player>()
            {
                new Player("player1",Image.FromFile(Application.StartupPath + "//Image//x.png")),
                new Player("player2", Image.FromFile(Application.StartupPath + "//Image//o1.png"))
            };
            //Currentplayer = 0;
        }

        #endregion
        public void DrawChessBoard(Panel chessboard)
        {
            chessboard.Enabled = true;
            chessboard.Controls.Clear();
            PlayTimeLine = new Stack<PlayInfo>();
            Currentplayer = 0;
            Matrix = new List<List<Button>>();
            Button oldbutton = new Button() { Width = 0, Location = new Point(0, 0) };
            for (int i = 0; i < Cons.CHESS_BOARD_HEIGHT; i++)
            {
                Matrix.Add(new List<Button>()); 
                for (int j = 0; j < Cons.CHESS_BOARD_WIDTH; j++)
                {
                    Button btn = new Button()
                    {
                        Width = Cons.CHESS_WIDTH,
                        Height = Cons.CHESS_HEIGHT,
                        Location = new Point(oldbutton.Location.X + oldbutton.Width, oldbutton.Location.Y),
                        BackgroundImageLayout = ImageLayout.Stretch,
                        Tag = i.ToString()
                    };

                    btn.Click += btn_Click; // ủy thác even

                    chessboard.Controls.Add(btn);

                    Matrix[i].Add(btn);

                    oldbutton = btn;
                }
                oldbutton.Location = new Point(0, oldbutton.Location.Y + Cons.CHESS_HEIGHT);
                oldbutton.Width = 0;
                oldbutton.Height = 0;
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;   // để bắt khi click vào

            if (btn.BackgroundImage != null)
                return;

            Mark(btn);

            // xử lý thắng thua cho một người chơi.
            
            PlayTimeLine.Push(new PlayInfo(GetChessPoint(btn), Currentplayer));

            Currentplayer = Currentplayer == 1 ? 0 : 1;

            if (playerMarked != null)
            playerMarked(this, new ButtonClickEvent(GetChessPoint(btn)));
            SocketManager socket = new SocketManager();
            
            if (IsEndGame(btn))
            {
                if (socket.ConnecServer() == false)
                {
                    PvsPEndGame();
                }
                else EndGame();
            }
           
            
        }

        public void OtherPlayerMark(Point point)
        {
            Button btn = Matrix[point.Y][point.X];

            if (btn.BackgroundImage != null)
                return;

            Mark(btn);

            PlayTimeLine.Push(new PlayInfo(GetChessPoint(btn), Currentplayer));

            Currentplayer = Currentplayer == 1 ? 0 : 1;

            //ChangePlayer();

            if (IsEndGame(btn))
            {
                EndGame();
            }
        }

        public void EndGame()
        {
            if (endedGame != null)
                endedGame(this, new EventArgs());
        }

        public void PvsPEndGame()
        {
            MessageBox.Show("Kết thúc");
        }
        
        public bool Undo()
        {
            bool isUndoPlayer1;
            bool isUndoPlayer2;
            PlayInfo oldPoint;
            if (PlayTimeLine.Count <= 0)
                return false;
            else if (PlayTimeLine.Count == 2)
            {
                isUndoPlayer1 = StepUndo();
                isUndoPlayer2 = StepUndo();
                Currentplayer = 0;
            }
            else
            {
                isUndoPlayer1 = StepUndo();
                isUndoPlayer2 = StepUndo();

                oldPoint = PlayTimeLine.Peek();
                Currentplayer = oldPoint.CurrentPlayer == 1 ? 0 : 1;
            }

            return isUndoPlayer1 && isUndoPlayer2;
        }
        private bool StepUndo()
        {
            if (PlayTimeLine.Count <= 0)
                return false;
            PlayInfo oldPoint = PlayTimeLine.Pop();

            Button btn = Matrix[oldPoint.Point.Y][oldPoint.Point.X];
            btn.BackgroundImage = null;

            if (PlayTimeLine.Count <= 0)
            {
                Currentplayer = 0;
            }
            else
            {
                oldPoint = PlayTimeLine.Peek();
            }

            return true;
        }
        private bool IsEndGame(Button btn)
        {
            return IsEndHorizontal(btn) || IsEndVertical(btn) || IsEndPrimaryDiagonal(btn) || IsEndSubDiagonal(btn);
        }
        // lấy tọa độ
        private Point GetChessPoint(Button btn)
        {
            int vertical = Convert.ToInt32(btn.Tag);
            int horizontal = Matrix[vertical].IndexOf(btn);
            Point point = new Point(horizontal,vertical);
            return point;
        }    
        // Xử thắng theo hàng ngang
        private bool IsEndHorizontal(Button btn)
        {
            Point point = GetChessPoint(btn);
            int countLeft = 0;
            for(int i= point.X; i>=0; i--)
            {
                if (Matrix[point.Y][i].BackgroundImage == btn.BackgroundImage)
                {
                    countLeft++;
                }
                else
                    break;                 
            }    
            int countRight = 0;
            for (int i = point.X+1; i < Cons.CHESS_BOARD_WIDTH; i++)
            {
                if (Matrix[point.Y][i].BackgroundImage == btn.BackgroundImage)
                {
                    countRight++;
                }
                else
                    break;
            }
            return countLeft + countRight == 5;
        }
        //Dọc
        private bool IsEndVertical(Button btn)
        {
            Point point = GetChessPoint(btn);
            int countTop = 0;
            for (int i = point.Y; i >= 0; i--)
            {
                if (Matrix[i][point.X].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                }
                else
                    break;
            }
            int countBottom = 0;
            for (int i = point.Y + 1; i < Cons.CHESS_BOARD_HEIGHT; i++)
            {
                if (Matrix[i][point.X].BackgroundImage == btn.BackgroundImage)
                {
                    countBottom++;
                }
                else
                    break;
            }
            return countTop + countBottom == 5;
        }
        //đường chéo chính
        private bool IsEndPrimaryDiagonal(Button btn)
        {
            Point point = GetChessPoint(btn);
            int countTop = 0;
            for (int i = 0; i <= point.X; i++)
            {
                if (point.X - i < 0 || point.Y - i < 0)
                    break;
                if (Matrix[point.Y-i][point.X-i].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                }
                else
                    break;
            }
            int countBottom = 0;
            for (int i = 1; i <= Cons.CHESS_BOARD_WIDTH - point.X; i++)
            {
                if (point.Y + i >= Cons.CHESS_BOARD_HEIGHT || point.X - i <0)
                    break;
                if (Matrix[point.Y + i][point.X - i].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                }
                else
                    break;
            }
            return countTop + countBottom == 5;
        }
        // đường chéo phụ
        private bool IsEndSubDiagonal(Button btn)
        {
            Point point = GetChessPoint(btn);
            int countTop = 0;
            for (int i = 0; i <= point.X; i++)
            {
                if (point.X + i > Cons.CHESS_BOARD_WIDTH || point.Y - i < 0)
                    break;
                if (Matrix[point.Y - i][point.X + i].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                }
                else
                    break;
            }
            int countBottom = 0;
            for (int i = 1; i <= Cons.CHESS_BOARD_WIDTH - point.X; i++)
            {
                if (point.Y + i >= Cons.CHESS_BOARD_HEIGHT || point.X + i >= Cons.CHESS_BOARD_WIDTH)
                    break;
                if (Matrix[point.Y + i][point.X + i].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                }
                else
                    break;
            }
            return countTop + countBottom == 5;
        }

        private void Mark(Button btn)
        {
            btn.BackgroundImage = Player[Currentplayer].Mark;

           // Currentplayer = Currentplayer == 1 ? 0 : 1;
        }
        public class ButtonClickEvent : EventArgs
        {
            private Point clickedPoint;

            public Point ClickedPoint
            {
                get { return clickedPoint; }
                set { clickedPoint = value; }
            }

            public ButtonClickEvent(Point point)
            {
                this.ClickedPoint = point;
            }
        }

    }
}
