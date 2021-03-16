using System;
using System.Collections.Generic;

namespace HeistPartII
{
    class Program
    {
        static void Main(string[] args)
        {

            List<IRobber> rolodex = new List<IRobber>();


            LockSpecialist Rob = new LockSpecialist()
            {
                Name = "Rob",
                SkillLevel = 20,
                PercentageCut = 25,
            };
            LockSpecialist Billy = new LockSpecialist()
            {
                Name = "Billy",
                SkillLevel = 25,
                PercentageCut = 30,
            };
            Hacker Kyle = new Hacker()
            {
                Name = "Kyle",
                SkillLevel = 45,
                PercentageCut = 35,
            };
            Hacker Heath = new Hacker()
            {
                Name = "Heath",
                SkillLevel = 15,
                PercentageCut = 5,
            };
            Muscle Blaze = new Muscle()
            {
                Name = "Blaze",
                SkillLevel = 55,
                PercentageCut = 40,
            };
            Muscle Lazor = new Muscle()
            {
                Name = "Laz",
                SkillLevel = 35,
                PercentageCut = 35,
            };

            rolodex.Add(Rob);
            rolodex.Add(Billy);
            rolodex.Add(Kyle);
            rolodex.Add(Heath);
            rolodex.Add(Blaze);
            rolodex.Add(Lazor);

            // beginning of the program for a user
            Console.WriteLine("Advanced Heist Planner 2k21");
            Console.WriteLine($@"Here you'll be able to customize your crew and pick an ideal bank to knock off.
            There are three (3) types of specialists who can join your crew:
            
            Hacker (Disables alarms)
            Muscle (Disarms guards)
            Lock Specialist (cracks vault)
            
            You currently have {rolodex.Count} contacts in your book. Choose wisely. ");

            // Loop through list to show who we have currently 
            int index = 0;
            foreach (IRobber contact in rolodex)
            {
                Console.WriteLine("-------------------");
                Console.WriteLine($@"
                    no. {index}
                    Name: {contact.Name}
                    Speciality: {contact.Speciality}
                    Skill Level: {contact.SkillLevel}
                    Cut of job: {contact.PercentageCut}");
                Console.WriteLine("-------------------");
                index++;
            }
            Console.WriteLine("Lest begin!");

            // User enters loop until empty string is entered
            bool continueLoop = true;

            while (continueLoop != false)
            {

                // User chooses a name for the new contact
                Console.WriteLine("Enter a name of a new contact below.");
                Console.Write(">");

                string newContact = Console.ReadLine().ToUpper();

                // Kill switch for the loop
                if ( newContact == "" )
                    {
                        continueLoop = false;
                        break;
                    }
                    

                // User now selects category for the new contact
                Console.WriteLine($"Alright, based on {newContact}'s skillset, what category would they fit in?");
                Console.WriteLine(@"
            Select a category by entering the corresponding number.

            [1] Hacker (Disables alarms) 
            [2] Muscle (Disarms guards)
            [3] Lock Specialist (cracks vault)");

                Console.Write(">");
                int categorySelection = Int32.Parse(Console.ReadLine());



                // If statement to take user input and create new instance of robber
                if (categorySelection == 1)
                {
                    rolodex.Add(new Hacker()
                    {
                        Name = newContact,
                        SkillLevel = 0,
                        PercentageCut = 0,
                        Speciality = "Hacker"

                    });
                }
                else if (categorySelection == 2)
                {
                    rolodex.Add(new Muscle()
                    {
                        Name = newContact,
                        SkillLevel = 0,
                        PercentageCut = 0,
                        Speciality = "Muscle"
                    });
                }
                else if (categorySelection == 3)
                {
                    rolodex.Add(new LockSpecialist()
                    {
                        Name = newContact,
                        SkillLevel = 0,
                        PercentageCut = 0,
                        Speciality = "Lock Specialist"
                    });
                }

                // User to enter new contact's percentage cut
                Console.WriteLine($"How much skill does {newContact} actually have in his craft?");
                Console.Write(">");
                int skill = Int32.Parse(Console.ReadLine());


                // Adds skill level to skill 
                rolodex[rolodex.Count - 1].SkillLevel = skill;


                // User to enter new contact's percentage cut
                Console.WriteLine($"Let's see.. How much of the total are we wililng to give {newContact}?");
                Console.Write(">");
                int percentage = Int32.Parse(Console.ReadLine());


                // Add percentage to new contact that was created

                rolodex[rolodex.Count - 1].PercentageCut = percentage;


            }
            // Loop through list to show who we have currently 
            foreach (IRobber contact in rolodex)
            {
                Console.WriteLine("-------------------");
                Console.WriteLine($@"
                    Name: {contact.Name}
                    Speciality: {contact.Speciality}
                    Skill Level: {contact.SkillLevel}
                    Cut of job: {contact.PercentageCut}");
                Console.WriteLine("-------------------");
            }
            
            Console.WriteLine("----------------");
            Console.WriteLine("You've checked the white pages and found a bank. Time to check it out.");
            Console.WriteLine("After a quick Recon you have come to find some info.");
            //Create random bank for the heist
            Bank bank = new Bank(){
                AlarmScore = new Random().Next(0, 101),
                CashOnHand = new Random().Next(50000, 1000000),
                VaultScore = new Random().Next(0, 101),
                SecurityGuardScore = new Random().Next(0, 101)

            };

           // Determine which is least secure and most secure
           

        }

    }
}
