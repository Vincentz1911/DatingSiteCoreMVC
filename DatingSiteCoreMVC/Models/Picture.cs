using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;

namespace DatingSiteCoreMVC.Models
{
    public class Picture
    {
        public int ID { get; set; }
        public string ImagePath { get; set; }
    }
}
