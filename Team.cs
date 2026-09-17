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

        public bool areAllPlayersAlive()
        {
            foreach (var s in TeamListe)
            {
                if(s.getLebenspunkte() == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public int PlayerAlive()
        {
            int lebendigeSpieler = 0;
            foreach (var s in TeamListe)
            {
                if (s.getLebenspunkte() != 0)
                {
                    lebendigeSpieler ++;
                }
            }
            return lebendigeSpieler;
        }
    }
}

