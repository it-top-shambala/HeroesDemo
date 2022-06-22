namespace HeroesDemo.Lib.Weapons; 

public abstract class Weapon {
    public int Damage { get; }
    public string Name { get; }

    protected Weapon(string name, int damage)
    {
        this.Name = name;
        this.Damage = damage;
    }
}
