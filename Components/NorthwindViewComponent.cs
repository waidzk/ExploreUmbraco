using ExploreUmbraco.Services;
using Microsoft.AspNetCore.Mvc;

namespace ExploreUmbraco.Components
{
    public class NorthwindViewComponent : ViewComponent
    {
        private readonly NorthwindService _northwindService;

        public NorthwindViewComponent(NorthwindService northwindService)
        {
            _northwindService = northwindService;
        }

        public IViewComponentResult Invoke()
        {
            var customers = _northwindService.GetCustomers();
            return View(customers);
        }
    }
}
