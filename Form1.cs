using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraIMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CALCULAR_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Pega o que está escrito nas caixas (texto)
                string textoPeso = textBox3.Text;
                string textoAltura = textBox1.Text;

                // 2. Transforma o texto em números (double)
                double p = double.Parse(textoPeso);
                double a = double.Parse(textoAltura);

                // 3. Faz a conta do IMC
                double imc = p / (a * a);

                // 4. Mostra o resultado na tela (virando texto de novo)
                textBox2.Text = imc.ToString("F2");

                string classificacao = "";

                // Classificação do IMC
                if (imc < 18.5)
                {
                    classificacao = "Peso Baixo";
                }
                else if (imc >= 18.5 && imc <= 24.9)
                {
                    classificacao = "Peso Normal";
                }
                else if (imc >= 25 && imc <= 29.9)
                {
                    classificacao = "Sobrepeso";
                }
                else if (imc >= 30 && imc <= 34.9)
                {
                    classificacao = "Obesidade Grau 1";
                }
                else if (imc >= 35 && imc <= 39.9)
                {
                    classificacao = "Obesidade Grau 2";
                }
                else
                {
                    classificacao = "Obesidade Grau 3";
                }

                // Mostrar resultado + classificação
                textBox2.Text = imc.ToString("F2") + " - " + classificacao;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro técnico: " + ex.Message);
            }

} 
        private void LIMPAR_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

            textBox3.Focus();
        }

        private void PESO_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
