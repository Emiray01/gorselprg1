using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace görselprog_deney1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int sayac = 0;
        private void btn_girisEK_Click(object sender, EventArgs e)
        {
            
            string Kadi = "Aymes", Ksifre = "12345";
            if (txt_KadiEK.Text == Kadi && txt_SifreEK.Text == Ksifre)
            {
                MessageBox.Show("Sisteme Bağlandınız");
                txt_KadiEK.Clear();
                txt_SifreEK.Clear();
            }
            else
            {
                sayac++;
                MessageBox.Show("Kullanıcı Adı Yada Şifre Yanlış"); 
                txt_KadiEK.Clear();
                txt_SifreEK.Clear();
                MessageBox.Show(Convert.ToString(sayac));
            }
            if (sayac >= 3)
            {
                btn_girisEK.Enabled = false;
            }
        }
    }
}
