namespace DEMO
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
            this.Password = new System.Windows.Forms.TextBox();
            this.PWD_Currect = new System.Windows.Forms.TextBox();
            this.Account = new System.Windows.Forms.TextBox();
            this.Email_bar = new System.Windows.Forms.TextBox();
            this.Number = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EMAIL = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Bun_Cancal = new System.Windows.Forms.Button();
            this.But_Submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(283, 195);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(529, 29);
            this.Password.TabIndex = 0;
            // 
            // PWD_Currect
            // 
            this.PWD_Currect.Location = new System.Drawing.Point(283, 230);
            this.PWD_Currect.Name = "PWD_Currect";
            this.PWD_Currect.Size = new System.Drawing.Size(529, 29);
            this.PWD_Currect.TabIndex = 1;
            // 
            // Account
            // 
            this.Account.Location = new System.Drawing.Point(283, 148);
            this.Account.Name = "Account";
            this.Account.Size = new System.Drawing.Size(529, 29);
            this.Account.TabIndex = 2;
            // 
            // Email_bar
            // 
            this.Email_bar.Location = new System.Drawing.Point(283, 275);
            this.Email_bar.Name = "Email_bar";
            this.Email_bar.Size = new System.Drawing.Size(529, 29);
            this.Email_bar.TabIndex = 3;
            // 
            // Number
            // 
            this.Number.Location = new System.Drawing.Point(283, 321);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(529, 29);
            this.Number.TabIndex = 4;
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(283, 102);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(529, 29);
            this.Name.TabIndex = 5;
            this.Name.TextChanged += new System.EventHandler(this.Name_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(118, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "姓名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "帳號";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "密碼";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(124, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "確認密碼";
            // 
            // EMAIL
            // 
            this.EMAIL.AutoSize = true;
            this.EMAIL.Location = new System.Drawing.Point(124, 275);
            this.EMAIL.Name = "EMAIL";
            this.EMAIL.Size = new System.Drawing.Size(67, 18);
            this.EMAIL.TabIndex = 10;
            this.EMAIL.Text = "E-MAIL";

            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(127, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "手機號碼";
            // 
            // Bun_Cancal
            // 
            this.Bun_Cancal.Location = new System.Drawing.Point(238, 377);
            this.Bun_Cancal.Name = "Bun_Cancal";
            this.Bun_Cancal.Size = new System.Drawing.Size(197, 41);
            this.Bun_Cancal.TabIndex = 12;
            this.Bun_Cancal.Text = "取消";
            this.Bun_Cancal.UseVisualStyleBackColor = true;
            this.Bun_Cancal.Click += new System.EventHandler(this.button1_Click);
            // 
            // But_Submit
            // 
            this.But_Submit.Location = new System.Drawing.Point(527, 377);
            this.But_Submit.Name = "But_Submit";
            this.But_Submit.Size = new System.Drawing.Size(197, 41);
            this.But_Submit.TabIndex = 13;
            this.But_Submit.Text = "註冊";
            this.But_Submit.UseVisualStyleBackColor = true;
            this.But_Submit.Click += new System.EventHandler(this.button2_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 466);
            this.Controls.Add(this.But_Submit);
            this.Controls.Add(this.Bun_Cancal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.EMAIL);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.Email_bar);
            this.Controls.Add(this.Account);
            this.Controls.Add(this.PWD_Currect);
            this.Controls.Add(this.Password);
            this.Text = "註冊";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox PWD_Currect;
        private System.Windows.Forms.TextBox Account;
        private System.Windows.Forms.TextBox Email_bar;
        private System.Windows.Forms.TextBox Number;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label EMAIL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Bun_Cancal;
        private System.Windows.Forms.Button But_Submit;
    }
}