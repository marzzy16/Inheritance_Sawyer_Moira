using System;

namespace Inheritance_Sawyer_Moira
{
    class Program
    {
        static void Main(string[] args)
        {

            // Passes through the  Title and ESRB arguments.
            FPS myfPS = new FPS("E", "ZOMBCUBE");

            Console.WriteLine(myfPS.Describe());
            myfPS.PlayGame();

            FPS csGo = new FPS("M", "CS:GO");
            Console.WriteLine(csGo.Describe());
            csGo.PlayGame();
        }
    }
}
