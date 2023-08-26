using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAbstract
{
    public class Retangulo : Forma
    {
        private double baseR;
        private double alturaR;
        public double Base
        {
            get
            { return baseR; }
            set
            { baseR = value; }
        }
        
        public double Altura
        {
            get
            { return alturaR; }
            set
            { alturaR = value; }
        }
        public override void CalcularArea()
        {
            this.Area = baseR * alturaR;
        }
        public override void CalcularPerimetro()
        {
            this.Perimetro = (2 * baseR) + (2* alturaR);
        }
    }
}
