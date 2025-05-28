namespace Commandos.Program
{
    public class Enemy
    {
        public string Name { get; set; }
        public int Live { get; set; }
        public string Status { get; set; }
        public string Shout { get; set; }

        public Enemy(string name)
        {
            Name = name;
            Live = 100;
            Status = "Alive";
            Shout = "Enemy spotted!";
        }
    }
}