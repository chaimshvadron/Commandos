namespace Commandos.Program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Commando commando = new Commando("John", "EagleEye");
            commando.Name = "Jsdsdsd";
            Console.WriteLine($"Commando Name: {commando.Name}");
            Console.WriteLine($"Commando Code Name: {commando.CodeName}");
        }
    }
}