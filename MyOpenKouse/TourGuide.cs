using System;
using System.Collections.Generic;
using System.Text;

namespace MyOpenHouse
{
    public class TourGuide
    {
        public string Name { get; set; }

        public void ShowExibit(Exhibit exibitToShow)
        {
            exibitToShow.ShowExhibit();
        }

        public void Speak(string message)
        {
            Console.WriteLine(message);
        }
        public void ShowWing(Wing wingToShow)
        {
            string answer = Program.GetUserResponse("do you" + wingToShow.Name);
            if (Program.YesOrNO(answer))
            {
                foreach (Exhibit exhibit in wingToShow.Exhibits)
                {
                    exhibit.ShowExhibit();
                }
            }
        }
    }
}
