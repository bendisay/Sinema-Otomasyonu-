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
    public partial class seansEkleme : Form
    {
        public seansEkleme()
        {
            InitializeComponent();
        }

        private void seansEkleme_FormClosing(object sender, FormClosingEventArgs e)
        {
            anaSayfa anaSayfa = new anaSayfa();
            anaSayfa.ShowDialog();
            this.Hide();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-JTCBAF3E\\SQLEXPRESS;Initial Catalog=SinemaOtomasyonu;Integrated Security=True");


        string seans = "";
        private void RadiobuttonSeciliyse()
        {
            if (radioButton1.Checked == true) { seans = radioButton1.Text; }
            else if (radioButton2.Checked == true) { seans = radioButton2.Text; }
            else if (radioButton3.Checked == true) { seans = radioButton3.Text; }
            else if (radioButton4.Checked == true) { seans = radioButton4.Text; }
            else if (radioButton5.Checked == true) { seans = radioButton5.Text; }
            else if (radioButton6.Checked == true) { seans = radioButton6.Text; }
            else if (radioButton7.Checked == true) { seans = radioButton7.Text; }
            else if (radioButton8.Checked == true) { seans = radioButton8.Text; }
            else if (radioButton9.Checked == true) { seans = radioButton9.Text; }
            else if (radioButton10.Checked == true) { seans = radioButton10.Text; }
            else if (radioButton11.Checked == true) { seans = radioButton11.Text; }
            else if (radioButton12.Checked == true) { seans = radioButton12.Text; }

        }
        SinemaOtoTableAdapters.SeansBilgileriTableAdapter filmSeansı = new SinemaOtoTableAdapters.SeansBilgileriTableAdapter();
        private void ekle_Click(object sender, EventArgs e)
        {
            RadiobuttonSeciliyse();

            if (seans != "")
            {
                filmSeansı.SeansEkleme(comboBox1.Text, comboBox2.Text, dateTimePicker1.Text, seans);
                MessageBox.Show("seans ekleme işlemi yapıldı!", "kayıt");
            }
            else if (seans == "")
                MessageBox.Show("seans seçimi yapmadınız", "uyarı!");

            comboBox1.Text = "";
            comboBox2.Text = "";
            dateTimePicker1.Text = DateTime.Now.ToShortDateString();

        }
       
        private void FilmveSalonGöster(ComboBox combo, string sql, string sql2)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sql, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read() == true)
            {
                combo.Items.Add(read[sql2].ToString());
            }
            baglanti.Close();
        }

        private void seansEkleme_Load(object sender, EventArgs e)
        {
            FilmveSalonGöster(comboBox1, "SELECT * FROM Film_Bilgileri", "FilmAdi");
            FilmveSalonGöster(comboBox2, "SELECT * FROM SalonBilgileri", "SalonAdi");

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            foreach (Control item3 in panel1.Controls)
            {
                item3.Enabled = true;
            }
            DateTime bugün = DateTime.Parse(DateTime.Now.ToString());
            DateTime yeni = DateTime.Parse(dateTimePicker1.Text);
            if (bugün == yeni)
            {
                foreach (Control item in panel1.Controls)
                {
                    if (DateTime.Parse(DateTime.Now.ToShortDateString()) > DateTime.Parse(item.Text))
                    {
                        item.Enabled = false;
                    }
                }
                TarihleriKarşılaştır();
            }
            else if (yeni == bugün)
            {
                TarihleriKarşılaştır();
            }
            else if (yeni < bugün)
            {
                MessageBox.Show("geriye dönük işlem yapılamaz!", "uyarı!!");
                dateTimePicker1.Text = DateTime.Now.ToShortDateString();
            }
        }

        private void TarihleriKarşılaştır()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from SeansBilgileri where SalonAdi = '" + comboBox2.Text + "' and Tarih = '" + dateTimePicker1.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read() == true)
            {
                foreach (Control item2 in panel1.Controls)
                {
                    if (read["seans"].ToString() == item2.Text)
                    {
                        item2.Enabled = false;
                    }
                }
            }
            baglanti.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Text = DateTime.Now.ToShortDateString();

        }
    }
}
