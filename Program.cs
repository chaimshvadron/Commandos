namespace Commandos.Program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Commando commando = new Commando("John", "EagleEye");
            Console.WriteLine($"Commando Name: {commando.Name}");
            Console.WriteLine($"Commando Code Name: {commando.CodeName}");

            Console.WriteLine("Commando Tools:");
            foreach (var tool in commando.Tools)
            {
                Console.WriteLine($"- {tool}");
            }
        }
    }
}