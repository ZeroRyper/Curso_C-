namespace Numero_P_N
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num = 0;
            double.TryParse(textBox1.Text, out num);

            if (num > 0)
                label2.Text = ("Es Positivo");

            else if (num < 0)
                label2.Text = ("Es Negativo");

            else
                label2.Text = ("Es 0");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num1=0,num2=0;
            int.TryParse(textBox2.Text, out num1);
            int.TryParse(textBox3.Text, out num2);

            if (num1 > num2)
                label5.Text = (num1 + " Es mayor que el " + num2);
            else if (num1 < num2)
                label5.Text = (num1 + " Es menor que el " + num2);
            else
                label5.Text = (num1 + " Es igual que el " + num2);


        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num1=0,num2=0,num3=0;
            int.TryParse(textBox5.Text, out num1);
            int.TryParse(textBox4.Text, out num2);
            int.TryParse(textBox6.Text, out num3);

            if (num1 > num2 && num1 > num3)
                label9.Text = (num1 + " Es mayor que " + num2 + " y " + num3);

            else if (num2 > num1 && num2 > num3)
                label9.Text = (num2 + " Es mayor que numero " + num1 + " y " + num3);
            else if (num3 > num2 && num3 > num1)
                label9.Text = (num3 + " Es mayor que numero " + num1 + " y " + num2);
            else
                label9.Text = (num2 + " Son iguales el " + num1 + " y " + num3);



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}