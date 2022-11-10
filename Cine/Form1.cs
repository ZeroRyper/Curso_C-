namespace Cine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string respuesta=textBox1.Text.ToUpper();

            if (respuesta == "SI") 
                MessageBox.Show("Estas en el Cine ");

            if (respuesta == "NO") 
                MessageBox.Show("No estas en el Cine ");
        }
    }
}