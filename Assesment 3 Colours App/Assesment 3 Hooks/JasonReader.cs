using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assesment_3_Hooks
{
    class JasonReader
    {
        public List<Colour> LoadJson()
        {
            //decearls a streamreader for a one time use
            using (StreamReader r = new StreamReader("Colours.json"))
            {
                // reads json file in to string
                string json = r.ReadToEnd();
                //converts that string into a list of colours
                RootObject ColoursList = JsonConvert.DeserializeObject<RootObject>(json);
                //return the list
                return ColoursList.colors;
            }
            
        }
    }
}
