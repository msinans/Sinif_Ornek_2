using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinif_Ornek_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Animal cat = new Animal();
            cat.tur = "Van";
            cat.renk = "Beyaz";
            cat.fiyat = 10000;

            label1.Text = cat.tur;
            label2.Text = cat.renk;
            label3.Text = cat.fiyat.ToString();

            pictureBox1.BackColor = Color.DarkMagenta;

        }
    }
}
