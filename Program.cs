using System;

namespace lenght
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int quantidade;

            Console.WriteLine("DIGITE O NOME ");
            nome = Console.ReadLine();

            quantidade = nome.Length;


            Console.WriteLine("\n O nome: " + nome + " tem " + quantidade + " letras");
        }
    }
}
