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
            if (txt_aciklama.Text == "��k")
            {
                Application.Exit();
            }
            else if (txt_aciklama.Text == "d��me")
            {
                MessageBox.Show("Ahmedim Sana S�yl�yorum D��me D�n��me");
                txt_aciklama.Clear();
            }
        }

        private void txt_enter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                MessageBox.Show("Enter tu�una bas�ld�.");
            }
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Kayd�n�z silindi");
        }

        private void btn_mesaj_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("i�lem Tamamland�", "Bilgi");
            DialogResult sonuc;
            sonuc = MessageBox.Show("kayd� sil", "onay",MessageBoxButtons.YesNo);
            if(sonuc== DialogResult.Yes)
            {
                MessageBox.Show("Kay�t Ba�ar�yla Silindi");
            }
            else
            {
                MessageBox.Show("Kay�t Silinemedi");
            }
        }
    }
}