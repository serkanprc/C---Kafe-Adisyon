namespace kafe_adisyon_uygulaması
{
    public partial class giris_sayfasi : Form
    {
        public giris_sayfasi()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buton8_MouseMove(object sender, MouseEventArgs e)
        {


        }

        private void buton1_MouseHover(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "1234")
            {
                this.Hide();
                admin_panel frm = new admin_panel();
                frm.ShowDialog();
            }
            else if (textBox1.Text == "")
            {
                MessageBox.Show("Lütfen Pin Giriniz!");
            }
            else
            {
                MessageBox.Show("Yanlış Pin!");
                textBox1.Text = "";
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
