using System;
using System.Collections.Generic;
using Colecoes.Helper;

namespace Colecoes
{
  class Program
  {
    static void Main(string[] args)
    {
      //Trabalhando com LINQ

      int[] arrayNumeros = new int[10] { 100, 1, 4, 0, 8, 15, 19, 19, 4, 100 };
      var minimo = arrayNumeros.Min();
      var maximo = arrayNumeros.Max();
      var medio = arrayNumeros.Average();
      var soma = arrayNumeros.Sum();
      var arrayUnico = arrayNumeros.Distinct().ToArray();


      System.Console.WriteLine($"minimo: {minimo}");
      System.Console.WriteLine($"maximo: {maximo}");
      System.Console.WriteLine($"média: {medio}");
      System.Console.WriteLine($"soma: {soma}");
      System.Console.WriteLine($"Array original: ({string.Join(",", arrayNumeros)})");
      System.Console.WriteLine($"Array distinto: ({string.Join(",", arrayUnico)})");


      // var numerosParesQuery = 
      // from num in arrayNumeros 
      // where num % 2 == 0
      // orderby num
      // select num;
      // var numerosParesMetodo = arrayNumeros.Where(x => x % 2 == 0).OrderBy(x => x).ToList();
      // System.Console.WriteLine("numeros pares query: " + string.Join(", ", numerosParesQuery));
      // System.Console.WriteLine("Numeros pares método: " + string.Join(",",numerosParesMetodo));



      //TRABALHANDO COM DICIONÁRIOS
      // Dictionary<string, string> estados = new Dictionary<string, string>();
      // estados.Add("SP","São Paulo");
      // estados.Add("MG","Minas Gerais");
      // estados.Add("BA","Bahia");
      // foreach(KeyValuePair<string,string> item in estados)
      //  {
      //   //System.Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
      //  }
      // string valorProcurado = "BA";
      // if(estados.TryGetValue(valorProcurado, out string estadoEncontrado))
      // {
      //   System.Console.WriteLine(estadoEncontrado);
      // }
      // else
      // {
      //   System.Console.WriteLine($"Chave {valorProcurado} não existe no dicionário");
      // }
      // System.Console.WriteLine($"Removendo o valor: {valorProcurado}");
      // estados.Remove(valorProcurado);
      // foreach(KeyValuePair<string,string> item in estados)
      //  {
      //   System.Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
      //  }
      // System.Console.WriteLine("Valor Original: ");
      // System.Console.WriteLine(estados[valorProcurado]);
      // estados[valorProcurado] = "BA - teste atualização";
      // System.Console.WriteLine("Valor atualizado");
      // System.Console.WriteLine(estados[valorProcurado]);


      //Trabalhando com Pilhas (Stack)
      // Stack<string> pilhaLivros = new Stack<string>();
      // pilhaLivros.Push(".NET");
      // pilhaLivros.Push("DDD");
      // pilhaLivros.Push("Código Limpo");
      // System.Console.WriteLine($"Livros para a leitura {pilhaLivros.Count}");
      // while(pilhaLivros.Count > 0)
      // {
      //   System.Console.WriteLine($"Próximo livro para leitura: {pilhaLivros.Peek()}");
      //   System.Console.WriteLine($"{pilhaLivros.Pop()} Lido com sucesso");
      // }
      // System.Console.WriteLine($"Livros para a leitura {pilhaLivros.Count}");

      //Trabalhando com filas (Queue)
      // Queue<string> fila = new Queue<string>();
      // fila.Enqueue("Leonardo");
      // fila.Enqueue("Eduardo");
      // fila.Enqueue("André");
      // System.Console.WriteLine($"Pessoas na fila: {fila.Count}");
      // while (fila.Count > 0)
      // {
      //   System.Console.WriteLine($"Vez de: {fila.Peek()}");
      //   System.Console.WriteLine($"{fila.Dequeue()} atendido");
      // }
      // System.Console.WriteLine($"Pessoas na fila: {fila.Count}");


      // Adicionando coleções na lista
      // OperacoesLista oplista = new OperacoesLista();
      // List<string> estados = new List<string> { "SP", "MG", "BA" };
      // string[] estadosArray = new string[2] { "SC", "MT" };
      // System.Console.WriteLine($"Quantidade de elementos na lista: {estados.Count}");
      // oplista.ImprimirListaString(estados);
      // estados.AddRange(estadosArray);
      // adicionando elementos por indice
      // estados.Insert(1, "RJ");
      // oplista.ImprimirListaString(estados);

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