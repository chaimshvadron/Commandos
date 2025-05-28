namespace Commandos.Program
{
    public class Game
    {
        public static void Start()
        {
            List<string> commandorNames = new List<string>
            {
                "Shadow Wolf", "Iron Hawk", "Blaze Viper", "Ghost Falcon", "Steel Panther",
                "Thunder Fox", "Night Eagle", "Crimson Bear", "Frost Tiger", "Storm Lion",
                "Raven Blade", "Viper Strike", "Falcon Eye", "Wolf Claw", "Panther Fang",
                "Eagle Wing", "Bear Claw", "Tiger Roar", "Lion Heart", "Hawk Talon"
            };


            List<string> codeName = new List<string>
            {
                "The Shadow", "The Hawk", "The Cheetah", "The Scorpion", "The Panther",
                "The Wolf", "The Tiger", "The Eagle", "The Raven", "The Snake",
                "The Bear", "The Lion", "The White Hawk", "The Black Panther", "The Golden Eagle",
                "The Lone Wolf", "The Flying Tiger", "The Night Raven", "The Swift Cheetah", "The Red Scorpion"
            };


            List<string> enemyNames = new List<string>
            {
                "Venom Cobra", "Iron Jackal", "Shadow Mamba", "Crimson Vulture", "Steel Hyena",
                "Thunder Serpent", "Night Scorpion", "Frost Wasp", "Storm Spider", "Raven Fang",
                "Viper Ghost", "Falcon Shade", "Wolf Bane", "Panther Claw", "Eagle Doom",
                "Bear Mauler", "Tiger Slash", "Lion Fangs", "Hawk Reaper", "Coyote Blaze"
            };

            Console.WriteLine("Welcome to the Commando Game!");
            Console.WriteLine("How many soldiers do you want to create?");
            int numberOfCommandos;
            while (!int.TryParse(Console.ReadLine(), out numberOfCommandos) || numberOfCommandos <= 0)
            {
                Console.WriteLine("Please enter a valid number greater than 0.");
            }

            for (int i = 0; i < numberOfCommandos; i++)
            {
                string name = commandorNames[new Random().Next(commandorNames.Count)];
                string codeNameValue = codeName[new Random().Next(codeName.Count)];
                Commando commando = CommandoFactory.CreateCommando(name, codeNameValue);
            }

            Console.WriteLine("How many enemies do you want to create?");
            int numberOfEnemies;
            while (!int.TryParse(Console.ReadLine(), out numberOfEnemies) || numberOfEnemies <= 0)
            {
                Console.WriteLine("Please enter a valid number greater than 0.");
            }

            for (int i = 0; i < numberOfEnemies; i++)
            {
                string enemyName = enemyNames[new Random().Next(enemyNames.Count)];
                EnemyFactory.CreateEnemy(enemyName);
                
            }

        }
    }
}