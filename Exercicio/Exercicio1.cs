using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    class Exercicio1
    {
        const string PESO = "Digite seu peso: ";
        const string ALTURA = "Digite seu altura: ";
        const string IMC = "Seu Status: ";
        double peso;
        double altura;
        double imc;

        
        public Exercicio1()
        {

        }
        
        public Exercicio1 (double peso, double altura, double imc)
        {
            this.setPeso(peso);
            this.setAltura(altura);
            this.setIMC(imc);
        }

        public string getEnunciadoPeso()
        {
            return PESO;
        }

        public string getEnunciadoAltura()
        {
            return ALTURA;
        }

        public double getPeso()
        {
            return this.peso;
        }

        public void setPeso(double peso)
        {
            this.peso = peso;
        }

        public double getAltura()
        {
            return this.altura;
        }

        public void setAltura(double altura)
        {
            this.altura = altura;
        }

        public double getIMC()
        {
            return this.imc;
        }

        public void setIMC(double imc)
        {
            this.imc = imc;
        }

        public double calculoIMC(double peso, double altura)
        {
            double altura2 = altura * altura;
            return peso / altura2;
        }

        public string resultadoIMC(double imc)
        {
            string resultado;
            if(imc < 20)
            {
                resultado = IMC + "\n Abaixo do peso!";
            } 
            else if(imc >= 25)
            {
                resultado = IMC + "\n Acima do peso!";
            }
            else
            {
                resultado = IMC + "\n Peso ideal!";
            }
            return resultado;
        }

    }
}
