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
    public partial class frm_anamenu : Form
    {
        public frm_anamenu()
        {
            InitializeComponent();
        }

        private void btn_formgec_Click(object sender, EventArgs e)
        {
            frm_nüfus formnufus = new frm_nüfus();
            formnufus.ShowDialog();
        }

        private void btn_drsformgec_Click(object sender, EventArgs e)
        {
            frm_dersler formdersler = new frm_dersler();
            formdersler.ShowDialog();
        }

        private void nüfusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_nüfus frmnüfus = new frm_nüfus();
            frmnüfus.ShowDialog();
        }

        private void btngonder_Click(object sender, EventArgs e)
        {
            string secilenler = "Seçilen Diller:";
            if (java_chb.Checked == true)
            {
                secilenler += "Java\n";
            }
            if (c_chb.Checked == true)
            {
                secilenler += ",C++\n";
            }
            if (csh_cbh.Checked == true)
            {
                secilenler += ",C#\n";
            }
            MessageBox.Show(secilenler);
        }

        private void btngonder2_Click(object sender, EventArgs e)
        {
            if (rdbbay.Checked == true) 
            {
                MessageBox.Show("Bay'ı seçtiniz");
            }
            if(rdbbayan.Checked == true)
            {
                MessageBox.Show("Bayan'ı seçtiniz");
            }
        }
    }
}
