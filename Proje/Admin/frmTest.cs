using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje.Admin
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }

        private void btnkare_Click(object sender, EventArgs e)
        {
            int sayi, sonuc;
            sayi =Convert.ToInt32 (textBox1.Text);
            sonuc = sayi * sayi;
            label1.Text = sonuc.ToString();
        }

        private void btntekmiciftmi_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox1.Text);
            if(sayi % 2 == 0)
            {
                label2.Text = "Cift";
            }
            else
            {
                label2.Text = "Tek";
            }
        }

        private void btnbasamak_Click(object sender, EventArgs e)
        {
            //456
            int sayi, birler, onlar, yuzler, toplam;
            sayi = Convert.ToInt32(TextBox1.text);
            birler = sayi % 10;
            yuzler = sayi / 100;
            onlar = sayi / 10 % 10;
            toplam = birler + onlar + yuzler
            label1.Text = toplam.ToString();
        }

        private void btnbakteri_Click(object sender, EventArgs e)
        {
            
        }
    }
}
