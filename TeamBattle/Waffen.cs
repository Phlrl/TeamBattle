namespace TeamBattle
{
    public abstract class Waffe
    {
         protected int Schaden = 0; 
         protected string WeaponName;
    }
    class Pistole:Waffe
    {
        
        public Pistole()
        {
            WeaponName = "Pistol";
            Schaden = 20;
        }
    }

    class Gewehr : Waffe
    {
        public Gewehr()
        {
            WeaponName = "Rifle";
            Schaden = 30;
        }
    }

    class Schrotflinte : Waffe
    {
        public Schrotflinte()
        {
            WeaponName = "Shotgun";
            Schaden = 40;
        }
    }
}