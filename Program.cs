﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoonWalker
{
    class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
                Output output = new Output();
                Control control = new Control();
                output.main(control.main(Input.main()));

                Console.ReadKey();
            //}
            //catch (Exception e)
            //{


            //    Console.WriteLine("Возникла ошибка!");

            //    Console.WriteLine(e.Message);
            //    Console.ReadKey();
            //    throw;
            //}
        }
    }
}
