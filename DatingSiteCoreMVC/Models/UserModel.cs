using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DatingSiteCoreMVC.Models
{
    public class UserModel
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        [DataType(DataType.Date)]
        public DateTime? Birthday { get; set; }
        //public DateTime Birthday { get; set; } = new DateTime(2000, 1, 1);
        public int HeightCm { get; set; }
        public int WeightKg { get; set; }
        public string ImagePath { get; set; } = "/neutral.jpg";
    }
}
