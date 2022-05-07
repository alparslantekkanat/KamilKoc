using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudTours.Domain
{
    public  class Trip
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Yolculuk adı boş olamaz")]
        public string Name { get; set; }
        public double Price { get; set; }
        
        public string Description { get; set; }

        public string  ImageUrl { get; set; }








    }
}
