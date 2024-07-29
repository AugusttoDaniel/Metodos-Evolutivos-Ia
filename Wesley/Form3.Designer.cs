namespace Wesley
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_fit = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lb_valorX = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_decimal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_cronossomo = new System.Windows.Forms.Label();
            this.btn_estEvolutiva = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_fit
            // 
            this.lb_fit.AutoSize = true;
            this.lb_fit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_fit.Location = new System.Drawing.Point(144, 188);
            this.lb_fit.Name = "lb_fit";
            this.lb_fit.Size = new System.Drawing.Size(232, 20);
            this.lb_fit.TabIndex = 52;
            this.lb_fit.Text = "Encontrar o minimo da Equa;ao";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(69, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 20);
            this.label9.TabIndex = 51;
            this.label9.Text = "F(x):";
            // 
            // lb_valorX
            // 
            this.lb_valorX.AutoSize = true;
            this.lb_valorX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_valorX.Location = new System.Drawing.Point(144, 139);
            this.lb_valorX.Name = "lb_valorX";
            this.lb_valorX.Size = new System.Drawing.Size(232, 20);
            this.lb_valorX.TabIndex = 49;
            this.lb_valorX.Text = "Encontrar o minimo da Equa;ao";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(69, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 20);
            this.label5.TabIndex = 48;
            this.label5.Text = "X";
            // 
            // lb_decimal
            // 
            this.lb_decimal.AutoSize = true;
            this.lb_decimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_decimal.Location = new System.Drawing.Point(144, 100);
            this.lb_decimal.Name = "lb_decimal";
            this.lb_decimal.Size = new System.Drawing.Size(232, 20);
            this.lb_decimal.TabIndex = 47;
            this.lb_decimal.Text = "Encontrar o minimo da Equa;ao";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 46;
            this.label3.Text = "Decimal";
            // 
            // lb_cronossomo
            // 
            this.lb_cronossomo.AutoSize = true;
            this.lb_cronossomo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cronossomo.Location = new System.Drawing.Point(242, 63);
            this.lb_cronossomo.Name = "lb_cronossomo";
            this.lb_cronossomo.Size = new System.Drawing.Size(161, 20);
            this.lb_cronossomo.TabIndex = 45;
            this.lb_cronossomo.Text = "0 0 0 0 0 0 0 0 0 0 0 0";
            // 
            // btn_estEvolutiva
            // 
            this.btn_estEvolutiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_estEvolutiva.Location = new System.Drawing.Point(365, 239);
            this.btn_estEvolutiva.Name = "btn_estEvolutiva";
            this.btn_estEvolutiva.Size = new System.Drawing.Size(98, 34);
            this.btn_estEvolutiva.TabIndex = 42;
            this.btn_estEvolutiva.Text = "Mutação";
            this.btn_estEvolutiva.UseVisualStyleBackColor = true;
            this.btn_estEvolutiva.Click += new System.EventHandler(this.btn_estEvolutiva_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(69, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 20);
            this.label7.TabIndex = 44;
            this.label7.Text = "Cronossomo Gerado:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(230, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 53;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 310);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_fit);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lb_valorX);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lb_decimal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_cronossomo);
            this.Controls.Add(this.btn_estEvolutiva);
            this.Controls.Add(this.label7);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_fit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lb_valorX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_decimal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_cronossomo;
        private System.Windows.Forms.Button btn_estEvolutiva;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
    }
}