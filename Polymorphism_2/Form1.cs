using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polymorphism_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Serce s = new Serce();
            MessageBox.Show("Serçe sesi: " + s.Ses());

            Karga k = new Karga();
            MessageBox.Show("Karga sesi: " + k.Ses());
        }
    }
}
// Kuş adında class. İçindede ses adında bir method. Serçe ve karga türlerinin seslerini serçe için cik cik, karga için gak gak olarak gösteriniz.