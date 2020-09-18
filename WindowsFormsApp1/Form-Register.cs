using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form_Register : Form
    {
        public Form_Register()
        {
            InitializeComponent();
        }

        int CheckUser()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionstring))
            {
                SqlCommand cmd = new SqlCommand("Select Username from Player p where p.Username=@username", connection);
                cmd.Parameters.AddWithValue("@username", txt_User.Text);
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                connection.Close();
                int count = ds.Tables[0].Rows.Count;
                return count;
            }
           // return 0;
        }
        void Register()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionstring))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("insert into Player values (@Username,@Password,@Email,@Score)", connection);
                cmd.Parameters.AddWithValue("@Username", txt_User.Text);
                cmd.Parameters.AddWithValue("@Password", txt_Pass.Text);
                cmd.Parameters.AddWithValue("@Email", txt_Email.Text);
                cmd.Parameters.AddWithValue("@Score", 0);
                cmd.ExecuteNonQuery();
                connection.Close();
             //   return true;
            }
           // return false;
        }
        private void btn_Log_Click(object sender, EventArgs e)
        {
           
            if (txt_User.Text == "" || txt_Pass.Text == "" )
            {
                label_Notify.Text = "Vui lòng nhập đầy đủ thông tin!";
            }
            else if(CheckUser()==1)  // check user có tồn tại không. nếu có hàm CheckUser sẽ trả về 1.
            {
                label_Notify.Text = "Tài khoản đã tồn tại.";
                label_Notify.ForeColor = Color.Red;
            }
            else
            {
                Register();
                Form_Main formmain = new Form_Main(txt_User.Text, txt_Email.Text);
                formmain.Show();
                //formmain.FormClosed += Logout;
                this.Hide();

            }
            
        }

        private void Form_Register_Load(object sender, EventArgs e)
        {
            btn_Register.Select();
        }

        private void txt_User_Click(object sender, EventArgs e)
        {
            txt_User.Text = "";
        }

        private void txt_User_Leave(object sender, EventArgs e)
        {
            if (txt_User.Text == "")
            {
                txt_User.Text = "Username";
                txt_User.ForeColor = Color.FromArgb(30, 132, 178);
            }
        }

        private void txt_Pass_Click(object sender, EventArgs e)
        {
            txt_Pass.Text = "";
        }

        private void txt_Pass_Leave(object sender, EventArgs e)
        {
            if (txt_Pass.Text == "")
            {
                txt_Pass.Text = "Password";
                txt_Pass.ForeColor = Color.FromArgb(30, 132, 178);
                txt_Pass.UseSystemPasswordChar = true;
            }
        }

        private void txt_Email_Click(object sender, EventArgs e)
        {
            txt_Email.Text = "";
        }

        private void txt_Email_Leave(object sender, EventArgs e)
        {
            if (txt_Email.Text == "")
            {
                txt_Email.Text = "Email";
                txt_Email.ForeColor = Color.FromArgb(30, 132, 178);
            }
        }
    }
}
