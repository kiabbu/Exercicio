using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    class Exercicio5
    {
        const string TXTNOME = "\nDigite o NOME do animal ";
        const string TXTTIPO = "Digite o TIPO do animal ";
        private string nome;
        private string tipo;

        public Exercicio5()
        {

        }

        public Exercicio5(string nome, string tipo)
        {
            this.setNome(nome);
            this.setTipo(tipo);
        }

        public string getEnunciadoNome()
        {
            return TXTNOME;
        }

        public string getEnunciadoTipo()
        {
            return TXTTIPO;
        }

        public string getNome()
        {
            return this.nome;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }


        public string getTipo()
        {
            return this.tipo;
        }

        public void setTipo(string tipo)
        {
            this.tipo = tipo;
        }


    }
}
