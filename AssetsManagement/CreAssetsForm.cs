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
    public partial class CreAssetsForm : Form
    {
        bool flagCreAssets;
        public CreAssetsForm()
        {
            InitializeComponent();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            if ((itemNameTextBox.Text.Length > 0) && (ownerComboBox.Text.Length > 0))
            {
                flagCreAssets = true;
            }
            else
            {
                if (itemNameTextBox.Text.Length <= 0)
                {
                    MessageBox.Show("请输入物品名称！", "提示");
                    return;
                }
                if (ownerComboBox.Text.Length <= 0)
                {
                    MessageBox.Show("请输入领用者！", "提示");
                }             
            }
            if (flagCreAssets == true)
            {
                string strConnect = "Server=127.0.0.1;DataBase=AssetsDB;Uid=sa;Pwd=123456";
                SqlConnection conn = new SqlConnection(strConnect);
                conn.Open();
                string selCmdSql = "insert into Item(ItemName,ItemDescribe,Creator,Owner,Borrower) values " +
                    "('" + itemNameTextBox.Text + "'," + "'" + describeRichTextBox.Text + "'," + "'" + creatorComboBox.Text
                    + "'," + "'" + ownerComboBox.Text + "'," + "," + borrowerComboBox.Text + "')";
                SqlCommand cmd = new SqlCommand(selCmdSql,conn);
                cmd.ExecuteNonQuery();
                DialogResult regResult = MessageBox.Show("注册成功");

            }
        }
        //数据集绑定
        private void BindCombox()
        {
            //DataTable dt = new DataTable();
            //DataColumn dc1 = new DataColumn("UserId");
            //DataColumn dc2 = new DataColumn("UserName");
            //dt.Columns.Add(dc1);
            //dt.Columns.Add(dc2);

            //DataRow dr1 = dt.NewRow();
            //dr1["UserId"] = "1";
            //dr1["UserId"] = "aaaaaa";

            //DataRow dr2 = dt.NewRow();
            //dr2["UserId"] = "2";
            //dr2["UserId"] = "bbbbbb";

            //dt.Rows.Add(dr1);
            //dt.Rows.Add(dr2);
            DataTable dt = new DataTable("[User]");

            DataColumn column;
            DataRow row;

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "UserId";
            dt.Columns.Add(column);

            // Create second column.
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "UserName";
            dt.Columns.Add(column);

            creatorComboBox.DataSource = dt;
            creatorComboBox.ValueMember = "UserId";
            creatorComboBox.DisplayMember = "UserName";

            ownerComboBox.DataSource = dt;
            ownerComboBox.ValueMember = "UserId";
            ownerComboBox.DisplayMember = "UserName";

            borrowerComboBox.DataSource = dt;
            borrowerComboBox.ValueMember = "UserId";
            borrowerComboBox.DisplayMember = "UserName";
        }

        private void CreAssetsForm_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“assetsDBDataSet1.User”中。您可以根据需要移动或删除它。
            this.userTableAdapter1.Fill(this.assetsDBDataSet1.User);
            // TODO: 这行代码将数据加载到表“assetsDBDataSet.User”中。您可以根据需要移动或删除它。
            this.userTableAdapter.Fill(this.assetsDBDataSet.User);

        }
    }
}
