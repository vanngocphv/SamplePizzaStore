using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SampleStoreWebApp.DatabaseContext;
using SampleStoreWebApp.Models;

namespace SampleStoreWebApp.Pages.Histories
{
    public class OrderHistoryModel : PageModel
    {
        public List<PizzaOrder> pizzaOrderHistory = new List<PizzaOrder>();

        private ApplicationDbContext _context;

        public OrderHistoryModel(ApplicationDbContext applicationDbContext)
        {
            _context= applicationDbContext;
        }
        public void OnGet()
        {
            //set value for list
            pizzaOrderHistory = _context.PizzaOrders.ToList();
        }
    }
}
