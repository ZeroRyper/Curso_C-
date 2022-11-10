namespace Estructuras_Selectivas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int edad = 0;
            int.TryParse(textBox1.Text, out edad);
            if (edad > 17)
                MessageBox.Show("Usted es mayor de edad");
            //La primera sentecia de un if entra por eso no ponemos corchetes.
            else if (edad < 18)
                MessageBox.Show("Usted es menor de edad");

        }
    }
}