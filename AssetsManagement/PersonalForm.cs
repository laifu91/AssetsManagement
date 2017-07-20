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
    public partial class PersonalForm : Form
    {
        static string strConnect = "Server=127.0.0.1;DataBase=AssetsDB;Uid=sa;Pwd=123456";
        SqlConnection conn = new SqlConnection(strConnect);
        public PersonalForm()
        {
            InitializeComponent();
            //LoginForm logform = new LoginForm();
            //this.usrLabel.Text = logform.aa;
        }

        private void usrLabel_Click(object sender, EventArgs e)
        {
            //string strConnect = "Server=127.0.0.1;DataBase=AssetsDB;Uid=sa;Pwd=123456";
            //SqlConnection conn = new SqlConnection(strConnect);
            //SqlCommand cmd = new SqlCommand();
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable("User");
            //DataRow dr = dt.Rows[0];



        }

        private void hiLabel_Click(object sender, EventArgs e)
        {

        }

        private void selButton_Click(object sender, EventArgs e)
        {
            string selcmd = "select * from Item where Creator = " + usrLabel.Tag;
            conn.Open();
            SqlCommand cmd = new SqlCommand(selcmd, conn);     
            DataSet dt = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            if (dt.Tables.Count > 0 && dt.Tables[0].Rows.Count>0)
            {
                dataGridView1.DataSource = dt.Tables[0];
            }
            else
            {
                MessageBox.Show("未查询到相关结果！");
            }
            
            da.Dispose();
            cmd.Dispose();
            conn.Close();

        }

        private void creButton_Click(object sender, EventArgs e)
        {
            CreAssetsForm creaAssetsFrom = new CreAssetsForm();            
            creaAssetsFrom.StartPosition = FormStartPosition.CenterScreen;
            creaAssetsFrom.ShowDialog();
        }
    }
}
