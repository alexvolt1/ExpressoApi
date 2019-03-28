using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExpressoApi.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [RegularExpression(@"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$")]
        public string Email { get; set; }
        [Required]
        [RegularExpression(@"^\D?(\d{3})\D?\D?(\d{3})\D?(\d{4})$")]
        public string Phone { get; set; }
        [Required]
        public int TotalPeople { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        [DataType(DataType.Time)]
        public string Time { get; set; }
    }
}
