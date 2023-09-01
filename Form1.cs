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
            int Sayý1;
            int Sayý2;
            int toplam;

            Sayý1 = Convert.ToInt32(textBox1.Text);
            Sayý2 = Convert.ToInt32(textBox2.Text);

            toplam = Sayý1 + Sayý2;

            label4.Text = toplam.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a, b, sonuç;

            a = Convert.ToInt32(textBox3.Text);
            b = Convert.ToInt32(textBox4.Text);

            sonuç = a * b;
            label7.Text=sonuç.ToString();
        }
    }
}