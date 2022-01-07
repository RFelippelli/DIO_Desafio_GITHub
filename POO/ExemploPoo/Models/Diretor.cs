namespace ExemploPoo.Models
{
    public class Diretor : professor
    {
        public override void Apresentar()
        {
            Console.WriteLine($"Diretor");
        }
    }
}