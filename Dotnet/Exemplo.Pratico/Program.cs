using System;
namespace ExemploPratico
{
  class Program
  {
    static void Main(string[] args)
    {
      Aluno[] alunos = new Aluno [5];
      var indiceAluno = 0;

      string opcaoUsuario = ObterOpcaoUsuario();

      while (opcaoUsuario.ToUpper() != "X")
      {
        switch (opcaoUsuario)
        {
          case "1":
            Console.WriteLine("Informe o nome do aluno:");
            Aluno aluno = new Aluno();
            aluno.Nome = Console.ReadLine();

            Console.WriteLine("Informe a nota do aluno:");
            
            if (decimal.TryParse(Console.ReadLine(), out decimal nota))
            {
              aluno.Nota = nota;
            }
            else
            {
              throw new ArgumentException("Valor da nota deve ser em decimal");
            }
            
            alunos[indiceAluno] = aluno;
            indiceAluno++;

            break;
          case "2":
            foreach(var a in alunos)
            {
              if (!string.IsNullOrEmpty(a.Nome))
                {
                Console.WriteLine($"ALUNO: {a.Nome} - NOTA: {a.Nota}");
                }
            }
            break;
          case "3":
            decimal notaTotal = 0; 
            var nAlunos = 0;

            for (int i=0; i < alunos.Length; i++)
            { 
              if(!string.IsNullOrEmpty(alunos[i].Nome))
              {
                notaTotal = notaTotal + alunos[i].Nota;
                nAlunos++;
              }
            }

            var mediaGeral = notaTotal / nAlunos;
            Conceito  conceitoGeral;

            if (mediaGeral < 2)
            {
              conceitoGeral = Conceito.E;
            }
            else if (mediaGeral < 4)
            {
              conceitoGeral = Conceito.D;
            }
            else if (mediaGeral < 6)
            {
              conceitoGeral = Conceito.C;
            }
            else if (mediaGeral < 8)
            {
              conceitoGeral = Conceito.B;
            }
            else
            {
              conceitoGeral = Conceito.A;
            }

            Console.WriteLine($"Media Geral: {mediaGeral} - Conceito: {conceitoGeral}");

            break;
          default:
            throw new ArgumentOutOfRangeException();
        }
        
        opcaoUsuario = ObterOpcaoUsuario();
      }
    }

    private static string ObterOpcaoUsuario()
    {
      Console.WriteLine();
      Console.WriteLine("informe a opção desejada:");
      Console.WriteLine("1- inserir novo aluno");
      Console.WriteLine("2- listar alunos");
      Console.WriteLine("3- Calcular média geral");
      Console.WriteLine("X- Sair");
      Console.WriteLine();


      string opcaoUsuario = Console.ReadLine();
      Console.WriteLine();
      return opcaoUsuario;
    }
  }
}