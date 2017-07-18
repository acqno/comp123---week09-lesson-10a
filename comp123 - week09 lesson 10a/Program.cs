﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Alvin Quijano
 * Date: July 11, 2017
 * Description: This is the driver class for my project
 * Version: 0.2 - instantiated two objects of type SuperHero and SuperVillain
 */

namespace comp123___week09_lesson_10a
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperHuman superhuman = new SuperHuman("super dude");
            superhuman.AddPower("Spider Climbing", 50);
            superhuman.AddPower("Webcasting", 40);
            Console.WriteLine(superhuman.ToString());

            SuperHero hero1 = new SuperHero("Captain America", 100);
            hero1.AddPower("Shield", 40);
            hero1.AddPower("Super Strength", 30);
            Console.WriteLine(hero1.ToString());
            Console.WriteLine("Karma: " + hero1.Karma);

            SuperVillain villain1 = new SuperVillain("Thanos", 9999);
            villain1.AddPower("Infinity Gauntlet", 99);
            villain1.AddPower("evil", 20);
            Console.WriteLine(villain1.ToString());
            Console.WriteLine("Malice: " + villain1.Malice);

            if (hero1 is IHasMalice)
            {
                Console.WriteLine(hero1.Name + " is definitely a super hero");
            }
            else
            {
                Console.WriteLine(hero1.Name + " is not a super villain");
            }

            Console.WriteLine(villain1.GetPowerRank("Infinity Gauntlet"));
        }
    }
}
