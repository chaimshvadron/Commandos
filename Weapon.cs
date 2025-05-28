namespace Commandos.Program
{
    public class Weapon
    {
        public string name;
        public string maker;
        public int numberOfBullets;

        public Weapon(string name, string maker, int numberOfBullets)
        {
            this.name = name;
            this.maker = maker;
            this.numberOfBullets = numberOfBullets;
        }

        public void Shoot()
        {
            numberOfBullets--;
            System.Console.WriteLine($"{name} made by {maker} is shooting. Bullets left: {numberOfBullets}");
        }

    }

    class Stone
    {
        
    }
}