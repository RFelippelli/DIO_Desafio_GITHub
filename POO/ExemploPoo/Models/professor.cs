namespace ExemploPoo.Models
{
    public class professor : Pessoa
    {
        public double Salario {get; set;}

        public override void Apresentar()
        {
            Console.WriteLine($"Olá meu nome é {Nome} e tenho {Idade} anos, meu numero de funcionario é {Documento} e meu salário é {Salario}");
        }
    }
}