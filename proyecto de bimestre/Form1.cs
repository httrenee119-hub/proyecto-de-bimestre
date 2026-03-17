using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_de_bimestre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show(" error, Ingrese un numero en el primer campo ");
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show(" error, Ingrese un numero en el segundo campo ");
               
            }
            //checar si los datos ingresados sean numero 
            double num1, num2;
           
            if (!double.TryParse(textBox1.Text, out num1))
            {
                MessageBox.Show(" error, Ingrese un numero valido en el primer campo ");
                return;
            }
            if (!double.TryParse(textBox2.Text, out num2))
            {
                MessageBox.Show(" error, Ingrese un numero valido en el segundo campo ");
                return;
            }

            double resultado = num1 + num2;
            label3.Text = resultado.ToString();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            

        }
    }
}
