using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11
{
    class Movie
    {
        private string title;
        private string category;
        public int i = 0;

        public Movie(string title, string category)
        {
            this.title = title;
            this.category = category;
        }

        public string GetCategory()
        {
            return category;
        }

        public void PrintCategories()
        {
            Console.WriteLine(category);
        }

        public void PrintTitles(int input)
        {
            if (input == 1 && category.Contains("Sci-Fi"))
            {
                Console.WriteLine(title);
            }
            else if (input == 2 && category.Contains("Crime"))
            {
                Console.WriteLine(title);
            }
            else if (input == 3 && category.Contains("Comedy"))
            {
                Console.WriteLine(title);
            }
            else if (input == 4 && category.Contains("Action"))
            {
                Console.WriteLine(title);
            }
        }
    }
}
