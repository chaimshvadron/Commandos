namespace Commandos.Program
{
    public class WeaponFactory
    {
        private static List<Weapon> weapons = new List<Weapon>();

        public static Weapon CreateWeapon(string name, string maker, int numberOfBullets)
        {
            Weapon weapon = new Weapon(name, maker, numberOfBullets);
            weapons.Add(weapon);
            return weapon;
        }
    }
}