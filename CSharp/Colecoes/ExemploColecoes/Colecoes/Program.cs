using System;
using Colecoes.Helper;

namespace Colecoes
{
  class Program
  {
    static void Main(string[] args)
    {
      OperacoesArray op = new OperacoesArray();

      int[] array = new int[5] { 6, 3, 8, 1, 9 };
      int[] arrayCopia = new int[10];

      System.Console.WriteLine("Array antes da cópia");
      op.ImprimirArray(arrayCopia);

      op.Copiar(ref array, ref arrayCopia);
      System.Console.WriteLine("Array após a cópia");
      op.ImprimirArray(arrayCopia);

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