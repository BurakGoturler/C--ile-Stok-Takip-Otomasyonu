namespace stok_takip_01_08_2022
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.stokİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünDetaylarınıGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniÜrünEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depoİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mevcutStokDurumuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.girişİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.girişSeçimEkranıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yönetimPaneliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kayıtlıYöneticilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kayıtlıKullanıcılarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.yöneticiŞifreDeğiştirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıŞifreDeğiştirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.yöneticiEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıEkleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.yöneticiSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stokİşlemleriToolStripMenuItem,
            this.depoİşlemleriToolStripMenuItem,
            this.girişİşlemleriToolStripMenuItem,
            this.yönetimPaneliToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(437, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // stokİşlemleriToolStripMenuItem
            // 
            this.stokİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ürünGüncelleToolStripMenuItem,
            this.ürünSilToolStripMenuItem,
            this.ürünDetaylarınıGüncelleToolStripMenuItem,
            this.yeniÜrünEkleToolStripMenuItem});
            this.stokİşlemleriToolStripMenuItem.Name = "stokİşlemleriToolStripMenuItem";
            this.stokİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.stokİşlemleriToolStripMenuItem.Text = "Stok İşlemleri";
            // 
            // ürünGüncelleToolStripMenuItem
            // 
            this.ürünGüncelleToolStripMenuItem.Image = global::stok_takip_01_08_2022.Properties.Resources.Iconsmind_Outline_Folder_Refresh;
            this.ürünGüncelleToolStripMenuItem.Name = "ürünGüncelleToolStripMenuItem";
            this.ürünGüncelleToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.ürünGüncelleToolStripMenuItem.Text = "Ürün Adet Güncelle - Ekle";
            this.ürünGüncelleToolStripMenuItem.Click += new System.EventHandler(this.ürünGüncelleToolStripMenuItem_Click);
            // 
            // ürünSilToolStripMenuItem
            // 
            this.ürünSilToolStripMenuItem.Image = global::stok_takip_01_08_2022.Properties.Resources.Iconsmind_Outline_Folder_Trash;
            this.ürünSilToolStripMenuItem.Name = "ürünSilToolStripMenuItem";
            this.ürünSilToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.ürünSilToolStripMenuItem.Text = "Ürün Adet Güncelle - Sil";
            this.ürünSilToolStripMenuItem.Click += new System.EventHandler(this.ürünSilToolStripMenuItem_Click);
            // 
            // ürünDetaylarınıGüncelleToolStripMenuItem
            // 
            this.ürünDetaylarınıGüncelleToolStripMenuItem.Image = global::stok_takip_01_08_2022.Properties.Resources.Iconsmind_Outline_Folder_Settings;
            this.ürünDetaylarınıGüncelleToolStripMenuItem.Name = "ürünDetaylarınıGüncelleToolStripMenuItem";
            this.ürünDetaylarınıGüncelleToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.ürünDetaylarınıGüncelleToolStripMenuItem.Text = "Ürün Detaylarını Güncelle";
            this.ürünDetaylarınıGüncelleToolStripMenuItem.Click += new System.EventHandler(this.ürünDetaylarınıGüncelleToolStripMenuItem_Click);
            // 
            // yeniÜrünEkleToolStripMenuItem
            // 
            this.yeniÜrünEkleToolStripMenuItem.Image = global::stok_takip_01_08_2022.Properties.Resources.Iconsmind_Outline_Folder_Upload;
            this.yeniÜrünEkleToolStripMenuItem.Name = "yeniÜrünEkleToolStripMenuItem";
            this.yeniÜrünEkleToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.yeniÜrünEkleToolStripMenuItem.Text = "Yeni Ürün Ekle";
            this.yeniÜrünEkleToolStripMenuItem.Click += new System.EventHandler(this.yeniÜrünEkleToolStripMenuItem_Click);
            // 
            // depoİşlemleriToolStripMenuItem
            // 
            this.depoİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mevcutStokDurumuToolStripMenuItem});
            this.depoİşlemleriToolStripMenuItem.Name = "depoİşlemleriToolStripMenuItem";
            this.depoİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.depoİşlemleriToolStripMenuItem.Text = "Depo İşlemleri";
            // 
            // mevcutStokDurumuToolStripMenuItem
            // 
            this.mevcutStokDurumuToolStripMenuItem.Image = global::stok_takip_01_08_2022.Properties.Resources.Iconsmind_Outline_Financial;
            this.mevcutStokDurumuToolStripMenuItem.Name = "mevcutStokDurumuToolStripMenuItem";
            this.mevcutStokDurumuToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.mevcutStokDurumuToolStripMenuItem.Text = "Mevcut Stok Durumu";
            this.mevcutStokDurumuToolStripMenuItem.Click += new System.EventHandler(this.mevcutStokDurumuToolStripMenuItem_Click);
            // 
            // girişİşlemleriToolStripMenuItem
            // 
            this.girişİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.girişSeçimEkranıToolStripMenuItem});
            this.girişİşlemleriToolStripMenuItem.Name = "girişİşlemleriToolStripMenuItem";
            this.girişİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.girişİşlemleriToolStripMenuItem.Text = "Giriş İşlemleri";
            // 
            // girişSeçimEkranıToolStripMenuItem
            // 
            this.girişSeçimEkranıToolStripMenuItem.Image = global::stok_takip_01_08_2022.Properties.Resources.Iconsmind_Outline_Home_2_2;
            this.girişSeçimEkranıToolStripMenuItem.Name = "girişSeçimEkranıToolStripMenuItem";
            this.girişSeçimEkranıToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.girişSeçimEkranıToolStripMenuItem.Text = "Giriş Seçim Ekranı";
            this.girişSeçimEkranıToolStripMenuItem.Click += new System.EventHandler(this.girişSeçimEkranıToolStripMenuItem_Click);
            // 
            // yönetimPaneliToolStripMenuItem
            // 
            this.yönetimPaneliToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kayıtlıYöneticilerToolStripMenuItem,
            this.kayıtlıKullanıcılarToolStripMenuItem,
            this.toolStripMenuItem1,
            this.yöneticiŞifreDeğiştirToolStripMenuItem,
            this.kullanıcıŞifreDeğiştirToolStripMenuItem,
            this.toolStripMenuItem2,
            this.yöneticiEkleToolStripMenuItem,
            this.kullanıcıEkleToolStripMenuItem1,
            this.toolStripMenuItem3,
            this.yöneticiSilToolStripMenuItem,
            this.kullanıcıSilToolStripMenuItem});
            this.yönetimPaneliToolStripMenuItem.Name = "yönetimPaneliToolStripMenuItem";
            this.yönetimPaneliToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.yönetimPaneliToolStripMenuItem.Text = "Kullanıcı İşlemleri";
            this.yönetimPaneliToolStripMenuItem.Click += new System.EventHandler(this.yönetimPaneliToolStripMenuItem_Click);
            // 
            // kayıtlıYöneticilerToolStripMenuItem
            // 
            this.kayıtlıYöneticilerToolStripMenuItem.Image = global::stok_takip_01_08_2022.Properties.Resources.Iconsmind_Outline_Address_Book;
            this.kayıtlıYöneticilerToolStripMenuItem.Name = "kayıtlıYöneticilerToolStripMenuItem";
            this.kayıtlıYöneticilerToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.kayıtlıYöneticilerToolStripMenuItem.Text = "Kayıtlı Yöneticileri Göster";
            this.kayıtlıYöneticilerToolStripMenuItem.Click += new System.EventHandler(this.kayıtlıYöneticilerToolStripMenuItem_Click);
            // 
            // kayıtlıKullanıcılarToolStripMenuItem
            // 
            this.kayıtlıKullanıcılarToolStripMenuItem.Image = global::stok_takip_01_08_2022.Properties.Resources.Iconsmind_Outline_Address_Book;
            this.kayıtlıKullanıcılarToolStripMenuItem.Name = "kayıtlıKullanıcılarToolStripMenuItem";
            this.kayıtlıKullanıcılarToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.kayıtlıKullanıcılarToolStripMenuItem.Text = "Kayıtlı Personelleri Göster";
            this.kayıtlıKullanıcılarToolStripMenuItem.Click += new System.EventHandler(this.kayıtlıKullanıcılarToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(206, 6);
            // 
            // yöneticiŞifreDeğiştirToolStripMenuItem
            // 
            this.yöneticiŞifreDeğiştirToolStripMenuItem.Image = global::stok_takip_01_08_2022.Properties.Resources.Icons8_Ios7_User_Interface_Password;
            this.yöneticiŞifreDeğiştirToolStripMenuItem.Name = "yöneticiŞifreDeğiştirToolStripMenuItem";
            this.yöneticiŞifreDeğiştirToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.yöneticiŞifreDeğiştirToolStripMenuItem.Text = "Yönetici Şifre Değiştir";
            this.yöneticiŞifreDeğiştirToolStripMenuItem.Click += new System.EventHandler(this.yöneticiŞifreDeğiştirToolStripMenuItem_Click);
            // 
            // kullanıcıŞifreDeğiştirToolStripMenuItem
            // 
            this.kullanıcıŞifreDeğiştirToolStripMenuItem.Image = global::stok_takip_01_08_2022.Properties.Resources.Icons8_Ios7_User_Interface_Password;
            this.kullanıcıŞifreDeğiştirToolStripMenuItem.Name = "kullanıcıŞifreDeğiştirToolStripMenuItem";
            this.kullanıcıŞifreDeğiştirToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.kullanıcıŞifreDeğiştirToolStripMenuItem.Text = "Personel Şifre Değiştir";
            this.kullanıcıŞifreDeğiştirToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıŞifreDeğiştirToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(206, 6);
            // 
            // yöneticiEkleToolStripMenuItem
            // 
            this.yöneticiEkleToolStripMenuItem.Image = global::stok_takip_01_08_2022.Properties.Resources.Iconsmind_Outline_Add_User;
            this.yöneticiEkleToolStripMenuItem.Name = "yöneticiEkleToolStripMenuItem";
            this.yöneticiEkleToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.yöneticiEkleToolStripMenuItem.Text = "Yönetici Ekle";
            this.yöneticiEkleToolStripMenuItem.Click += new System.EventHandler(this.yöneticiEkleToolStripMenuItem_Click);
            // 
            // kullanıcıEkleToolStripMenuItem1
            // 
            this.kullanıcıEkleToolStripMenuItem1.Image = global::stok_takip_01_08_2022.Properties.Resources.Iconsmind_Outline_Add_User;
            this.kullanıcıEkleToolStripMenuItem1.Name = "kullanıcıEkleToolStripMenuItem1";
            this.kullanıcıEkleToolStripMenuItem1.Size = new System.Drawing.Size(209, 22);
            this.kullanıcıEkleToolStripMenuItem1.Text = "Personel Ekle";
            this.kullanıcıEkleToolStripMenuItem1.Click += new System.EventHandler(this.kullanıcıEkleToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(206, 6);
            // 
            // yöneticiSilToolStripMenuItem
            // 
            this.yöneticiSilToolStripMenuItem.Image = global::stok_takip_01_08_2022.Properties.Resources.Iconsmind_Outline_Remove_User;
            this.yöneticiSilToolStripMenuItem.Name = "yöneticiSilToolStripMenuItem";
            this.yöneticiSilToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.yöneticiSilToolStripMenuItem.Text = "Yönetici Sil";
            this.yöneticiSilToolStripMenuItem.Click += new System.EventHandler(this.yöneticiSilToolStripMenuItem_Click);
            // 
            // kullanıcıSilToolStripMenuItem
            // 
            this.kullanıcıSilToolStripMenuItem.Image = global::stok_takip_01_08_2022.Properties.Resources.Iconsmind_Outline_Remove_User;
            this.kullanıcıSilToolStripMenuItem.Name = "kullanıcıSilToolStripMenuItem";
            this.kullanıcıSilToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.kullanıcıSilToolStripMenuItem.Text = "Personel Sil";
            this.kullanıcıSilToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıSilToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(437, 307);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Takip";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem stokİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniÜrünEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depoİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mevcutStokDurumuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünDetaylarınıGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem girişİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem girişSeçimEkranıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kayıtlıKullanıcılarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        public System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem yöneticiEkleToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem yönetimPaneliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıEkleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem yöneticiŞifreDeğiştirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıŞifreDeğiştirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kayıtlıYöneticilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yöneticiSilToolStripMenuItem;
    }
}

