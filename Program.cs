using System;

namespace ExercVetores
{
  class Program
  {
    static void Main(string[] args)
    {
      Alugar[] quartos = new Alugar[10];

      Console.WriteLine("Quantos quartos serão alugados?");
      int qtdQuartosAlugados = int.Parse(Console.ReadLine());


      for (int i = 0; i < qtdQuartosAlugados; i++)
      {
        Console.WriteLine("DIGITE SEU NOME");
        string name = Console.ReadLine();
        Console.WriteLine("DIGITE SEU EMAIL");
        string email = Console.ReadLine();
        Console.WriteLine("DIGITE SEU QUARTO ENTRE 1 - 10");
        int numeroQuarto = int.Parse(Console.ReadLine());

        quartos[numeroQuarto] = new Alugar(name, email);
      }

      Console.WriteLine();
      Console.WriteLine("Quartos ocupados:");
      for (int i = 0; i < quartos.Length; i++)
      {
        if (quartos[i] != null)
        {
          Console.WriteLine(i + ": " + quartos[i]);
        }
      }

    }
  }
}