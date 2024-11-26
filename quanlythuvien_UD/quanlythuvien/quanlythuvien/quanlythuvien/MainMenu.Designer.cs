namespace quanlythuvien
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýHọcGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýSáchToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýMượnTrảToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýDoanhSốToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýHọcGiảToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1281, 33);
            this.menuStrip1.TabIndex = 27;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýHọcGiảToolStripMenuItem
            // 
            this.quảnLýHọcGiảToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngNhậpToolStripMenuItem,
            this.quảnLýSáchToolStripMenuItem1,
            this.quảnLýMượnTrảToolStripMenuItem2,
            this.quảnLýDoanhSốToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.quảnLýHọcGiảToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quảnLýHọcGiảToolStripMenuItem.Name = "quảnLýHọcGiảToolStripMenuItem";
            this.quảnLýHọcGiảToolStripMenuItem.Size = new System.Drawing.Size(108, 29);
            this.quảnLýHọcGiảToolStripMenuItem.Text = "Hệ Thống";
            this.quảnLýHọcGiảToolStripMenuItem.Click += new System.EventHandler(this.quảnLýHọcGiảToolStripMenuItem_Click);
            // 
            // đăngNhậpToolStripMenuItem
            // 
            this.đăngNhậpToolStripMenuItem.Name = "đăngNhậpToolStripMenuItem";
            this.đăngNhậpToolStripMenuItem.Size = new System.Drawing.Size(253, 30);
            this.đăngNhậpToolStripMenuItem.Text = "Quản Lý Độc Giả";
            this.đăngNhậpToolStripMenuItem.Click += new System.EventHandler(this.đăngNhậpToolStripMenuItem_Click);
            // 
            // quảnLýSáchToolStripMenuItem1
            // 
            this.quảnLýSáchToolStripMenuItem1.Name = "quảnLýSáchToolStripMenuItem1";
            this.quảnLýSáchToolStripMenuItem1.Size = new System.Drawing.Size(253, 30);
            this.quảnLýSáchToolStripMenuItem1.Text = "Quản Lý Sách";
            this.quảnLýSáchToolStripMenuItem1.Click += new System.EventHandler(this.quảnLýSáchToolStripMenuItem1_Click);
            // 
            // quảnLýMượnTrảToolStripMenuItem2
            // 
            this.quảnLýMượnTrảToolStripMenuItem2.Name = "quảnLýMượnTrảToolStripMenuItem2";
            this.quảnLýMượnTrảToolStripMenuItem2.Size = new System.Drawing.Size(253, 30);
            this.quảnLýMượnTrảToolStripMenuItem2.Text = "Quản Lý Mượn Trả";
            this.quảnLýMượnTrảToolStripMenuItem2.Click += new System.EventHandler(this.quảnLýMượnTrảToolStripMenuItem2_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(253, 30);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // quảnLýDoanhSốToolStripMenuItem
            // 
            this.quảnLýDoanhSốToolStripMenuItem.Name = "quảnLýDoanhSốToolStripMenuItem";
            this.quảnLýDoanhSốToolStripMenuItem.Size = new System.Drawing.Size(253, 30);
            this.quảnLýDoanhSốToolStripMenuItem.Text = "Quản Lý Doanh Số";
            this.quảnLýDoanhSốToolStripMenuItem.Click += new System.EventHandler(this.quảnLýDoanhSốToolStripMenuItem_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1281, 666);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thư Viện Thành Phố";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýHọcGiảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýSáchToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýMượnTrảToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýDoanhSốToolStripMenuItem;
    }
}