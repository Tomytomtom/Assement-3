using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment_3_Hooks
{
    //These are the same vaiables that are in the json file 
    public class Colour
    {
        public string color { get; set; }
        public List<int> rgba { get; set; }
        public string hex { get; set; }
    }

    //In order to deseralise  the json in to a list we need to set it with a new class
    public class RootObject
    {
        public List<Colour> colors { get; set; }
    }
}
