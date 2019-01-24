using System;

namespace MyOpenHouse
{
    class Program
    {
        //This is the method I use for every question
        public static string GetUserResponse(string question)
        {
            Console.WriteLine(question);
            string response = Console.ReadLine();
            return response;
        }

        //this method is to gather the users Y/N answers, and to insure they answer as such
        public static bool IsAffermative(string userResponse)
        {
            userResponse = userResponse.ToUpper();

            while (userResponse != "YES" && userResponse != "NO")
            {
                Console.WriteLine("Please answer: Yes or No");
                userResponse = Console.ReadLine();
                userResponse = userResponse.ToUpper();
            }

            if (userResponse == "YES")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static  void ShowExibit(Exhibit exibitToShow)
        {
  
        }




        static void Main(string[] args)
        {
            Exhibit bullShark = new Exhibit("Bull Shark");
            bullShark.Descriptions.Add("...");

            Exhibit tigerShark = new Exhibit("Tiger Shark");
            tigerShark.Descriptions.Add("...");

            Exhibit tigerShark = new Exhibit("Hammerhead Shark");
            tigerShark.Descriptions.Add("...");

            Exhibit tropicalFish = new Exhibit("tropicalFish",true, 2, true);
            tropicalFish.Descriptions.Add("...");         
  
            Exhibit shellFish = new Exhibit("shellfish", true, 2, false);
            shellFish.Descriptions.Add("...");



            Console.WriteLine("Welcome to the Walkthrough Aquarium.");
            Console.WriteLine("This aquarium is a walkthrough of each exibit,");
            Console.WriteLine("with a decription of each creature");
            Console.WriteLine("along with information and fun facts on each species.\n");

            string name = GetUserResponse("what's your name\n");

            //Having volonteered at an aquarium, this is a very normal welcome from a tour guide
            Console.WriteLine("welcome " + name + ".");
            Console.WriteLine("My name is Willy, I am the tour guide for this walkthrough.");

            string answer = GetUserResponse("Would you like to start the tour ?\n");
            if (IsAffermative(answer))
            {

                sharks.ShowExibit();

            }
            else
            {
                Console.WriteLine("Ok, thanks for coming in.\n");

                answer = GetUserResponse("would you like to learn more about us?\n");
                if (IsAffermative(answer))
                {
                    Console.WriteLine("Here's a flyer describing what we do here.\n");
                }
                else
                {
                    Console.WriteLine("No problem.\n");
                }
            }

            //this end seemed most appropriate for leaving an establishment like an aquarium.
            Console.WriteLine("Thank you for visiting, we hope to see you again soon!\n");
            Console.WriteLine("Have a great day " + name + "!");

            Console.ReadLine();
        }
    }
}
