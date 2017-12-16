namespace DEMO
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.帳號ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.註冊ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.說明ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.結束ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.買書ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.賣書ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.登出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.帳號ToolStripMenuItem,
            this.買書ToolStripMenuItem,
            this.賣書ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(526, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 帳號ToolStripMenuItem
            // 
            this.帳號ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.註冊ToolStripMenuItem,
            this.說明ToolStripMenuItem,
            this.登出ToolStripMenuItem,
            this.結束ToolStripMenuItem});
            this.帳號ToolStripMenuItem.Name = "帳號ToolStripMenuItem";
            this.帳號ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.帳號ToolStripMenuItem.Text = "帳號";
            // 
            // 註冊ToolStripMenuItem
            // 
            this.註冊ToolStripMenuItem.Name = "註冊ToolStripMenuItem";
            this.註冊ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.註冊ToolStripMenuItem.Text = "註冊";
            // 
            // 說明ToolStripMenuItem
            // 
            this.說明ToolStripMenuItem.Name = "說明ToolStripMenuItem";
            this.說明ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.說明ToolStripMenuItem.Text = "說明";
            // 
            // 結束ToolStripMenuItem
            // 
            this.結束ToolStripMenuItem.Name = "結束ToolStripMenuItem";
            this.結束ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.結束ToolStripMenuItem.Text = "結束";
            this.結束ToolStripMenuItem.Click += new System.EventHandler(this.結束ToolStripMenuItem_Click);
            // 
            // 買書ToolStripMenuItem
            // 
            this.買書ToolStripMenuItem.Name = "買書ToolStripMenuItem";
            this.買書ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.買書ToolStripMenuItem.Text = "買書";
            // 
            // 賣書ToolStripMenuItem
            // 
            this.賣書ToolStripMenuItem.Name = "賣書ToolStripMenuItem";
            this.賣書ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.賣書ToolStripMenuItem.Text = "賣書";
            // 
            // 登出ToolStripMenuItem
            // 
            this.登出ToolStripMenuItem.Name = "登出ToolStripMenuItem";
            this.登出ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.登出ToolStripMenuItem.Text = "登出";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 342);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 帳號ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 註冊ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 說明ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 結束ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 登出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 買書ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 賣書ToolStripMenuItem;
    }
}

