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
    public partial class ÜrünDetaylarınıGüncelle : Form
    {
        public ÜrünDetaylarınıGüncelle()
        {
            InitializeComponent();

        }

        MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder();
        MySqlConnection baglanti;

        DataSet daset = new DataSet();
        private void ÜrünDetaylarınıGüncelle_Load(object sender, EventArgs e)
        {
            build.Server = "localhost";
            build.UserID = "root";
            build.Database = "stoktakip";
            build.Password = "MwC676";

            baglanti = new MySqlConnection(build.ToString());

            ÜrünListele();
        }
        private void ÜrünListele()
        {
            baglanti.Open();
            MySqlDataAdapter adtr = new MySqlDataAdapter("select * from ürünkayit", baglanti);
            adtr.Fill(daset, "ürünkayit");
            dataGridView1.DataSource = daset.Tables["ürünkayit"];
            baglanti.Close();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            if (txtSeriNo.Text != "")
            {
                build.Server = "localhost";
                build.UserID = "root";
                build.Database = "stoktakip";
                build.Password = "MwC676";

                baglanti = new MySqlConnection(build.ToString());

                baglanti.Open();
                MySqlCommand komut = new MySqlCommand("update ürünkayit set dbmarka=@dbmarka,dbalindiğiyer=@dbalindiğiyer,dbmodel=@dbmodel,dbürün=@dbürün where dbserinumara=@dbserinumara", baglanti);
                komut.Parameters.AddWithValue("@dbserinumara", txtSeriNo.Text);
                komut.Parameters.AddWithValue("@dbmarka", txtMarka.Text);
                komut.Parameters.AddWithValue("@dbalindiğiyer", txtAlındığıYer.Text);
                komut.Parameters.AddWithValue("@dbmodel", txtModel.Text);
                komut.Parameters.AddWithValue("@dbürün", txtÜrün.Text);

                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Ürün Detayları Başarıyla Güncellendi!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Geçerli Bir Seri Numarası Giriniz!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
     
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSeriNo.Text = dataGridView1.CurrentRow.Cells["dbserinumara"].Value.ToString();
            txtMarka.Text = dataGridView1.CurrentRow.Cells["dbmarka"].Value.ToString();
            txtÜrün.Text = dataGridView1.CurrentRow.Cells["dbürün"].Value.ToString();
            txtModel.Text = dataGridView1.CurrentRow.Cells["dbmodel"].Value.ToString();
            txtAlındığıYer.Text = dataGridView1.CurrentRow.Cells["dbalindiğiyer"].Value.ToString();
        }

        private void txtSeriNo_TextChanged(object sender, EventArgs e)
        {}

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { }
    }
}
