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

namespace AssetsManagement
{
    public partial class LoginForm : Form
    {
        string usrName = null;
        string strConnect = "Server=127.0.0.1;DataBase=AssetsDB;Uid=sa;Pwd=123456";
        public LoginForm()
        {
            InitializeComponent();
            Owner?.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void regLinkLabelByLoginForm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.StartPosition = FormStartPosition.CenterScreen;
            registerForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(strConnect);
            SqlCommand cmd = new SqlCommand();
            string nowUsrStr = usrTextBox.Text;//获取当前用户名输入框中的内容
            string nowPwdStr = pwdTextBox.Text;//获取当前密码输入框中的内容
            try
            {
                string sqlSel = "select * from [User] where UserName = @username and UserPassward = @userpassward";
                cmd.Connection = conn;
                cmd.CommandText = sqlSel;
                cmd.Parameters.AddWithValue("@username", usrTextBox.Text);
                cmd.Parameters.AddWithValue("@userpassward", pwdTextBox.Text);
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    PersonalForm perform = new PersonalForm();
                    usrName = usrTextBox.Text.ToString();
                    perform.usrLabel.Text = usrName;
                    perform.usrLabel.Tag = dt.Rows[0]["UserId"];
                    //MessageBox.Show("登录成功！");
                    this.Hide();
                    //SummaryForm sumform = new SummaryForm();
                    //sumform.ShowDialog();

                    perform.ShowDialog();
                }
                else
                {
                    MessageBox.Show("失败！");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }
    }
}
