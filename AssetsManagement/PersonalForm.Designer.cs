namespace AssetsManagement
{
    partial class PersonalForm
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
            this.hiLabel = new System.Windows.Forms.Label();
            this.usrLabel = new System.Windows.Forms.Label();
            this.assetsGroupBox1 = new System.Windows.Forms.GroupBox();
            this.assetsCountsLabel2 = new System.Windows.Forms.Label();
            this.assetsCounts = new System.Windows.Forms.Label();
            this.assetsCountsLabel1 = new System.Windows.Forms.Label();
            this.creButton = new System.Windows.Forms.Button();
            this.selButton = new System.Windows.Forms.Button();
            this.assetsGroupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ItemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Owner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Borrower = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Creator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemDescribe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assetsGroupBox1.SuspendLayout();
            this.assetsGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // hiLabel
            // 
            this.hiLabel.AutoSize = true;
            this.hiLabel.Font = new System.Drawing.Font("宋体", 9F);
            this.hiLabel.Location = new System.Drawing.Point(6, 25);
            this.hiLabel.Name = "hiLabel";
            this.hiLabel.Size = new System.Drawing.Size(29, 12);
            this.hiLabel.TabIndex = 0;
            this.hiLabel.Text = "嘿！";
            this.hiLabel.Click += new System.EventHandler(this.hiLabel_Click);
            // 
            // usrLabel
            // 
            this.usrLabel.AutoSize = true;
            this.usrLabel.Font = new System.Drawing.Font("宋体", 9F);
            this.usrLabel.Location = new System.Drawing.Point(49, 27);
            this.usrLabel.Name = "usrLabel";
            this.usrLabel.Size = new System.Drawing.Size(35, 12);
            this.usrLabel.TabIndex = 1;
            this.usrLabel.Text = "dsass";
            this.usrLabel.Click += new System.EventHandler(this.usrLabel_Click);
            // 
            // assetsGroupBox1
            // 
            this.assetsGroupBox1.Controls.Add(this.selButton);
            this.assetsGroupBox1.Controls.Add(this.creButton);
            this.assetsGroupBox1.Controls.Add(this.assetsCountsLabel2);
            this.assetsGroupBox1.Controls.Add(this.usrLabel);
            this.assetsGroupBox1.Controls.Add(this.assetsCounts);
            this.assetsGroupBox1.Controls.Add(this.hiLabel);
            this.assetsGroupBox1.Controls.Add(this.assetsCountsLabel1);
            this.assetsGroupBox1.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold);
            this.assetsGroupBox1.Location = new System.Drawing.Point(13, 13);
            this.assetsGroupBox1.Name = "assetsGroupBox1";
            this.assetsGroupBox1.Size = new System.Drawing.Size(775, 52);
            this.assetsGroupBox1.TabIndex = 2;
            this.assetsGroupBox1.TabStop = false;
            this.assetsGroupBox1.Text = "我的资产";
            // 
            // assetsCountsLabel2
            // 
            this.assetsCountsLabel2.AutoSize = true;
            this.assetsCountsLabel2.Font = new System.Drawing.Font("宋体", 9F);
            this.assetsCountsLabel2.Location = new System.Drawing.Point(263, 27);
            this.assetsCountsLabel2.Name = "assetsCountsLabel2";
            this.assetsCountsLabel2.Size = new System.Drawing.Size(41, 12);
            this.assetsCountsLabel2.TabIndex = 2;
            this.assetsCountsLabel2.Text = "件资产";
            // 
            // assetsCounts
            // 
            this.assetsCounts.AutoSize = true;
            this.assetsCounts.Font = new System.Drawing.Font("宋体", 9F);
            this.assetsCounts.Location = new System.Drawing.Point(226, 27);
            this.assetsCounts.Name = "assetsCounts";
            this.assetsCounts.Size = new System.Drawing.Size(23, 12);
            this.assetsCounts.TabIndex = 1;
            this.assetsCounts.Text = "xxx";
            // 
            // assetsCountsLabel1
            // 
            this.assetsCountsLabel1.AutoSize = true;
            this.assetsCountsLabel1.Font = new System.Drawing.Font("宋体", 9F);
            this.assetsCountsLabel1.Location = new System.Drawing.Point(138, 27);
            this.assetsCountsLabel1.Name = "assetsCountsLabel1";
            this.assetsCountsLabel1.Size = new System.Drawing.Size(77, 12);
            this.assetsCountsLabel1.TabIndex = 0;
            this.assetsCountsLabel1.Text = "您当前共计有";
            // 
            // creButton
            // 
            this.creButton.Location = new System.Drawing.Point(584, 19);
            this.creButton.Name = "creButton";
            this.creButton.Size = new System.Drawing.Size(75, 23);
            this.creButton.TabIndex = 3;
            this.creButton.Text = "新增资产";
            this.creButton.UseVisualStyleBackColor = true;
            this.creButton.Click += new System.EventHandler(this.creButton_Click);
            // 
            // selButton
            // 
            this.selButton.Location = new System.Drawing.Point(683, 19);
            this.selButton.Name = "selButton";
            this.selButton.Size = new System.Drawing.Size(75, 23);
            this.selButton.TabIndex = 4;
            this.selButton.Text = "查询";
            this.selButton.UseVisualStyleBackColor = true;
            this.selButton.Click += new System.EventHandler(this.selButton_Click);
            // 
            // assetsGroupBox2
            // 
            this.assetsGroupBox2.Controls.Add(this.dataGridView1);
            this.assetsGroupBox2.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.assetsGroupBox2.Location = new System.Drawing.Point(13, 72);
            this.assetsGroupBox2.Name = "assetsGroupBox2";
            this.assetsGroupBox2.Size = new System.Drawing.Size(775, 516);
            this.assetsGroupBox2.TabIndex = 3;
            this.assetsGroupBox2.TabStop = false;
            this.assetsGroupBox2.Text = "资产明细";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemId,
            this.ItemName,
            this.Owner,
            this.Borrower,
            this.Creator,
            this.ItemDescribe});
            this.dataGridView1.Location = new System.Drawing.Point(8, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(761, 487);
            this.dataGridView1.TabIndex = 0;
            // 
            // ItemId
            // 
            this.ItemId.DataPropertyName = "ItemId";
            this.ItemId.HeaderText = "物品编号";
            this.ItemId.Name = "ItemId";
            // 
            // ItemName
            // 
            this.ItemName.DataPropertyName = "ItemName";
            this.ItemName.HeaderText = "物品名称";
            this.ItemName.Name = "ItemName";
            // 
            // Owner
            // 
            this.Owner.DataPropertyName = "Owner";
            this.Owner.HeaderText = "领用者";
            this.Owner.Name = "Owner";
            // 
            // Borrower
            // 
            this.Borrower.DataPropertyName = "Borrower";
            this.Borrower.HeaderText = "借用者";
            this.Borrower.Name = "Borrower";
            // 
            // Creator
            // 
            this.Creator.DataPropertyName = "Creator";
            this.Creator.HeaderText = "录入者";
            this.Creator.Name = "Creator";
            // 
            // ItemDescribe
            // 
            this.ItemDescribe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ItemDescribe.DataPropertyName = "ItemDescribe";
            this.ItemDescribe.HeaderText = "物品描述";
            this.ItemDescribe.Name = "ItemDescribe";
            // 
            // PersonalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.assetsGroupBox2);
            this.Controls.Add(this.assetsGroupBox1);
            this.Name = "PersonalForm";
            this.Text = "PersonalForm";
            this.assetsGroupBox1.ResumeLayout(false);
            this.assetsGroupBox1.PerformLayout();
            this.assetsGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Label hiLabel;
        public System.Windows.Forms.Label usrLabel;
        private System.Windows.Forms.GroupBox assetsGroupBox1;
        private System.Windows.Forms.Label assetsCountsLabel2;
        private System.Windows.Forms.Label assetsCounts;
        private System.Windows.Forms.Label assetsCountsLabel1;
        private System.Windows.Forms.Button creButton;
        private System.Windows.Forms.Button selButton;
        private System.Windows.Forms.GroupBox assetsGroupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Owner;
        private System.Windows.Forms.DataGridViewTextBoxColumn Borrower;
        private System.Windows.Forms.DataGridViewTextBoxColumn Creator;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemDescribe;
    }
}