namespace HeroesDemo.Lib.Weapons; 

public class Staff : Weapon {
    private static int s_damage = 15;
    private static string s_name = "Staff";
    
    public Staff() : base(s_name, s_damage) { }
}
