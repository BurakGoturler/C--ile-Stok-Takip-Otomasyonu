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
    public partial class PersonelKaydı : Form
    {
        public PersonelKaydı()
        {
            InitializeComponent();
        }

        MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder();
        MySqlConnection baglanti;

        private void button1_Click(object sender, EventArgs e)
        {
            Mükerrer();
        }

        private void Mükerrer() 
        {
            build.Server = "localhost";
            build.UserID = "root";
            build.Database = "stoktakip";
            build.Password = "MwC676";

            baglanti = new MySqlConnection(build.ToString());
            baglanti.Open();

            MySqlCommand komut = new MySqlCommand("select * from kullanicilar where dbkullaniciadi=@dbkullaniciadi", baglanti);

            komut.Parameters.AddWithValue("@dbkullaniciadi", textBox1.Text);
            // komut.Parameters.AddWithValue("@dysifre", textBox2.Text); // şifrenin de aynı olması istenmiyorsa kullanılabilir.

            MySqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                MessageBox.Show("Girilen kullanıcı adı zaten kullanılıyor, lütfen başka bir kullanıcı adı yazınız", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            }
            else
            {
                if (textBox1.Text == "" || textBox2.Text == "")

                {
                    MessageBox.Show("Lütfen boş alanları doldurunuz!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Yeni Personel Eklenmiştir.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    kayıtEkle();
                }
            }
            baglanti.Close();
        }

        private void kayıtEkle() 
        {
            if (textBox1.Text == "" || textBox2.Text == "")
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

                MySqlCommand komut2 = new MySqlCommand("insert into kullanicilar (dbkullaniciadi,dbsifre)values (@dbkullaniciadi,@dbsifre)", baglanti);

                komut2.Parameters.AddWithValue("@dbkullaniciadi", textBox1.Text);
                komut2.Parameters.AddWithValue("@dbsifre", textBox2.Text);
                komut2.ExecuteNonQuery();

                baglanti.Close();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = '\0';
            }
            else
            {
                textBox2.PasswordChar = '*';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {}

        private void textBox2_TextChanged(object sender, EventArgs e)
        {}

        private void button2_MouseEnter(object sender, EventArgs e)
        {}

        private void PersonelKaydı_Load(object sender, EventArgs e)
        {
            build.Server = "localhost";
            build.UserID = "root";
            build.Database = "stoktakip";
            build.Password = "MwC676";

            baglanti = new MySqlConnection(build.ToString());
        }
    }
}
