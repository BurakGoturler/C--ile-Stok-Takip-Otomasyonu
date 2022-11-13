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
    public partial class KullanıcıKayıtları : Form
    {
        public KullanıcıKayıtları()
        {
            InitializeComponent();
        }

        MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder();
        MySqlConnection baglanti;

        DataSet daset = new DataSet();

        private void button1_Click(object sender, EventArgs e)
        {
            build.Server = "localhost";
            build.UserID = "root";
            build.Database = "stoktakip";
            build.Password = "MwC676";

            baglanti = new MySqlConnection(build.ToString());

            DataTable tablo = new DataTable();

            baglanti.Open();
            MySqlDataAdapter adtr = new MySqlDataAdapter("select * from kullanicilar",baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void KullanıcıKayıtları_Load(object sender, EventArgs e)
        {}

        private void KullanıcıKayıtları_Shown(object sender, EventArgs e)
        {
            button1.Focus();
        }
    }
}
