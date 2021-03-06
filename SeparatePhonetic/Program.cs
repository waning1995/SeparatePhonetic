﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeparatePhonetic
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<string>() { "huangzhuanga","aanghahaohuang","tian'gaorenniaofei","haineicunzhiji","nichifanlema","changao","chan'gao" };

            foreach(var phonetic in list)
            {
                var separater = new Separater(phonetic);
                var result = separater.Split();
                Console.WriteLine($"Input:{phonetic}");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Result:{string.Join("/",result)}");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
            }

            //var s = "tian'gao";
            //var separater = new Separater(s);
            //var result = separater.Split();
            //Console.WriteLine($"Input:{s}");
            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine($"Result:{string.Join("/",result)}");
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.WriteLine();


            Console.WriteLine("END");
            Console.ReadKey();
        }
    }
}
