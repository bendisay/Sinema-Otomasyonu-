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
    public partial class anaSayfa : Form
    {
        public anaSayfa()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-JTCBAF3E\\SQLEXPRESS;Initial Catalog=SinemaOtomasyonu;Integrated Security=True");

        int sayac = 0;

        private void FilmveSalonGetir(ComboBox combo, string sql1, string sql2)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sql1, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while(read.Read()) 
            {
                combo.Items.Add(read[sql2].ToString());
            }
            baglanti.Close();
        }

        private void FilmAfisiGöster()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Film_Bilgileri where FilmAdi = '"+filmadi.SelectedItem+"' ", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while(read.Read())
            {
                pictureBox1.ImageLocation = read["Resim"].ToString();
            }
            baglanti.Close();

        }
        private void ComboDoluKoltuklar()
        {
            comboBox1.Items.Clear();
            comboBox1.Text = "";
            foreach (Control item in panel1.Controls)
            {
                if (item is Button)
                {
                    if (item.BackColor == Color.LightCoral)
                    {
                        comboBox1.Items.Add(item.Text);
                    }
                }
            }
        }
        private void YenidenRenklendir()
        {
            foreach (Control item in panel1.Controls)
            {
                if (item is Button)
                {
                    item.BackColor = Color.MistyRose;
                }
            }
        }
        private void VeritabanıDoluKoltuklar()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from SatisBilgileri",baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while(read.Read())
            {
                foreach(Control item in panel1.Controls)
                {
                    if (item is Button)
                    {
                        item.BackColor= Color.LightCoral;
                    }
                }    
            }
            baglanti.Close();
        }
        private void anaSayfa_Load(object sender, EventArgs e)
        {
            bosKoltuklar();
            FilmveSalonGetir(filmadi, "select * from Film_Bilgileri", "FilmAdi");
            FilmveSalonGetir(salonadi, "select * from SalonBilgileri", "SalonAdi");
        }

        private void bosKoltuklar()
        //dinamik şekilde buttonların oluşturulması
        {
            sayac = 1;

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    Button btn = new Button();
                    btn.BackColor = Color.MistyRose;
                    btn.Size = new Size(30, 30);
                    btn.Location = new Point(i * 35 + 30, j * 30 + 30);
                    btn.Name = sayac.ToString();
                    btn.Text = sayac.ToString();
                    sayac++;
                    if (i == 3) continue;
                    this.panel1.Controls.Add(btn);
                    btn.Click += BtnClick;
                }
            }
        }

        private void BtnClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.BackColor == Color.MistyRose)
            {
                koltukno.Text = b.Text;
            }

        }
        private void salonekle_Click(object sender, EventArgs e)
        {
            salonEkleme salon = new salonEkleme();
            salon.Show();
            this.Hide();
        }

        private void filmekle_Click(object sender, EventArgs e)
        {
            filmEkleme film = new filmEkleme();
            film.Show();
            this.Hide();
        }

        private void seansekle_Click(object sender, EventArgs e)
        {
            seansEkleme seans = new seansEkleme();
            seans.Show();
            this.Hide();
        }

        private void seanslistele_Click(object sender, EventArgs e)
        {
            seansListele listele = new seansListele();
            listele.Show();
            this.Hide();    
        }

        private void cıkıs_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("çıkmak istediğinize emin misiniz?", "EXİT", MessageBoxButtons.YesNo, MessageBoxIcon.Question); ;
            if (result == DialogResult.Yes)
                this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            satislar satislar = new satislar();
            satislar.Show();    
            this.Hide();
        }

        private void filmadi_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilmAfisiGöster();
            YenidenRenklendir();
            ComboDoluKoltuklar();

        }
        SinemaOtoTableAdapters.SatisBilgileriTableAdapter satis = new SinemaOtoTableAdapters.SatisBilgileriTableAdapter(); 
        private void biletsat_Click(object sender, EventArgs e)
        {
            if (koltukno.Text != "")
            {
                try
                {
                    satis.SatisYap(koltukno.Text, salonadi.Text, filmadi.Text, filmtarihi.Text, filmseansi.Text, musadı.Text, mussoyad.Text, ucret.Text, DateTime.Now.ToString());
                    YenidenRenklendir();
                    VeritabanıDoluKoltuklar();
                    ComboDoluKoltuklar();
                
                }
                catch (Exception)
                {

                    MessageBox.Show("hata oluştu", "hata");
                } 
            }
            else
            {
                MessageBox.Show("koltuk seçimi yapmadınız!!", "uyarı");
            }
        }

        private void FilmTarihiGetir()
        {
            filmtarihi.Text = "";
            filmseansi.Text = "";
            filmtarihi.Items.Clear();
            filmseansi.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from SeansBilgileri where FilmAdi = '" + filmadi.SelectedItem + "' and SalonAdi ='" + salonadi.SelectedItem + "'",baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                filmtarihi.Items.Add(read["Tarih"].ToString());
            }
            baglanti.Close();
        }
        private void salonadi_SelectedIndexChanged(object sender, EventArgs e)
        {
           FilmTarihiGetir();
        }

        private void FilmSeansıGetir()
        {
            baglanti.Open();
            filmseansi.Text = "";
            filmseansi.Items.Clear();
            SqlCommand komut = new SqlCommand("select * from SeansBilgileri where FilmAdi = '" + filmadi.SelectedItem + "' and SalonAdi ='" + salonadi.SelectedItem + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                filmseansi.Items.Add(read["Seans"].ToString());
            }
            baglanti.Close();
        }
        private void filmtarihi_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilmSeansıGetir();
        }

        private void filmseansi_SelectedIndexChanged(object sender, EventArgs e)
        {
            YenidenRenklendir();
            VeritabanıDoluKoltuklar();
            ComboDoluKoltuklar();
        }

        private void biletiptal_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                try
                {
                    satis.SatisIptal(filmadi.Text, salonadi.Text, filmtarihi.Text, filmseansi.Text, koltukno.Text);
                    YenidenRenklendir();
                    VeritabanıDoluKoltuklar();
                    ComboDoluKoltuklar();
                }
                catch (Exception hata)
                {

                    MessageBox.Show("hata oluştu!!!" + hata.Message , "uyarı");

                }
            }
            else
            {
                MessageBox.Show("koltuk seçimi yapmadınız", "uyarı");

            }
        }
    }
}
