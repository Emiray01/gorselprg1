namespace hafta3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txt_aciklama_TextChanged(object sender, EventArgs e)
        {
            if (txt_aciklama.Text == "çýk")
            {
                Application.Exit();
            }
            else if (txt_aciklama.Text == "düþme")
            {
                MessageBox.Show("Ahmedim Sana Söylüyorum Düþme Dönüþme");
                txt_aciklama.Clear();
            }
        }

        private void txt_enter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                MessageBox.Show("Enter tuþuna basýldý.");
            }
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Kaydýnýz silindi");
        }

        private void btn_mesaj_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("iþlem Tamamlandý", "Bilgi");
            DialogResult sonuc;
            sonuc = MessageBox.Show("kaydý sil", "onay",MessageBoxButtons.YesNo);
            if(sonuc== DialogResult.Yes)
            {
                MessageBox.Show("Kayýt Baþarýyla Silindi");
            }
            else
            {
                MessageBox.Show("Kayýt Silinemedi");
            }
        }
    }
}