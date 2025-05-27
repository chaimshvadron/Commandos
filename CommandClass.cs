namespace Commandos.Program
{
    public class Commando
    {
        public string Name { get; set; }
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
    }
}