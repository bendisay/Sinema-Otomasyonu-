using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaOtomasyonu
{
    public partial class filmEkleme : Form
    {
        public filmEkleme()
        {
            InitializeComponent();
        }
        SinemaOtoTableAdapters.Film_BilgileriTableAdapter film = new SinemaOtoTableAdapters.Film_BilgileriTableAdapter();
        private void filmekle_Click(object sender, EventArgs e)
        {
            try
            {
                film.FilmEkleme(filmadi.Text, yonetmen.Text, filmturu.Text, sure.Text, tarih.Text, yapimyili.Text, pictureBox1.ImageLocation);
                MessageBox.Show("film eklendi.");
            }
            catch (Exception)
            {
                MessageBox.Show("bu film daha önce eklendi!!", "uyarı");
            }

            foreach (Control item in Controls) if (item is TextBox) 
                    item.Text = "";
                    filmturu.Text = "";

        }
        private void afisec_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void filmEkleme_FormClosing(object sender, FormClosingEventArgs e)
        {
            anaSayfa anaSayfa = new anaSayfa();
            anaSayfa.ShowDialog();
            this.Hide();
        }
    }
}
