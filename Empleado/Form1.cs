namespace Empleado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string nombre = textBox1.Text;
            double sueldo = 0;
            int edad = 0;
            int.TryParse(textBox2.Text, out edad);
            double.TryParse(textBox3.Text, out sueldo);

            if (edad >= 70)
                MessageBox.Show("Si tienen bono por edad: "+nombre + " Edad: " + edad + " Bono: " + (sueldo * 20)/100);
            else
                MessageBox.Show(nombre + " No tiene bono por edad ");

        }
    }
}