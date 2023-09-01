using System;

namespace aula
{
    class Program
    {
        static void Main(string[] args)
        {
          Dados pessoa1 = new Dados();
            Console.WriteLine("Dados da primeira pessoa");
            Console.WriteLine("Nome:");
            pessoa1.Nome = Console.ReadLine();
            Console.WriteLine("Idade:");
            pessoa1.Idade = int.Parse(Console.ReadLine());

            Dados pessoa2 = new Dados();
            Console.WriteLine("Dados da segunda pessoa");
            Console.WriteLine("Nome:");
            pessoa2.Nome = Console.ReadLine();
            Console.WriteLine("Idade:");
            pessoa2.Idade = int.Parse(Console.ReadLine());

            if (pessoa1.Idade > pessoa2.Idade){
              Console.WriteLine("Pessoa com maior idade é: " + pessoa1.Nome);
            }
            else
            {
              Console.WriteLine("Pessoa com maior idade é: " + pessoa2.Nome);
            }
        }

    }
}