namespace Areas
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

        private void button1_Click(object sender, EventArgs e)
        {
            double lado = 0 ;
            Double.TryParse(textBox1.Text, out lado);
            double area = lado * lado;
            label3.Text = area.ToString("0.00"); 



        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double altura = 0, Base=0;
            Double.TryParse(textBox2.Text, out altura);
            Double.TryParse(textBox3.Text, out Base);
            double area = Base * altura;
            label7.Text = area.ToString("0.00");
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double f = 0;
            Double.TryParse(textBox4.Text, out f);
            double c =  (f - 32)*(5/9) ;
            label8.Text = c.ToString("0.00");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double c = 0;
            Double.TryParse(textBox5.Text, out c);
            double f = (c * (9 / 5) + 32);
            label11.Text = f.ToString("0.00");

        }
    }
}