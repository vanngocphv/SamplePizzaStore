using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SampleStoreWebApp.Models;

namespace SampleStoreWebApp.Pages.Forms
{
    public class CustomPizzaModel : PageModel
    {
        [BindProperty]
        public PizzasModel pizzasModel { get; set; }

        public float PizzaPrice { get; set; }
        public void OnGet()
        {
        }

        [HttpPost]
        public IActionResult OnPost()
        {
            PizzaPrice = pizzasModel.BasePrice;

            if (pizzasModel.TomatoSauce) PizzaPrice += 1;
			if (pizzasModel.Cheese) PizzaPrice += 1;
			if (pizzasModel.Peperoni) PizzaPrice += 1;
			if (pizzasModel.Mushroom) PizzaPrice += 1;
			if (pizzasModel.Tuna) PizzaPrice += 1;
			if (pizzasModel.Pineapple) PizzaPrice += 1;
			if (pizzasModel.Ham) PizzaPrice += 1;
			if (pizzasModel.Beef) PizzaPrice += 1;

			return RedirectToPage("/Checkout/Checkout", new {pizzasModel.PizzaName, PizzaPrice});
        }
    }
}
