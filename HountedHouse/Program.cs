using System;
using System.Collections.Generic;
using SolidHountedHouse.House;

namespace HountedHouse
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Guest> guests = new List<Guest>();
            guests.Add(new Guest("Mary"));

            List<BaseMonster> monsters = new List<BaseMonster>();
            BaseMonster monster = new BaseMonster(MonsterType.DEMON);
            monsters.Add(monster);

            HauntedHouse hauntedHouse = new HauntedHouse(guests, monsters, new Random());

            hauntedHouse.StartHaunting();
        }
    }
}
