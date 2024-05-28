using System;
using System.Text;
using System.Windows.Forms;

namespace ResoluçãoProblemas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProblemaA_Click(object sender, EventArgs e)
        {
            string resultado = "";
            for (int i = 1; i < 40; i += 2)
            {
                resultado += i + " ";
            }
            textBoxResultado.Text = resultado;
        }

        private void btnProblemaB_Click(object sender, EventArgs e)
        {
            int soma = 0;
            for (int i = 1; i <= 100; i++)
            {
                soma += i;
            }
            textBoxResultado.Text = "Soma: " + soma;
        }

        private void btnProblemaC_Click(object sender, EventArgs e)
        {
            string resultado = "";
            for (int i = 1; i < 40; i++)
            {
                if (i % 4 == 0)
                {
                    resultado += i + " ";
                }
            }
            textBoxResultado.Text = resultado;
        }

        private void btnProblemaD_Click(object sender, EventArgs e)
        {
            var resultado = new StringBuilder();
            for (int i = 15; i <= 200; i++)
            {
                resultado.AppendLine($"Quadrado de {i}: {i * i}");
            }
            textBoxResultado.Text = resultado.ToString();
        }

        private void btnProblemaE_Click(object sender, EventArgs e)
        {
            int soma = 0;
            for (int i = 2; i <= 50; i += 2)
            {
                soma += i;
            }
            textBoxResultado.Text = "Soma dos pares: " + soma;
        }
    }
}
