using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApp1.ChessBoardManager;
using static WindowsFormsApp1.SocketData;

namespace WindowsFormsApp1
{
    public partial class Form_Main : Form
    {
        #region Properties
        ChessBoardManager ChessBoard;
        private string playername,playeremail;
        SocketManager socket;// = new SocketManager();
        #endregion

        public Form_Main(string username,string useremail)
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            this.playername = username;
            this.playeremail = useremail;
            ChessBoard = new ChessBoardManager(pnl_ChessBoard);
            ChessBoard.DrawChessBoard(pnl_ChessBoard);
            ChessBoard.EndedGame += ChessBoard_EndedGame;
            ChessBoard.PlayerMarked += ChessBoard_PlayerMarked;
            pcbCoolDown.Maximum = Cons.COOL_DOWN_TIME;
            pcbCoolDown.Step = Cons.COOL_DOWN_STEP;
            pcbCoolDown.Value = 0;

            tmCoolDown.Interval = Cons.COOL_DOWN_INTERVAL;

            socket = new SocketManager();

            NewGame();
            pnl_ChessBoard.Enabled = false;
            
        }

        #region Methos

        void NewGame()
        {
            pcbCoolDown.Value = 0;
            tmCoolDown.Stop();
            btn_Undo.Enabled = true;
            ChessBoard.DrawChessBoard(pnl_ChessBoard);
        }
        void EndGame()
        {
            tmCoolDown.Stop();
            pnl_ChessBoard.Enabled = false;
            btn_Undo.Enabled = false;
            //MessageBox.Show("Game Over!");
        }

        void Undo()
        {
            ChessBoard.Undo();
            pcbCoolDown.Value = 0;
        }

        private void ChessBoard_PlayerMarked(object sender, ButtonClickEvent e)
        {
            tmCoolDown.Start();
            pnl_ChessBoard.Enabled = false;
            pcbCoolDown.Value = 0;

            socket.Send(new SocketData((int)SocketCommand.SEND_POINT, "", e.ClickedPoint));

            btn_Undo.Enabled = false;

            Listen();
        }

        private void ChessBoard_EndedGame(object sender, EventArgs e)
        {
            EndGame();

            socket.Send(new SocketData((int)SocketCommand.END_GAME, "", new Point()));
        }

        private void tmCoolDown_Tick(object sender, EventArgs e)
        {
            pcbCoolDown.PerformStep();
            if (pcbCoolDown.Value >= pcbCoolDown.Maximum)
            {
                EndGame();
                socket.Send(new SocketData((int)SocketCommand.TIME_OUT, "", new Point()));
            }
        }

        private void btn_Out_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure to log out?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
            {
                e.Cancel = true;
            }   
            else
            {
                try
                {
                    socket.Send(new SocketData((int)SocketCommand.QUIT, "", new Point()));
                }
                catch { }
            }
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            NewGame();
            //if(socket.ConnecServer())
           // {
                socket.Send(new SocketData((int)SocketCommand.NEW_GAME, "", new Point()));
                pnl_ChessBoard.Enabled = true;
            //}    
            
        }

        private void btn_About_Click(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            pnl_ChessBoard.Controls.Clear();
           // Control_About.Height = pnl_ChessBoard.Height;
           // Control_About.Top = pnl_ChessBoard.Top;
            Control_About.BringToFront();
            //this.Controls.Add(control_About);
            // Control_Aboutt.Visible = true;
            pnl_ChessBoard.Enabled = true;
            Control_About.Enabled = true;
            pnl_ChessBoard.Controls.Add(Control_About);
            Control_About.Show();
        }

        private void btn_Undo_Click(object sender, EventArgs e)
        {
            Undo();
            socket.Send(new SocketData((int)SocketCommand.UNDO, "", new Point()));
        }

        private void btn_Lan_Click(object sender, EventArgs e)
        {
            ChessBoard = new ChessBoardManager(pnl_ChessBoard);
            ChessBoard.DrawChessBoard(pnl_ChessBoard);
            ChessBoard.EndedGame += ChessBoard_EndedGame;
            ChessBoard.PlayerMarked += ChessBoard_PlayerMarked;
            socket.IP = txt_IP.Text;

            if(!socket.ConnecServer())
            {
                socket.isServer = true;
                pnl_ChessBoard.Enabled = true;
                socket.CreateServer();
            }
            else
            {
                socket.isServer = false;
                pnl_ChessBoard.Enabled = false;
                Listen();
                MessageBox.Show("Kết nối thành công");
            }
            
        }
        void Listen()
        {
            Thread listenThread = new Thread(() =>
            {
                try
                {
                    SocketData data = (SocketData)socket.Received();
                    ProcessData(data);
                }
                catch (Exception )
                {
                    
                }
            });
            listenThread.IsBackground = true;
            listenThread.Start();
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            lb_Level.Text = "Tân Binh";
            lb_Name.Text = playername;
            lb_Email.Text = playeremail;
            txt_IP.Text = socket.GetLocalIPv4(System.Net.NetworkInformation.NetworkInterfaceType.Wireless80211);

            if(string.IsNullOrEmpty(txt_IP.Text))
            {
                txt_IP.Text = socket.GetLocalIPv4(System.Net.NetworkInformation.NetworkInterfaceType.Ethernet);
            }
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            /*string mess = lb_Name.Text + ": " + txt_Mess.Text;
            socket.Send(new SocketData((int)SocketCommand.SEND_MESS, mess, new Point()));*/
        }

        public void UpdateScore()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionstring))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Player SET Score += 3 WHERE Username = @username", connection);
                cmd.Parameters.AddWithValue("@username", lb_Name.Text);
                //   return true;
            }
        }

        private void ProcessData(SocketData data)
        {
            switch (data.Command)
            {
                case (int)SocketCommand.NOTIFY:
                    MessageBox.Show(data.Message);
                    break;
                case (int)SocketCommand.SEND_MESS:
                    MessageBox.Show(data.Message);
                    break;
                case (int)SocketCommand.NEW_GAME:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        NewGame();
                        pnl_ChessBoard.Enabled = false;
                    }));
                    break;
                case (int)SocketCommand.SEND_POINT:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        pcbCoolDown.Value = 0;
                        pnl_ChessBoard.Enabled = true;
                        tmCoolDown.Start();
                        ChessBoard.OtherPlayerMark(data.Point);
                        btn_Undo.Enabled = true;
                    }));
                    break;
                case (int)SocketCommand.UNDO:
                    Undo();
                    pcbCoolDown.Value = 0; 
                    break;
                case (int)SocketCommand.END_GAME:
                    tmCoolDown.Stop();
                    MessageBox.Show("You Win");
                    UpdateScore();
                    break;
                case (int)SocketCommand.TIME_OUT:
                    MessageBox.Show("Hết Thời Gian");
                    UpdateScore();
                    break;
                case (int)SocketCommand.QUIT:
                    tmCoolDown.Stop();
                    MessageBox.Show("Người Chơi Đã Thoát");
                    socket.Close();
                    break;
                default:
                    break;
            }

            Listen();
        }

        private void btn_Computer_Click(object sender, EventArgs e)
        {
            ChessBoard = new ChessBoardManager(pnl_ChessBoard);
            ChessBoard.DrawChessBoard(pnl_ChessBoard);
            ChessBoard.EndedGame += ChessBoard_EndedGame;
            NewGame();
        }

        private void btn_Chart_Click(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            pnl_ChessBoard.Controls.Clear();
            Control_Charts.BringToFront();
            pnl_ChessBoard.Enabled = true;
            Control_Charts.Enabled = true;
            pnl_ChessBoard.Controls.Add(Control_Charts);
            Control_Charts.Show();
        }

        private void btn_Instruct_Click(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            pnl_ChessBoard.Controls.Clear();
            Control_Instruction.BringToFront();
            pnl_ChessBoard.Enabled = true;
            Control_Instruction.Enabled = true;
            pnl_ChessBoard.Controls.Add(Control_Instruction);
            Control_Instruction.Show();
        }

        private void btn_DashBoard_Click(object sender, EventArgs e)
        {
            ChessBoard.DrawChessBoard(pnl_ChessBoard);
            pnl_ChessBoard.Enabled = false;
        }

        public void InFoMessage(string mess)
        {
            ListViewItem item = new ListViewItem();
            item.Text = mess;

            if (list_Mess.InvokeRequired)
            {
                list_Mess.Invoke(new MethodInvoker(delegate ()
                {
                    list_Mess.Items.Add(item);
                }));
            }
            else
            {
                list_Mess.Items.Add(item);
            }
        }
        #endregion
    }
}
