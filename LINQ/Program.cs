using System.Linq;
using System.Collections.Generic;
using System; 


namespace LINQ

{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> gameNames = new List<string>() 
                { "Grand Theft Auto v", "Call of Duty", "Super Mario Bros", "The Last of Us" };
            gameNames.Add("Spider-Man 2");
            gameNames.Add("Spider-Man (Miles Morales)");

            var names = gameNames.OrderBy(name=>name.Length);
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }



        }
    }
}
