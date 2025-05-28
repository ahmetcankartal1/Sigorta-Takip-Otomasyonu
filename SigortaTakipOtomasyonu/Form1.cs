using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SigortaTakipOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnmusteriislemleri_Click(object sender, EventArgs e)
        {
            FormMusteriIslemleri musteriForm = new FormMusteriIslemleri(); // Yeni formdan nesne oluştur
            musteriForm.Show(); // O formu aç
        }

        private void btnPoliceIslemleri_Click(object sender, EventArgs e)
        {
            FormPoliceIslemleri policeForm = new FormPoliceIslemleri();
            policeForm.Show();
        }

        private void btnHasarIslemleri_Click(object sender, EventArgs e)
        {
            FormHasarIslemleri hasarForm = new FormHasarIslemleri();
            hasarForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
