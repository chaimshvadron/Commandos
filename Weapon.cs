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

    public class M16 : IWeapon, IShootable
    {
        public string Name { get; } = "M16";
        public string Manufacturer { get; } = "COLT";
        public int Bullets { get; set; } = 29;

        public void Shoot()
        {
            if (Bullets > 0)
            {
                Bullets--;
                Console.WriteLine($"{Name} shoots! Bullets left: {Bullets}");
            }
            else
            {
                Console.WriteLine($"{Name} is out of bullets!");
            }
        }
    }

    public class AK47 : IWeapon, IShootable
    {
        public string Name { get; } = "AK-47";
        public string Manufacturer { get; } = "Kalashnikov";
        public int Bullets { get; set; } = 30;

        public void Shoot()
        {
            if (Bullets > 0)
            {
                Bullets--;
                Console.WriteLine($"{Name} shoots! Bullets left: {Bullets}");
            }
            else
            {
                Console.WriteLine($"{Name} is out of bullets!");
            }
        }
    }

    public class Stone : IWeapon, IBreakable
    {
        public string Name { get; } = "Stone";
        public string Manufacturer { get; } = "Nature";
        public string Status { get; set; } = "Intact";
        public int MaxHits { get; } = 5;
        public int CurrentHits { get; set; } = 0;

        public void Hit()
        {
            CurrentHits++;
            if (CurrentHits >= MaxHits)
            {
                Status = "Broken";
            }
            Console.WriteLine($"{Name} hit! Status: {Status} ({CurrentHits}/{MaxHits})");
        }
    }




}