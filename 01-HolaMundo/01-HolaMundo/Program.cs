﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_HolaMundo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola mundo");
            Console.WriteLine("Escribe tu nombre:");
            String resp = Console.ReadLine();
            Console.WriteLine("Hola "+resp);
        }
    }
}
