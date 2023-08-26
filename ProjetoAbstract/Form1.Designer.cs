namespace ProjetoAbstract
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxQ = new System.Windows.Forms.TextBox();
            this.buttonQ = new System.Windows.Forms.Button();
            this.labelAreaQ = new System.Windows.Forms.Label();
            this.labelPerimetroQ = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxLadoA = new System.Windows.Forms.TextBox();
            this.labelAreaT = new System.Windows.Forms.Label();
            this.labelPerimetroT = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonT = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxBaseR = new System.Windows.Forms.TextBox();
            this.labelAreaR = new System.Windows.Forms.Label();
            this.labelPerimetroR = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonR = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxLadoC = new System.Windows.Forms.TextBox();
            this.textBoxLadoB = new System.Windows.Forms.TextBox();
            this.textBoxAlturaT = new System.Windows.Forms.TextBox();
            this.textBoxAlturaR = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o valor do lado do quadrado em metros:";
            // 
            // textBoxQ
            // 
            this.textBoxQ.Location = new System.Drawing.Point(249, 32);
            this.textBoxQ.Name = "textBoxQ";
            this.textBoxQ.Size = new System.Drawing.Size(49, 20);
            this.textBoxQ.TabIndex = 1;
            // 
            // buttonQ
            // 
            this.buttonQ.Location = new System.Drawing.Point(106, 67);
            this.buttonQ.Name = "buttonQ";
            this.buttonQ.Size = new System.Drawing.Size(105, 23);
            this.buttonQ.TabIndex = 2;
            this.buttonQ.Text = "Calcular quadrado";
            this.buttonQ.UseVisualStyleBackColor = true;
            this.buttonQ.Click += new System.EventHandler(this.buttonQ_Click);
            // 
            // labelAreaQ
            // 
            this.labelAreaQ.AutoSize = true;
            this.labelAreaQ.Location = new System.Drawing.Point(19, 108);
            this.labelAreaQ.Name = "labelAreaQ";
            this.labelAreaQ.Size = new System.Drawing.Size(113, 13);
            this.labelAreaQ.TabIndex = 3;
            this.labelAreaQ.Text = "A área do quadrado é:";
            // 
            // labelPerimetroQ
            // 
            this.labelPerimetroQ.AutoSize = true;
            this.labelPerimetroQ.Location = new System.Drawing.Point(19, 137);
            this.labelPerimetroQ.Name = "labelPerimetroQ";
            this.labelPerimetroQ.Size = new System.Drawing.Size(138, 13);
            this.labelPerimetroQ.TabIndex = 4;
            this.labelPerimetroQ.Text = "O perímetro do quadrado é:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxQ);
            this.groupBox1.Controls.Add(this.labelAreaQ);
            this.groupBox1.Controls.Add(this.labelPerimetroQ);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonQ);
            this.groupBox1.Location = new System.Drawing.Point(22, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 174);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quadrado";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxAlturaT);
            this.groupBox2.Controls.Add(this.textBoxLadoB);
            this.groupBox2.Controls.Add(this.textBoxLadoC);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.textBoxLadoA);
            this.groupBox2.Controls.Add(this.labelAreaT);
            this.groupBox2.Controls.Add(this.labelPerimetroT);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.buttonT);
            this.groupBox2.Location = new System.Drawing.Point(380, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(261, 274);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Triângulo";
            // 
            // textBoxLadoA
            // 
            this.textBoxLadoA.Location = new System.Drawing.Point(178, 32);
            this.textBoxLadoA.Name = "textBoxLadoA";
            this.textBoxLadoA.Size = new System.Drawing.Size(49, 20);
            this.textBoxLadoA.TabIndex = 1;
            // 
            // labelAreaT
            // 
            this.labelAreaT.AutoSize = true;
            this.labelAreaT.Location = new System.Drawing.Point(19, 208);
            this.labelAreaT.Name = "labelAreaT";
            this.labelAreaT.Size = new System.Drawing.Size(108, 13);
            this.labelAreaT.TabIndex = 3;
            this.labelAreaT.Text = "A área do triângulo é:";
            // 
            // labelPerimetroT
            // 
            this.labelPerimetroT.AutoSize = true;
            this.labelPerimetroT.Location = new System.Drawing.Point(19, 237);
            this.labelPerimetroT.Name = "labelPerimetroT";
            this.labelPerimetroT.Size = new System.Drawing.Size(133, 13);
            this.labelPerimetroT.TabIndex = 4;
            this.labelPerimetroT.Text = "O perímetro do triângulo é:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Lado A do triangulo em metros:";
            // 
            // buttonT
            // 
            this.buttonT.Location = new System.Drawing.Point(80, 170);
            this.buttonT.Name = "buttonT";
            this.buttonT.Size = new System.Drawing.Size(105, 23);
            this.buttonT.TabIndex = 2;
            this.buttonT.Text = "Calcular triângulo";
            this.buttonT.UseVisualStyleBackColor = true;
            this.buttonT.Click += new System.EventHandler(this.buttonT_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxAlturaR);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.textBoxBaseR);
            this.groupBox3.Controls.Add(this.labelAreaR);
            this.groupBox3.Controls.Add(this.labelPerimetroR);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.buttonR);
            this.groupBox3.Location = new System.Drawing.Point(682, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(328, 210);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Retângulo";
            // 
            // textBoxBaseR
            // 
            this.textBoxBaseR.Location = new System.Drawing.Point(256, 33);
            this.textBoxBaseR.Name = "textBoxBaseR";
            this.textBoxBaseR.Size = new System.Drawing.Size(49, 20);
            this.textBoxBaseR.TabIndex = 1;
            // 
            // labelAreaR
            // 
            this.labelAreaR.AutoSize = true;
            this.labelAreaR.Location = new System.Drawing.Point(19, 146);
            this.labelAreaR.Name = "labelAreaR";
            this.labelAreaR.Size = new System.Drawing.Size(112, 13);
            this.labelAreaR.TabIndex = 3;
            this.labelAreaR.Text = "A área do retângulo é:";
            // 
            // labelPerimetroR
            // 
            this.labelPerimetroR.AutoSize = true;
            this.labelPerimetroR.Location = new System.Drawing.Point(19, 175);
            this.labelPerimetroR.Name = "labelPerimetroR";
            this.labelPerimetroR.Size = new System.Drawing.Size(137, 13);
            this.labelPerimetroR.TabIndex = 4;
            this.labelPerimetroR.Text = "O perímetro do retângulo é:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(226, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Digite o valor da base do retângulo em metros:";
            // 
            // buttonR
            // 
            this.buttonR.Location = new System.Drawing.Point(115, 108);
            this.buttonR.Name = "buttonR";
            this.buttonR.Size = new System.Drawing.Size(105, 23);
            this.buttonR.TabIndex = 2;
            this.buttonR.Text = "Calcular retângulo";
            this.buttonR.UseVisualStyleBackColor = true;
            this.buttonR.Click += new System.EventHandler(this.buttonR_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(153, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Lado B do triangulo em metros:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(153, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Lado C do triangulo em metros:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 134);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(146, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "Altura do triangulo em metros:";
            // 
            // textBoxLadoC
            // 
            this.textBoxLadoC.Location = new System.Drawing.Point(178, 98);
            this.textBoxLadoC.Name = "textBoxLadoC";
            this.textBoxLadoC.Size = new System.Drawing.Size(49, 20);
            this.textBoxLadoC.TabIndex = 8;
            // 
            // textBoxLadoB
            // 
            this.textBoxLadoB.Location = new System.Drawing.Point(178, 64);
            this.textBoxLadoB.Name = "textBoxLadoB";
            this.textBoxLadoB.Size = new System.Drawing.Size(49, 20);
            this.textBoxLadoB.TabIndex = 9;
            // 
            // textBoxAlturaT
            // 
            this.textBoxAlturaT.Location = new System.Drawing.Point(178, 131);
            this.textBoxAlturaT.Name = "textBoxAlturaT";
            this.textBoxAlturaT.Size = new System.Drawing.Size(49, 20);
            this.textBoxAlturaT.TabIndex = 10;
            // 
            // textBoxAlturaR
            // 
            this.textBoxAlturaR.Location = new System.Drawing.Point(256, 70);
            this.textBoxAlturaR.Name = "textBoxAlturaR";
            this.textBoxAlturaR.Size = new System.Drawing.Size(49, 20);
            this.textBoxAlturaR.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Digite o valor da altura do retângulo em metros:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 321);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxQ;
        private System.Windows.Forms.Button buttonQ;
        private System.Windows.Forms.Label labelAreaQ;
        private System.Windows.Forms.Label labelPerimetroQ;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxLadoA;
        private System.Windows.Forms.Label labelAreaT;
        private System.Windows.Forms.Label labelPerimetroT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonT;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxBaseR;
        private System.Windows.Forms.Label labelAreaR;
        private System.Windows.Forms.Label labelPerimetroR;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonR;
        private System.Windows.Forms.TextBox textBoxAlturaT;
        private System.Windows.Forms.TextBox textBoxLadoB;
        private System.Windows.Forms.TextBox textBoxLadoC;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxAlturaR;
        private System.Windows.Forms.Label label2;
    }
}

