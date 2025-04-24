using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deneyimsi_hesapmakine_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            txt_islem.Clear();
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            txt_islem.Text += "1";
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            txt_islem.Text += "2";
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            txt_islem.Text += "3";
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            txt_islem.Text += "4";
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            txt_islem.Text += "5";
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            txt_islem.Text += "6";
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            txt_islem.Text += "7";
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            txt_islem.Text += "8";
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            txt_islem.Text += "9";
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            txt_islem.Text += "0";
        }

        private void btn_topla_Click(object sender, EventArgs e)
        {
            txt_islem.Text += "+";
        }

        private void btn_sonuc_Click(object sender, EventArgs e)
        {
            string[] numbers = txt_islem.Text.Split('+');
            int result = 0;
            foreach (string number in numbers) 
            {
                if (int.TryParse(number, out int parsedNumber))
                {
                    result += parsedNumber;
                    txt_islem.Text = result.ToString();
                }
                else
                {
                    MessageBox.Show("Lütfen Geçerli Bir Veri Giriniz!");
                    return;
                }
            }
        }
    }
}