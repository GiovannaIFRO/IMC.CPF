using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1.IMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lb_resultado.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = tx_nome.Text;
            string cpf = mask_cpf.Text;
            double altura = Convert.ToDouble(nm_altura.Text);
            double peso = Convert.ToDouble(nm_peso.Text);
            string sexo = cb_sexo.Text;
            int idade = Convert.ToInt32(nm_idade.Text);
            Pessoa p = new Pessoa(nome, cpf, altura, peso, sexo, idade);
            (double a , string b, string c) = p.CalcularIMC();
            lb_resultado.Text = $"Seu IMC é {a.ToString("00.00")}, sua classificação é {b} e o seu grau é {c}";
        }

        private void nm_peso_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nm_idade_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lb_resultado_Click(object sender, EventArgs e)
        {

        }
    }
}
