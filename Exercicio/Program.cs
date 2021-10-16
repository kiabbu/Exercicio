using System;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcaoMenu;
            Console.WriteLine("====== Seja Bem-Vindo ao Menu de Exercícios ======");
            do
            {
                Console.WriteLine("\nSelecione a Opção Desejada: \n");
                Console.WriteLine("1) Calcular seu IMC");
                Console.WriteLine("2) Descobrir quantos salários mínimos você recebe");
                Console.WriteLine("3) Descobrir o volume de uma esfera");
                Console.WriteLine("4) Calcular média de notas");
                Console.WriteLine("5) Contando Animaizinhos");
                Console.WriteLine("6) Sair\n");

                opcaoMenu = Convert.ToInt32(Console.ReadLine());

                switch (opcaoMenu) { 
                    case 1:
                        Console.Clear();
                        Program.execucaoEx1();
                        break;
                    case 2:
                        Console.Clear();
                        Program.execucaoEx2();
                        break;
                    case 3:
                        Console.Clear();
                        Program.execucaoEx3();
                        break;
                    case 4:
                        Console.Clear();
                        Program.execucaoEx4();
                        break;
                    case 5:
                        Console.Clear();
                        Program.execucaoEx5();
                        break;
                    case 6:
                        break;
                    default:
                        Console.WriteLine("\nOpção Invalida!");
                        break;    
                }

                if(opcaoMenu != 6)
                {
                    Console.WriteLine("\nPressione Enter para retornar ao Menu");
                    Console.ReadLine();
                }               
                Console.Clear();
            } while (opcaoMenu != 6);
        }

        public static void execucaoEx1()
        {
            Console.WriteLine("======= Cálculo IMC =======\n");
            Exercicio1 exercicio1 = new Exercicio1();
            Console.WriteLine(exercicio1.getEnunciadoPeso());
            double peso = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(exercicio1.getEnunciadoAltura());
            double altura = Convert.ToDouble(Console.ReadLine());
            double imc = exercicio1.calculoIMC(peso, altura);
            string resultado = exercicio1.resultadoIMC(imc);
            Console.WriteLine(resultado);
        }

        public static void execucaoEx2()
        {
            Console.WriteLine("======= Cálculo Salários Mínimos =======\n");
            Exercicio2 exercicio2 = new Exercicio2();
            Console.WriteLine(exercicio2.getEnunciadoSalario());
            double seuSalario = Convert.ToDouble(Console.ReadLine());
            double result = exercicio2.calculoSalario(seuSalario);
            string resultado = exercicio2.resultadoSalario(result);
            Console.WriteLine(resultado);
        }

        public static void execucaoEx3()
        {
            Console.WriteLine("======= Cálculo Volume de uma Esfera =======\n");
            Exercicio3 exercicio3 = new Exercicio3();
            Console.WriteLine(exercicio3.getEnunciadoRaio());
            double raio = Convert.ToDouble(Console.ReadLine());
            double result = exercicio3.calculoVolume(raio);
            string resultado = exercicio3.resultadoVolume(result);
            Console.WriteLine(resultado);
        }

        public static void execucaoEx4()
        {
            Console.WriteLine("======= Cálculo Média das Notas =======\n");
            Exercicio4 exercicio4 = new Exercicio4();
            double soma = 0;
            for(int i=0; i<3; i++)
            {
                Console.WriteLine(exercicio4.getEnunciadoNota() + (i+1) + ": ");
                double nota = Convert.ToDouble(Console.ReadLine());
                soma = soma + nota;
            }
            double result = exercicio4.calculoMedia(soma);
            if(result >= 7)
            {
                string resultado = exercicio4.resultadoMedia(result, 0);
                Console.WriteLine(resultado);
            }
            else
            {
                Console.WriteLine(exercicio4.getEnunciadoNotaExame());
                soma = soma + Convert.ToDouble(Console.ReadLine());
                result = exercicio4.calculoMediaExame(soma);
                string resultado = exercicio4.resultadoMedia(result, 1);
                Console.WriteLine(resultado);
            }
        }

        public static void execucaoEx5()
        {
            Console.WriteLine("======= Cálculo da Quantidade de Animais =======\n");
            Exercicio5 exercicio5 = new Exercicio5();
            Console.WriteLine("Você irá digitar o nome e tipo de 5 animais (Ex.: nome 'alfredo', tipo 'gato')\n");

            Exercicio5[] animais = new Exercicio5[5];
            int cachorro = 0;
            int gato = 0;
            int peixe = 0;

            for (int i = 0; i<5; i++)
            {                              
                Console.WriteLine(exercicio5.getEnunciadoNome() + (i + 1) + ": ");
                string nome = (Console.ReadLine());
                Console.WriteLine(exercicio5.getEnunciadoTipo() + (i + 1) + ": ");
                string tipo = (Console.ReadLine());
                animais[i] = Program.instanciaAnimail(nome, tipo);
            }
            
            foreach(Exercicio5 animal in animais)
            {
                if(String.Equals(animal.getTipo(),  "cachorro"))
                {
                    cachorro++;
                }  
                else if (String.Equals(animal.getTipo(), "gato"))
                {
                    gato++;
                }
                else
                {
                    peixe++;
                }
            }

            Console.WriteLine("\n=== Resumo dos Animais ===\n");
            Console.WriteLine("- Cachorros: {0}\n- Gatos: {1}\n- Peixes: {2}", cachorro, gato, peixe);
            Console.WriteLine("\n==========================\n");
        }

        public static Exercicio5 instanciaAnimail(string nome, string tipo)
        {
            Exercicio5 animal = new Exercicio5(nome, tipo);
            return animal;
        }

    }
}
