namespace Wesley
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_valorC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_valorB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_valorMax = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_valorMin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_valorA = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_estEvolutiva = new System.Windows.Forms.Button();
            this.txt_qntBits = new System.Windows.Forms.TextBox();
            this.Bits = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_taxa = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_qntIndividuos = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_valorC);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_valorB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_valorMax);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_valorMin);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_valorA);
            this.groupBox1.Location = new System.Drawing.Point(32, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 396);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Problema";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(232, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "Encontrar o minimo da Equa;ao";
            // 
            // txt_valorC
            // 
            this.txt_valorC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valorC.Location = new System.Drawing.Point(187, 103);
            this.txt_valorC.Name = "txt_valorC";
            this.txt_valorC.Size = new System.Drawing.Size(40, 26);
            this.txt_valorC.TabIndex = 27;
            this.txt_valorC.Text = "6";
            this.txt_valorC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(158, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "X +";
            // 
            // txt_valorB
            // 
            this.txt_valorB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valorB.Location = new System.Drawing.Point(112, 103);
            this.txt_valorB.Name = "txt_valorB";
            this.txt_valorB.Size = new System.Drawing.Size(40, 26);
            this.txt_valorB.TabIndex = 25;
            this.txt_valorB.Text = "-5";
            this.txt_valorB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(233, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "= 0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Max";
            // 
            // txt_valorMax
            // 
            this.txt_valorMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valorMax.Location = new System.Drawing.Point(72, 302);
            this.txt_valorMax.Name = "txt_valorMax";
            this.txt_valorMax.Size = new System.Drawing.Size(99, 26);
            this.txt_valorMax.TabIndex = 19;
            this.txt_valorMax.Text = "6";
            this.txt_valorMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Min";
            // 
            // txt_valorMin
            // 
            this.txt_valorMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valorMin.Location = new System.Drawing.Point(72, 242);
            this.txt_valorMin.Name = "txt_valorMin";
            this.txt_valorMin.Size = new System.Drawing.Size(99, 26);
            this.txt_valorMin.TabIndex = 17;
            this.txt_valorMin.Text = "0";
            this.txt_valorMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "X^2 + ";
            // 
            // txt_valorA
            // 
            this.txt_valorA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valorA.Location = new System.Drawing.Point(30, 103);
            this.txt_valorA.Name = "txt_valorA";
            this.txt_valorA.Size = new System.Drawing.Size(40, 26);
            this.txt_valorA.TabIndex = 15;
            this.txt_valorA.Text = "1";
            this.txt_valorA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_estEvolutiva);
            this.groupBox2.Controls.Add(this.txt_qntBits);
            this.groupBox2.Controls.Add(this.Bits);
            this.groupBox2.Location = new System.Drawing.Point(342, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(326, 166);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados do Individuo";
            // 
            // btn_estEvolutiva
            // 
            this.btn_estEvolutiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_estEvolutiva.Location = new System.Drawing.Point(50, 96);
            this.btn_estEvolutiva.Name = "btn_estEvolutiva";
            this.btn_estEvolutiva.Size = new System.Drawing.Size(206, 33);
            this.btn_estEvolutiva.TabIndex = 2;
            this.btn_estEvolutiva.Text = "Estratégia Evolutiva";
            this.btn_estEvolutiva.UseVisualStyleBackColor = true;
            this.btn_estEvolutiva.Click += new System.EventHandler(this.btn_estEvolutiva_Click);
            // 
            // txt_qntBits
            // 
            this.txt_qntBits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_qntBits.Location = new System.Drawing.Point(131, 40);
            this.txt_qntBits.Name = "txt_qntBits";
            this.txt_qntBits.Size = new System.Drawing.Size(86, 26);
            this.txt_qntBits.TabIndex = 1;
            this.txt_qntBits.Text = "10";
            // 
            // Bits
            // 
            this.Bits.AutoSize = true;
            this.Bits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bits.Location = new System.Drawing.Point(32, 43);
            this.Bits.Name = "Bits";
            this.Bits.Size = new System.Drawing.Size(36, 20);
            this.Bits.TabIndex = 0;
            this.Bits.Text = "Bits";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txt_taxa);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.txt_qntIndividuos);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(342, 197);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(326, 180);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dados da População";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(282, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "%";
            // 
            // txt_taxa
            // 
            this.txt_taxa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_taxa.Location = new System.Drawing.Point(219, 74);
            this.txt_taxa.Name = "txt_taxa";
            this.txt_taxa.Size = new System.Drawing.Size(57, 26);
            this.txt_taxa.TabIndex = 4;
            this.txt_taxa.Text = " 10";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(197, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Taxa de Sucesso Mutacao";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(50, 119);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(206, 37);
            this.button2.TabIndex = 2;
            this.button2.Text = "Programação Evolutiva";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_qntIndividuos
            // 
            this.txt_qntIndividuos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_qntIndividuos.Location = new System.Drawing.Point(219, 35);
            this.txt_qntIndividuos.Name = "txt_qntIndividuos";
            this.txt_qntIndividuos.Size = new System.Drawing.Size(57, 26);
            this.txt_qntIndividuos.TabIndex = 1;
            this.txt_qntIndividuos.Text = " 100";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Quantidade de Indivíduos:";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(392, 383);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(206, 38);
            this.button3.TabIndex = 3;
            this.button3.Text = "Algoritmo Genético";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Metodos IA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_valorMax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_valorMin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_valorA;
        private System.Windows.Forms.TextBox txt_valorC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_valorB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_estEvolutiva;
        private System.Windows.Forms.TextBox txt_qntBits;
        private System.Windows.Forms.Label Bits;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_qntIndividuos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txt_taxa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

