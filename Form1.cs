namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Say�1;
            int Say�2;
            int toplam;

            Say�1 = Convert.ToInt32(textBox1.Text);
            Say�2 = Convert.ToInt32(textBox2.Text);

            toplam = Say�1 + Say�2;

            label4.Text = toplam.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a, b, sonu�;

            a = Convert.ToInt32(textBox3.Text);
            b = Convert.ToInt32(textBox4.Text);

            sonu� = a * b;
            label7.Text=sonu�.ToString();
        }
    }
}