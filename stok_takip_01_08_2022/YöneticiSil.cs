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
    public partial class YöneticiSil : Form
    {
        public YöneticiSil()
        {
            InitializeComponent();
        }

        MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder();
        MySqlConnection baglanti;

        DataSet daset = new DataSet();

        private void YöneticiSil_Load(object sender, EventArgs e)
        {}

        private void button1_Click(object sender, EventArgs e)
        {
            build.Server = "localhost";
            build.UserID = "root";
            build.Database = "stoktakip";
            build.Password = "MwC676";

            baglanti = new MySqlConnection(build.ToString());

            DataTable tablo = new DataTable();

            baglanti.Open();
            MySqlDataAdapter adtr = new MySqlDataAdapter("select * from yönetici", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {}
        private void Listele()
        {}

        private void KayıtSil()
        {}

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Lütfen boş alanları doldurunuz!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                baglanti.Open();
                MySqlCommand komut = new MySqlCommand("delete from yönetici  where dbykullaniciadi=@dbykullaniciadi", baglanti);
                komut.Parameters.AddWithValue("@dbykullaniciadi", textBox1.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Yönetici Kaydı Silindi!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void YöneticiSil_Shown(object sender, EventArgs e)
        {
            textBox1.Focus();
        }
    }
}
