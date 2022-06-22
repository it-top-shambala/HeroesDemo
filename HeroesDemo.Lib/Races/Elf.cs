using HeroesDemo.Lib.Weapons;

namespace HeroesDemo.Lib.Races; 

public class Elf : Race {
    private const int RATE_DAMAGE = 0;
    private const int RATE_HEALTH = 10;
    
    public Elf(string name, Weapon weapon) : base(name, weapon)
    {
        this.RateDamage = RATE_DAMAGE;
        this.RateHealth = RATE_HEALTH;

        this.Damage = weapon.Damage + this.RateDamage;
        this.Health += this.RateHealth;
    }
}
