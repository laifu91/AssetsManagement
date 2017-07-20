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

namespace AssetsManagement
{
    public partial class RegisterForm : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        string strConnect = "Server=127.0.0.1;DataBase=AssetsDB;Uid=sa;Pwd=123456";
        bool flagRegister;//定义标志位，确认用户注册
        public RegisterForm()
        {
            InitializeComponent();
        }
        private void reg_Click(object sender, EventArgs e)
        {
            if ((usrTextBox.Text.Length >= 4)
                && (usrTextBox.Text.Length <= 12)
                && (pwdTextBox.Text.Length >= 6)
                && (pwd2TextBox.Text.Length >= 6)
                && (pwd2TextBox.Text == pwdTextBox.Text))
            {

                flagRegister = true;//用户名和密码达到要求，做个标记
            }
            else
            {
                if ((usrTextBox.Text.Length < 4) || (usrTextBox.Text.Length > 12))
                {
                    MessageBox.Show("用户名长度在4~12位之间，请确认！", "提示");
                    return;
                }
                if (pwdTextBox.Text.Length < 6)
                {
                    MessageBox.Show("密码长度不足6位，请重新输入", "提示");
                    return;
                }
                if (pwd2TextBox.Text.Length < 6)
                {
                    MessageBox.Show("密码长度不足6位，请重新输入", "提示");
                    return;
                }
                if (pwd2TextBox.Text != pwdTextBox.Text)
                {
                    MessageBox.Show("两次输入的密码不一致，请确认", "提示");
                    return;
                }
            }

            if (flagRegister == true)
            {
                string textBoxUsrName = usrTextBox.Text;
                conn.ConnectionString = strConnect;
                string selSql = "select UserName from [User] where UserName ='" + textBoxUsrName + "'";
                cmd.Connection = conn;
                cmd.CommandText = selSql;
                conn.Open();
                object regUsrName = cmd.ExecuteScalar();
                if (regUsrName == null)
                {
                    string registerCmd = "insert into [User](UserName,UserPassward,UserMail) values " +
                    "('" + usrTextBox.Text + "'," + "'" + pwdTextBox.Text + "'," + "'" + mailTextBox.Text + "')";
                    cmd.CommandText = registerCmd;
                    cmd.ExecuteNonQuery();//执行查询语言
                    DialogResult regResult = MessageBox.Show("注册成功");  //给出提示,注册成功
                    if (regResult == DialogResult.OK)
                    {
                        this.Dispose();
                        LoginForm loginForm = new LoginForm();
                        loginForm.StartPosition = FormStartPosition.CenterScreen;
                        loginForm.ShowDialog();                        
                    }
                    else if(regResult == DialogResult.Cancel)
                    {

                    }
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("用户已存在", "提示");
                    conn.Close();
                    return;
                }
            }
        }
        //string rest = cmd.ExecuteScalar().ToString();
        //        if (rest == textBoxUsrName)
        //        {
        //            MessageBox.Show("用户已存在", "提示");
        //        }
        //        else
        //        {
        //            string registerCmd = "insert into [User](UserName,UserPassward,UserMail) values " +
        //            "('" + usrTextBox.Text + "'," + "'" + pwdTextBox.Text + "'," + "'" + mailTextBox.Text + "')";
        //            cmd.ExecuteNonQuery();//执行查询语言
        //            MessageBox.Show("注册成功");  //给出提示,注册成功
        //        }
        //        conn.Close();
        //    }
        //}
        //        conn.ConnectionString = strConnect;
        //        conn.Open();
        //        string UserName = usrTextBox.Text;
        //        SqlCommand cmd = new SqlCommand("select * from [user] where UserName='" + UserName + "'", conn); 
        //        string registerCmd = "insert into [User](UserName,UserPassward,UserMail) values " +
        //            "('" + usrTextBox.Text + "'," + "'" + pwdTextBox.Text + "'," + "'" + mailTextBox.Text + "')";
        //        string selectTempUserNameCmd = "select * from [User] where UserName ='" + usrTextBox + "'";
        //        SqlDataReader reader = null;
        //        reader = cmd.ExecuteReader();
        //        if (!reader.Read())
        //        {
        //            cmd.CommandText = "Insert into [Users](UserName,UserPassward,UserMail) values " +
        //            "('" + usrTextBox.Text + "'," + "'" + pwdTextBox.Text + "'," + "'" + mailTextBox.Text + "')";
        //            cmd.ExecuteNonQuery();//执行查询语言  
        //            MessageBox.Show("注册成功");  //给出提示,注册成功 
        //        }
        //        else
        //        {
        //            //如果(!reader.Read())为假,说明reader.Read()为真,数据库中没有相同的用户名  
        //            MessageBox.Show("你输入的用户名已存在!");
        //        }
        //        int result = cmd.ExecuteNonQuery();
        //            if (result == 0)
        //            {
        //                MessageBox.Show("注册失败", "提示");
        //            }
        //            else
        //            {
        //                MessageBox.Show("注册成功", "提示");
        //            }
        //        }                   
        //        conn.Close();

        //}
        private void escButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void usrLabel_Click(object sender, EventArgs e)
        {

        }

        private void usrTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pwdTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pwdLabel_Click(object sender, EventArgs e)
        {

        }

        private void mailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void mailLabel_Click(object sender, EventArgs e)
        {

        }

        private void tipsLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
