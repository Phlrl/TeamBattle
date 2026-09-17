using System.Runtime.CompilerServices;

namespace TeamBattle
{
    public class Teams
    {
        string TeamName;
        List<Spieler>TeamListe = new List<Spieler>();
        

        public void addPlayer(Spieler Player)
        {
            TeamListe.Add(Player);
        }

        public void checkPlayerAlive(List<Spieler> TeamListe)
        {
            int count = 0;
            foreach (var Spieler in TeamListe)
            {
                if (count != 0)
                {
                    Console.WriteLine("Es gibt noch Spieler");
                }

                else
                {
                    Console.WriteLine("Es sind keine Spieler vorhanden");
                }
            }
          
        }

        public int PlayerAlive()
        {
            return ;
        }
    }
}

