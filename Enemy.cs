namespace Commandos.Program
{
    public class Enemy
    {
        public string Name { get; set; }
        public int LivePoint { get; set; }
        public bool Alive { get; set; }
        public string Shout { get; set; }

        public Enemy(string name)
        {
            Name = name;
            LivePoint = 100;
            Alive = true;
            Shout = "Enemy spotted!";
        }
    }
}