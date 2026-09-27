namespace TeamBattle
{
    public abstract class Waffe
    {
         protected int WaffenSchaden = 0; 
         protected string WeaponName;
    }
    class Pistole:Waffe
    {
        
        public Pistole()
        {
            WeaponName = "Pistol";
            WaffenSchaden = 20;
        }
    }

    class Gewehr : Waffe
    {
        public Gewehr()
        {
            WeaponName = "Rifle";
            WaffenSchaden = 30;
        }
    }

    class Schrotflinte : Waffe
    {
        public Schrotflinte()
        {
            WeaponName = "Shotgun";
            WaffenSchaden = 40;
        }
    }
}