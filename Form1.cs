using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadoraVB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double valor1 = 0, valor2 = 0, resultado = 0;
        string operador = "";

        private void textBox1_TextChanged(object sender, EventArgs e) //display resultado
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button11_Click(object sender, EventArgs e) // botão de resultado
        {
            valor2 = double.Parse(textBox1.Text);
            switch (operador)
            {
                case "+":
                    resultado = valor1 + valor2;
                    break;
                case "-":
                    resultado = valor1 - valor2;
                    break;
                case "/":
                    resultado = valor1 / valor2;
                    break;
                case "*":
                    resultado = valor1 * valor2;
                    break;
            }
            textBox1.Text = resultado.ToString();
        }

        private void button12_Click(object sender, EventArgs e) // botão de limpar 
        {
            textBox1.Clear();
            valor1 = valor2 = resultado = 0;
            operador = "";
        }

        private void button13_Click(object sender, EventArgs e) // botão de soma
        {
            valor1 = double.Parse(textBox1.Text);
            operador = "+";
            textBox1.Clear();
        }

        private void button14_Click(object sender, EventArgs e) //botão de subtração
        {
            valor1 = double.Parse(textBox1.Text);
            operador = "-";
            textBox1.Clear();
        }

        private void button15_Click(object sender, EventArgs e) //botão de divisão
        {
            valor1 = double.Parse(textBox1.Text);
            operador = "/";
            textBox1.Clear();
        }

        private void button16_Click(object sender, EventArgs e) //botão de multiplicação
        {
            valor1 = double.Parse(textBox1.Text);
            operador = "*";
            textBox1.Clear();
        }
    }
}
