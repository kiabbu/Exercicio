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
                Console.WriteLine("1) Primeiro Exercício");
                Console.WriteLine("2) Segundo Exercício");
                Console.WriteLine("3) Terceiro Exercício");
                Console.WriteLine("4) Quarto Exercício");
                Console.WriteLine("5) Quinto Exercício");
                Console.WriteLine("6) Sair");

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
                }

                Console.WriteLine("Pressione Enter para retornar ao Menu");
                Console.ReadLine();
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

    }
}
