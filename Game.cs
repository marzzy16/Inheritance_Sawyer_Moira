using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Sawyer_Moira
{
   abstract class Game
    {
        // Creates an automatic properties for ESRB, and title.
        public string Esrb { get; set; }

        public string Title { get; set; }

        public Game(string esrbParam, string titleParam)
        {
            Esrb = esrbParam;
            Title = titleParam;
        }

        /// <summary>
        /// Prints the title  and says it is starting.
        /// </summary>
        public void PlayGame()
        {
            Console.WriteLine($"{Title} is Starting!");
        }
        public abstract string Describe();

    }
}
