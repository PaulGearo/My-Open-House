using System;
using System.IO;

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
                Console.WriteLine("Please answer: Yes or No\n");
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
        public static void Main(string[] args)
        {
            Exhibit bullShark = new Exhibit("Bull Shark", 1, false);
            bullShark.Descriptions.Add(File.ReadAllText("Bull Shark Facts.txt"));
            Exhibit tigerShark = new Exhibit("Tiger Shark", 2, false);
            tigerShark.Descriptions.Add(File.ReadAllText("Tiger Shark Facts.txt"));
            Exhibit hammerheadShark = new Exhibit("Hammerhead Shark", 3,true);
            hammerheadShark.Descriptions.Add(File.ReadAllText("Hammerhead Shark Facts.txt"));
            Wing sharkWing = new Wing();
            sharkWing.Name = "Shark wing";
            sharkWing.Exhibits.Add(bullShark);
            sharkWing.Exhibits.Add(tigerShark);
            sharkWing.Exhibits.Add(hammerheadShark);

            Exhibit clownFish = new Exhibit("Clownfish", 5, false);
            clownFish.Descriptions.Add(File.ReadAllText("Clownfish Facts.txt"));
            Exhibit lionFish = new Exhibit("Lionfish", 1, false);
            lionFish.Descriptions.Add(File.ReadAllText("Lionfish Facts.txt"));
            Exhibit pufferFish = new Exhibit("PufferFish", 2, false);
            pufferFish.Descriptions.Add(File.ReadAllText("Pufferfish Facts.txt"));
            Exhibit yellowTang = new Exhibit("Yellow Tang", 4, false);
            yellowTang.Descriptions.Add(File.ReadAllText("Yellow Tang Facts.txt"));
            Wing tropicalfishWing = new Wing();
            tropicalfishWing.Name = "Tropical Fish Wing";
            tropicalfishWing.Exhibits.Add(clownFish);
            tropicalfishWing.Exhibits.Add(lionFish);
            tropicalfishWing.Exhibits.Add(pufferFish);
            tropicalfishWing.Exhibits.Add(yellowTang);

            Exhibit seaUrchin = new Exhibit("Sea Urchin", 3, false);
            seaUrchin.Descriptions.Add(File.ReadAllText("Sea Urchin Facts.txt"));
            Exhibit lobster = new Exhibit("Lobster", 8, false);
            lobster.Descriptions.Add(File.ReadAllText("Lobster Facts.txt"));
            Exhibit octopus = new Exhibit("Octopus", 1, false);
            octopus.Descriptions.Add(File.ReadAllText("Octopus Facts.txt"));
            Wing shellfishwing = new Wing();
            shellfishwing.Name = "Shellfish Wing";
            shellfishwing.Exhibits.Add(lobster);
            shellfishwing.Exhibits.Add(seaUrchin);
            shellfishwing.Exhibits.Add(octopus);

            TourGuide tourGuide = new TourGuide();
            tourGuide.Name = "Willy Freeman";

            Visitor newVisitor = new Visitor();
            newVisitor.Name = tourGuide.WelcomeVisitor(newVisitor);

            string answer = GetUserResponse("Would you like to start the tour?\n");
            if (YesOrNO(answer))
            {
                tourGuide.ShowWing(sharkWing);
                tourGuide.ShowWing(tropicalfishWing);
                tourGuide.ShowWing(shellfishwing);
                tourGuide.EndOfTour(newVisitor);
            }
            else
            {
                tourGuide.VisitorSaysNo(newVisitor);
            }

            tourGuide.WishFarewell(newVisitor);

            Console.ReadLine();
        }
    }
}
