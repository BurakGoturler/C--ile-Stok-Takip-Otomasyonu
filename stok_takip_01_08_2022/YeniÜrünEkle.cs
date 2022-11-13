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
    public partial class YeniÜrünEkle : Form
    {
        public YeniÜrünEkle()
        {
            InitializeComponent();
        }

        MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder();
        MySqlConnection baglanti;

        private void YeniÜrünEkle_Load(object sender, EventArgs e)
        {}

        private void Mükerrer() 
        {
            build.Server = "localhost";
            build.UserID = "root";
            build.Database = "stoktakip";
            build.Password = "MwC676";

            baglanti = new MySqlConnection(build.ToString());
            baglanti.Open();

            MySqlCommand komut = new MySqlCommand("select * from ürünkayit where dbserinumara=@dbserinumara", baglanti);
            komut.Parameters.AddWithValue("dbserinumara",txtSeriNumara.Text);

            MySqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                MessageBox.Show("Girilen ürün numarası zaten kullanılıyor, lütfen başka bir ürün adı yazınız", "Uyarı");
            }
            else
            {
                if (txtSeriNumara.Text == "" || txtModel.Text == "" || txtMarka.Text == "" || txtFiyat.Text == "" || txtAlındığıYer.Text == "" || txtAdet.Text == "" || txtÜrün.Text == "")

                {
                    MessageBox.Show("Lütfen boş alanları doldurunuz!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ürünler Başarıyla Eklendi!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    kayıtEkle();
                }
            }
            baglanti.Close();
        }

        private void kayıtEkle()
        {
            if (txtSeriNumara.Text == "" || txtModel.Text == "" || txtMarka.Text == "" || txtFiyat.Text == "" || txtAlındığıYer.Text == "" || txtAdet.Text == "" || txtÜrün.Text == "")
            {
                MessageBox.Show("Alanları Boş Geçemezsiniz", "Boş Alan Hatası");
            }
            else
            {
                build.Server = "localhost";
                build.UserID = "root";
                build.Database = "stoktakip";
                build.Password = "MwC676";

                baglanti = new MySqlConnection(build.ToString());
                baglanti.Open();

                MySqlCommand komut = new MySqlCommand("insert into ürünkayit(dbserinumara,dbmarka,dbürün,dbmodel,dbfiyat,dbadet,dbalindiğiyer) values(@dbserinumara,@dbmarka,@dbürün,@dbmodel,@dbfiyat,@dbadet,@dbalindiğiyer)", baglanti);
                komut.Parameters.AddWithValue("@dbserinumara", txtSeriNumara.Text);
                komut.Parameters.AddWithValue("@dbmarka", txtMarka.Text);
                komut.Parameters.AddWithValue("@dbmodel", txtModel.Text);
                komut.Parameters.AddWithValue("@dbürün", txtÜrün.Text);
                komut.Parameters.AddWithValue("@dbfiyat", txtFiyat.Text.ToString());
                komut.Parameters.AddWithValue("@dbadet", txtAdet.Text.ToString());
                komut.Parameters.AddWithValue("@dbalindiğiyer", txtAlındığıYer.Text);

                komut.ExecuteNonQuery();
                baglanti.Close();
            }
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void txtSeriNumara_TextChanged(object sender, EventArgs e)
        {}

        private void btnYeniEkle_Click(object sender, EventArgs e)
        {
            Mükerrer();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        { }
    }
}
