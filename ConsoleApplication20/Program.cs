using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication20
{
    class Program
    {
        static void Main(string[] args)
        {
            string proceed="";

            do
            {
                List<movie> movieList = new List<movie>();
                movieList.Add(new movie("panda", "animation"));
                movieList.Add(new movie("dissindents", "animation"));
                movieList.Add(new movie("valentines day", "romantic"));
                movieList.Add(new movie("veterans ", "action"));
                movieList.Add(new movie("titanic", "action"));
                movieList.Add(new movie("the signs", "scifi"));
                movieList.Add(new movie("evil dead", "scifi"));
                movieList.Add(new movie("comedy nights", "comedy"));
                movieList.Add(new movie("laughing all the way", "comedy"));
                movieList.Add(new movie("other half", "romantic"));
                Console.WriteLine("welcome to the movie list application");
                Console.WriteLine("ther are 100 movies in the list");
                Console.WriteLine("what catagories you are interested,choose from animation/scifi/romantic/comedy ");
                string userentry = Console.ReadLine();
                foreach (movie mv in movieList)
                {
                    if (mv.catagory == userentry)
                    {
                        Console.WriteLine(mv.name);
                    }

                  
                }
                Console.WriteLine("do you want to continue y/n");
                proceed = Console.ReadLine();
            }
            while (proceed == "y");


        }
    }
}
