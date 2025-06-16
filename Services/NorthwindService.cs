using ExploreUmbraco.Models;
using ExploreUmbraco.Data;

namespace ExploreUmbraco.Services
{
    public class NorthwindService
    {
        private readonly NorthwindContext _context;

        public NorthwindService(NorthwindContext context)
        {
            _context = context;
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return _context.Customers.Take(10).ToList();
        }
    }
}
