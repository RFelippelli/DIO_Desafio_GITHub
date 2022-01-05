using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    interface CadAnimal
    {
      void Nome(string nome);
      void Dono(string nomeDono);
      void Especie(string epecie);
    }

    class Animal : CadAnimal
    {
      public string nome{get;get;}
      public string nomeDono{get;get;}
      public string especie{get;get;}

      void CadAnimal.Nome(string nome)
      {
        this.nome = nome;
      }
      void CadAnimal.nomeDono(string nomeDono)
      {
        this.nome = nomeDono;
      }
      void CadAnimal.Especie(string epecie)
      {
        this.especie = especie;
       
    }
}