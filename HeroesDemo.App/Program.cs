using HeroesDemo.Lib.Races;
using HeroesDemo.Lib.Weapons;

namespace HeroesDemo.App
{
    public enum TypeHero {
        Human, Elf, Unknown
    }
    
    internal static class Program
    {
        static void Main()
        {
            Console.WriteLine("Типы персонажей:");
            Console.WriteLine("1. Человек (бонус к атаке)");
            Console.WriteLine("2. Эльф (бонус к здоровью)");
            Console.Write("Введите номер типа персонажа - ");
            var select = Console.ReadLine();
            
            Console.Write("Введите имя - ");
            var name = Console.ReadLine();

            TypeHero typeHero;
            TypeHero typeEnemy;
            switch(select) {
                case "1":
                    typeHero = TypeHero.Human;
                    typeEnemy = TypeHero.Elf;
                    break;
                case "2":
                    typeHero = TypeHero.Elf;
                    typeEnemy = TypeHero.Human;
                    break;
                default:
                    typeHero = TypeHero.Unknown;
                    typeEnemy = TypeHero.Unknown;
                    break;
            }

            Race hero;
            Race enemy;
            hero = CreateHero(typeHero, name);
            enemy = CreateHero(typeEnemy, "enemy");
            
            ShowHeroInfo(hero);
            ShowHeroInfo(enemy);
            Console.WriteLine($"{hero.Name} урон = {hero.Damage}");
            Console.WriteLine($"{enemy.Name} урон = {enemy.Damage}");

            do {
                hero.Attack(enemy);
                Console.WriteLine($"{hero.Name} атакует {enemy.Name}");
                enemy.Attack(hero);
                Console.WriteLine($"{enemy.Name} атакует {hero.Name}");
            
                ShowHeroInfo(hero);
                ShowHeroInfo(enemy);

                hero.Weapon = new Staff();
                enemy.Weapon = new Staff();
                
                Console.WriteLine($"{hero.Name} сменил оружие. Урон = {hero.Damage}");
                Console.WriteLine($"{enemy.Name} сменил оружие. Урон = {enemy.Damage}");

            } while(!hero.IsDeath && !enemy.IsDeath);

            if(hero.IsDeath) {
                Console.WriteLine($"{enemy.Name} победитель!");
            }

            if(enemy.IsDeath) {
                Console.WriteLine($"{hero.Name} победитель!");
            }
        }
        
        /*
        static Race CreateHero(TypeHero typeHero, string name) =>
            typeHero switch {
                TypeHero.Human => new Human(name, new Axe()),
                TypeHero.Elf => new Elf(name, new Axe()),
                TypeHero.Unknown => throw new ArgumentOutOfRangeException(nameof(typeHero), typeHero, null),
                _ => throw new ArgumentOutOfRangeException(nameof(typeHero), typeHero, null)
            };
        */
        static Race CreateHero(TypeHero typeHero, string name)
        {
            switch(typeHero) {
                case TypeHero.Human:
                    return new Human(name, new Axe());
                case TypeHero.Elf:
                    return new Elf(name, new Axe());
                default:
                    throw new ArgumentOutOfRangeException(nameof(typeHero), typeHero, null);
            }
        }
        

        static void ShowHeroInfo(Race hero) => Console.WriteLine($"NAME: {hero.Name}, HEALTH: {hero.Health}");
    }
}
