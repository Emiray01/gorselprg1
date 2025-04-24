using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hafta_4
{
    public partial class frm_nüfus : Form
    {
        public frm_nüfus()
        {
            InitializeComponent();
        }

        private void frm_nüfus_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Nüfus Formu Kapatılıyor");
        }

        private void frm_nüfus_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Nüfus Formu Kapatıldı");
        }

        private void frm_nüfus_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Nüfus Formu Yüklendi");
        }
    }
}
