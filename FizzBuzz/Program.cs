﻿using System;

namespace FizzBuzz {
    class Program {
        static void Main(string[] args) {

            for (var idx = 1; idx <= 30; idx++) {
                if (idx % 3 == 0 && idx % 5 == 0)
                    Console.Write($"  {idx} FIZZBUZZ ");
                else
                if (idx % 3 == 0)
                    Console.Write($" {idx} FIZZ ");
                else
                    if (idx % 5 == 0)
                    Console.Write($" {idx} BUZZ ");

            }
        }
    }
}
