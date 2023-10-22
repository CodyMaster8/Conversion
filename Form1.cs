namespace Conversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double C;
            double F;

            F = double.Parse(this.textBox1.Text);
            C = 5.0 / 9.0 * (F - 32);
            this.textBox2.Text = C.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            float cent = float.Parse(this.textBox3.Text);
            float fahr = (cent * 9 / 5) + 32;
            this.textBox4.Text = fahr.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            textBox4.Clear();
        }
    }
}