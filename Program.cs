using System;
using System.Collections.Generic;
using System.Text;

namespace MusicPlayList
{
    class Program
    {
        public static void Main()
        {
            Run();
        }
        public static int DisplayMainMenu()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Music Playlist");
            Console.WriteLine("---------------");
            Console.WriteLine();
            Console.WriteLine(" 1. Add Artist");
            Console.WriteLine(" 2. Exit");
            Console.WriteLine();
            Console.Write("Choice: ");
            var result = Console.ReadLine();
            return Convert.ToInt32(result);
        }

        public static Artist AddArtist()
        {
            Artist returnValue = new Artist();

            Console.Write("Artist Name: ");
            returnValue.Name = Console.ReadLine();
            Console.Write("Arist Genre: ");
            returnValue.Genre = Console.ReadLine();
            Console.Write("Year Formed: ");
            returnValue.YearFormed = Int32.Parse(Console.ReadLine()); ;


            return returnValue;
        }

  
        public static void Run()
        {
            int userInput = 0;
            do
            {
                try
                {
                    //get the selection
                    userInput = DisplayMainMenu();
                    
                    switch (userInput)
                    {
                        case 1:
                            AddArtist();
                            break;

                        case 2:
                            Console.WriteLine("Exiting...");
                            break;

                        default:
                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine(" Error: Invalid Choice");
                            System.Threading.Thread.Sleep(1000);
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine(" Unexpected Error:");
                    Console.WriteLine(e);
                    System.Threading.Thread.Sleep(2000);
                }

            } while (userInput != 2);
        }
    }
}
