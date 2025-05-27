namespace Commandos.Program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            AirCommando airCommando = new AirCommando("Mike", "SkyWalker");
            airCommando.Attack();

            SeaCommando seaCommando = new SeaCommando("John", "WaveRider");
            seaCommando.Attack();

            List<Commando> commandos = new List<Commando>
            {
                airCommando,
                seaCommando
            };

            foreach (var commando in commandos)
            {
                commando.SayName("GENERAL");
            }

        }
    }
}