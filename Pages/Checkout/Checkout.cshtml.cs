using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SampleStoreWebApp.DatabaseContext;
using SampleStoreWebApp.Models;

namespace SampleStoreWebApp.Pages.Checkout
{
    [BindProperties(SupportsGet = true)]
    public class CheckoutModel : PageModel
    {
        public string PizzaName { get; set; }
        public float PizzaPrice { get; set; }
        public string ImageTitle { get; set; }

        private ApplicationDbContext _DbContext;
        public CheckoutModel(ApplicationDbContext dbContext)
        {
            _DbContext= dbContext;
        }

        public void OnGet()
        {
            //check if name is null or space (this was been checked before click get, but still check for security)
            if (string.IsNullOrWhiteSpace(PizzaName))
            {
                PizzaName = "Custom"; //just set a new name for it
            }
            if (string.IsNullOrWhiteSpace(ImageTitle))
            {
                //this is check for image title, new
                ImageTitle = "Create"; //it's just return Create.png in wwwroot/images/Pizzas/Create.png
            }

            PizzaOrder pizzaOrder = new PizzaOrder();
            pizzaOrder.PizzaName = PizzaName;
            pizzaOrder.BasePrice = PizzaPrice;

            _DbContext.PizzaOrders.Add(pizzaOrder);
            _DbContext.SaveChanges();
        }
    }
}
