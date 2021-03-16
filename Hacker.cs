using System;

namespace HeistPartII
{
    public class Hacker : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }
        public string Speciality { get; set; }

        public void PerformSkil(Bank bank)
        {

            bank.AlarmScore -= SkillLevel;
            int adjustedScore = bank.VaultScore - SkillLevel;
            if( adjustedScore > 0)
            {                
                Console.Write($"{Name} attempted to disarm the alarm. Decreased security by {SkillLevel}.");
            }
            else 
            {
                Console.WriteLine($"{Name} successfully hacke the security for the bank!");
            }
        }


    }
}