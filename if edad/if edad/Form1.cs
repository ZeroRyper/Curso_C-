using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace if_edad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int mes=0,ano=0,dia=0;
            int.TryParse(comboBox1.Text,out dia);
            int.TryParse(comboBox2.Text,out mes);
            int.TryParse(comboBox3.Text, out ano);

            if (mes == 1) 
            label4.Text=(+dia+" Dia de Enero del "+ano);

            else if (mes == 2) 
            label4.Text = (+dia + " Dia de Febrero del " + ano);

            else if (mes == 3) 
            label4.Text = (+dia + " Dia de Marzo del " + ano);

            else if (mes == 4) 
            label4.Text = (+dia + " Dia de Abril del " + ano);


            else if (mes == 5) 
            label4.Text = (+dia + " Dia de Mayo del " + ano);

            else if (mes == 6) 
            label4.Text = (+dia + " Dia de Junio del " + ano);

            else if (mes == 7) 
            label4.Text = (+dia + " Dia de Julio del " + ano);

            else if (mes == 8) 
            label4.Text = (+dia + " Dia de Agosto del " + ano);

            else if (mes == 9) 
            label4.Text = (+dia + " Dia de Septiembre del " + ano);

            else if (mes == 10) 
            label4.Text = (+dia + " Dia de Octubre del " + ano);

            else if (mes == 11) 
            label4.Text = (+dia + " Dia de Noviembre del " + ano);

            else if (mes == 12) 
            label4.Text = (+dia + " Dia de Diciembre del " + ano);



        }
    }
}
