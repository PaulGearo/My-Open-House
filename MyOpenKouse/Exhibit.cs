using System;
using System.Collections.Generic;
using System.Text;

namespace MyOpenHouse
{
    public class Exhibit
    {
        public string ExhibitName { get; set; }
        public bool Indangered { get; set; }
        public int NumberOfCreatures { get; set; }
        public bool IsBig { get; set; }
        public List<string> Descriptions { get; set; } = new List<string>();

        public Exhibit(string name, bool isBig, int numberOfCreatures, bool indangered)
        {
            ExhibitName = name;
            Indangered = indangered;
            NumberOfCreatures = numberOfCreatures;
            IsBig = isBig;
        }

        public void ShowExhibit()
        {
            // Ask about the room and display if they answer yes
            string answer = Program.GetUserResponse("Would you like to see the " + ExhibitName + "?");
            if (Program.YesOrNO(answer))
            {
                if (Indangered)
                {
                    Console.WriteLine("This species is indagered");
                }
                else
                {
                    Console.WriteLine("This speacies is not indangered ");
                }
                Console.WriteLine("We have " + NumberOfCreatures + " in this exhibit.");
                if (IsBig)
                {
                    Console.WriteLine("is big");
                }
                else
                {
                    Console.WriteLine("is small");
                }
                foreach (string description in Descriptions)
                {
                    Console.WriteLine(description);
                }

                Console.WriteLine("lets's see the next exhibit.\n");

            }
            else
            {
                Console.WriteLine("Okay, Let's see the next exhibit.");
            }

        }
    }
}

