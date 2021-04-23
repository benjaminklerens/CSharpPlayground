using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSharpPlayground.Models
{
    public class Medicine
    {
        public int ID{ get; set; }
        public string Name { get; set; }

        [Display(Name = "Discovery Date")]
        [DataType(DataType.Date)]
        public DateTime DateReleased { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
    }
}