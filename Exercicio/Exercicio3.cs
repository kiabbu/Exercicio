using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    class Exercicio3
    {
        const string SEURAIO = "Digite o valor do Raio: ";
        const double PI = 3.14;
        double raio;

        public Exercicio3()
        {

        }

        public Exercicio3(double raio)
        {
            this.setRaio(raio);
        }

        public string getEnunciadoRaio()
        {
            return SEURAIO;
        }


        public double getraio()
        {
            return this.raio;
        }

        public void setRaio(double raio)
        {
            this.raio = raio;
        }


        public double calculoVolume(double raio)
        {
            return Math.Round(((4/3)* PI) *  (Math.Pow(raio, 3)), 2);
        }

        public string resultadoVolume(double resultadoVolume)
        {
            string resultado;
            resultado = "O volume é: " + resultadoVolume;
            return resultado;
        }

    }
}
