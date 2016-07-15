﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    public class Worker
    {
        public Worker()
        {
            Work();
        }

        public void Work()
        {
            Console.WriteLine("Open file here...");
            try
            {
                Console.WriteLine("Throwing Exception...");
                throw new System.Exception();
                //Console.WriteLine("Closing File...");
            }
            catch
            {
                Console.WriteLine("Handling the exception");
            }
            finally
            {
                Console.WriteLine("Closing");
            }
        }
    }
}
