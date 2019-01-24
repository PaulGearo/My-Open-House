using System;
using System.Collections.Generic;
using System.Text;

namespace MyOpenHouse
{
    class Exhibit
    {
        public string Name { get; set; }
       /* public bool FreshWater { get; set; }
        public int NumberOfCreatures { get; set; }
        public bool Indangered { get; set; }
        public List<string> Descriptions { get; set; } = new List<string>();*/

        public Exhibit(string name, bool freshwater, int numberofcreatures, bool indangered)
        {
            Name = name;
            FreshWater = freshwater;
            NumberOfCreatures = numberofcreatures;
            Indangered = indangered;

        }


        public void ShowExhibit()
        {
            string answer = Program.GetUserResponse("Would you like to start the you the " + Name + "?\n");
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
    }
}

