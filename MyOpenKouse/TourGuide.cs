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
            string answer = Program.GetUserResponse("would you like to see our " + wingToShow.Name + " ?");
            if (Program.YesOrNO(answer))
            {
                foreach (Exhibit exhibit in wingToShow.Exhibits)
                {
                    exhibit.ShowExhibit();
                }
            }
        }
        public string WelcomeVisitor(Visitor newVisitor)
        {
            Console.WriteLine("Welcome to the Walkthrough Aquarium.");
            Console.WriteLine("This aquarium is a walkthrough of each exibit,");
            Console.WriteLine("with a decription of each creature");
            Console.WriteLine("along with information and fun facts on each species.\n");

            string name = Program.GetUserResponse("what's your name\n");

            Console.WriteLine("welcome " + name + ".");
            Console.WriteLine("My name is " + Name + ", I am the tour guide for this walkthrough.");
            return name;

        }

        public void VisitorSaysNo(Visitor visitor)
        {
            Console.WriteLine("Ok, thanks for coming in.\n");

            string answer = Program.GetUserResponse("would you like to learn more about us?\n");
            if (Program.YesOrNO(answer))
            {
                Console.WriteLine("Here's a flyer describing what we do here.\n");
            }
            else
            {
                Console.WriteLine("No problem.\n");
            }

        }
        public void WishFarewell(Visitor visitor)
        {
            //this end seemed most appropriate for leaving an establishment like an aquarium.
            Speak("Thank you for visiting, we hope to see you again soon!\n");
            Speak("Have a great day " + visitor.Name + "!");
        }

        public string GetResponseFromVisitor(String question)
        {
            Speak(question);
            string response = Console.ReadLine();
            return response;
        }

    }
}
