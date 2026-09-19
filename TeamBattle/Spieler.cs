using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace TeamBattle
{
    public class Spieler
    {
        private string PlayerName;
        private int Lebenspunkte = 100;
        private Faehigkeit faehigkeit;
        private Waffe waffe;
        public List<Spieler> TargetPlayer = new List<Spieler>();
        public int getLebenspunkte()
        {
            return Lebenspunkte;
        }

        public void setLebenspunkte(int L)
        {
            Lebenspunkte = L;
        }

        public bool attack(Spieler target, int damage)
        {   

            foreach (var s in TargetPlayer)
            {
                if(s = target)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }

        public void takeDamage(int Schaden)
        {
            Lebenspunkte = Lebenspunkte - Schaden;
        }
        
        public bool avoidAttack()
        {
            if (Spieler = )
            {
                return true;
            }
        }
        public void useFaehigkeit()
        {
            
        }
    }
}