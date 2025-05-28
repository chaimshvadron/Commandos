namespace Commandos.Program
{
    public class WeaponFactory
    {
        private static List<Weapon> weapons = new List<Weapon>();

        public static Weapon CreateWeapon(string name, string maker, int numberOfBullets)
        {
            Weapon weapon;
            switch (name.ToLower())
            {
                case "m16":
                    weapon = new M16();
                    break;
                case "ak47":
                case "ak-47":
                    weapon = new AK47();
                    break;
                case "stone":
                    weapon = new Stone();
                    break;
                default:
                    weapon = new Weapon(name, maker, numberOfBullets);
                    break;
            }
            weapons.Add(weapon);
            return weapon;
        }
    }
}