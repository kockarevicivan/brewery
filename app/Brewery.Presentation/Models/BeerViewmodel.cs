
namespace Brewery.Presentation.Models
{
    public class BeerViewmodel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal AlcoholPercentage { get; set; }
        public decimal IBU { get; set; }
        public int? Quantity { get; set; }
        public int BeerTypeId { get; set; }
        public int? BreweryId { get; set; }
    }
}