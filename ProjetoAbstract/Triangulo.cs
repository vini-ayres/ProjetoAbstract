using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAbstract
{
    public class Triangulo : Forma
    {
        private double ladoA, ladoB, ladoC, alturaT;
        public double LadoA
        {
            get
            { return ladoA; }
            set
            { ladoA = value; }
        }
        
        public double LadoB
        {
            get
            { return ladoB; }
            set
            { ladoB = value; }
        }
        
        public double LadoC
        {
            get
            { return ladoC; }
            set
            { ladoC = value; }
        }
        
        public double Altura
        {
            get
            { return alturaT; }
            set
            { alturaT = value; }
        }
        public override void CalcularArea()
        {
            this.Area = (ladoB * alturaT) / 2;
        }
        public override void CalcularPerimetro()
        {
            this.Perimetro = ladoA + ladoB + ladoC;
        }
    }
}
