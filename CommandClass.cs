namespace Commandos.Program
{
    public class Commando
    {
        private string Name { get; set; }
        public string CodeName { get; set; }
        public string[] Tools { get; } = new string[] { "Hammer", "Chisel", "Rope", "Bag", "Canteen" };
        public string Status { get; set; }

        public Commando(string name, string codeName)
        {
            Name = name;
            CodeName = codeName;
            Status = "Ready";
        }

        public void Walk()
        {
            Status = "Walking";
            Console.WriteLine($"{Name} is walking.");
        }

        public void Hide()
        {
            Status = "Hiding";
            Console.WriteLine($"{Name} is hiding.");
        }

        public void Attack()
        {
            Status = "Attacking";
            Console.WriteLine($"The commando with code name {CodeName} is attacking.");
        }

        public void SayName(string commanderRank)
        {
            switch (commanderRank)
            {
                case "GENERAL":
                    Console.WriteLine($"name: {Name}");
                    break;
                case "COLONEL":
                    Console.WriteLine($"cade name: {CodeName}");
                    break;
                default:
                    Console.WriteLine("Invalid rank. Cannot display name or code name.");
                    break;
            }
        }
    }

    public class AirCommando : Commando
    {
        public AirCommando(string name, string codeName) : base(name, codeName) { }

        public void Parachute()
        {
            Status = "Parachuting";
            Console.WriteLine("is parachuting from the sky!");
        }
    }

    public class SeaCommando : Commando
    {
        public SeaCommando(string name, string codeName) : base(name, codeName) { }

        public void Swim()
        {
            Status = "Swimming";
            Console.WriteLine("is swimming through the water!");
        }
    }
}