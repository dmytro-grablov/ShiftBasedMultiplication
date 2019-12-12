﻿using System;

namespace ShiftBasedMultiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.SetWindowSize(140, Console.WindowWidth);
            } catch (Exception ex)
            {
                Console.WriteLine("could not change size of the window, table might be displayed incorrectly");
            }
            while (true)
            {
                Multiplicator multiplicator = new Multiplicator();
                Console.Write("enter operand A: ");
                string inputA = Console.ReadLine();
                uint operandA = UInt32.Parse(inputA);
                Console.Write("enter operand B: ");
                string inputB = Console.ReadLine();
                uint operandB = UInt32.Parse(inputB);
                uint result = multiplicator.MultiplyUnsignedExplained(operandA, operandB);
                Console.WriteLine("multiplication result is {0}, and should be {1}", result, operandA * operandB);
            }
        }
    }
}
