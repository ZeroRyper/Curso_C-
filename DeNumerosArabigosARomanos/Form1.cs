using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeNumerosArabigosARomanos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num=0;
            int.TryParse(textBox1.Text, out num);
            int c = 0;
            c = num / 100;
            int resta = 0;
            int d = 0;
            resta = num % 100;
            d = resta / 10;
            int u=resta% 10;
            string rom = "";
         
            switch(c)
            {
                case 5:
                    rom = (rom+"D");
                    break;
 
            }
            switch (d)
            {
                case 8:
                    rom = (rom + "LXXX");
                    break;

            }
            switch (u)
            {
                case 8:
                    rom = (rom + "IX");
                    break;

            }
            label2.Text = rom;
        }
    }
}
