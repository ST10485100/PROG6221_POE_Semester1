
using System.Media;
using static System.Net.Mime.MediaTypeNames;
namespace PROG6221_POE
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Part 1 Question 2, ASCII logo
            String msg = "CSAB";

            String asc = FigletFontArt.FiggleFonts.Standard.Render(msg);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(asc);
            Console.ResetColor();

            //Part 1 Question 1, welcome voice
            string audioPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "POE Part1 Q1.wav");
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(audioPath);
            player.Play();
            Console.WriteLine("\nPress enter to proceed");
            Console.ReadKey();

            //Part 1 Question 3
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            Console.Clear();
        
            Greeting welcome = new Greeting();
            welcome.DisplayWelcome(name);
            Console.ReadKey();
            

            //Part 1 Question 4, chatbot
            Chatbot myBot = new Chatbot();
            bool isRunning = true;

            while (isRunning)
            {
                Console.Write("\nAsk a question (or type 'exit' to stop): ");
                string userInput = Console.ReadLine();

                if (userInput.ToLower() == "exit")
                {
                    isRunning = false;
                    Console.WriteLine("Stay safe online! Goodbye.");
                }
                else
                {
                    myBot.GetResponse(userInput);
                }
            }
        }
    }
}
