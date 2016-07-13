﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchDemo
{
    class Program
    {
        enum Movies
        {
            Casablanca,
            Godfather,
            Matrix
        }
        static void Main(string[] args)
        {
            Movies bestMovie = Movies.Godfather;
            switch (bestMovie)
            {
                case Movies.Casablanca:
                    Console.WriteLine("Ahhh, Bogie and Bacall...");
                    break;
                case Movies.Godfather:
                    Console.WriteLine("I'll make him an offer...");
                    break;
                case Movies.Matrix:
                    Console.WriteLine("Will you take the red pill or the blue?");
                    break;
                default:
                    Console.WriteLine("You have to choose one.");
                    break;
            }
        }
    }
}
