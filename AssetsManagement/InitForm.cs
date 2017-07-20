using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace AssetsManagement
{
    public partial class InitForm : Form
    {
        public InitForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void regLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.StartPosition = FormStartPosition.CenterScreen;
            registerForm.ShowDialog();
        }

        private void loginLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.StartPosition = FormStartPosition.CenterScreen;
            loginForm.ShowDialog();
            Close();
        }
    }
}
