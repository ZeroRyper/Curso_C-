namespace Promedio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double calf1=0,calf2=0,calf3 = 0;
            double.TryParse(textBox1.Text, out calf1);
            double.TryParse(textBox2.Text, out calf2);
            double.TryParse(textBox3.Text, out calf3);
            double prom = (calf1 + calf2 + calf3) / 3;
            label4.Text = prom.ToString();


        }
    }
}