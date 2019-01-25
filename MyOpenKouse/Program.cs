﻿using System;

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
        public static bool YesOrNO(string userResponse)
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

        static void ShowExhibit(Exhibit exibitToShow)
        {

        }

        static void Main(string[] args)
        {


            Exhibit bullShark = new Exhibit("Bull Shark", false, 2, false);
            bullShark.Descriptions.Add("...");

            Exhibit tigerShark = new Exhibit("Tiger Shark", false, 2, false);
            tigerShark.Descriptions.Add("...");

            Exhibit hammerheadShark = new Exhibit("Hammerhead Shark",false, 2, false);
            hammerheadShark.Descriptions.Add("...");

            Wing sharkWing = new Wing();
            sharkWing.Exhibits.Add(bullShark);
            sharkWing.Exhibits.Add(tigerShark);
            sharkWing.Exhibits.Add(hammerheadShark);



            Exhibit clownFish = new Exhibit("Clownfish",false, 2, false);
            clownFish.Descriptions.Add("...");

            Exhibit zebraFish = new Exhibit("Zibrafish",false, 2, false);
            zebraFish.Descriptions.Add("...");

            Exhibit pufferFish = new Exhibit("PufferFish", false, 2, false);
            pufferFish.Descriptions.Add("...");

            Exhibit yellowTang = new Exhibit("Yellow Tang", false, 2, false);
            yellowTang.Descriptions.Add("...");

            Wing tropicalfishWing = new Wing();
            tropicalfishWing.Exhibits.Add(zebraFish);
            tropicalfishWing.Exhibits.Add(clownFish);
            tropicalfishWing.Exhibits.Add(pufferFish);
            tropicalfishWing.Exhibits.Add(yellowTang);



            Exhibit seaUrchin = new Exhibit("Sea Urchin", false, 2, false);
            seaUrchin.Descriptions.Add("...");

            Exhibit lobster = new Exhibit("Lobster", false,2, false);
            lobster.Descriptions.Add("...");

            Exhibit octopus = new Exhibit("Octopus", false, 2, false);
            octopus.Descriptions.Add("...");

            Wing shellfishwing = new Wing();
            shellfishwing.Exhibits.Add(lobster);
            shellfishwing.Exhibits.Add(seaUrchin);
            shellfishwing.Exhibits.Add(octopus);


            TourGuide tourGuide = new TourGuide();
            Console.WriteLine("Welcome to the Walkthrough Aquarium.");
            Console.WriteLine("This aquarium is a walkthrough of each exibit,");
            Console.WriteLine("with a decription of each creature");
            Console.WriteLine("along with information and fun facts on each species.\n");

            string name = GetUserResponse("what's your name\n");

            //Having volonteered at an aquarium, this is a very normal welcome from a tour guide
            Console.WriteLine("welcome " + name + ".");
            Console.WriteLine("My name is Willy, I am the tour guide for this walkthrough.");

            string answer = GetUserResponse("Would you like to start the tour ?\n");
            if (YesOrNO(answer))
            {
                tourGuide.ShowWing(sharkWing);
                tourGuide.ShowWing(tropicalfishWing);
                tourGuide.ShowWing(tropicalfishWing);
            }
            else
            {
                Console.WriteLine("Ok, thanks for coming in.\n");

                answer = GetUserResponse("would you like to learn more about us?\n");
                if (YesOrNO(answer))
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
