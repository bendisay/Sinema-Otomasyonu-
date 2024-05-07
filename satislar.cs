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
    public partial class satislar : Form
    {
        public satislar()
        {
            InitializeComponent();
        }

        SinemaOtoTableAdapters.SatisBilgileriTableAdapter satisListesi = new SinemaOtoTableAdapters.SatisBilgileriTableAdapter();
        private void satislar_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = satisListesi.SatisBilgileri2();
            //ToplamUcretHesapla();
        }

        /*
        private void ToplamUcretHesapla()
        {
            int ucretToplamı = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                ucretToplamı += Convert.ToInt32(dataGridView1.Rows[i].Cells["ucret"].Value);

            }
            label1.Text = "Toplam Satış = " + ucretToplamı + "TL";
        }
        */
        private void listele_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = satisListesi.SatisBilgileri2();
            //ToplamUcretHesapla();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = satisListesi.TariheGöreListele2(dateTimePicker1.Text);
            //ToplamUcretHesapla();

        }

        private void satislar_FormClosing(object sender, FormClosingEventArgs e)
        {
            anaSayfa anasayfa = new anaSayfa();
            anasayfa.ShowDialog();
            this.Hide();
        }
    }
}
