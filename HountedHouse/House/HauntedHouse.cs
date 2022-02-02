using System;
using System.Collections.Generic;

namespace SolidHountedHouse
{
    public class HauntedHouse
    {
        private List<Guest> guestList;
        private readonly List<BaseMonster> monsters;
        private readonly Random random;

        public HauntedHouse(List<Guest> guestList, List<BaseMonster> monsters, Random random)
        {
            this.guestList = guestList;
            this.monsters = monsters;
            this.random = random;
        }

        public void StartHaunting()
        {
            // each guest should be scared by a random monster selected from the monsterList
            // if it gets too scary for a guest, remove the guest from the list
        }
    }
}
