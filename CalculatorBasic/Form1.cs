namespace CalculatorBasic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            lblhasil.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            lblhasil.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Please Fill Angka 1 & Angka 2");
            }
            else
            {
                int a, b, c;
                a = int.Parse(textBox1.Text);
                b = int.Parse(textBox2.Text);
                c = a + b;
                lblhasil.Text = c.ToString();
            }         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Please Fill Angka 1 & Angka 2");
            }
            else
            {
                int a, b, c;
                a = int.Parse(textBox1.Text);
                b = int.Parse(textBox2.Text);
                c = a - b;
                lblhasil.Text = c.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Please Fill Angka 1 & Angka 2");
            }
            else
            {
                int a, b, c;
                a = int.Parse(textBox1.Text);
                b = int.Parse(textBox2.Text);
                c = a * b;
                lblhasil.Text = c.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Please Fill Angka 1 & Angka 2");
            }
            else
            {
                int a, b, c;
                a = int.Parse(textBox1.Text);
                b = int.Parse(textBox2.Text);
                c = a / b;
                lblhasil.Text = c.ToString();
            }
        }
    }
}