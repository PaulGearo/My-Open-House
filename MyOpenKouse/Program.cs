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


        public static void Main(string[] args)
        {


            Exhibit bullShark = new Exhibit("Bull Shark", false, 1, false);
            bullShark.Descriptions.Add("Why is it called the bull shark? one of the reasons: the bull shark has a bad temper. It is known for being one of the most aggressive sharks. It is territorial so if you mistakenly step into its territory, you’re dead meat.\nThe bull shark can grow over 7 feet long. Females average 7.8 feet long and weigh 285 pounds. The males are smaller, growing up to around 7.3 feet long and weighing about 209 pounds. Females are larger because they carry pups.\nFun fact: As fierce as they are, bull sharks are not at the top of the food chain. In the ocean, they can be preyed on. In order to get away, bull sharks employ a special technique – they throw up! The predator gets distracted by the vomit and the bull shark gets a chance to escape. As disgusting as it is, it works.\n");

            Exhibit tigerShark = new Exhibit("Tiger Shark", false, 2, false);
            tigerShark.Descriptions.Add("So, why are they called tiger sharks? It’s because when a tiger shark is born, it has dark stripes on the upper side of its body.\nThe tiger shark is one of the largest sharks in the ocean. On average, it can grow 10 to 16 feet long and weigh around 800 to 1500 pounds, about as heavy as a horse.\nFun fact: tiger sharks ar known as the garbage can of the sea\n");

            Exhibit hammerheadShark = new Exhibit("Hammerhead Shark", false, 2, false);
            hammerheadShark.Descriptions.Add("Why is it called a hammerhead?  so named for the unusual and distinctive structure of their heads, which are flattened and laterally extended into a hammer shape\nThe great hammerhead shark is the largest species, with the longest recorded reaching 20 feet long – that’s longer than most pickup trucks! It can also weigh over 1000 pounds. On average, though, great hammerhead sharks are about 11 feet long and weigh around 500 pounds.\nFun fact: Hammerhead sharks have a 360-degree range of vision. This means that they can see all around them at all times, whether in front of them, behind them, above them or below them, which helps during hunting and also helps them get away from predators.\n");

            Wing sharkWing = new Wing();
            sharkWing.Name = "Shark wing";
            sharkWing.Exhibits.Add(bullShark);
            sharkWing.Exhibits.Add(tigerShark);
            sharkWing.Exhibits.Add(hammerheadShark);



            Exhibit clownFish = new Exhibit("Clownfish", false, 5, false);
            clownFish.Descriptions.Add("Most clownfish are orange with three white bands on the head and body. The white bands are outlined in black. Their bodies are a bit more than 3 inches (88 millimeters) long on average, but they may grow up to 4 inches.\nFun Fact: A clownfish is born male and has the ability to change into a female. This can happen when the dominant female dies, the dominant male will turn into a female and then choose to mate with another male in the group. However, once they change they cannot turn back.");

            Exhibit lionFish = new Exhibit("Lionfish", false, 1, false);
            lionFish.Descriptions.Add("Juveniles measure less than an inch long and grow to about 13 to 15 inches long as adults. Unusually large lionfish have been found swimming at depths of up to 300 feet (91 meters), and these mega-specimens breed and eat even more than their smaller counterparts do.\n Fun Fact :No matter the size, all lionfish sport spines along their back, pelvis and underside, and they use these protrusions for defense. When a lionfish spine punctures flesh, the pressure pushes out toxin from two venom glands along the fish's backbone. The poison rushes through channels on either side of the backbone, through the spine and into the victim");

            Exhibit pufferFish = new Exhibit("PufferFish", false, 2, false);
            pufferFish.Descriptions.Add("Puffer fish vary in size from one inch long pygmy puffer, to a two feet long freshwater giant puffer.\nMain feature, common for all puffer fish, is ability to ingest huge amount of water (and air sometimes) which increases their body size and turn them into odd-looking ball-like creatures. Quick transformation scares predators.\nFun fact: Sharks are the only species immune to the puffer fish's toxin. They can eat puffer fish without any negative consequences.");

            Exhibit yellowTang = new Exhibit("Yellow Tang", false, 4, false);
            yellowTang.Descriptions.Add("An average grown up yellow tang fish varies between 7 inches and 8 inches in length. Adult males are bigger in size than the adult females. Their width varies between 0.40 inches and 0.80 inches.\nMost of the marine animals that wander about in the depth range of yellow tang’s habitat are supposed to be its predators. Interestingly, orange tang is its most common predator.\nThese fishes outstretch the spikes on their tail fins while attacking their oppositions and as a defense mechanism against their predators.");

            Wing tropicalfishWing = new Wing();
            tropicalfishWing.Name = "Tropical Fish Wing";
            tropicalfishWing.Exhibits.Add(lionFish);
            tropicalfishWing.Exhibits.Add(clownFish);
            tropicalfishWing.Exhibits.Add(pufferFish);
            tropicalfishWing.Exhibits.Add(yellowTang);



            Exhibit seaUrchin = new Exhibit("Sea Urchin", false, 3, false);
            seaUrchin.Descriptions.Add("Size of sea urchins depends on the species. They usually have 1.2 to 3.9 inches in diameter.\nSea urchins have globe-like shape of the body that is covered with large number of long spines. Bony plates form shell that provides protection for the soft inner parts.\nRed sea urchin has the longest lifespan on Earth. It can survive up to 200 years in the wild.");

            Exhibit lobster = new Exhibit("Lobster", false, 4, false);
            lobster.Descriptions.Add("Depending on the species, lobsters vary in size from 0.8 to 3.25 feet in length. Most species are somewhere in between.\nDeep-sea lobsters are blind. Other species have compound eyes. They cannot see clear image, but can detect movement even at night.\nLobsters in the wild can survive up to 100 years. Huge percent of lobsters live much shorter because they end up in the fishing nets much earlier.");

            Exhibit octopus = new Exhibit("Octopus", false, 1, false);
            octopus.Descriptions.Add("All octopuses have head, called mantle, surrounded with 8 arms, called tentacles. All vital organs are located in their head.\nTheir color and size is determined by their environment. Those that live in colder water will be much larger than those that live in tropical (warm) water.\nThey have 3 hearts and their blood is blue in color.");

            Wing shellfishwing = new Wing();
            tropicalfishWing.Name = "Shellfish Wing";
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
                tourGuide.ShowWing(tropicalfishWing);
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
