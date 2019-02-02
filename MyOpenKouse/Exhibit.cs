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
        public List<string> Descriptions { get; set; } = new List<string>();

        public Exhibit(string name, int numberOfCreatures, bool indangered)
        {
            ExhibitName = name;
            Indangered = indangered;
            NumberOfCreatures = numberOfCreatures;
        }

        public void ShowExhibit()
        {
            // Ask about the room and display if they answer yes
            string answer = Program.GetUserResponse($"\nWould you like to see the {ExhibitName}?\n");
            if (Program.YesOrNO(answer))
            {
                if (Indangered)
                {
                    Console.WriteLine("\nThis speacies is indagered\n");
                }
                else
                {
                    Console.WriteLine("\nThis speacies is not indangered\n");
                }
                Console.WriteLine($"We have {NumberOfCreatures} in this exhibit.\n");

                foreach (string description in Descriptions)
                {
                    Console.WriteLine(description);
                }

                Console.WriteLine("lets's see the next exhibit.\n");

            }
            else
            {
                Console.WriteLine("Okay, Let's see the next exhibit.\n");
            }

        }
    }
}

