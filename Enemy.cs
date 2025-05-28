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

    class EnemyFactory
    {
        private static List<Enemy> enemies = new List<Enemy>();
        public static Enemy CreateEnemy(string name)
        {
            Enemy enemy = new Enemy(name);
            enemies.Add(enemy);
            return enemy;
        }
    }
}