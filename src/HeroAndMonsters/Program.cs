using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

namespace HeroAndMonsters;

class HeroAndMonsters
{
   
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        List<string> name = new List<string>() { "Jackson", "Hawk", "John", "Bull", "Monster", "Crocodile", "AntyHero", "MasterValture", "Black Spider", "Hill" };
        Random random = new Random();
        List<Monster> monsters = new List<Monster>();

        Hero newHero = new Hero("Hero", 100, 20, 0);

        for (int i = 0; i < 10; i++)
        {
            monsters.Add(new Monster(
                name[i],
                random.Next(50, 101),  
                random.Next(10, 21),   
                random.Next(0, 11)     
            ));
        }

        foreach (var monster in monsters)
        {
            Console.WriteLine($"Бой: {newHero.Name} against {monster.Name}");
            newHero.Fight(monster);
            if (newHero.IsDefeated())
            {
                Console.WriteLine($"{newHero.Name} was defeated.");
                break;
            }
            else if (monster.IsDefeated())
            {
                Console.WriteLine($"{monster.Name} defeated. {newHero.Name} is winner!");
            }
        }



    }
}