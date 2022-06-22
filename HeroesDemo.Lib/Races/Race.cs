using HeroesDemo.Lib.Weapons;

namespace HeroesDemo.Lib.Races; 

public abstract class Race {
    #region NAME

    /*
    * private readonly string _name;
    * public string Name { get => this._name; }
    */
    public string Name { get; }

    #endregion

    #region HEALTH & DAMAGE

    public int Damage { get; set; }
    
    private int _health;
    public int Health {
        get => this._health;
        set => this._health = value <= 0 ? 0 : value;
    }

    /*
     * public bool IsDeath()
     *   {
     *       if(this._health == 0) {
     *           return true;
     *       } else {
     *           return false;
     *       }
     *   }
     */
    // public bool IsDeath() => this._health == 0;
    public bool IsDeath { get => this._health == 0; }

    #endregion

    #region RATES

    public int RateDamage { get; set; }
    public int RateHealth { get; set; }

    #endregion

    #region WEAPON

    private Weapon _weapon;
    public Weapon Weapon {
        get => this._weapon;
        set {
            this._weapon = value;
            this.Damage = this._weapon.Damage + this.RateDamage;
        }
    }

    #endregion

    #region CONSTRUCTORS

    protected Race(string name, Weapon weapon)
    {
        this.Name = name;
        this.Weapon = weapon;

        this.Health = 100;
    }

    #endregion

    #region ATTACK

    public void Attack(Race enemy) => enemy.Health -= this.Damage;

    #endregion
}
