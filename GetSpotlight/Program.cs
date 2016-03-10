using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSpotlight
{
    class Program
    {
        static void Main(string[] args)
        {
            GetSpotlightImages fisk = new GetSpotlightImages();
            fisk.SaveAndConvertImages();
        }
    }
}
