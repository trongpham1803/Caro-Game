namespace WindowsFormsApp1
{
    partial class Form_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.pnl_DashBoard = new System.Windows.Forms.Panel();
            this.lb_Email = new System.Windows.Forms.Label();
            this.lb_Name = new System.Windows.Forms.Label();
            this.btn_Out = new System.Windows.Forms.Button();
            this.lb_Level = new System.Windows.Forms.Label();
            this.ptb_Logo = new System.Windows.Forms.PictureBox();
            this.ptb_Instruct = new System.Windows.Forms.PictureBox();
            this.ptb_Charts = new System.Windows.Forms.PictureBox();
            this.ptb_Dash = new System.Windows.Forms.PictureBox();
            this.btn_Instruct = new System.Windows.Forms.Button();
            this.btn_Chart = new System.Windows.Forms.Button();
            this.btn_DashBoard = new System.Windows.Forms.Button();
            this.pnl_ChessBoard = new System.Windows.Forms.Panel();
            this.pnl_Info = new System.Windows.Forms.Panel();
            this.btn_About = new System.Windows.Forms.Button();
            this.btn_Undo = new System.Windows.Forms.Button();
            this.btn_Setting = new System.Windows.Forms.Button();
            this.btn_Notify = new System.Windows.Forms.Button();
            this.ptb_Home = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.pnl_Box = new System.Windows.Forms.Panel();
            this.pnl_Lan = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_New = new System.Windows.Forms.Button();
            this.pcbCoolDown = new System.Windows.Forms.ProgressBar();
            this.txt_IP = new System.Windows.Forms.TextBox();
            this.btn_Computer = new System.Windows.Forms.Button();
            this.btn_Lan = new System.Windows.Forms.Button();
            this.pnl_Mess = new System.Windows.Forms.Panel();
            this.btn_Send = new System.Windows.Forms.Button();
            this.list_Mess = new System.Windows.Forms.ListView();
            this.txt_Mess = new System.Windows.Forms.TextBox();
            this.tmCoolDown = new System.Windows.Forms.Timer(this.components);
            this.Control_Instruction = new WindowsFormsApp1.Intruction();
            this.Control_Charts = new WindowsFormsApp1.Charts();
            this.Control_About = new WindowsFormsApp1.About_Control();
            this.pnl_DashBoard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Instruct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Charts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Dash)).BeginInit();
            this.pnl_ChessBoard.SuspendLayout();
            this.pnl_Info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Home)).BeginInit();
            this.pnl_Box.SuspendLayout();
            this.pnl_Lan.SuspendLayout();
            this.pnl_Mess.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_DashBoard
            // 
            this.pnl_DashBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.pnl_DashBoard.Controls.Add(this.lb_Email);
            this.pnl_DashBoard.Controls.Add(this.lb_Name);
            this.pnl_DashBoard.Controls.Add(this.btn_Out);
            this.pnl_DashBoard.Controls.Add(this.lb_Level);
            this.pnl_DashBoard.Controls.Add(this.ptb_Logo);
            this.pnl_DashBoard.Controls.Add(this.ptb_Instruct);
            this.pnl_DashBoard.Controls.Add(this.ptb_Charts);
            this.pnl_DashBoard.Controls.Add(this.ptb_Dash);
            this.pnl_DashBoard.Controls.Add(this.btn_Instruct);
            this.pnl_DashBoard.Controls.Add(this.btn_Chart);
            this.pnl_DashBoard.Controls.Add(this.btn_DashBoard);
            this.pnl_DashBoard.Location = new System.Drawing.Point(1, 0);
            this.pnl_DashBoard.Name = "pnl_DashBoard";
            this.pnl_DashBoard.Size = new System.Drawing.Size(161, 462);
            this.pnl_DashBoard.TabIndex = 0;
            // 
            // lb_Email
            // 
            this.lb_Email.AutoSize = true;
            this.lb_Email.ForeColor = System.Drawing.Color.White;
            this.lb_Email.Location = new System.Drawing.Point(71, 66);
            this.lb_Email.Name = "lb_Email";
            this.lb_Email.Size = new System.Drawing.Size(0, 13);
            this.lb_Email.TabIndex = 1;
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.ForeColor = System.Drawing.Color.White;
            this.lb_Name.Location = new System.Drawing.Point(71, 43);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(0, 13);
            this.lb_Name.TabIndex = 0;
            // 
            // btn_Out
            // 
            this.btn_Out.BackColor = System.Drawing.Color.Transparent;
            this.btn_Out.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Out.BackgroundImage")));
            this.btn_Out.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Out.FlatAppearance.BorderSize = 0;
            this.btn_Out.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Out.Location = new System.Drawing.Point(58, 421);
            this.btn_Out.Name = "btn_Out";
            this.btn_Out.Size = new System.Drawing.Size(38, 35);
            this.btn_Out.TabIndex = 1;
            this.btn_Out.UseVisualStyleBackColor = false;
            this.btn_Out.Click += new System.EventHandler(this.btn_Out_Click);
            // 
            // lb_Level
            // 
            this.lb_Level.AutoSize = true;
            this.lb_Level.ForeColor = System.Drawing.Color.White;
            this.lb_Level.Location = new System.Drawing.Point(71, 24);
            this.lb_Level.Name = "lb_Level";
            this.lb_Level.Size = new System.Drawing.Size(0, 13);
            this.lb_Level.TabIndex = 0;
            // 
            // ptb_Logo
            // 
            this.ptb_Logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptb_Logo.BackgroundImage")));
            this.ptb_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptb_Logo.Location = new System.Drawing.Point(3, 24);
            this.ptb_Logo.Name = "ptb_Logo";
            this.ptb_Logo.Size = new System.Drawing.Size(62, 55);
            this.ptb_Logo.TabIndex = 0;
            this.ptb_Logo.TabStop = false;
            // 
            // ptb_Instruct
            // 
            this.ptb_Instruct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptb_Instruct.BackgroundImage")));
            this.ptb_Instruct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb_Instruct.Location = new System.Drawing.Point(11, 248);
            this.ptb_Instruct.Name = "ptb_Instruct";
            this.ptb_Instruct.Size = new System.Drawing.Size(27, 26);
            this.ptb_Instruct.TabIndex = 3;
            this.ptb_Instruct.TabStop = false;
            // 
            // ptb_Charts
            // 
            this.ptb_Charts.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptb_Charts.BackgroundImage")));
            this.ptb_Charts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb_Charts.Location = new System.Drawing.Point(11, 207);
            this.ptb_Charts.Name = "ptb_Charts";
            this.ptb_Charts.Size = new System.Drawing.Size(27, 26);
            this.ptb_Charts.TabIndex = 3;
            this.ptb_Charts.TabStop = false;
            // 
            // ptb_Dash
            // 
            this.ptb_Dash.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptb_Dash.BackgroundImage")));
            this.ptb_Dash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb_Dash.Location = new System.Drawing.Point(11, 164);
            this.ptb_Dash.Name = "ptb_Dash";
            this.ptb_Dash.Size = new System.Drawing.Size(27, 26);
            this.ptb_Dash.TabIndex = 2;
            this.ptb_Dash.TabStop = false;
            // 
            // btn_Instruct
            // 
            this.btn_Instruct.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Instruct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Instruct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Instruct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Instruct.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Instruct.ForeColor = System.Drawing.Color.White;
            this.btn_Instruct.Location = new System.Drawing.Point(0, 239);
            this.btn_Instruct.Name = "btn_Instruct";
            this.btn_Instruct.Size = new System.Drawing.Size(161, 46);
            this.btn_Instruct.TabIndex = 1;
            this.btn_Instruct.Text = "Instruction";
            this.btn_Instruct.UseVisualStyleBackColor = true;
            this.btn_Instruct.Click += new System.EventHandler(this.btn_Instruct_Click);
            // 
            // btn_Chart
            // 
            this.btn_Chart.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Chart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Chart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Chart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Chart.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Chart.ForeColor = System.Drawing.Color.White;
            this.btn_Chart.Location = new System.Drawing.Point(0, 196);
            this.btn_Chart.Name = "btn_Chart";
            this.btn_Chart.Size = new System.Drawing.Size(161, 46);
            this.btn_Chart.TabIndex = 1;
            this.btn_Chart.Text = "Charts";
            this.btn_Chart.UseVisualStyleBackColor = true;
            this.btn_Chart.Click += new System.EventHandler(this.btn_Chart_Click);
            // 
            // btn_DashBoard
            // 
            this.btn_DashBoard.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_DashBoard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_DashBoard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_DashBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DashBoard.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DashBoard.ForeColor = System.Drawing.Color.White;
            this.btn_DashBoard.Location = new System.Drawing.Point(0, 154);
            this.btn_DashBoard.Name = "btn_DashBoard";
            this.btn_DashBoard.Size = new System.Drawing.Size(164, 46);
            this.btn_DashBoard.TabIndex = 0;
            this.btn_DashBoard.Text = "DashBoard";
            this.btn_DashBoard.UseVisualStyleBackColor = true;
            this.btn_DashBoard.Click += new System.EventHandler(this.btn_DashBoard_Click);
            // 
            // pnl_ChessBoard
            // 
            this.pnl_ChessBoard.BackColor = System.Drawing.Color.White;
            this.pnl_ChessBoard.Controls.Add(this.Control_Instruction);
            this.pnl_ChessBoard.Controls.Add(this.Control_Charts);
            this.pnl_ChessBoard.Controls.Add(this.Control_About);
            this.pnl_ChessBoard.Location = new System.Drawing.Point(160, 43);
            this.pnl_ChessBoard.Name = "pnl_ChessBoard";
            this.pnl_ChessBoard.Size = new System.Drawing.Size(540, 419);
            this.pnl_ChessBoard.TabIndex = 2;
            // 
            // pnl_Info
            // 
            this.pnl_Info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(132)))), ((int)(((byte)(178)))));
            this.pnl_Info.Controls.Add(this.btn_About);
            this.pnl_Info.Controls.Add(this.btn_Undo);
            this.pnl_Info.Controls.Add(this.btn_Setting);
            this.pnl_Info.Controls.Add(this.btn_Notify);
            this.pnl_Info.Controls.Add(this.ptb_Home);
            this.pnl_Info.Controls.Add(this.button4);
            this.pnl_Info.Location = new System.Drawing.Point(160, 0);
            this.pnl_Info.Name = "pnl_Info";
            this.pnl_Info.Size = new System.Drawing.Size(540, 43);
            this.pnl_Info.TabIndex = 1;
            // 
            // btn_About
            // 
            this.btn_About.BackColor = System.Drawing.Color.Transparent;
            this.btn_About.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_About.BackgroundImage")));
            this.btn_About.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_About.FlatAppearance.BorderSize = 0;
            this.btn_About.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_About.Location = new System.Drawing.Point(508, 8);
            this.btn_About.Name = "btn_About";
            this.btn_About.Size = new System.Drawing.Size(25, 29);
            this.btn_About.TabIndex = 5;
            this.btn_About.UseVisualStyleBackColor = false;
            this.btn_About.Click += new System.EventHandler(this.btn_About_Click);
            // 
            // btn_Undo
            // 
            this.btn_Undo.BackColor = System.Drawing.Color.Transparent;
            this.btn_Undo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Undo.BackgroundImage")));
            this.btn_Undo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Undo.FlatAppearance.BorderSize = 0;
            this.btn_Undo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Undo.Location = new System.Drawing.Point(372, 8);
            this.btn_Undo.Name = "btn_Undo";
            this.btn_Undo.Size = new System.Drawing.Size(25, 29);
            this.btn_Undo.TabIndex = 4;
            this.btn_Undo.UseVisualStyleBackColor = false;
            this.btn_Undo.Click += new System.EventHandler(this.btn_Undo_Click);
            // 
            // btn_Setting
            // 
            this.btn_Setting.BackColor = System.Drawing.Color.Transparent;
            this.btn_Setting.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Setting.BackgroundImage")));
            this.btn_Setting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Setting.FlatAppearance.BorderSize = 0;
            this.btn_Setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Setting.Location = new System.Drawing.Point(463, 8);
            this.btn_Setting.Name = "btn_Setting";
            this.btn_Setting.Size = new System.Drawing.Size(25, 29);
            this.btn_Setting.TabIndex = 4;
            this.btn_Setting.UseVisualStyleBackColor = false;
            // 
            // btn_Notify
            // 
            this.btn_Notify.BackColor = System.Drawing.Color.Transparent;
            this.btn_Notify.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Notify.BackgroundImage")));
            this.btn_Notify.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Notify.FlatAppearance.BorderSize = 0;
            this.btn_Notify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Notify.Location = new System.Drawing.Point(419, 8);
            this.btn_Notify.Name = "btn_Notify";
            this.btn_Notify.Size = new System.Drawing.Size(25, 29);
            this.btn_Notify.TabIndex = 3;
            this.btn_Notify.UseVisualStyleBackColor = false;
            // 
            // ptb_Home
            // 
            this.ptb_Home.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptb_Home.BackgroundImage")));
            this.ptb_Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb_Home.Location = new System.Drawing.Point(8, 11);
            this.ptb_Home.Name = "ptb_Home";
            this.ptb_Home.Size = new System.Drawing.Size(27, 26);
            this.ptb_Home.TabIndex = 3;
            this.ptb_Home.TabStop = false;
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Default;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(30, 11);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 0;
            this.button4.Text = "Home";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // pnl_Box
            // 
            this.pnl_Box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.pnl_Box.Controls.Add(this.pnl_Lan);
            this.pnl_Box.Controls.Add(this.pnl_Mess);
            this.pnl_Box.Location = new System.Drawing.Point(699, 0);
            this.pnl_Box.Name = "pnl_Box";
            this.pnl_Box.Size = new System.Drawing.Size(211, 462);
            this.pnl_Box.TabIndex = 3;
            // 
            // pnl_Lan
            // 
            this.pnl_Lan.Controls.Add(this.label3);
            this.pnl_Lan.Controls.Add(this.label2);
            this.pnl_Lan.Controls.Add(this.label1);
            this.pnl_Lan.Controls.Add(this.btn_New);
            this.pnl_Lan.Controls.Add(this.pcbCoolDown);
            this.pnl_Lan.Controls.Add(this.txt_IP);
            this.pnl_Lan.Controls.Add(this.btn_Computer);
            this.pnl_Lan.Controls.Add(this.btn_Lan);
            this.pnl_Lan.Location = new System.Drawing.Point(0, 248);
            this.pnl_Lan.Name = "pnl_Lan";
            this.pnl_Lan.Size = new System.Drawing.Size(213, 214);
            this.pnl_Lan.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(135, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "New Game";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(22, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Computer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(36, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "LAN";
            // 
            // btn_New
            // 
            this.btn_New.BackColor = System.Drawing.Color.Transparent;
            this.btn_New.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_New.BackgroundImage")));
            this.btn_New.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_New.FlatAppearance.BorderSize = 0;
            this.btn_New.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_New.Location = new System.Drawing.Point(113, 126);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(94, 63);
            this.btn_New.TabIndex = 5;
            this.btn_New.UseVisualStyleBackColor = false;
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // pcbCoolDown
            // 
            this.pcbCoolDown.Location = new System.Drawing.Point(4, 89);
            this.pcbCoolDown.Name = "pcbCoolDown";
            this.pcbCoolDown.Size = new System.Drawing.Size(203, 31);
            this.pcbCoolDown.TabIndex = 4;
            // 
            // txt_IP
            // 
            this.txt_IP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.txt_IP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_IP.Location = new System.Drawing.Point(110, 26);
            this.txt_IP.Name = "txt_IP";
            this.txt_IP.Size = new System.Drawing.Size(100, 20);
            this.txt_IP.TabIndex = 3;
            this.txt_IP.Text = "192.169.111.111";
            // 
            // btn_Computer
            // 
            this.btn_Computer.BackColor = System.Drawing.Color.Transparent;
            this.btn_Computer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Computer.BackgroundImage")));
            this.btn_Computer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Computer.FlatAppearance.BorderSize = 0;
            this.btn_Computer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Computer.Location = new System.Drawing.Point(3, 126);
            this.btn_Computer.Name = "btn_Computer";
            this.btn_Computer.Size = new System.Drawing.Size(94, 63);
            this.btn_Computer.TabIndex = 2;
            this.btn_Computer.UseVisualStyleBackColor = false;
            this.btn_Computer.Click += new System.EventHandler(this.btn_Computer_Click);
            // 
            // btn_Lan
            // 
            this.btn_Lan.BackColor = System.Drawing.Color.Transparent;
            this.btn_Lan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Lan.BackgroundImage")));
            this.btn_Lan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Lan.FlatAppearance.BorderSize = 0;
            this.btn_Lan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Lan.Location = new System.Drawing.Point(4, 3);
            this.btn_Lan.Name = "btn_Lan";
            this.btn_Lan.Size = new System.Drawing.Size(94, 63);
            this.btn_Lan.TabIndex = 0;
            this.btn_Lan.UseVisualStyleBackColor = false;
            this.btn_Lan.Click += new System.EventHandler(this.btn_Lan_Click);
            // 
            // pnl_Mess
            // 
            this.pnl_Mess.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Mess.Controls.Add(this.btn_Send);
            this.pnl_Mess.Controls.Add(this.list_Mess);
            this.pnl_Mess.Controls.Add(this.txt_Mess);
            this.pnl_Mess.Location = new System.Drawing.Point(3, 3);
            this.pnl_Mess.Name = "pnl_Mess";
            this.pnl_Mess.Size = new System.Drawing.Size(213, 239);
            this.pnl_Mess.TabIndex = 2;
            // 
            // btn_Send
            // 
            this.btn_Send.Location = new System.Drawing.Point(167, 207);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(40, 23);
            this.btn_Send.TabIndex = 0;
            this.btn_Send.Text = "Send";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // list_Mess
            // 
            this.list_Mess.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.list_Mess.ForeColor = System.Drawing.Color.White;
            this.list_Mess.HideSelection = false;
            this.list_Mess.Location = new System.Drawing.Point(-3, -3);
            this.list_Mess.Name = "list_Mess";
            this.list_Mess.Size = new System.Drawing.Size(216, 200);
            this.list_Mess.TabIndex = 0;
            this.list_Mess.UseCompatibleStateImageBehavior = false;
            // 
            // txt_Mess
            // 
            this.txt_Mess.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_Mess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Mess.Location = new System.Drawing.Point(3, 210);
            this.txt_Mess.Name = "txt_Mess";
            this.txt_Mess.Size = new System.Drawing.Size(158, 20);
            this.txt_Mess.TabIndex = 1;
            // 
            // tmCoolDown
            // 
            this.tmCoolDown.Tick += new System.EventHandler(this.tmCoolDown_Tick);
            // 
            // Control_Instruction
            // 
            this.Control_Instruction.Location = new System.Drawing.Point(0, 0);
            this.Control_Instruction.Name = "Control_Instruction";
            this.Control_Instruction.Size = new System.Drawing.Size(540, 419);
            this.Control_Instruction.TabIndex = 2;
            // 
            // Control_Charts
            // 
            this.Control_Charts.Location = new System.Drawing.Point(-1, 0);
            this.Control_Charts.Name = "Control_Charts";
            this.Control_Charts.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Control_Charts.Size = new System.Drawing.Size(540, 419);
            this.Control_Charts.TabIndex = 1;
            // 
            // Control_About
            // 
            this.Control_About.Location = new System.Drawing.Point(-1, 0);
            this.Control_About.Name = "Control_About";
            this.Control_About.Size = new System.Drawing.Size(540, 419);
            this.Control_About.TabIndex = 0;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 462);
            this.Controls.Add(this.pnl_Box);
            this.Controls.Add(this.pnl_ChessBoard);
            this.Controls.Add(this.pnl_Info);
            this.Controls.Add(this.pnl_DashBoard);
            this.Name = "Form_Main";
            this.Text = "Form_Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Main_FormClosing);
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.pnl_DashBoard.ResumeLayout(false);
            this.pnl_DashBoard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Instruct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Charts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Dash)).EndInit();
            this.pnl_ChessBoard.ResumeLayout(false);
            this.pnl_Info.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Home)).EndInit();
            this.pnl_Box.ResumeLayout(false);
            this.pnl_Lan.ResumeLayout(false);
            this.pnl_Lan.PerformLayout();
            this.pnl_Mess.ResumeLayout(false);
            this.pnl_Mess.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl_DashBoard;
        private System.Windows.Forms.Panel pnl_ChessBoard;
        private System.Windows.Forms.Panel pnl_Info;
        private System.Windows.Forms.Panel pnl_Box;
        private System.Windows.Forms.Button btn_Instruct;
        private System.Windows.Forms.Button btn_Chart;
        private System.Windows.Forms.Button btn_DashBoard;
        private System.Windows.Forms.PictureBox ptb_Instruct;
        private System.Windows.Forms.PictureBox ptb_Charts;
        private System.Windows.Forms.PictureBox ptb_Logo;
        private System.Windows.Forms.PictureBox ptb_Home;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txt_Mess;
        private System.Windows.Forms.ListView list_Mess;
        private System.Windows.Forms.Panel pnl_Mess;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.Panel pnl_Lan;
        private System.Windows.Forms.Label lb_Level;
        private System.Windows.Forms.Label lb_Email;
        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.Button btn_Out;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_New;
        private System.Windows.Forms.ProgressBar pcbCoolDown;
        private System.Windows.Forms.TextBox txt_IP;
        private System.Windows.Forms.Button btn_Computer;
        private System.Windows.Forms.Button btn_Lan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer tmCoolDown;
        private System.Windows.Forms.Button btn_Notify;
        private System.Windows.Forms.Button btn_Undo;
        private System.Windows.Forms.Button btn_Setting;
        private System.Windows.Forms.Button btn_About;
        private About_Control Control_About;
        private System.Windows.Forms.PictureBox ptb_Dash;
        private Charts Control_Charts;
        private Intruction Control_Instruction;
    }
}