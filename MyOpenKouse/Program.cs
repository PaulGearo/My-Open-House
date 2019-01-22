using System;

namespace MyOpenKouse
{
    class Program
    {

        static string GetUserResponse(string question)
        {
            Console.WriteLine(question);
            string response = Console.ReadLine();
            return response;
        }
        static bool IsAffermative(string userResponse)
        {
            userResponse = userResponse.ToUpper();

            while(userResponse != "YES" && userResponse != "NO")
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

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Walkthrough Aquarium.");
            Console.WriteLine("This aquarium is a walkthrough of each exibit,");
            Console.WriteLine("with a decription of each creature");
            Console.WriteLine("along with information and fun facts on each species.\n");

            string name = GetUserResponse("what's your name\n");

            //Having volonteered at an aquarium, this is a very normal welcome from a tour guide
            Console.WriteLine("welcome " + name + ".");
            Console.WriteLine("My name is willy, I am the tour guide for this walkthrough.");

            string answer = GetUserResponse("Would you like to start the tour ?\n");

            if (IsAffermative(answer))
            {
                answer = GetUserResponse("Would you like to start the you the the shark exipit?\n");

                if (IsAffermative(answer))
                {
                    Console.WriteLine("Let's start with the tiger shark\n");

                    Console.WriteLine("So, why are they called tiger sharks? It’s because when a tiger shark is born, it has dark stripes on the upper side of its body.");
                    Console.WriteLine("The tiger shark is one of the largest sharks in the ocean. On average, it can grow 10 to 16 feet long and weigh around 800 to 1500 pounds, about as heavy as a horse.");
                    Console.WriteLine("Fun fact: tiger sharks ar known as the garbage can of the sea\n");

                    answer = GetUserResponse("would you like to see the bull shark?\n");
                    if (IsAffermative(answer))
                    {
                        Console.WriteLine("Why is it called the bull shark? one of the reasons: the bull shark has a bad temper. In fact, it is known for being one of the most aggressive sharks. It is territorial so if you mistakenly step into its territory, you’re dead meat.");
                        Console.WriteLine("The bull shark can grow over 7 feet long. In fact, females average 7.8 feet long and weigh 285 pounds. The males are smaller, growing up to around 7.3 feet long and weighing about 209 pounds. Females are larger because they carry pups.");
                        Console.WriteLine("Fun fact: As fierce as they are, bull sharks are not at the top of the food chain. In the ocean, they can be preyed on. In order to get away, bull sharks employ a special technique – they throw up! The predator gets distracted by the vomit and the bull shark gets a chance to escape. As disgusting as it is, it works.\n");

                        Console.WriteLine("Let's, see the next shark.\n");
                    }
                    else
                    {
                        Console.WriteLine("Ok, Let's see the next shark.\n");
                    }

                    answer = GetUserResponse("Would you like to see the Hammerhead shark?\n");
                    if (IsAffermative(answer))
                    {
                        Console.WriteLine("Why is it called a hammerhead?  so named for the unusual and distinctive structure of their heads, which are flattened and laterally extended into a hammer shape");
                        Console.WriteLine("The great hammerhead shark is the largest species, with the longest recorded reaching 20 feet long – that’s longer than most pickup trucks! It can also weigh over 1000 pounds. On average, though, great hammerhead sharks are about 11 feet long and weigh around 500 pounds.");
                        Console.WriteLine("Fun fact: Hammerhead sharks have a 360-degree range of vision. This means that they can see all around them at all times, whether in front of them, behind them, above them or below them, which helps during hunting and also helps them get away from predators.\n");

                        Console.WriteLine("Okay, Lets move on to the next exibit.\n");
                    }
                    else
                    {
                        Console.WriteLine("Okay, let's move on to the next exibit.\n");
                    }


                }
                else
                {
                    Console.WriteLine("Okay, let's see the next exibit.\n");
                }











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
