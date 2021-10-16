using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    class Exercicio4
    {
        const string TEXTONOTA = "Digite a nota ";
        const string TEXTOEXAME = "Digite a nota do exame: ";
        double nota;

        public Exercicio4()
        {

        }

        public Exercicio4(double nota)
        {
            this.setNota(nota);
        }

        public string getEnunciadoNota()
        {
                return TEXTONOTA;
        }

        public string getEnunciadoNotaExame()
        {
            return TEXTOEXAME;
        }

        public double getNota()
        {
            return this.nota;
        }

        public void setNota(double nota)
        {
            this.nota = nota;
        }


        public double calculoMedia(double soma)
        {
            return Math.Round(soma / 3, 2);
        }

        public double calculoMediaExame(double soma)
        {
            return Math.Round(soma / 4, 2);
        }

        public string resultadoMedia(double resultadoMedia, int exame)
        {
            string resultado;
            if(resultadoMedia >= 7 && exame == 0)
            {
                resultado = "\nAprovado, com a média: " + resultadoMedia;
            }
            else if(resultadoMedia >= 7 && exame == 1)
            {
                resultado = "\nAprovado em exame, com a média: " + resultadoMedia;
            }
            else
            {
                resultado = "\nReprovado, com a média: " + resultadoMedia;
            }
            return resultado;
        }


    }
}
