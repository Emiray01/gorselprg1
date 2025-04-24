using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hafta_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmb_iller.Items.Clear();
            cmb_iller.Items.Add("Ankara");
            cmb_iller.Items.Add("İstanbul");
            cmb_iller.Items.Add("İzmir");
            cmb_iller.Items.Add("Adana");
            cmb_iller.Items.Add("Antalya");
            cmb_iller.Items.Add("Bursa");
            cmb_iller.Items.Add("Eskişehir");
            cmb_iller.Items.Add("Konya");
            cmb_iller.Items.Add("Samsun");

        }

        private void btn_renk_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Red;
        }

        private void btn_pasif_Click(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            panel1.Visible = false;
        }

        private void btn_aktif_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            panel1.Visible = true;
        }

        private void btn_veriekle_Click(object sender, EventArgs e)
        {
            string[] dizi = { "Denizli", "Kayseri", "Uşak", "siirt", "Kahramanmaraş", "Adana" };    
            lb_sehirler.Items.Clear();
            lb_sehirler.Items.AddRange(dizi);
            /* try
             {
                 MessageBox.Show(dizi[6]);
             }
             catch (Exception)
             {
                 MessageBox.Show("Dizide Olayan Değeri İstiyorsunuz");
             }*/
        }

        private void btn_sehirekle_Click(object sender, EventArgs e)
        {
            lb_sehirler.Items.Add(txt_sehir.Text);
        }

        private void bnt_sehirsil_Click(object sender, EventArgs e)
        {
            lb_sehirler.Items.Remove(lb_sehirler.SelectedItem);
        }
    }
}