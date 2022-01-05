using System;
using System.Text;
using System.
using Primeiro;
using CSharp;
using Interface;
using Enum;
     
}

namespace CSharp
{
    class Program
    {
      static void Main(string[] args)
      {
          var pessoa1 = (Pessoas)0;
          Pessoas pessoa2 = Pessoas.Marcos;
          Pessoas pessoa3 = (Pessoas)4;
          
          var animal = new Animal();
          
          animal.nome = "Rex";
          animal.nomeDono = "pedro";
          animal.especie = "cachorro";

          Pessoa person = new Pessoa();
          
          person.Nome = "Rafael";
          person.Idade = 28;
          person.Estado = "SP";

          var person2 = new Pessoa();
          person2.Nome = "Claudia"
          person2.Idade = "29"
          person2.Esado = "RJ"

          va r classe = new Classe();
          var classe2 = new Segundo.Classe();

          Console.WriteLine("Hello World!"):
      
      } 
    }
}