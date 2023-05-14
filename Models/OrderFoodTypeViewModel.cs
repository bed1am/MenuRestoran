using Microsoft.AspNetCore.Mvc.Rendering;

namespace MvcOrder.Models
{
    public class OrderFoodTypeViewModel
    {
        public List<Order>? Orders { get; set; }
        public SelectList? FoodTypes { get; set; }
        public string? FoodType { get; set; }
        public string? SearchString { get; set; }
    }
}
