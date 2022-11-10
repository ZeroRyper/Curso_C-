namespace Bicicletas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double costo = 0;
            int bicis = 0;
            double.TryParse(textBox1.Text, out costo);
            int.TryParse(textBox2.Text, out bicis);
            double costoT = costo * bicis;
            if (bicis > 7)
                MessageBox.Show("Se aplica descuento " + (costoT - (costoT * 0.25)));
            else
                MessageBox.Show("No se aplica descuento " + costoT);
        }
    }
}