namespace AssetsManagement
{
    partial class CreAssetsForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.itemNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.creatorComboBox = new System.Windows.Forms.ComboBox();
            this.ownerComboBox = new System.Windows.Forms.ComboBox();
            this.borrowerComboBox = new System.Windows.Forms.ComboBox();
            this.escButton = new System.Windows.Forms.Button();
            this.enterButton = new System.Windows.Forms.Button();
            this.bitianLabel1 = new System.Windows.Forms.Label();
            this.bitianLabel2 = new System.Windows.Forms.Label();
            this.describeRichTextBox = new System.Windows.Forms.RichTextBox();
            this.assetsDBDataSet = new AssetsManagement.AssetsDBDataSet();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userTableAdapter = new AssetsManagement.AssetsDBDataSetTableAdapters.UserTableAdapter();
            this.assetsDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assetsDBDataSet1 = new AssetsManagement.AssetsDBDataSet1();
            this.userBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.userTableAdapter1 = new AssetsManagement.AssetsDBDataSet1TableAdapters.UserTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.assetsDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetsDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetsDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "物品名称：";
            // 
            // itemNameTextBox
            // 
            this.itemNameTextBox.Location = new System.Drawing.Point(106, 15);
            this.itemNameTextBox.Name = "itemNameTextBox";
            this.itemNameTextBox.Size = new System.Drawing.Size(100, 21);
            this.itemNameTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "物品描述：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "录入者：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(223, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "领用者：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(390, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 9;
            this.label7.Text = "借用者：";
            // 
            // creatorComboBox
            // 
            this.creatorComboBox.FormattingEnabled = true;
            this.creatorComboBox.Location = new System.Drawing.Point(106, 157);
            this.creatorComboBox.Name = "creatorComboBox";
            this.creatorComboBox.Size = new System.Drawing.Size(87, 20);
            this.creatorComboBox.TabIndex = 10;
            // 
            // ownerComboBox
            // 
            this.ownerComboBox.DataSource = this.userBindingSource1;
            this.ownerComboBox.DisplayMember = "UserName";
            this.ownerComboBox.FormattingEnabled = true;
            this.ownerComboBox.Location = new System.Drawing.Point(275, 157);
            this.ownerComboBox.Name = "ownerComboBox";
            this.ownerComboBox.Size = new System.Drawing.Size(98, 20);
            this.ownerComboBox.TabIndex = 11;
            this.ownerComboBox.ValueMember = "UserId";
            // 
            // borrowerComboBox
            // 
            this.borrowerComboBox.FormattingEnabled = true;
            this.borrowerComboBox.Location = new System.Drawing.Point(441, 157);
            this.borrowerComboBox.Name = "borrowerComboBox";
            this.borrowerComboBox.Size = new System.Drawing.Size(95, 20);
            this.borrowerComboBox.TabIndex = 12;
            // 
            // escButton
            // 
            this.escButton.Location = new System.Drawing.Point(106, 199);
            this.escButton.Name = "escButton";
            this.escButton.Size = new System.Drawing.Size(75, 23);
            this.escButton.TabIndex = 13;
            this.escButton.Text = "取消";
            this.escButton.UseVisualStyleBackColor = true;
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(297, 198);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(75, 23);
            this.enterButton.TabIndex = 14;
            this.enterButton.Text = "确定";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // bitianLabel1
            // 
            this.bitianLabel1.AutoSize = true;
            this.bitianLabel1.ForeColor = System.Drawing.Color.Red;
            this.bitianLabel1.Location = new System.Drawing.Point(27, 18);
            this.bitianLabel1.Name = "bitianLabel1";
            this.bitianLabel1.Size = new System.Drawing.Size(11, 12);
            this.bitianLabel1.TabIndex = 15;
            this.bitianLabel1.Text = "*";
            // 
            // bitianLabel2
            // 
            this.bitianLabel2.AutoSize = true;
            this.bitianLabel2.ForeColor = System.Drawing.Color.Red;
            this.bitianLabel2.Location = new System.Drawing.Point(213, 161);
            this.bitianLabel2.Name = "bitianLabel2";
            this.bitianLabel2.Size = new System.Drawing.Size(11, 12);
            this.bitianLabel2.TabIndex = 16;
            this.bitianLabel2.Text = "*";
            // 
            // describeRichTextBox
            // 
            this.describeRichTextBox.Location = new System.Drawing.Point(106, 54);
            this.describeRichTextBox.Name = "describeRichTextBox";
            this.describeRichTextBox.Size = new System.Drawing.Size(266, 87);
            this.describeRichTextBox.TabIndex = 17;
            this.describeRichTextBox.Text = "";
            // 
            // assetsDBDataSet
            // 
            this.assetsDBDataSet.DataSetName = "AssetsDBDataSet";
            this.assetsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "User";
            this.userBindingSource.DataSource = this.assetsDBDataSet;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // assetsDBDataSetBindingSource
            // 
            this.assetsDBDataSetBindingSource.DataSource = this.assetsDBDataSet;
            this.assetsDBDataSetBindingSource.Position = 0;
            // 
            // assetsDBDataSet1
            // 
            this.assetsDBDataSet1.DataSetName = "AssetsDBDataSet1";
            this.assetsDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userBindingSource1
            // 
            this.userBindingSource1.DataMember = "User";
            this.userBindingSource1.DataSource = this.assetsDBDataSet1;
            // 
            // userTableAdapter1
            // 
            this.userTableAdapter1.ClearBeforeFill = true;
            // 
            // CreAssetsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 242);
            this.Controls.Add(this.describeRichTextBox);
            this.Controls.Add(this.bitianLabel2);
            this.Controls.Add(this.bitianLabel1);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.escButton);
            this.Controls.Add(this.borrowerComboBox);
            this.Controls.Add(this.ownerComboBox);
            this.Controls.Add(this.creatorComboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.itemNameTextBox);
            this.Controls.Add(this.label2);
            this.Name = "CreAssetsForm";
            this.Text = "CreAssetsForm";
            this.Load += new System.EventHandler(this.CreAssetsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.assetsDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetsDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetsDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox itemNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox creatorComboBox;
        private System.Windows.Forms.ComboBox ownerComboBox;
        private System.Windows.Forms.ComboBox borrowerComboBox;
        private System.Windows.Forms.Button escButton;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Label bitianLabel1;
        private System.Windows.Forms.Label bitianLabel2;
        private System.Windows.Forms.RichTextBox describeRichTextBox;
        private AssetsDBDataSet assetsDBDataSet;
        private System.Windows.Forms.BindingSource userBindingSource;
        private AssetsDBDataSetTableAdapters.UserTableAdapter userTableAdapter;
        private System.Windows.Forms.BindingSource assetsDBDataSetBindingSource;
        private AssetsDBDataSet1 assetsDBDataSet1;
        private System.Windows.Forms.BindingSource userBindingSource1;
        private AssetsDBDataSet1TableAdapters.UserTableAdapter userTableAdapter1;
    }
}