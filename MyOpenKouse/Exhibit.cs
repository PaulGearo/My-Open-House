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
        public bool FreshWater { get; set; }
        public List<string> Descriptions { get; set; } = new List<string>();

        public Exhibit(string name, bool freshwater, int numberofcreatures, bool indangered)
        {
            ExhibitName = name;
            Indangered = indangered;
            NumberOfCreatures = numberofcreatures;
            FreshWater = freshwater;
        }
        public void ShowExhibit()
        {
            string answer = Program.GetUserResponse("Would you like to start the you the " + ExhibitName + "?\n");
            if (Program.YesOrNO(answer))
            {
                foreach (string description in Descriptions)
                {
                    Console.WriteLine(description);
                }
            }
            else
            {
                Console.WriteLine("Okay, let's move on to the next exhibit.\n");
            }
        }
        public void ShowRoom()
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
                if (FreshWater)
                {
                    Console.WriteLine("...");
                }
                else
                {
                    Console.WriteLine("...");
                }
                foreach (string description in Descriptions)
                {
                    Console.WriteLine(description);
                }
            }
        }
    }
}

