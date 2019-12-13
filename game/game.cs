using System;
using System.Collections.Generic;
using Shia;
using System.Threading;

namespace Game
{
    public class Woods
    {
        public static int Stage = 0;
        public static int resultCounter = 0;
        public static int choicesCounter = 0;
        public bool win = false;
        public bool death = false;
        public static List<string> descriptions = new List<string>();
        public static List<string> choices = new List<string>();
        public static List<string> result = new List<string>();
        
        public static void Begin()
        {
            descriptions.Add("\n\n You are walking in the woods theres no one around and your phone is dead. \n Out of the corner of your eye you spot him... \n He's following you about thirty feet back, He gets down on all fours and breaks into a sprint \n He's gaining on you... \n Shia LaBeouf\n\n");
            descriptions.Add(" Now it's dark and you seem to have lost him but you're hopelessly lost yourself \n Stranded with a murderer.\n Aha! In the distance A small cottage with a light on \n Hope!\n\n");
            descriptions.Add(" Gnawing off your leg \n Limping to the cottage\n Now you're on the doorstep\n Sitting inside: Shia LaBeouf\n\n");

            choices.Add("Run");
            choices.Add("Fight");
            choices.Add("Talk");
            choices.Add("Sneak");
            choices.Add("Walk");
            choices.Add("Run");

            result.Add("You run away from Shia LaBeouf");
            result.Add("You attempt to fight Shia LaBeouf but he surprises you with a swift stab in the neck");
            result.Add("You chat with Shia LaBeouf, he kills you.");
            result.Add("this one is different");
            result.Add("this one too");
            result.Add("not this one");
        }
        public static bool Play(int num)
        {
            Describe(num);
            Choice(num);
            return Play(Stage);
        }
        public static void Describe(int num)
        {
            Console.WriteLine(descriptions[num]);
        }  
        public static bool Again(bool agn)
        {
            if(agn)
            {
                Console.WriteLine("Game Over, Would you like to play again?");
                string again = Console.ReadLine().ToLower();
                if(again == "y")
                {
                    Play(0);
                    return false;
                }
                else if(again == "n")
                {
                    return false;
                }
                else 
                {
                    Console.WriteLine("Invalid Command");
                    return Again(agn);
                }
            }
            else
            {
                return false;
            }
        }
        public static void Choice(int num)
        {
            Thread.Sleep(500);
            for(int i = 0; i < 3; i++)
            {
                Console.Write(i+1 + ": " + choices[choicesCounter] + " ");
                choicesCounter++;
                Thread.Sleep(500);
            }
            Console.WriteLine("\n");
            string madeChoice = Console.ReadLine();
            switch(madeChoice)
            {
                case "1":
                    Thread.Sleep(500);
                    Console.WriteLine("\n" + result[resultCounter] + "\n");
                    Thread.Sleep(1500);
                    Stage++;
                    resultCounter += 3;
                    break;
                case "2":
                    Thread.Sleep(500);
                    Console.WriteLine("\n" + result[resultCounter + 1] + "\n");
                    Thread.Sleep(1500);
                    Stage++;
                    resultCounter += 2;
                    break;
                case "3":
                    Thread.Sleep(500);
                    Console.WriteLine("\n" + result[resultCounter + 2] + "\n");
                    Thread.Sleep(1500);
                    Stage++;
                    resultCounter += 1;
                    break;
                default:
                    Console.WriteLine("Invalid Command");
                    Thread.Sleep(1000);
                    choicesCounter -= 3;
                    Describe(num);
                    Choice(num);
                    break;
            }
        }
    }
}