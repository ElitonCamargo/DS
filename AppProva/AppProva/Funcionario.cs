using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProva
{
    public class Funcionario
    {
        public int matricula;
        public string nome;
        public int codigoCargo;
        public double salario;
        public int tempotrab;
        public double reajuste;
        public double acrescimo;
        public double salarioReajutado;

        private void calcReajuste()
        {
            double[] valor = { 10.8, 9.6, 8.7, 4.2, 3 };
            this.reajuste = this.salario * valor[this.codigoCargo] / 100;
        }

        private void calcAcrescimo()
        {
            double percentualAcrescimo = 0;
            if (this.codigoCargo == 1)
                if (this.tempotrab < 11)
                    percentualAcrescimo = 1.5;
                else if (this.tempotrab < 21)
                    percentualAcrescimo = 2;
                else
                    percentualAcrescimo = 2.5;
            else if (this.codigoCargo == 2)
                if (this.tempotrab < 11)
                    percentualAcrescimo = 2;
                else if (this.tempotrab < 21)
                    percentualAcrescimo = 2.5;
                else
                    percentualAcrescimo = 3;
            else if (this.codigoCargo == 3)
                if (this.tempotrab < 11)
                    percentualAcrescimo = 2.5;
                else if (this.tempotrab < 21)
                    percentualAcrescimo = 3;
                else
                    percentualAcrescimo = 3.5;

            this.acrescimo = this.salario * percentualAcrescimo / 100;
        }

        public void calcReajusteSalarial()
        {
            this.calcReajuste();
            this.calcAcrescimo();
            this.salarioReajutado = this.salario + this.acrescimo + this.reajuste;
        }

    }
}
