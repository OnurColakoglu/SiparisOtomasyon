
namespace SiparisOtomasyon.WinUI
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.CustomerList = new System.Windows.Forms.ToolStripMenuItem();
            this.newCustomerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CustomerListMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünİşlmleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniÜrünToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparişİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tanımlamalarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CustomerList,
            this.ürünİşlmleriToolStripMenuItem,
            this.siparişİşlemleriToolStripMenuItem,
            this.tanımlamalarToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(815, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // CustomerList
            // 
            this.CustomerList.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newCustomerMenuItem,
            this.CustomerListMenuItem});
            this.CustomerList.Name = "CustomerList";
            this.CustomerList.Size = new System.Drawing.Size(116, 24);
            this.CustomerList.Text = "Müşteri Listesi";
            // 
            // newCustomerMenuItem
            // 
            this.newCustomerMenuItem.Name = "newCustomerMenuItem";
            this.newCustomerMenuItem.Size = new System.Drawing.Size(185, 26);
            this.newCustomerMenuItem.Text = "Yeni Müşteri";
            this.newCustomerMenuItem.Click += new System.EventHandler(this.newCustomerMenuItem_Click);
            // 
            // CustomerListMenuItem
            // 
            this.CustomerListMenuItem.Name = "CustomerListMenuItem";
            this.CustomerListMenuItem.Size = new System.Drawing.Size(185, 26);
            this.CustomerListMenuItem.Text = "Müşteri Lİstesi";
            this.CustomerListMenuItem.Click += new System.EventHandler(this.CustomerListMenuItem_Click);
            // 
            // ürünİşlmleriToolStripMenuItem
            // 
            this.ürünİşlmleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniÜrünToolStripMenuItem,
            this.ürünListesiToolStripMenuItem});
            this.ürünİşlmleriToolStripMenuItem.Name = "ürünİşlmleriToolStripMenuItem";
            this.ürünİşlmleriToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.ürünİşlmleriToolStripMenuItem.Text = "Ürün İşlemleri";
            // 
            // yeniÜrünToolStripMenuItem
            // 
            this.yeniÜrünToolStripMenuItem.Name = "yeniÜrünToolStripMenuItem";
            this.yeniÜrünToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.yeniÜrünToolStripMenuItem.Text = "Yeni Ürün";
            this.yeniÜrünToolStripMenuItem.Click += new System.EventHandler(this.yeniÜrünToolStripMenuItem_Click);
            // 
            // ürünListesiToolStripMenuItem
            // 
            this.ürünListesiToolStripMenuItem.Name = "ürünListesiToolStripMenuItem";
            this.ürünListesiToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ürünListesiToolStripMenuItem.Text = "Ürün Listesi";
            this.ürünListesiToolStripMenuItem.Click += new System.EventHandler(this.ürünListesiToolStripMenuItem_Click);
            // 
            // siparişİşlemleriToolStripMenuItem
            // 
            this.siparişİşlemleriToolStripMenuItem.Name = "siparişİşlemleriToolStripMenuItem";
            this.siparişİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.siparişİşlemleriToolStripMenuItem.Text = "Sipariş İşlemleri";
            // 
            // tanımlamalarToolStripMenuItem1
            // 
            this.tanımlamalarToolStripMenuItem1.Name = "tanımlamalarToolStripMenuItem1";
            this.tanımlamalarToolStripMenuItem1.Size = new System.Drawing.Size(112, 24);
            this.tanımlamalarToolStripMenuItem1.Text = "Tanımlamalar";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 623);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Siparis Otomasyon";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem CustomerList;
        private System.Windows.Forms.ToolStripMenuItem ürünİşlmleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siparişİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newCustomerMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CustomerListMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tanımlamalarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem yeniÜrünToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünListesiToolStripMenuItem;
    }
}

