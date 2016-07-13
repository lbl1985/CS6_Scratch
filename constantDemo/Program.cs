﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constantDemo
{
    class Program
    {
        enum Ages
        {
            oldEnough = 5,
            canDrink = 21,
            tooOld = 90

        }
        static void Main(string[] args)
        {
            const int age = 20;
            if(age < (int)Ages.oldEnough)
            {
                Console.WriteLine("Sorry, you are too young to play.");
            } else if (age < (int)Ages.canDrink)
            {
                Console.WriteLine("You can play, but not drinking!");
            } else
            {
                Console.WriteLine("How about a nice nap?");
            }
        }
    }
}
