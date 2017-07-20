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
    public partial class SummaryForm : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        string strConnect = "Server=127.0.0.1;DataBase=AssetsDB;Uid=sa;Pwd=123456";
        public SummaryForm()
        {
            InitializeComponent();
        }

        private void selButton_Click(object sender, EventArgs e)
        {
            string ownerName = ownerTextBox.Text;
            string borrowerName = ownerTextBox.Text;
            string itemName = itemNameTextBox.Text;
            string selString = "select (Owner,Borrower,ItemName) from Item where (Owner,Borrower,ItemName) = '"+ ownerTextBox.Text + "'," +"," +borrowerTextBox.Text + "'," + itemNameTextBox.Text + ",)";
            conn.ConnectionString = strConnect;


        }
    }
}
