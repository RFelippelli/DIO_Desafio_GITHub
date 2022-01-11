using System;
using System.Collections.Generic;
using Colecoes.Helper;

namespace Colecoes
{
  class Program
  {
    static void Main(string[] args)
    {
      OperacoesLista oplista = new OperacoesLista();
      List<string> estados = new List<string> { "SP", "MG", "BA" };
      string[] estadosArray = new string[2] { "SC", "MT" };
      System.Console.WriteLine($"Quantidade de elementos na lista: {estados.Count}");
      oplista.ImprimirListaString(estados);
      // Adicionando coleções na lista
      // estados.AddRange(estadosArray);

      // adicionando elementos por indice
      estados.Insert(1, "RJ");
      oplista.ImprimirListaString(estados);

      //Removendo itens de uma lista
      // estados.Add("SP");
      // estados.Add("MG");
      // estados.Add("BA");
      // System.Console.WriteLine("Removendo Itens");
      // estados.Remove("MG");
      //System.Console.WriteLine($"Quantidade de elementos na lista pós remoção: {estados.Count}");
      //oplista.ImprimirListaString(estados);

      //COLEÇÃO GENÉRICA TIPO LIST
      // List<string> estados = new List<string>();
      // estados.Add("SP");
      // estados.Add("MG");
      // estados.Add("BA");
      // System.Console.WriteLine($"Quantidade de elementos na lista: {estados.Count}");
      // foreach (var item in estados)
      // {
      //     System.Console.WriteLine(item);
      // }
      // for (int i = 0; i < estados.Count; i++)
      // {
      //     System.Console.WriteLine($"Indice: {i}, valor: {estados[i]}");
      // }
      // OperacoesArray op = new OperacoesArray();
      // int[] array = new int[5] { 6, 3, 8, 1, 9 };
      // int[] arrayCopia = new int[10];
      //int valorProcurado = 8;


      //Converter Array
      //string[] arrayString = op.ConverterParaArrayString(array);

      //Redimensionar um array
      // System.Console.WriteLine($"capacidade atual do array: {array.Length}");
      // op.RedimensionarArray(ref array, array.Length * 2);
      // System.Console.WriteLine($"capacidade atual do array após redimensionamento: {array.Length}");

      //Encontrando o índice de um valor com método
      // int indice = op.ObterIndice(array, valorProcurado);
      // if(indice > -1)
      //   {
      //     System.Console.WriteLine($"O indice do elemeto {valorProcurado} é: {indice}");
      //   }
      // else
      //   {
      //     System.Console.WriteLine("valor não encontrado no Array");
      //   }

      // buscando valor contido em uma array com o método Find
      // int valorAchado = op.ObterValor(array, valorProcurado);
      // if(valorAchado > 0)
      // {
      //   System.Console.WriteLine("encontrei o valor");
      // }
      // else
      // {
      //   System.Console.WriteLine("não encontrei o valor");
      // }


      //Utilizando método TrueForAll para verificar todos os elementos de um Array.
      // bool TodosMaiorQue = op.TodosMaiorQue(array, valorProcurado);
      // if(TodosMaiorQue)
      // {
      //   System.Console.WriteLine("Todos os valores são maiores que: {0}", valorProcurado);
      // }
      // else
      // {
      //   System.Console.WriteLine("Existem valores que não são maiores que: {0}", valorProcurado);
      // }


      //Utilizando método Exists para localizar valor dentro de um array
      // int valorProcurado = 4;
      // bool Existe = op.Existe(array, valorProcurado);
      // if(Existe)
      // {
      //   System.Console.WriteLine("Encontrei o valor: {0}", valorProcurado);
      // }
      // else
      // {
      //   System.Console.WriteLine("não encontrei o valor: {0}", valorProcurado);
      // }

      //Utilizando Array como Classe
      // System.Console.WriteLine("Array antes da cópia");
      // op.ImprimirArray(arrayCopia);
      // op.Copiar(ref array, ref arrayCopia);
      // System.Console.WriteLine("Array após a cópia");
      // op.ImprimirArray(arrayCopia);

      //Organizando valores com bubblesort
      //System.Console.WriteLine("Array Original");
      //op.ImprimirArray(array);
      //op.ordenarBubbleSort(ref array);
      //op.Ordenar(ref array);
      //System.Console.WriteLine("Array Ordenado");
      //op.ImprimirArray(array);

      //Array multidimensional e como percorrer
      //   int[,] matriz = new int[4,2]
      //   {
      //     {8,8},
      //     {50,100},
      //     {90,200},
      //     {10,20}
      //   };
      //   for (int i = 0; i < matriz.GetLength(0); i++)
      //   {
      //       for (int j = 0; j < matriz.GetLength(1); j++)
      //       {
      //           System.Console.WriteLine(matriz[i,j]);
      //       }
      //   }

      // convertendo valor de variavel com Parse
      // {
      //   int[] arrayInteiros = new int[3];
      //   arrayInteiros[0] = 10;
      //   arrayInteiros[1] = 20;
      //   arrayInteiros[2] = int.Parse("30");
      // }

      // percorrendo array pelo laço for e for each
      // {
      //   int[] arrayInteiros = new int [3];
      //   arrayInteiros[0] = 10;
      //   arrayInteiros[1] = 20;
      //   arrayInteiros[2] = 30;
      // System.Console.WriteLine("percorrendo o array pelo for");
      // for (int i = 0; i < arrayInteiros.Length; i++)
      // {
      //   System.Console.WriteLine(arrayInteiros[i]);
      // }
      // System.Console.WriteLine("percorrendo o array pelo foreach");
      // foreach (int item in arrayInteiros)
      // {
      //   System.Console.WriteLine(item);
      // }
    }
  }
}