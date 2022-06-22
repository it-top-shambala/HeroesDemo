namespace HeroesDemo.Lib.Weapons; 

public class Axe : Weapon {
    private static int s_damage = 20;
    private static string s_name = "Axe";
    
    public Axe() : base(s_name, s_damage) {}
}
