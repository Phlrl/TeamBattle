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

        public void setLebenspunkte(int L)
        {
            Lebenspunkte = L;
        }

        public static bool Attack(Spieler target, int damage, List<Spieler> TargetPlayer)
        {
            foreach (var s in TargetPlayer)
            {
                if (s == target)
                {
                    s.takeDamage(damage);
                    return true;
                }
            }

            return false;
        }

        public void takeDamage(int Schaden)
        {
            Lebenspunkte = Lebenspunkte - Schaden;
        }

        public bool avoidAttack(List<Spieler> TargetPlayer)
        {
            foreach (var s in TargetPlayer)
            {
                if (s == this)
                {
                    return true;
                }
            }

            return false;
        }

        public void useFaehigkeit()
        {
            
        }
    }
}