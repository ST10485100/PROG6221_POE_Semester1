
using System.Media;
using static System.Net.Mime.MediaTypeNames;
namespace PROG6221_POE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Part 1 Question 1
            string audioPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "POE Part1 Q1.wav");
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(audioPath);
            player.Play();
            Console.WriteLine("Press Enter to stop the music...");
            Console.ReadLine();
        }
    }
}
