using System;
using ExemploPoo.Interfaces;
using ExemploPoo.Models;

namespace ExemploPoo
{
  class Program
  {
    static void Main(string[] args)
    {
      Icalculadora calc = new calculadora();
      System.Console.WriteLine(calc.somar(10, 20));
    
    
      // computador comp = new computador();
      // comp.
      // Corrente c = new Corrente();
      // c.Creditar(100);
      // c.ExibirSaldo();

     
      // calculadora calc = new calculadora();
      // System.Console.WriteLine("Resultado da primeira soma " + calc.Somar(10, 10));
      // System.Console.WriteLine("Resultado da primeira soma " + calc.Somar(10, 10, 10));


      // Aluno p1 = new Aluno();
      // p1.Nota = 9;
      // p1.Nome = "Bob";
      // p1.Idade = 20;
      // p1.Documento = "123458748";
      // p1.Apresentar();

      // professor p2 = new professor();
      // p2.Salario = 2000;
      // p2.Nome = "Leo";
      // p2.Idade = 40;
      // p2.Documento = "789787456";
      // p2.Apresentar();

      // retangulo r = new retangulo();
      // r.DefinirMedidas(30, 30);
      // System.Console.WriteLine($"área: {r.ObterArea()}");
      
      // retangulo r2 = new retangulo();
      // r2.DefinirMedidas(0, 0);
      // System.Console.WriteLine($"área: {r2.ObterArea()}");
      
      // Pessoa p1 = new Pessoa();
      
      // p1.Nome = "Bob";
      // p1.Idade = 20;

      // p1.Apresentar();
    }
  }
}