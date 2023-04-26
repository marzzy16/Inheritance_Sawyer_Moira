using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Sawyer_Moira
{
    class FPS : Game
    {


        // inplements both the ESRB and Title and inherits from the base cless.
        public FPS(string esrbParam, string titleParam) : base(esrbParam, titleParam)
        {
            Title = titleParam;
            Esrb = esrbParam;
        }


        // describes the game and includes the title and esrb.
        public override string Describe()
        {
            return $"{Title} is a fps game rated {Esrb}!";
        }
    }
}
