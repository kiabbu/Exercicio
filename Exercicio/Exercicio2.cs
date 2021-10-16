using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    class Exercicio2
    {
        const string SEUSALARIO = "Digite seu sálario: ";
        const double SALARIOMINIMO = 1100;
        double seuSalario;

        public Exercicio2()
        {

        }

        public Exercicio2(double seuSalario)
        {
            this.setSeuSalario(seuSalario);
        }

        public string getEnunciadoSalario()
        {
            return SEUSALARIO;
        }


        public double getseuSalario()
        {
            return this.seuSalario;
        }

        public void setSeuSalario(double seuSalario)
        {
            this.seuSalario = seuSalario;
        }


        public double calculoSalario(double seuSalario)
        {
            return Math.Round(seuSalario / SALARIOMINIMO, 2);
        }

        public string resultadoSalario(double resultadoSalario)
        {
            string resultado;
            resultado = "Você recebe " + resultadoSalario + " salários mínimos.";
            return resultado;
        }

    }
}
