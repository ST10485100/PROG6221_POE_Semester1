using System;
using System.Collections.Generic;
using System.Text;

namespace PROG6221_POE
{
    internal class Greeting
    {
        //Part 1 Question 3, Welcoming user
        public void DisplayWelcome(string userName)
        {
            //ASCII art border
            string logo = FigletFontArt.FiggleFonts.Standard.Render($"Hello, {userName}!");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(logo);
            Console.ResetColor();

            //Welcome the user
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine($"Welcome to the Cyber Security Assistance Bot, {userName}!");
            Console.WriteLine("--------------------------------------------------");
        }
    }
}
