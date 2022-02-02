namespace SolidHountedHouse
{
    public class Guest
    {
        public int healthLevel = 100;
        public int scaredLevel = 0;
        public int energyLevel = 100;
        string name;

        public Guest(string name)
        {
            this.name = name;
        }
    }
}