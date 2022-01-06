using System;
using ExemploPoo.Models;

namespace ExemploPoo
{
  class Program
  {
    static void Main(string[] args)
    {
      Pessoa p1 = new Pessoa();
      
      p1.Nome = "Bob";
      p1.Idade = 20;

      p1.Apresentar();
    }
  }
}