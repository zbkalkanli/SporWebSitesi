using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SporSitesi.Models
{
    public class Adres
    {
        public int Id { get; set; }
        public string AdresTarifi { get; set; }
        public string Il { get; set; }
        public string Ilce { get; set; }
        public string PostaKodu { get; set; }
        [ForeignKey("UyeId")]
        public int UyeId{ get; set; }
    }
}
