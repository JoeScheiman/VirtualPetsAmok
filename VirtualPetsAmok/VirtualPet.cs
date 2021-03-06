﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace VirtualPetsAmok
{
    public class VirtualPet
    {
        public string Species { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Energy { get; set; }
        public int Happiness { get; set; }
        public const int IncreaseAmount = 6;
        public const int Max = 15;

        /* public VirtualPet()
         {
             Name = "default";
             Energy = 5;
             Happiness = 5;
             Fullness = 5;

         }*/

        public VirtualPet(string s, string n, int a)
        {
            Species = s;
            Name = n;
            Age = a;
            Energy = 5;
            Happiness = 5;
           // Fullness = 5;

        }

        public void SpecifyPet()
        {
            Console.Write("\n\tEnter the pet's species: ");
            Species = Console.ReadLine();
            Console.Write("\n\tEnter the pet's name: ");
            Name = Console.ReadLine();
            Console.Clear();
            Console.Write("Congratulations! Your pet's name is " + Name +
                "\nWhat is " + Name + "'s age? ");
            //Console.WriteLine("\n\tEnter the pet's age:");
            Age = System.Convert.ToInt32(Console.ReadLine());
        }
        public virtual void TimeIncrement()
        {
            Console.Beep();
            Energy--;
            //Happiness--; put in organic class
            //Fullness--;   put in organic class
        }

        public void Play()
        {
            Happiness += IncreaseAmount;
            if (Happiness >= Max) Happiness = Max;
            Console.Clear();
            Console.WriteLine("\tYou just PLAYED with " + Name + " !");
        }
        public void Nap()
        {
            Energy += IncreaseAmount;
            if (Energy >= Max) Energy = Max;
            Console.Clear();
            Console.WriteLine("\t" + Name + " took a NAP!");
        }
        public static void Kitty(int tabs, int milliSec)
        {

            //int milliseconds = 400;

            for (int i = 0; i < tabs; i++)
            {

                Console.Clear();
                if (i < (tabs / 2))
                {
                    for (int t = 0; t < i; t++)
                        Console.Write("\n\n\n");
                }
                else
                {
                    for (int t = tabs; t > i; t--)
                        Console.Write("\n\n\n");
                }

                Console.WriteLine("\n\n");
                for (int t = 0; t < i; t++)
                    Console.Write("\t");
                Console.WriteLine(@" _");
                for (int t = 0; t < i; t++)
                    Console.Write("\t");
                Console.WriteLine(@"( \");
                for (int t = 0; t < i; t++)
                    Console.Write("\t");
                Console.WriteLine(@" \ \");
                for (int t = 0; t < i; t++)
                    Console.Write("\t");
                Console.WriteLine(@" / /                 |\\");
                for (int t = 0; t < i; t++)
                    Console.Write("\t");
                Console.WriteLine(@"/ /     .-`````-.    / ^`-.");
                for (int t = 0; t < i; t++)
                    Console.Write("\t");
                Console.WriteLine(@"\ \    /         \_ /  {|} `o");
                for (int t = 0; t < i; t++)
                    Console.Write("\t");
                Console.WriteLine(@" \ \  /   .-- -.   \\ _  ,--'");
                for (int t = 0; t < i; t++)
                    Console.Write("\t");
                Console.WriteLine(@"  \ \/   /     \,   \( `^^^");
                for (int t = 0; t < i; t++)
                    Console.Write("\t");
                Console.WriteLine(@"   \   \/\      (\  )");
                for (int t = 0; t < i; t++)
                    Console.Write("\t");
                Console.WriteLine(@"    \   ) \     ) \ \                    ____()()");
                for (int t = 0; t < i; t++)
                    Console.Write("\t");
                Console.WriteLine(@"     ) / __ \__  ) (\ \___             /       @@");
                for (int t = 0; t < i; t++)
                    Console.Write("\t");
                Console.WriteLine(@"   (___)))__))(__))(__)))        `~~~~~\_;m__m._ >o");
                Thread.Sleep(milliSec);

            }


            //        ____()()
            //       /       @@
            // `~~~~~\_;m__m._ >o
        }



        public static void PrintStatusBar(int howMuch, int spaceMult)
        {
            //ConsoleColor currentBackground = Console.BackgroundColor;
            //ConsoleColor currentForeground = Console.ForegroundColor;

            //max is the number which will show 100% full bar
            int max = 10;
            //spaceMult is how many "blocks" per 1 unit, this is just for readability & aesthetics
            //int spaceMult = 2;

            Console.ForegroundColor = ConsoleColor.DarkBlue; //make font color easier to read inside bar
            //3 Color Scale: Green, Yellow, Red

            if (howMuch > ((2.0 / 3.0) * (double)max))//If number is between MAX and 2/3 of MAX
            {
                //Console.WriteLine("1st if green");
                Console.BackgroundColor = ConsoleColor.Green;
                for (int i = 1; i <= howMuch * spaceMult; i++)
                    Console.Write(" ");
            }
            else if (howMuch > ((1.0 / 3.0) * (double)max))//If number is < 2/3 and > 1/3 of MAX
            {
                //Console.WriteLine("2nd if yellow");
                Console.BackgroundColor = ConsoleColor.Yellow;
                for (int i = 1; i <= howMuch * spaceMult; i++)
                    Console.Write(" ");
            }
            else //If number is less than 1/3 of MAX
            {
                //Console.WriteLine("3rd if red");
                Console.BackgroundColor = ConsoleColor.Red;
                for (int i = 1; i <= howMuch * spaceMult; i++)
                    Console.Write(" ");
            }
            if (howMuch > 99)
                Console.Write("\b\b");// Add 2 extra backspaces in case number is 3 digits
            else if (howMuch > 9)
                Console.Write("\b");// Add 1 extra backspace in case number is 2 digits

            Console.Write("\b" + howMuch + "\n");

            Console.ResetColor();
        }
       
        public virtual void DisplayPetInfo()
        {
            Console.Write("\n\tYour " + Species + ", " + Name + ", is " + Age + " years old.\n\n");
            
            /*Console.Write("\n\tFullness:  ");
            PrintStatusBar(Fullness, 2);
            Console.Write("\n\tHappiness: ");
            PrintStatusBar(Happiness, 2);*/
            Console.Write("\n\tEnergy:    ");
            PrintStatusBar(Energy, 2);
            Console.WriteLine("\n");
        }
       
           
        
        public virtual bool IsAlive()
        {
            bool alive = true;
            if (/*(Fullness < 1) || (Happiness < 1) ||*/ (Energy < 1))
            {
                alive = false;
            }
            return (alive);
        }
        public void PetDies()
        {
            Console.Clear();
            string sadNews = "SAD NEWS!";
            for (int x=0; x<sadNews.Length; x++)
            {
                Console.Write(sadNews[x]);
                Console.Beep(x * 100 + 500, 50);
            }
            
            Console.Write("\n\t" +
            @"  _;~)                  (~;_"+ "\n\t" +
            @" (   |                  |   )"+ "\n\t" +
            @"  ~', ',    ,''~'',   ,' ,'~"+ "\n\t" +
            @"      ', ','       ',' ,'"+ "\n\t" +
            @"       ',: {'} {'} :,'"+ "\n\t" +
            @"         ;   /^\   ;"+ "\n\t" +
            @"          ~\  ~  /~"+ "\n\t" +
            @"        ,' ,~~~~~, ',"+ "\n\t" +
            @"      ,' ,' ;~~~; ', ',"+ "\n\t" +
            @"    ,' ,'    '''    ', ',"+ "\n\t" +
            @"  (~  ;               ;  ~)"+ "\n\t" +
            @"   -;_)               (_;-"+ "\n\t" );

            Console.WriteLine("\n\t\t" + Name + " is dead");
            Console.WriteLine("PRESS ANY KEY TO CONTINUE!");
            Console.ReadKey();
        }

    }
}
