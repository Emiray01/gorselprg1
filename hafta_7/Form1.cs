using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hafta_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            lstmeyveler.Items.Add(txtmeyve.Text);
        }

        private void btnaktar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstmeyveler.CheckedItems.Count; i++)
            {
               lstsecilenler.Items.Add(lstmeyveler.CheckedItems[i]);
            }
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstmeyveler.Items.Count; i++)
            {
                lstmeyveler.SetItemChecked(i, false);
            }
        }
    }
}
