using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSharpPlayground.Models
{
    public class Medicine
    {
        public int ID{ get; set; }
        

        [Required]
        [StringLength(35, MinimumLength = 3)]
        public string Name { get; set; }


        [Display(Name = "Discovery Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime DateReleased { get; set; }


        [Column(TypeName = "decimal(18,2)")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
    }
}