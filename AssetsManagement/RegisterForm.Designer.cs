using System;

namespace AssetsManagement
{
    partial class RegisterForm
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
            this.tipsLabel = new System.Windows.Forms.Label();
            this.usrLabel = new System.Windows.Forms.Label();
            this.pwdLabel = new System.Windows.Forms.Label();
            this.usrTextBox = new System.Windows.Forms.TextBox();
            this.pwdTextBox = new System.Windows.Forms.TextBox();
            this.mailLabel = new System.Windows.Forms.Label();
            this.mailTextBox = new System.Windows.Forms.TextBox();
            this.regButton = new System.Windows.Forms.Button();
            this.escButton = new System.Windows.Forms.Button();
            this.usrTextBoxTips = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pwd2Label = new System.Windows.Forms.Label();
            this.pwd2TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tipsLabel
            // 
            this.tipsLabel.AutoSize = true;
            this.tipsLabel.Location = new System.Drawing.Point(190, 181);
            this.tipsLabel.Name = "tipsLabel";
            this.tipsLabel.Size = new System.Drawing.Size(149, 12);
            this.tipsLabel.TabIndex = 0;
            this.tipsLabel.Text = "请根据提示内容注册用户：";
            this.tipsLabel.Click += new System.EventHandler(this.tipsLabel_Click);
            // 
            // usrLabel
            // 
            this.usrLabel.AutoSize = true;
            this.usrLabel.Location = new System.Drawing.Point(190, 217);
            this.usrLabel.Name = "usrLabel";
            this.usrLabel.Size = new System.Drawing.Size(53, 12);
            this.usrLabel.TabIndex = 1;
            this.usrLabel.Text = "用户名：";
            this.usrLabel.Click += new System.EventHandler(this.usrLabel_Click);
            // 
            // pwdLabel
            // 
            this.pwdLabel.AutoSize = true;
            this.pwdLabel.Location = new System.Drawing.Point(190, 257);
            this.pwdLabel.Name = "pwdLabel";
            this.pwdLabel.Size = new System.Drawing.Size(41, 12);
            this.pwdLabel.TabIndex = 2;
            this.pwdLabel.Text = "密码：";
            this.pwdLabel.Click += new System.EventHandler(this.pwdLabel_Click);
            // 
            // usrTextBox
            // 
            this.usrTextBox.Location = new System.Drawing.Point(276, 217);
            this.usrTextBox.Name = "usrTextBox";
            this.usrTextBox.Size = new System.Drawing.Size(213, 21);
            this.usrTextBox.TabIndex = 3;
            this.usrTextBox.TextChanged += new System.EventHandler(this.usrTextBox_TextChanged);
            // 
            // pwdTextBox
            // 
            this.pwdTextBox.Location = new System.Drawing.Point(276, 257);
            this.pwdTextBox.Name = "pwdTextBox";
            this.pwdTextBox.PasswordChar = '*';
            this.pwdTextBox.Size = new System.Drawing.Size(213, 21);
            this.pwdTextBox.TabIndex = 4;
            this.pwdTextBox.TextChanged += new System.EventHandler(this.pwdTextBox_TextChanged);
            // 
            // mailLabel
            // 
            this.mailLabel.AutoSize = true;
            this.mailLabel.Location = new System.Drawing.Point(192, 339);
            this.mailLabel.Name = "mailLabel";
            this.mailLabel.Size = new System.Drawing.Size(41, 12);
            this.mailLabel.TabIndex = 5;
            this.mailLabel.Text = "邮箱：";
            this.mailLabel.Click += new System.EventHandler(this.mailLabel_Click);
            // 
            // mailTextBox
            // 
            this.mailTextBox.Location = new System.Drawing.Point(276, 339);
            this.mailTextBox.Name = "mailTextBox";
            this.mailTextBox.Size = new System.Drawing.Size(213, 21);
            this.mailTextBox.TabIndex = 6;
            this.mailTextBox.TextChanged += new System.EventHandler(this.mailTextBox_TextChanged);
            // 
            // regButton
            // 
            this.regButton.Location = new System.Drawing.Point(192, 379);
            this.regButton.Name = "regButton";
            this.regButton.Size = new System.Drawing.Size(75, 23);
            this.regButton.TabIndex = 7;
            this.regButton.Text = "注册";
            this.regButton.UseVisualStyleBackColor = true;
            this.regButton.Click += new System.EventHandler(this.reg_Click);
            // 
            // escButton
            // 
            this.escButton.Location = new System.Drawing.Point(414, 379);
            this.escButton.Name = "escButton";
            this.escButton.Size = new System.Drawing.Size(75, 23);
            this.escButton.TabIndex = 8;
            this.escButton.Text = "取消";
            this.escButton.UseVisualStyleBackColor = true;
            this.escButton.Click += new System.EventHandler(this.escButton_Click_1);
            // 
            // usrTextBoxTips
            // 
            this.usrTextBoxTips.AutoSize = true;
            this.usrTextBoxTips.Location = new System.Drawing.Point(509, 220);
            this.usrTextBoxTips.Name = "usrTextBoxTips";
            this.usrTextBoxTips.Size = new System.Drawing.Size(137, 12);
            this.usrTextBoxTips.TabIndex = 9;
            this.usrTextBoxTips.Text = "用户名长度在4~12位之间";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(511, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "密码长度大于6位";
            // 
            // pwd2Label
            // 
            this.pwd2Label.AutoSize = true;
            this.pwd2Label.Location = new System.Drawing.Point(190, 302);
            this.pwd2Label.Name = "pwd2Label";
            this.pwd2Label.Size = new System.Drawing.Size(65, 12);
            this.pwd2Label.TabIndex = 11;
            this.pwd2Label.Text = "确认密码：";
            // 
            // pwd2TextBox
            // 
            this.pwd2TextBox.Location = new System.Drawing.Point(276, 299);
            this.pwd2TextBox.Name = "pwd2TextBox";
            this.pwd2TextBox.PasswordChar = '*';
            this.pwd2TextBox.Size = new System.Drawing.Size(213, 21);
            this.pwd2TextBox.TabIndex = 12;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.pwd2TextBox);
            this.Controls.Add(this.pwd2Label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usrTextBoxTips);
            this.Controls.Add(this.escButton);
            this.Controls.Add(this.regButton);
            this.Controls.Add(this.mailTextBox);
            this.Controls.Add(this.mailLabel);
            this.Controls.Add(this.pwdTextBox);
            this.Controls.Add(this.usrTextBox);
            this.Controls.Add(this.pwdLabel);
            this.Controls.Add(this.usrLabel);
            this.Controls.Add(this.tipsLabel);
            this.Name = "RegisterForm";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label tipsLabel;
        private System.Windows.Forms.Label usrLabel;
        private System.Windows.Forms.Label pwdLabel;
        private System.Windows.Forms.TextBox usrTextBox;
        private System.Windows.Forms.TextBox pwdTextBox;
        private System.Windows.Forms.Label mailLabel;
        private System.Windows.Forms.TextBox mailTextBox;
        private System.Windows.Forms.Button regButton;
        private System.Windows.Forms.Button escButton;
        private System.Windows.Forms.Label usrTextBoxTips;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label pwd2Label;
        private System.Windows.Forms.TextBox pwd2TextBox;
    }
}