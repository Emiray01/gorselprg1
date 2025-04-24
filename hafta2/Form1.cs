using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hafta2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_mesajver_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OOP kullanarak yaptığım ilk program");
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            lbl_veri.Text=txt_adsoyad.Text;
            MessageBox.Show("Veriniz Kaydedildi");
            txt_adsoyad.Clear();
        }
    }
}
