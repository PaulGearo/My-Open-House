using System;
using System.Collections.Generic;
using System.Text;

namespace MyOpenHouse
{
    class TourGuide
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
    }
}
