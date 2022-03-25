using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqEx2
{
    class Program
    {
        static void Main(string[] args)
        {

                    
            //make a list of games
            string [] games = //new List<string>()
            { "Frogger", 
                "Mario",
                "Monster Rancher",
                "Monster Hunter",
                "Zelda",
                "WatchDogs",
                "FryCry",
                "BioMutant"
            };
        
            // sorts games by string length and stores in var sortLength
            var sortLength = games.OrderBy(game => game.Length).AsEnumerable();
             

            foreach(var item in sortLength)
            {
                Console.WriteLine(item);
            }
            
            // Count how many items in games list then store in varible to disply
            var qtyCount = games.Count();

            Console.WriteLine("-----------");
            Console.WriteLine($"Amount of games in list: {qtyCount}");

            //Avg length of items in games list
            var avgLenth = games.Average(game => game.Length);
            Console.WriteLine("-------");
            Console.WriteLine($"Average legnth of games name {avgLenth}");
            
            //Min length
            int minLength = games.Min(mLength => mLength.Length);


            int temp1 = minLength + 1;
            string temp2 = Convert.ToString(temp1);
             minLength = Convert.ToInt32(temp2);

             Console.WriteLine("-------");
             Console.WriteLine($"Game/s with the shortest name is/are {minLength} chareters");
            //Reuse sortLength to find shortest name/s for game
           var tempSort = sortLength.Where(sL => sL.Length < minLength );
            foreach(var sName in tempSort)
            {
                Console.WriteLine(sName);
            }

            //Max length              
            int maxLength = games.Max(mxLength => mxLength.Length);
            Console.WriteLine("-------");
            Console.WriteLine($"Game/s with the longest name is/are {maxLength} chareters");

            temp1 = maxLength;
             temp2 = Convert.ToString(temp1);
            maxLength = Convert.ToInt32(temp2);

            tempSort = sortLength.Where(sL => sL.Length == maxLength);
            foreach (var lName in tempSort)
            {
                Console.WriteLine(lName);
            }

            //display names that have space
            var nameSpaces =  games.Where(names => names.Contains(" "));
            Console.WriteLine("-----------");
            Console.WriteLine("Display games that have space in their name.");
            foreach (var names in nameSpaces)
            {
                Console.WriteLine(names);
             }
                      

        }
        
    }
}
