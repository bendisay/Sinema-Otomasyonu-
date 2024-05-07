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
    public partial class satisListele : Form
    {
        public satisListele()
        {
            InitializeComponent();
        }

        private void satislar_FormClosing(object sender, FormClosingEventArgs e)
        {
            anaSayfa anaSayfa = new anaSayfa();
            anaSayfa.ShowDialog();
            this.Hide();
        }
    }
}
