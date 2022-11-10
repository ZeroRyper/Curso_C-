using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa_Presupuesto_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1=0,num2=0,num3=0,num4=0;
            int.TryParse(textBox1.Text, out num1);
            int.TryParse(textBox2.Text, out num2);
            int.TryParse(textBox3.Text, out num3);
            int.TryParse(textBox4.Text, out num4);

            if (num1 > num2 && num1 > num3 && num1 > num4)
                label5.Text = ("El numero mayor es " + num1);
            else if (num2 > num1 && num2 > num3 && num2 > num4)
                label5.Text = ("El numero mayor es " + num2);
            else if (num3 > num1 && num3 > num2 && num3 > num4)
                label5.Text = ("El numero mayor es " + num3);
            else if (num4 > num1 && num4 > num2 && num4 > num3)
                label5.Text = ("El numero mayor es " + num4);
            else
                label5.Text = ("Todos los numeros son iguales");


        }
    }
}
