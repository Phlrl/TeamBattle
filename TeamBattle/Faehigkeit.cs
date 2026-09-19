namespace TeamBattle
{
    public abstract class Faehigkeit:Waffe
    {
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
        protected int Schaden = 0; 

        public StarkerAngriff()
        {
            WaffenSchaden = WaffenSchaden + 20;
        }   

    }

    class Schnelligkeit : Faehigkeit
    {
        public Schnelligkeit()
        {
            
        }
    }
}