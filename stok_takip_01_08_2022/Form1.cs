using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace stok_takip_01_08_2022
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder();
        MySqlConnection baglanti;
        private void Form1_Load(object sender, EventArgs e)
        {
            build.Server = "localhost";
            build.UserID = "root";
            build.Database = "stoktakip";
            build.Password = "MwC676";

            baglanti = new MySqlConnection(build.ToString());
        }
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            MessageBox.Show("Ürün Başarıyla Eklendi!");
        }
        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap = MessageBox.Show("Programı Kapatmak İstiyor Musunuz ?", "Çıkış", MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if (cevap == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void yeniÜrünEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YeniÜrünEkle yeniÜrünEkle = new YeniÜrünEkle();
            yeniÜrünEkle.ShowDialog();
        }

        private void ürünGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ÜrünGüncelle ürünGüncelle = new ÜrünGüncelle();
            ürünGüncelle.ShowDialog();
        }

        private void ürünSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ÜrünSil ürünSil = new ÜrünSil();
            ürünSil.ShowDialog();
        }

        private void mevcutStokDurumuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MevcutStokDurumu mevcutStokDurumu = new MevcutStokDurumu();
            mevcutStokDurumu.ShowDialog();
        }

        private void ürünDetaylarınıGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ÜrünDetaylarınıGüncelle ürünDetaylarınıGüncelle = new ÜrünDetaylarınıGüncelle();
            ürünDetaylarınıGüncelle .ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            PersonelGiris giris = new PersonelGiris();
            giris.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            YöneticiGiris yöneticiGiris = new YöneticiGiris();
            yöneticiGiris.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {}
        private void girişSeçimEkranıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GirisSecimEkranı girisSecimEkranı = new GirisSecimEkranı();
            girisSecimEkranı.Show();
            this.Hide();
        }

        private void kullanıcıBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {}

        private void kullanıcıEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {}

        private void kullanıcıEkleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PersonelKaydı personelKaydı = new PersonelKaydı();
            personelKaydı.Show();
        }

        private void kayıtlıKullanıcılarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KullanıcıKayıtları kullanıcıKayıtları = new KullanıcıKayıtları();
            kullanıcıKayıtları.Show();
        }

        private void yöneticiEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YöneticiKaydi yöneticiKaydi = new YöneticiKaydi();
            yöneticiKaydi.Show();
        }

        private void kayıtlıYöneticilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KayıtlıYöneticiler kayıtlıYöneticiler = new KayıtlıYöneticiler();
            kayıtlıYöneticiler.Show();
        }

        private void yönetimPaneliToolStripMenuItem_Click(object sender, EventArgs e)
        {}

        private void yöneticiŞifreDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YöneticiSifreDegistir yöneticiSifreDegistir = new YöneticiSifreDegistir();
            yöneticiSifreDegistir.Show();
        }

        private void kullanıcıŞifreDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonelSifreDegistir personelSifreDegistir = new PersonelSifreDegistir();
            personelSifreDegistir.Show();
        }

        private void kullanıcıSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KullanıcıSil kullaniciSil = new KullanıcıSil();
            kullaniciSil.Show();
        }

        private void yöneticiSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YöneticiSil yöneticiSil = new YöneticiSil();
            yöneticiSil.Show();
        }
    }
}