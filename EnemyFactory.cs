namespace Commandos.Program
{   
    class EnemyFactory
    {
        private static List<Enemy> enemies = new List<Enemy>();
        public static Enemy CreateEnemy(string name)
        {
            Console.WriteLine($"Creating enemy: {name}");
            Enemy enemy = new Enemy(name);
            enemies.Add(enemy);
            return enemy;
        }
    }
}