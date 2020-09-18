namespace WindowsFormsApp1
{
    partial class Form_LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_LogIn));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_Notify = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Reg = new System.Windows.Forms.Button();
            this.btn_Log = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_User = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label_Notify);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_Reg);
            this.panel1.Controls.Add(this.btn_Log);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.txt_Pass);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txt_User);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 495);
            this.panel1.TabIndex = 0;
            // 
            // label_Notify
            // 
            this.label_Notify.AutoSize = true;
            this.label_Notify.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Notify.ForeColor = System.Drawing.Color.Red;
            this.label_Notify.Location = new System.Drawing.Point(57, 192);
            this.label_Notify.Name = "label_Notify";
            this.label_Notify.Size = new System.Drawing.Size(0, 16);
            this.label_Notify.TabIndex = 15;
            this.label_Notify.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(132)))), ((int)(((byte)(178)))));
            this.label2.Location = new System.Drawing.Point(109, 469);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 14);
            this.label2.TabIndex = 14;
            this.label2.Text = "Phiên bản 1.0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(132)))), ((int)(((byte)(178)))));
            this.label1.Location = new System.Drawing.Point(57, 453);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "2020 © Đức Trọng - Phát Triển";
            // 
            // btn_Reg
            // 
            this.btn_Reg.BackColor = System.Drawing.Color.Transparent;
            this.btn_Reg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reg.Location = new System.Drawing.Point(45, 400);
            this.btn_Reg.Name = "btn_Reg";
            this.btn_Reg.Size = new System.Drawing.Size(209, 40);
            this.btn_Reg.TabIndex = 12;
            this.btn_Reg.Text = "Rigister";
            this.btn_Reg.UseVisualStyleBackColor = false;
            this.btn_Reg.Click += new System.EventHandler(this.btn_Reg_Click);
            // 
            // btn_Log
            // 
            this.btn_Log.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(132)))), ((int)(((byte)(178)))));
            this.btn_Log.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Log.Location = new System.Drawing.Point(45, 347);
            this.btn_Log.Name = "btn_Log";
            this.btn_Log.Size = new System.Drawing.Size(209, 40);
            this.btn_Log.TabIndex = 11;
            this.btn_Log.Text = "Sign in";
            this.btn_Log.UseVisualStyleBackColor = false;
            this.btn_Log.Click += new System.EventHandler(this.btn_Log_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(45, 288);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(31, 26);
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Location = new System.Drawing.Point(45, 316);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(209, 1);
            this.panel3.TabIndex = 6;
            // 
            // txt_Pass
            // 
            this.txt_Pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Pass.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(132)))), ((int)(((byte)(178)))));
            this.txt_Pass.Location = new System.Drawing.Point(98, 288);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.Size = new System.Drawing.Size(145, 22);
            this.txt_Pass.TabIndex = 5;
            this.txt_Pass.Text = "Password";
            this.txt_Pass.UseSystemPasswordChar = true;
            this.txt_Pass.Click += new System.EventHandler(this.txt_Pass_Click);
            this.txt_Pass.Leave += new System.EventHandler(this.txt_Pass_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Location = new System.Drawing.Point(45, 253);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(209, 1);
            this.panel2.TabIndex = 3;
            // 
            // txt_User
            // 
            this.txt_User.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_User.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_User.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(132)))), ((int)(((byte)(178)))));
            this.txt_User.Location = new System.Drawing.Point(98, 225);
            this.txt_User.Name = "txt_User";
            this.txt_User.Size = new System.Drawing.Size(145, 22);
            this.txt_User.TabIndex = 2;
            this.txt_User.Text = "Username";
            this.txt_User.Click += new System.EventHandler(this.txt_User_Click);
            this.txt_User.Leave += new System.EventHandler(this.txt_User_Leave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(45, 225);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 26);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(35, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 162);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form_LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 493);
            this.Controls.Add(this.panel1);
            this.Name = "Form_LogIn";
            this.Text = "Form_LogIn";
            this.Load += new System.EventHandler(this.Form_LogIn_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_User;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_Reg;
        private System.Windows.Forms.Button btn_Log;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_Pass;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_Notify;
    }
}