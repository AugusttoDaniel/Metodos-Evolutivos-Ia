using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wesley
{
    public partial class Form4 : Form
    {
        private Populacao a;
        private int qntBits;
        private double valorA;
        private double valorB;
        private double valorC;
        private double valorMin;
        private double valorMax;
        private int qntIndividuos;
        private double taxaRecombinacao;
        private double taxaMutacao;
        private int numIteracao;
        private static Random random = new Random();


        public Form4(int qntBits, double valorA, double valorB, double valorC, double valorMin, double valorMax, int qntIndividuos, double taxa)
        {
            InitializeComponent();
            this.qntBits = qntBits;
            this.valorA = valorA;
            this.valorB = valorB;
            this.valorC = valorC;
            this.valorMin = valorMin;
            this.valorMax = valorMax;
            this.qntIndividuos = qntIndividuos;
            this.taxaMutacao = taxa;

            a = new Populacao(qntIndividuos, taxa, qntBits, valorA, valorB, valorC, valorMin, valorMax);
            a.AtualizarMelhorIndividuo();

            Console.WriteLine("Melhor Individuo Inicial");
            Console.WriteLine("-------------");
            Console.WriteLine("Melhor Individuo");
            a.melhorIndiduo.Imprimir();
            Console.WriteLine("Melhor População após a combinação:");
            a.ImprimirESalvarPopulacao();
            Console.WriteLine("-------------");

            UpdateUIWithBestIndividual(txt_cronossomo1, txt_decimal1, txt_x1, txt_fit1);
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // If no operation is needed, consider removing this method.
        }

        private async void btn_iniciar_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txt_taxaRec.Text, out double taxaRecombinacao))
            {
                MessageBox.Show("Entrada inválida para a Taxa de Recombinação.");
                return;
            }
            if (!int.TryParse(txt_numInter.Text, out int numIteracao))
            {
                MessageBox.Show("Entrada inválida para o Número de Iterações.");
                return;
            }

            this.taxaRecombinacao = taxaRecombinacao / 100;
            this.numIteracao = numIteracao;

            btn_iniciar.Enabled = false;

            try
            {
                await Task.Run(() =>
                {
                    try
                    {
                        for (int i = 0; i < this.numIteracao; i++)
                        {
                            Individuo parent1 = a.SelecaoPorRoleta();
                            Individuo parent2 = a.SelecaoPorRoleta();

                            while (parent1 == parent2)
                            {
                                parent2 = a.SelecaoPorRoleta();
                            }

                            if (parent1 != null && parent2 != null && random.NextDouble() < this.taxaRecombinacao)
                            {
                                List<Individuo> filhos = a.RecombinarDoisPontos(parent1, parent2);
                                a.p.AddRange(filhos); // Adicionar filhos na população
                            }
                        }

                        a.AtualizarMelhorIndividuo();

                        Console.WriteLine("Melhor Individuo após Recombinação");
                        Console.WriteLine("-------------");
                        Console.WriteLine("Melhor Individuo");
                        a.melhorIndiduo.Imprimir();
                        Console.WriteLine("Melhor População após a combinação:");
                        a.ImprimirESalvarPopulacao();
                        Console.WriteLine("-------------");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Erro durante a execução do processo: " + ex.Message);
                    }
                });

                this.Invoke(new Action(() =>
                {
                    UpdateUIWithBestIndividual(txt_cronossomo2, txt_decimal2, txt_x2, txt_fit2);
                    MessageBox.Show("Processo concluído com sucesso.");
                }));
            }
            finally
            {
                btn_iniciar.Enabled = true;
            }
        }

        private void UpdateUIWithBestIndividual(Label txtCronossomo, Label txtDecimal, Label txtX, Label txtFit)
        {
            StringBuilder chromosomeSb = new StringBuilder();
            foreach (var bit in a.melhorIndiduo.bit)
            {
                chromosomeSb.Append(bit + " ");
            }
            txtCronossomo.Text = chromosomeSb.ToString();
            txtDecimal.Text = a.melhorIndiduo.fenotipo.ToString();
            txtX.Text = a.melhorIndiduo.x.ToString();
            txtFit.Text = a.melhorIndiduo.adaptabilidade.ToString();
        }


    }
}
