namespace SolidHountedHouse
{
    public class BaseMonster
    {
        MonsterType monsterType;

        public BaseMonster(MonsterType monsterType)
        {
            this.monsterType = monsterType;
        }

        public bool Scare(Guest guest)
        {
            switch (this.monsterType)
            {
                case MonsterType.DEMON:
                    guest.healthLevel -= 10;
                    guest.scaredLevel += 7;
                    break;
                case MonsterType.GHOST:
                    guest.scaredLevel += 33;
                    break;
                case MonsterType.VAMPIRE:
                    guest.energyLevel -= 40;
                    break;
            }

            return guest.scaredLevel > 100 || guest.energyLevel < 25 || guest.healthLevel < 4;
        }

        public MonsterType GetMonsterType()
        {
            return monsterType;
        }
    }
}