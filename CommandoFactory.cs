namespace Commandos.Program
{
        public class CommandoFactory
    {
        private static List<Commando> commandos = new List<Commando>();

        public static Commando CreateCommando(string name, string codeName)

        {
            Console.WriteLine("What commando are you creating? (simple, air, sea)");
            Console.WriteLine($"The details of the created soldier: name: {name} codeName: {codeName}");
            string type = Console.ReadLine()!.ToLower();
            Commando commando;
            switch (type)
            {
                case "simple":
                    commando = new Commando(name, codeName);
                    break;
                case "air":
                    commando = new AirCommando(name, codeName);
                    break;
                case "sea":
                    commando = new SeaCommando(name, codeName);
                    break;
                default:
                    Console.WriteLine("Invalid commando type. Creating a simple commando.");
                    commando = new Commando(name, codeName);
                    break;
            }
            commandos.Add(commando);
            return commando;
        }
    }
}