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

        public int Attack(Spieler target, int damage)
        {   
            return 0;
        }

        public void takeDamage(int Schaden)
        {
            Lebenspunkte = Lebenspunkte - Schaden;
        }
        
        public void avoidAttack()
        {
            
        }
        public void useFaehigkeit()
        {
                   
        }

    }
}