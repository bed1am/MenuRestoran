using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcOrder.Data;
using System;
using System.Linq;

namespace MvcOrder.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcOrderContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcOrderContext>>()))
            {
                // Look for any movies.
                if (context.Order.Any())
                {
                    return;   // DB has been seeded
                }

                context.Order.AddRange(
                    new Order
                    {
                        TableNumber = "4",
                        Dish = "Fish and Chips",
                        FoodType = "hot dish",
                        Cost = 499.00M,
                        Status = "Done"
                    },

                    new Order
                    {
                        TableNumber = "1",
                        Dish = "Margherita Pizza",
                        FoodType = "hot dish",
                        Cost = 699.00M,
                        Status = "in progress"
                    },

                    new Order
                    {
                        TableNumber = "2",
                        Dish = "Roll Philadelphia",
                        FoodType = "cold dish",
                        Cost = 349.00M,
                        Status = "in progress"
                    },
                    new Order
                    {
                        TableNumber = "5",
                        Dish = "olivier",
                        FoodType = "cold dish",
                        Cost = 399.00M,
                        Status = "Done"
                    },
                     new Order
                     {
                         TableNumber = "7",
                         Dish = "chocolate pudding",
                         FoodType = "dessert",
                         Cost = 300.00M,
                         Status = "in progress"
                     },
                     new Order
                     {
                         TableNumber = "3",
                         Dish = "cheesecake",
                         FoodType = "dessert",
                         Cost = 249.00M,
                         Status = "in progress"
                     }
                ); ;
                context.SaveChanges();
            }
        }
    }
}