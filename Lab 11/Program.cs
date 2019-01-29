using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie m1 = new Movie("Star Wars", "Sci-Fi");
            Movie m2 = new Movie("A Clockwork Orange", "Crime");
            Movie m3 = new Movie("Ace Ventura Pet Detective", "Comedy");
            Movie m10 = new Movie("Mission Impossible 2", "Action");
            Movie m4 = new Movie("Ace Ventura When Nature Calls", "Comedy");
            Movie m5 = new Movie("E.T. The Extra-terrestrial", "Sci-Fi");
            Movie m6 = new Movie("Close Encounters of the Third Kind", "Sci-Fi");
            Movie m7 = new Movie("Billy Madison", "Comedy");
            Movie m8 = new Movie("Psycho", "Crime");
            Movie m9 = new Movie("Mission Impossible", "Action");

            List<Movie> movies = new List<Movie>();
            movies.Add(m1);
            movies.Add(m2);
            movies.Add(m3);
            movies.Add(m4);
            movies.Add(m5);
            movies.Add(m6);
            movies.Add(m7);
            movies.Add(m8);
            movies.Add(m9);

            List<string> genresFound = new List<string>();
        
            do
            {
                int x = 1;
                foreach (Movie m in movies)
                {
                    if (!genresFound.Contains(m.GetCategory()))
                    {
                        Console.Write($"{x}: ");
                        m.PrintCategories();
                        genresFound.Add(m.GetCategory());                        
                        x++;
                    }                
                }

                Console.Write("Select A Category: ");
                int.TryParse(Console.ReadLine(), out int input);

                foreach (Movie m in movies)
                {
                    if (input == 1)
                    {
                        m.PrintTitles(1);
                    }
                    else if (input == 2)
                    {
                        m.PrintTitles(2);
                    }
                    else if (input == 3)
                    {
                        m.PrintTitles(3);
                    }
                }
            } while (Continue() == true);

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
        //public static List<Movie> RemoveDuplicates(List<Movie> items)
        //{
        //    List<Movie> result = new List<Movie>();
        //    for (int i = 0; i < items.Count; i++)
        //    {
        //        // Assume not duplicate.
        //        bool duplicate = false;
        //        for (int z = 0; z < i; z++)
        //        {
        //            if (items[z] == items[i])
        //            {
        //                // This is a duplicate.
        //                duplicate = true;
        //                break;
        //            }
        //        }
        //        // If not duplicate, add to result.
        //        if (!duplicate)
        //        {
        //            result.Add(items[i].PrintCategories());
        //        }
        //    }
        //    return result;
        //}
        public static bool Continue()
        {
            int i = 0;
            int x = 3;
            do
            {
                Console.Write("Would you like to continue (y/n)? ");
                string go = Console.ReadLine().ToLower();
                if (go == "y" || go == "yes")
                {
                    return true;
                }
                else if (go == "n" || go == "no" || go == "exit")
                {
                    Console.WriteLine("Goodbye!");
                    return false;
                }
                else
                {
                    Console.WriteLine("Invalid. You have {0} attempts remaining", x);
                    i++; x--;
                }
            } while (i <= 3);
            return false;
        }
    }
}
