using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Wesley
{
    public partial class Form3 : Form
    {
        private Individuo a;
        private int qntBits;
        private double valorA;
        private double valorB;
        private double valorC;
        private double valorMin;
        private double valorMax;

        public Form3(int qntBits, double valorA, double valorB, double valorC, double valorMin, double valorMax)
        {
            InitializeComponent();
            this.qntBits = qntBits;
            this.valorA = valorA;
            this.valorB = valorB;
            this.valorC = valorC;
            this.valorMin = valorMin;
            this.valorMax = valorMax;
            a = new Individuo(qntBits, valorA, valorB, valorC, valorMin, valorMax);
            UpdateDados();
        }


        private void btn_estEvolutiva_Click(object sender, EventArgs e)
        {
            Individuo mutated = new Individuo(qntBits, valorA, valorB, valorC, valorMin, valorMax);
            mutated.Copia(a); 
              
            mutated.Mutar(); 
            if (mutated.adaptabilidade < a.adaptabilidade)
            {
                a.Copia(mutated);
                label1.Text = "Sucesso na Mutação";
            }
            else
            {
                StringBuilder chromosomeSb = new StringBuilder();
                label1.Text = "Mutação sem sucesso";
            }
            

            UpdateDados();

        }

        
        public  void UpdateDados()
        {
            StringBuilder chromosomeSb = new StringBuilder();
            foreach (var b in a.bit)
            {
                chromosomeSb.Append(b + " ");
            }
            lb_cronossomo.Text = chromosomeSb.ToString();  // Assign the chromosome representation to the label

            // Set the decimal, X value, and fitness to their respective labels
            lb_decimal.Text = a.fenotipo.ToString();
            lb_valorX.Text = a.x.ToString();
            lb_fit.Text = a.adaptabilidade.ToString();
        }
    }
}
