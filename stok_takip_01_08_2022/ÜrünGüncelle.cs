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
    public partial class ÜrünGüncelle : Form
    {
        public ÜrünGüncelle()
        {
            InitializeComponent();
        }

        MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder();
        MySqlConnection baglanti;

        private void SeriNumaratxt_TextChanged(object sender, EventArgs e)
        {
            if (SeriNumaratxt.Text == "")
            {
                lblMiktar.Text = "";
                foreach (Control item in groupBox2.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("select * from ürünkayit where dbserinumara like '"+ SeriNumaratxt.Text+ "' ", baglanti);
            MySqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                label11.Text = read["dbürün"].ToString();
                label10.Text = read["dbmodel"].ToString();
                label9.Text = read["dbfiyat"].ToString();
                label2.Text = read["dbmarka"].ToString();
                label1.Text = read["dbalindiğiyer"].ToString();
                lblMiktar.Text = read["dbadet"].ToString();
            }
            baglanti.Close();
        }
        private void btnGüncelle_Click(object sender, EventArgs e) // Stok'a Ekle Butonu
        {
            if (SeriNumaratxt.Text == "" || Adettxt.Text == "" || SeriNumaratxt.Text == String.Empty || Adettxt.Text == String.Empty)
            {
                MessageBox.Show("Lütfen boş alanları doldurunuz!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                build.Server = "localhost";
                build.UserID = "root";
                build.Database = "stoktakip";
                build.Password = "MwC676";

                baglanti = new MySqlConnection(build.ToString());

                baglanti.Open();
                MySqlCommand komut = new MySqlCommand("update ürünkayit set dbadet=dbadet+'" + int.Parse(Adettxt.Text) + "' where dbserinumara='" + SeriNumaratxt.Text + "'", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Ürün Başarıyla Güncellendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {}

        private void ÜrünGüncelle_Load(object sender, EventArgs e)
        {
            build.Server = "localhost";
            build.UserID = "root";
            build.Database = "stoktakip";
            build.Password = "MwC676";

            baglanti = new MySqlConnection(build.ToString());
        }
    }
}
