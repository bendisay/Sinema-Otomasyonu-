using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaOtomasyonu
{
    public partial class seansListele : Form
    {
        public seansListele()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-JTCBAF3E\\SQLEXPRESS;Initial Catalog=SinemaOtomasyonu;Integrated Security=True");
        DataTable tablo = new DataTable();
        private void SeansListesi(string sql)
        { 
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter(sql, baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;   
            baglanti.Close();

        }
        private void seansListele_Load(object sender, EventArgs e)
        {
            tablo.Clear();
            SeansListesi("select * from SeansBilgileri where Tarih like'" + dateTimePicker1.Text + "'");
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            tablo.Clear();
            SeansListesi("select * from SeansBilgileri where Tarih like'" + dateTimePicker1.Text + "'");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            tablo.Clear();
            SeansListesi("select * from SeansBilgileri");
        }

        private void seansListele_FormClosing(object sender, FormClosingEventArgs e)
        {
            anaSayfa anaSayfa = new anaSayfa();
            anaSayfa.ShowDialog();
            this.Hide();

        }
    }
}
