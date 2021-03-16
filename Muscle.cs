using System;

namespace HeistPartII
{
    public class Muscle : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }
        public string Speciality { get; set; }

        public void PerformSkil(Bank bank)
        {

            bank.VaultScore -= SkillLevel;
            int adjustedScore = bank.VaultScore - SkillLevel;
            if (adjustedScore > 0)
            {

            Console.Write($"{Name} went in guns blazing. Decreased vault difficulty by {SkillLevel}.");
            }
            else 
            {
                Console.WriteLine($"{Name} took out all the guards!");
            }
        }


    }
}