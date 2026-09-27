namespace TeamBattle
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Spieler> alleSpieler = new List<Spieler>();

            Spieler spieler1 = new Spieler();
            Spieler spieler2 = new Spieler();
            Spieler spieler3 = new Spieler();

            alleSpieler.Add(spieler1);
            alleSpieler.Add(spieler2);
            alleSpieler.Add(spieler3);
        }
    }
}