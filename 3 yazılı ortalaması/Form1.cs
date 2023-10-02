using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_yazılı_ortalaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
           
            int yazili1 = Convert.ToInt32(txtYazili1.Text);
            int yazili2 = Convert.ToInt32(txtYazili2.Text);
            int yazili3 = Convert.ToInt32(txtYazili3.Text);

            int sonuc = (yazili1 + yazili2 + yazili3) / 3 ;

            lblOrtalama.Text = sonuc.ToString();

        }
    }
}
