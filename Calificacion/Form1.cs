using System;
using System.Windows.Forms;

namespace Calificacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = 0;
            int.TryParse(textBox1.Text, out num);
            switch(num)
            {
                case int n when (n > 90 && n < 100):
                    label2.Text = ("Excelente");
                    break;
                case int n when (n > 80 && n < 90):
                    label2.Text = ("Bueno");
                    break;

                case int n when (n > 70 && n < 80):
                    label2.Text = ("Error");
                    break;
            }

        }
    }
}
