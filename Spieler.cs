using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

namespace TeamBattle
{
    public class Spieler
    {
        private string PlayerName;
        private int Lebenspunkte = 100;
        private Faehigkeit faehigkeit;
        private Waffe waffe;
        public int getLebenspunkte()
        {
            return Lebenspunkte;
        }

        public void Attack(Spieler target)
        {   
            
        }

        public void takeDamage(int Schaden)
        {
            Lebenspunkte = Lebenspunkte - Schaden;
        }

        public void useFaehigkeit()
        {
                   
        }

    }
}