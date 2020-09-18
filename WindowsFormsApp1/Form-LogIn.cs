using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form_LogIn : Form
    {
        public Form_LogIn()
        {
            InitializeComponent();
           // Control.CheckForIllegalCrossThreadCalls = false;
        }
        public UserCache player = new UserCache();
        bool Login(string user,string pass)
        {
            //UserCache player = new UserCache();
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionstring))
            {
                
                SqlCommand cmd = new SqlCommand("Select * from Player where Username=@username and Password=@password", connection);
                cmd.Parameters.AddWithValue("@username", txt_User.Text);
                cmd.Parameters.AddWithValue("@password", txt_Pass.Text);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        player.Loginname = reader.GetString(0);
                        player.Password = reader.GetString(1);
                        player.Email = reader.GetString(2);
                    }
                    return true;
                }
                else
                    return false;
            }
        }

        private void btn_Log_Click(object sender, EventArgs e)
        {
            
            if (txt_User.Text == "" || txt_Pass.Text == "")
            {
                label_Notify.Text = "Vui lòng nhập đầy đủ thông tin!";
            }
            else
            {   
                    if (Login(txt_User.Text,txt_Pass.Text) == true)
                    {
                    //Đăng Nhập Thành Công
                    //phần code tiếp theo nếu đăng nhập thành công.
                    Form_Main formmain = new Form_Main(player.Loginname,player.Email);
                    formmain.Show();
                    //formmain.FormClosed += Logout;
                    this.Hide();
                    }
                    else
                    {
                        label_Notify.Text = "Tài khoản hoặc mật khẩu không đúng";
                    }

                
            }
            
        }
        // focus vào button loggin tránh tình trạng autofocus làm mất chữ Username
        private void Form_LogIn_Load(object sender, EventArgs e)
        {
            //this.ActiveControl = btn_Log;
            btn_Log.Select();
        }
        //Khi click txt_User sẽ thành khoảng trắng
        private void txt_User_Click(object sender, EventArgs e)
        {
            txt_User.Text = "";
        }

        private void txt_Pass_Click(object sender, EventArgs e)
        {
            txt_Pass.UseSystemPasswordChar = true;
            txt_Pass.Text = "";
        }

        private void txt_User_Leave(object sender, EventArgs e)
        {
            if(txt_User.Text == "")
            {
                txt_User.Text = "Username";
                txt_User.ForeColor = Color.FromArgb(30, 132, 178);
            }    
        }

        private void txt_Pass_Leave(object sender, EventArgs e)
        {
            if(txt_Pass.Text=="")
            {
                txt_Pass.Text = "Password";
                txt_Pass.ForeColor = Color.FromArgb(30, 132, 178);
                txt_Pass.UseSystemPasswordChar = true;
            }    
        }

        private void btn_Reg_Click(object sender, EventArgs e)
        {
            Form_Register form_register = new Form_Register();
            form_register.Show();
            this.Hide();
        }
    }
}
