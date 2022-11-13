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
    public partial class PersonelGiris : Form
    {
        public PersonelGiris()
        {
            InitializeComponent();
        }

        MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder();
        MySqlConnection baglanti;

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
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

                MySqlDataAdapter da = new MySqlDataAdapter("Select * from kullanicilar where dbkullaniciadi=@dbkullaniciadi AND dbsifre=@dbsifre", baglanti);

                da.SelectCommand.Parameters.AddWithValue("dbkullaniciadi", textBox1.Text);
                da.SelectCommand.Parameters.AddWithValue("dbsifre", textBox2.Text);

                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    Form1 form1 = new Form1();
                    form1.Show();
                    this.Hide();
                    form1.yönetimPaneliToolStripMenuItem.Visible = false;
                }
                else
                {
                    MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre. Tekrar Deneyiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                baglanti.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GirisSecimEkranı girisSecimEkranı = new GirisSecimEkranı();
            girisSecimEkranı.Show();
            this.Hide();
        }

        private void PersonelGiris_Load(object sender, EventArgs e)
        {}

        private void panel1_Paint(object sender, PaintEventArgs e)
        {}

        private void PersonelGiris_Shown(object sender, EventArgs e)
        {
            textBox1.Focus();
        }
    }
}
