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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void btn_estEvolutiva_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_qntBits.Text) ||
           string.IsNullOrEmpty(txt_valorA.Text) ||
           string.IsNullOrEmpty(txt_valorB.Text) ||
           string.IsNullOrEmpty(txt_valorC.Text) ||
           string.IsNullOrEmpty(txt_valorMin.Text) || 
           string.IsNullOrEmpty(txt_valorMax.Text)
           )
            {
                MessageBox.Show("Os Campos Obrigatórios estão vazios!!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int qntBits = int.Parse(txt_qntBits.Text);
                double valorA = double.Parse(txt_valorA.Text);
                double valorB = double.Parse(txt_valorB.Text);
                double valorC = double.Parse(txt_valorC.Text);
                double valorMin = double.Parse(txt_valorMin.Text);
                double valorMax = double.Parse(txt_valorMax.Text);
                Form3 frm = new Form3(qntBits, valorA, valorB, valorC, valorMin, valorMax);
                frm.Show();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (
                string.IsNullOrEmpty(txt_qntBits.Text) ||
           string.IsNullOrEmpty(txt_valorA.Text) ||
           string.IsNullOrEmpty(txt_valorB.Text) ||
           string.IsNullOrEmpty(txt_valorC.Text) ||
           string.IsNullOrEmpty(txt_valorMin.Text) ||
           string.IsNullOrEmpty(txt_qntIndividuos.Text) ||
           string.IsNullOrEmpty(txt_valorMax.Text)) 
            {
                MessageBox.Show("Os Campos Obrigatórios estão vazios!!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int qntBits = int.Parse(txt_qntBits.Text);
                double valorA = double.Parse(txt_valorA.Text);
                double valorB = double.Parse(txt_valorB.Text);
                double valorC = double.Parse(txt_valorC.Text);
                double valorMin = double.Parse(txt_valorMin.Text);
                double valorMax = double.Parse(txt_valorMax.Text);
                int qntIndividuos = int.Parse(txt_qntIndividuos.Text);
                double taxa = double.Parse(txt_taxa.Text);
                Form2 frm = new Form2(qntBits, valorA, valorB, valorC, valorMin, valorMax, qntIndividuos, taxa);
                frm.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int qntBits = int.Parse(txt_qntBits.Text);
            double valorA = double.Parse(txt_valorA.Text);
            double valorB = double.Parse(txt_valorB.Text);
            double valorC = double.Parse(txt_valorC.Text);
            double valorMin = double.Parse(txt_valorMin.Text);
            double valorMax = double.Parse(txt_valorMax.Text);
            int qntIndividuos = int.Parse(txt_qntIndividuos.Text);
            double taxa = double.Parse(txt_taxa.Text);
            Form4 frm = new Form4(qntBits, valorA, valorB, valorC, valorMin, valorMax, qntIndividuos, taxa);
            frm.Visible = true;
        }

        
    }
}
