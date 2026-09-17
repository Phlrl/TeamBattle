namespace TeamBattle.Tests;

public class TeamTest
{
    [Fact]
    public void TestPlayerAlive()
    {
        Team t = new Team();
        Spieler s = new Spieler();
        s.setLebenspunkte(0); //player dead
        t.addPlayer(s);
        int lebendigeSpieler = t.PlayerAlive();
        Assert.Equal(0, lebendigeSpieler);
    }
    
    [Fact]
    public void TestPlayerAliveOneAlive()
    {
        Team t = new Team();
        Spieler s = new Spieler();
        s.setLebenspunkte(100); 
        t.addPlayer(s);
        int lebendigeSpieler = t.PlayerAlive();
        Assert.Equal(1, lebendigeSpieler);
    }

    [Fact]
    public void TestPlayerAliveOneAliveOneDead()
    {
        Team t = new Team();
        Spieler s = new Spieler();
        s.setLebenspunkte(100); 
        Spieler s1 = new Spieler();
        s1.setLebenspunkte(0); //player dead
        t.addPlayer(s);
        t.addPlayer(s1);
        int lebendigeSpieler = t.PlayerAlive();
        Assert.Equal(1, lebendigeSpieler);
    }
}
