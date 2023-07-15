using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SampleStoreWebApp.Models;

namespace SampleStoreWebApp.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> PizzasDb = new List<PizzasModel>() 
        { 
            new PizzasModel(){ImageTitle = "Bolognese", PizzaName = "Bolognese", BasePrice = 5, Cheese = true, Beef = true, Pineapple = true, FinalPrice = 8},
            new PizzasModel(){ImageTitle = "Carbonara", PizzaName = "Carbonara", BasePrice = 7, Ham = true, Peperoni = true, Mushroom = true, TomatoSauce = true, Cheese = true, FinalPrice = 13},
			new PizzasModel(){ImageTitle = "Hawaiian", PizzaName = "Hawaiian", BasePrice = 5, Ham = true, TomatoSauce = true, Cheese = true, FinalPrice = 8},
			new PizzasModel(){ImageTitle = "Pepperoni", PizzaName = "Pepperoni", BasePrice = 3, Ham = true, Peperoni = true, FinalPrice = 5},
			new PizzasModel(){ImageTitle = "Vegetarian", PizzaName = "Vegetarian", BasePrice = 10, Ham = true, Peperoni = true, Mushroom = true, TomatoSauce = true, Cheese = true, Pineapple = true, Tuna = true, FinalPrice = 15},

		};  
        public void OnGet()
        {
        }
    }
}
