using FactoryMethod;

Console.Title = "Factory Method";

var factories = new List<DiscountFactory>() {
    new CodeDiscountFactory(Guid.NewGuid()),
    new CountryDiscountFactory("BE")
};

foreach (var item in factories)
{
    var discountService = item.CreateDiscountService();
    Console.WriteLine($"Percentage {discountService.DiscountPercentage} coming from {discountService}");
}