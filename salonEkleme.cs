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
    public partial class salonEkleme : Form
    {
        public salonEkleme()
        {
            InitializeComponent();
        }

        private void salonEkleme_FormClosing(object sender, FormClosingEventArgs e)
        {
            anaSayfa anaSayfa = new anaSayfa();
            anaSayfa.ShowDialog();
            this.Hide();
        }

        SinemaOtoTableAdapters.SalonBilgileriTableAdapter salon = new SinemaOtoTableAdapters.SalonBilgileriTableAdapter();
        private void button1_Click(object sender, EventArgs e)
        {

            try  
            {
                salon.SalonEkleme(textBox1.Text);
                MessageBox.Show("Salon Eklendi", "Kayıt");
            }
            catch (Exception)
            {
                MessageBox.Show("aynı salon daha önce eklendi!!", "uyarı!");
            }
            textBox1.Text = "";
        }
    }
}
