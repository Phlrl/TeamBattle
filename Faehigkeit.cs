using System.Security.Cryptography.X509Certificates;

namespace TeamBattle
{
    public abstract class Faehigkeit
    {
        protected int Schaden = 0; 
    }

    class Heilen:Faehigkeit
    {
        int Lebenspunkte = 100;
        public Heilen()
        {
               hpGainBack();
        }
        public void hpGainBack()
        {
            Lebenspunkte = Lebenspunkte + 30;
        }
    }

    class StarkerAngriff : Faehigkeit
    {
        public StarkerAngriff()
        {
            
        }
    }

    class Schnelligkeit : Faehigkeit
    {
        public Schnelligkeit()
        {
            
        }
    }
}