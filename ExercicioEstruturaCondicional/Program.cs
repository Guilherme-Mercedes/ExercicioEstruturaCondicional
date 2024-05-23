using System.Numerics;

namespace ExercicioEstruturaCondicional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exercicio5();
        }

        static void Exercicio1() /// exercicio para mostrar se o numero é positivo ou negativo
        {
            int n1;

            Console.WriteLine("Digite um numero inteiro");
            n1 = int.Parse(Console.ReadLine());

            if (n1 >= 0)
            {
                Console.WriteLine("O numero positivo!");
            }
            else
            {
                Console.WriteLine("O numero é negativo!");
            }
        }

        static void Exercicio2() /// exercicio para mostrar se o numero é par ou impar
        {
            int n1;

            Console.WriteLine("Digite um numero inteiro");
            n1 = int.Parse(Console.ReadLine());

            if (n1 % 2 == 0)
            {
                Console.WriteLine("O numero par!");
            }
            else
            {
                Console.WriteLine("O numero é impar!");
            }
        }

        static void Exercicio3() ///Ler dois numeros e mostrar se sao multiplos ou nao
        {
            int a, b;

            Console.WriteLine("Digite o primeiro valor");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Segundo valor");
            b = int.Parse(Console.ReadLine());

            if( a % b == 0 || b % a == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao multiplos");
            }
        }

        static void Exercicio4() ///Duracao de um jogo com maximo de 24 horas, ELDEN RING nao entra nessa lista
        {
            int horaInicial, horaFinal, duracao;

            Console.WriteLine("Digite a hora inicial do jogo");
            horaInicial = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a hora final do jogo");
            horaFinal = int.Parse(Console.ReadLine());


            if (horaInicial < horaFinal)
            {
                duracao =  horaFinal - horaInicial;
                Console.WriteLine("O jogo durou {0} Hora(s)", duracao);
            }
            else 
            {
                duracao = 24 - (horaInicial - horaFinal);
                Console.WriteLine("O jogo durou {0} Hora(s)", duracao);
            }

        }

        static void Exercicio5() ///Escolher a comida e a quantidade
        {
            string[] vet;
            int a;
            double preco;
            Console.WriteLine("Codido:    Especificacao:    Preco:    ");
            Console.WriteLine("  1       Cachorro Quente    R$ 4.00    ");
            Console.WriteLine("  2       X-Salada           R$ 4.50    ");
            Console.WriteLine("  3       X-Bacon            R$ 5.00    ");
            Console.WriteLine("  4       Torrada Simples    R$ 2.00    ");
            Console.WriteLine("  5       Refrigerante       R$ 1.50    ");
            vet = Console.ReadLine().Split(" ");
            a = int.Parse(vet[1]);

            if (vet[0] == "1") 
            {
                preco = 4.00 * a;
                Console.WriteLine("Total: R${0}", preco.ToString("F2"));
            }
            else if (vet[0] == "2")
            {
                preco = 4.50 * a;
                Console.WriteLine("Total: R${0}", preco.ToString("F2"));
            }
            else if (vet[0] == "3")
            {
                preco = 5.00 * a;
                Console.WriteLine("Total: R${0}", preco.ToString("F2"));
            }
            else if (vet[0] == "4")
            {
                preco = 2.00 * a;
                Console.WriteLine("Total: R${0}", preco.ToString("F2"));
            }
            else
            {
                preco = 1.50 * a;
                Console.WriteLine("Total: R${0}", preco.ToString("F2"));
            }


        }
    }
}
