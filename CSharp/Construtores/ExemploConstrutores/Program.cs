using System;
using ExemploConstrutores.Models;

namespace ExemploConstrutores
{
  class Program
  {
    static void Main(string[] args)
    {
      // Log log = Log.GetInstance();     

      // log.PropriedadeLog = "teste instacia";
      // Log log2 = Log.GetInstance();
      // System.Console.WriteLine(log2.PropriedadeLog);

      Aluno p1 = new Aluno("Rafael", "Felippelli", "ADS" );
      p1.Apresentar();
    }
  }
}