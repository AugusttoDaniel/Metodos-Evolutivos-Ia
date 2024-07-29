using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wesley
{
    public partial class Form2 : Form
    {
        private Populacao a;  
        private int qntBits;
        private double valorA;
        private double valorB;
        private double valorC;
        private double valorMin;
        private double valorMax;
        private int qntIndividuos;

        public Form2(int qntBits, double valorA, double valorB, double valorC, double valorMin, double valorMax, int qntIndividuos, double taxa)
        {
            InitializeComponent();
            this.qntBits = qntBits;
            this.valorA = valorA;
            this.valorB = valorB;
            this.valorC = valorC;
            this.valorMin = valorMin;
            this.valorMax = valorMax;
            this.qntIndividuos = qntIndividuos;
            a = new Populacao(qntIndividuos, taxa, qntBits, valorA, valorB, valorC, valorMin, valorMax);
            a.ImprimirESalvarPopulacao();
            AtualizarInterface();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txt_valorA.Text, out double repet))
            {
                MessageBox.Show("Entrada inválida. Por favor, insira um número válido.");
                return;
            }

            // Desabilita o botão para evitar múltiplos cliques
            button1.Enabled = false;

            // Opcionalmente, desabilite todo o formulário (exceto o botão)
            // this.Enabled = false;

            try
            {
                await Task.Run(() =>
                {
                    for (int i = 0; i < repet; i++)
                    {
                        a.Multacao();
                    }
                    a.ImprimirESalvarPopulacao();

                    // Use Invoke para atualizar a interface do usuário a partir da thread de fundo
                    this.Invoke(new Action(() =>
                    {
                        AtualizarInterface();
                    }));
                });
            }
            finally
            {
                // Reabilita o botão (ou o formulário) após a conclusão da operação
                button1.Enabled = true;
                txt_sitiuacao.Text = "Multação da População Completa!";
                // Opcionalmente, reabilite todo o formulário
                // this.Enabled = true;
            }
        }

        private void btn_estEvolutiva_Click(object sender, EventArgs e)
        {
            a.Multacao();
            txt_sitiuacao.Text = "Multação Completa!";
            AtualizarInterface();
        }
        
        private void AtualizarInterface()
        {
            // Atualiza a representação do cromossomo no label1
            StringBuilder chromosomeSb = new StringBuilder();
            foreach (var bit in a.melhorIndiduo.bit)
            {
                chromosomeSb.Append(bit + " ");
            }
            label1.Text = chromosomeSb.ToString();

            // Atualiza os valores fenotípicos, X e adaptabilidade nos labels correspondentes
            label2.Text = a.melhorIndiduo.fenotipo.ToString();
            label4.Text = a.melhorIndiduo.x.ToString();
            label8.Text = a.melhorIndiduo.adaptabilidade.ToString();

            if (this.InvokeRequired)
            {
                this.Invoke(new Action(AtualizarInterface));
            }
            /*else
            {
                txt_sitiuacao.Text = "Atualização completa!";
            }*/
        }

        
    }
}
