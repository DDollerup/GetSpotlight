using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace GetSpotlight
{
    class GetSpotlightImages
    {
        const string path = @"C:\Users\ddoll\AppData\Local\Packages\Microsoft.Windows.ContentDeliveryManager_cw5n1h2txyewy\LocalState\Assets";

        public void SaveAndConvertImages()
        {
            string[] images = Directory.GetFiles(path);
            List<string> capeableImages = new List<string>(); // Used for images over 60kb

            if (!Directory.Exists(@"C:\Users\ddoll\Desktop\SpotLightImages"))
            {
                Directory.CreateDirectory(@"C:\Users\ddoll\Desktop\SpotLightImages");
            }

            foreach (string image in images)
            {
                FileInfo f = new FileInfo(image);
                if (f.Length > 60000)
                {
                    Image newImage = Image.FromFile(image);
                    float aspect = (float)newImage.Width / (float)newImage.Height;

                    if (aspect > 1.71f)
                    {
                        f.CopyTo(@"C:\Users\ddoll\Desktop\SpotLightImages\" + f.Name + ".jpg", true); 
                    }
                }
            }

        }
    }
}
