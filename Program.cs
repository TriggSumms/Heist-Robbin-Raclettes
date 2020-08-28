using System;
using System.Linq;
using System.Collections.Generic;


namespace heist_robbin_raclettes
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = null;
            Heist heist = new Heist();
            Bank bank = new Bank();
            int successes = 0;
            int failures = 0;
            // bank.Difficulty = 100;


            Console.WriteLine("Plan your Heist!");
            Console.WriteLine("--------------");

            Console.WriteLine("Choose a difficulty Level?");
            int difficulty = Int32.Parse(Console.ReadLine());


            while (name != "")
            {

                Console.WriteLine("Enter the name of the thief");
                name = Console.ReadLine();
                if (name == "") break;
                Console.WriteLine("Enter the skill level of the thief");
                int skillLevel = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter the courage level of the thief (between 0 and 2)");
                double courageLevel = double.Parse(Console.ReadLine());

                // Applying user input to create new thief
                Thief newThief = new Thief()
                {
                    Name = name,
                    SkillLevel = skillLevel,
                    CourageLevel = courageLevel
                };
                // Displaying each theif information
                Console.WriteLine($"{newThief.Name} has skill of {newThief.SkillLevel} and courage of {newThief.CourageLevel}");
                heist.AddThief(newThief);
            }


            Console.WriteLine($"Team complete with {heist.ThiefList.Count()} members");
            Console.WriteLine("******************%&^$?***************");
            Console.WriteLine("Lets speed things up...Input how many times you'd like to dabble with lady luck?");
            int heistAttempts = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < heistAttempts; i++)
            {
                bank.Difficulty = difficulty;
                if (heist.SuccessFactor(bank)) successes++;
                else failures++;
            }

            Console.WriteLine($"You had {successes} successes and {failures} failures.");
            //heist.ThiefRollCall();
            //Console.WriteLine(heist.TotalSkill()); 




        }
    }
}

