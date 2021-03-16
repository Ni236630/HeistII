using System;
namespace HeistPartII
{
    public class LockSpecialist : IRobber
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
                Console.Write($"{Name} attempted to pick the vault. Decreased vault difficulty by {SkillLevel}.");
            }
            else 
            {
                Console.WriteLine($"{Name} successfully picked the lock!");
            }
        }
    }
}