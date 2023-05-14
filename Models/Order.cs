using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcOrder.Models
{
    public class Order
    {
        public int Id { get; set; }

       
        [Display(Name = "Table Number")]
        [StringLength(30)]
        [Required]
        public string? TableNumber { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [StringLength(5)]
        [Required]
        public string? Dish { get; set; }


        
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Cost { get; set; }

        [Display(Name = "Food Type")]
        [Required]
        [StringLength(30)]
        public string? FoodType { get; set; }


        [StringLength(20)]
        [Required]
        public string? Status { get; set; }
    }
}