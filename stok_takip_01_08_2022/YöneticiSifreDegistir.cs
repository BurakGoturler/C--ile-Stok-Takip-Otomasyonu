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
    public partial class YöneticiSifreDegistir : Form
    {
        public YöneticiSifreDegistir()
        {
            InitializeComponent();
        }

        MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder();
        MySqlConnection baglanti;

        DataSet daset = new DataSet();

        private void YöneticiSifreDegistir_Load(object sender, EventArgs e)
        {
            build.Server = "localhost";
            build.UserID = "root";
            build.Database = "stoktakip";
            build.Password = "MwC676";

            baglanti = new MySqlConnection(build.ToString());

            YöneticiListele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text == "" || txtSifre.Text == "" || txtKullaniciAdi.Text == String.Empty || txtSifre.Text == String.Empty)
            {
                MessageBox.Show("Lütfen boş alanları doldurunuz!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                baglanti.Open();
                MySqlCommand komut = new MySqlCommand("update yönetici set dbykullaniciadi=@dbykullaniciadi,dbysifre=@dbysifre  where dbykullaniciadi=@dbykullaniciadi", baglanti);
                komut.Parameters.AddWithValue("@dbykullaniciadi", txtKullaniciAdi.Text);
                komut.Parameters.AddWithValue("@dbysifre", txtSifre.Text);

                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Şifreniz Başarıyla Güncellendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void YöneticiListele()
        {
            baglanti.Open();
            MySqlDataAdapter adtr = new MySqlDataAdapter("select * from yönetici", baglanti);
            adtr.Fill(daset, "yönetici");
            dataGridView1.DataSource = daset.Tables["yönetici"];
            baglanti.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtKullaniciAdi.Text = dataGridView1.CurrentRow.Cells["dbykullaniciadi"].Value.ToString();
            txtSifre.Text = dataGridView1.CurrentRow.Cells["dbysifre"].Value.ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {}

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {

                txtSifre.PasswordChar = '\0';
            }
            else
            {
                txtSifre.PasswordChar = '*';
            }
        }

        private void YöneticiSifreDegistir_Shown(object sender, EventArgs e)
        {
            txtKullaniciAdi.Focus();
        }
    }
}
