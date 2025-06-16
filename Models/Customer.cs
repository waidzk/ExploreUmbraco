using System.ComponentModel.DataAnnotations;

namespace ExploreUmbraco.Models
{
    public class Customer
    {
        [Key]
        public string CustomerID { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
    }
}
