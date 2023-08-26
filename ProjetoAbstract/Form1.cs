using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAbstract
{
    public partial class Form1 : Form
    {
        Quadrado q = new Quadrado();
        Retangulo r = new Retangulo();
        Triangulo t = new Triangulo();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonQ_Click(object sender, EventArgs e)
        {
            q.Lado = Convert.ToInt32(textBoxQ.Text);
            q.CalcularArea();
            q.CalcularPerimetro();
            labelAreaQ.Text = "A área do quadrado é: " + q.Area + " metro(s) quadrado(s)";
            labelPerimetroQ.Text = "O perímetro do quadrado é: " + q.Perimetro + "metro(s)"; 
        }

        private void buttonT_Click(object sender, EventArgs e)
        {
            t.LadoA = Convert.ToInt32(textBoxLadoA.Text);
            t.LadoB = Convert.ToInt32(textBoxLadoB.Text);
            t.LadoC = Convert.ToInt32(textBoxLadoC.Text);
            t.Altura = Convert.ToInt32(textBoxAlturaT.Text);
            t.CalcularArea();
            t.CalcularPerimetro();
            labelAreaT.Text = "A área do triângulo é: " + t.Area + " metro(s) quadrado(s)";
            labelPerimetroT.Text = "O perímetro do quadrado é: " + t.Perimetro + "metro(s)";
        }

        private void buttonR_Click(object sender, EventArgs e)
        {
            r.Base = Convert.ToInt32(textBoxBaseR.Text);
            r.Altura = Convert.ToInt32(textBoxAlturaR.Text);
            r.CalcularArea();
            r.CalcularPerimetro();
            labelAreaR.Text = "A área do retângulo é: " + r.Area + " metro(s) quadrado(s)";
            labelPerimetroR.Text = "O perímetro do quadrado é: " + r.Perimetro + "metro(s)";
        }
    }
}
