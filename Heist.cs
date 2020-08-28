using System;
using System.Collections.Generic;
using System.Linq;

namespace heist_robbin_raclettes
{

    public class Heist
    {
        // Collection of Thieves
        public Dictionary<string, Thief> ThiefList { get; set; }
        // Constructor method to create an instance of a Heist
        public Heist()
        {
            ThiefList = new Dictionary<string, Thief>();
        }
        // Method to add thief to Dictionary
        public void AddThief(Thief aThief)
        {
            ThiefList.Add(aThief.Name, aThief);
        }
        // Displaying a list of Thieves and all of their info
        public void ThiefRollCall()
        {


            Console.WriteLine("\nWho's in on the heist:");
            foreach (KeyValuePair<string, Thief> aThief in ThiefList)
            {
                Console.WriteLine("----------------------");
                Console.WriteLine($"Our Thief: {aThief.Value.Name}");
                Console.WriteLine($"How Wicked Skilled is our Thief: {aThief.Value.SkillLevel}");
                Console.WriteLine($"What's our Thieves Courage Level: {aThief.Value.CourageLevel}");
            }
        }
        // Adding the SkillLevel up on each Thief
        public int TotalSkill()
        {
            return ThiefList.Sum(kvp => kvp.Value.SkillLevel);
        }
        // 
        public bool SuccessFactor(Bank bank)
        {

            // Grabbing a random number and adding it to bank difficulty
            int Luck = new Random().Next(-10, 11);
            bank.Difficulty += Luck;
            Console.WriteLine($"Total Skill Level: {TotalSkill()}");
            Console.WriteLine($"Total Bank Difficulty: {bank.Difficulty}");

            if (bank.Difficulty <= TotalSkill())
            {
                Console.WriteLine("Success, my Thief");
                return true;
            }
            else
            {
                Console.WriteLine("You dang failed, Jail time!");
                return false;
            }

        }


    }


}



