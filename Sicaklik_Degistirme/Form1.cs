namespace Sicaklik_Degistirme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double f = Convert.ToDouble(textBox1.Text);
            double c = (f - 32) / 1.8;
            textBox2.Text = c.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double c= Convert.ToDouble(textBox3.Text);
            double f = c * 1.8 + 32;
            textBox4.Text = f.ToString();
        }
    }
}
