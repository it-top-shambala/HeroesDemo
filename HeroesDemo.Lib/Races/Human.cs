using HeroesDemo.Lib.Weapons;

namespace HeroesDemo.Lib.Races;

public class Human : Race {
    private const int RATE_DAMAGE = 10;
    private const int RATE_HEALTH = 0;

    public Human(string name, Weapon weapon) : base(name, weapon)
    {
        this.RateDamage = RATE_DAMAGE;
        this.RateHealth = RATE_HEALTH;

        this.Damage = weapon.Damage + this.RateDamage;
        this.Health += this.RateHealth;
    }
}
