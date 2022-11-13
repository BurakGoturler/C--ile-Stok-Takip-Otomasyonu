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
    public partial class MevcutStokDurumu : Form
    {
        public MevcutStokDurumu()
        {
            InitializeComponent();
        }

        MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder();
        MySqlConnection baglanti;

        DataSet daset = new DataSet();
        private void MevcutStokDurumu_Load(object sender, EventArgs e)
        {}
        private void textBox1_TextChanged(object sender, EventArgs e)
        {}

        private void button1_Click(object sender, EventArgs e) // Ürünleri listeleyecek / gösterecek.
        {
            build.Server = "localhost";
            build.UserID = "root";
            build.Database = "stoktakip";
            build.Password = "MwC676";

            baglanti = new MySqlConnection(build.ToString());

            DataTable tablo = new DataTable();

            baglanti.Open();
            MySqlDataAdapter adtr = new MySqlDataAdapter("select * from ürünkayit where dbserinumara like '%" + textBox1.Text + "%'", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e) // Seçilen ürünü stok'tan silecek.
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Lütfen boş alanları doldurunuz!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                baglanti.Open();
                MySqlCommand komut = new MySqlCommand("delete from ürünkayit  where dbserinumara=@dbserinumara", baglanti);
                komut.Parameters.AddWithValue("@dbserinumara", textBox1.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Ürün Kayıttan Silindi!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells["dbserinumara"].Value.ToString();
        }
    }
}
