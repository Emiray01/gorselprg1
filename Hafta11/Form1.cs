using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hafta11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_bagverigetir_Click(object sender, EventArgs e)
        {
            baglantiliverigetir();
        }
        OleDbConnection baglanti = new OleDbConnection();
        OleDbCommand komut;
        OleDbDataReader okuyucu;
        private void Form1_Load(object sender, EventArgs e)
        {
            baglanti.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;data source=adresler.mdb";
        }
        void baglantiliverigetir()
        {
            baglanti.Open();
            komut = new OleDbCommand();
            komut.Connection = baglanti;
            komut.CommandText = "SELECT * FROM tblnüfus";  
            okuyucu=komut.ExecuteReader();
            lstveriler.Items.Clear();
            while(okuyucu.Read())
            {
                lstveriler.Items.Add(okuyucu["Ad"].ToString() + " " + okuyucu["Soyad"].ToString());
            }
            okuyucu.Close();
        }


    }
}
