using System;

namespace Dio.Series
{
class Program
{
  static SerieRepositorio repositorio = new SerieRepositorio();
  static void Main(string[] args)
  {
    string opcaoUsuario = ObterOpcaoUsuario();
    
    while(opcaoUsuario.ToUpper() != "X")
    {
      switch (opcaoUsuario)
      {
        case "1":
          ListarSeries();
         break;
        case "2":
          InserirSerie();
          break;
        case "3":
          AtualizarSerie();
          break;
        case "4":
          ExcluirSerie();
          break;
        case "5":
          VisualizarSerie();
          break;
        case "C":
          Console.Clear();
          break;
        
        default:
          throw new ArgumentOutOfRangeException();
      }

      opcaoUsuario = ObterOpcaoUsuario();
    } 
    System.Console.WriteLine("Obrigado por utilizar nossos serviços");
    System.Console.ReadLine();   
  }

  private static void AtualizarSerie()
  {
    System.Console.WriteLine("Digite o Id da série: ");
    int indiceSerie = int.Parse(Console.ReadLine());
    foreach(int i in Enum.GetValues(typeof(Genero)))
    {
      System.Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
    }
    System.Console.WriteLine("Digite o gênero entre as opções acima: ");
    int entradaGenero = int.Parse(Console.ReadLine());
    
    System.Console.WriteLine("Digite o Título da Série: ");
    string entradaTitulo = Console.ReadLine();

    System.Console.WriteLine("Digite o Ano de inicio da Série: ");
    int entradaAno = int.Parse(Console.ReadLine());

    System.Console.WriteLine("Digite a descrição da Série: ");
    string entradaDescricao = Console.ReadLine();

    Serie AtualizarSerie = new Serie(id: indiceSerie,
                                genero: (Genero)entradaGenero,
                                titulo: entradaTitulo,
                                ano: entradaAno,
                                descricao: entradaDescricao);
    repositorio.Atualizar(indiceSerie, AtualizarSerie);
  }
  private static void ListarSeries()
    {
      System.Console.WriteLine("Listar séries");
      var lista = repositorio.Lista();
      if (lista.Count == 0)
      {
        System.Console.WriteLine("Nenhuma série cadastrada");
        return;
      }
      foreach (var serie in lista)
      {
        var excluido  = serie.retornaExcluido();
        
          System.Console.WriteLine("#ID {0}: - {1} - {2}", serie.retornaId(), serie.retornaTitulo(), (excluido ? "Excluido" : ""));
      }
    }
  private static void InserirSerie()
  {
    System.Console.WriteLine("Inserir nova série");
    foreach(int i in Enum.GetValues(typeof(Genero)))
    {
      System.Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
    }
    System.Console.WriteLine("Digite o gênero entre as opções acima: ");
    int entradaGenero = int.Parse(Console.ReadLine());
    
    System.Console.WriteLine("Digite o Título da Série: ");
    string entradaTitulo = Console.ReadLine();

    System.Console.WriteLine("Digite o Ano de inicio da Série: ");
    int entradaAno = int.Parse(Console.ReadLine());

    System.Console.WriteLine("Digite a descrição da Série: ");
    string entradaDescricao = Console.ReadLine();

    Serie novaSerie = new Serie(id: repositorio.ProximoId(),
                                genero: (Genero)entradaGenero,
                                titulo: entradaTitulo,
                                ano: entradaAno,
                                descricao: entradaDescricao);
    repositorio.Insere(novaSerie);
  }
  private static void ExcluirSerie()
  {
    System.Console.WriteLine("Digite o Id da série: ");
    int indiceSerie = int.Parse(System.Console.ReadLine());
    repositorio.Exclui(indiceSerie);
  }
  private static void VisualizarSerie()
  {
    System.Console.WriteLine("Digite o id da Série: ");
    int indiceSerie = int.Parse(Console.ReadLine());
    var serie = repositorio.RetornaPorId(indiceSerie);
    System.Console.WriteLine(serie);
  }

  private static string ObterOpcaoUsuario()
  {
    System.Console.WriteLine();
    System.Console.WriteLine("Dio Séries ao seu dispor!");
    System.Console.WriteLine("informe a opção desejada: ");

    System.Console.WriteLine("1- Listar séries");
    System.Console.WriteLine("2- Inserir nova série");
    System.Console.WriteLine("3- Atualizar série");
    System.Console.WriteLine("4- Excluir série");
    System.Console.WriteLine("5- Visualizar séries");
    System.Console.WriteLine("C- Limpar tela");
    System.Console.WriteLine("X- Sair");
    System.Console.WriteLine();

    string opcaoUsuario = Console.ReadLine().ToUpper();
    System.Console.WriteLine();
    return opcaoUsuario;
  }

}
}
