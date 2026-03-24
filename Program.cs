
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
            Console.WriteLine("Press Enter to stop the music...");
            Console.ReadKey();
        }
    }
}
