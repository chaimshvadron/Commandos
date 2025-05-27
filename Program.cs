namespace Commandos.Program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            AirCommando airCommando = new AirCommando("Mike", "SkyWalker");

            SeaCommando seaCommando = new SeaCommando("John", "WaveRider");

            List<Commando> commandos = new List<Commando>
            {
                airCommando,
                seaCommando
            };

            foreach (var commando in commandos)
            {
                commando.Attack();
            }

        }
    }
}