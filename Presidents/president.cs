using System;

namespace cod
{
    public class president
    {
        Random generator = new Random();

        public string name;
        public int environmentPriority;
        public int defensePriority;
        public int healthcarePriority;
        public int corruption;
        public int money;

        public president()
        {
            environmentPriority = generator.Next(100);
            defensePriority = generator.Next(100);
            healthcarePriority = generator.Next(100);
            corruption = generator.Next(100);
            money = generator.Next(100);
        }
    }
    public class legislation
    {
        Random generator = new Random();

        public int legEnvironment;
        public int legDefense;
        public int legHealthcare;

        public legislation()
        {
            legEnvironment = generator.Next(10);
            legDefense = generator.Next(10);
            legHealthcare = generator.Next(10);
        }
    }
    public class country
    {
        Random generator = new Random();

        public int environment;
        public int defense;
        public int healthcare;
        public country()
        {
            environment = generator.Next(100);
            defense = generator.Next(100);
            healthcare = generator.Next(100);
        }
    }
}