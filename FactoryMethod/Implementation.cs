namespace FactoryMethod
{
    public abstract class DiscountService
    {
        public abstract int DiscountPercentage { get; }
        public override string ToString() => GetType().Name;
    }

    public class CountryDiscountService : DiscountService
    {
        private readonly string _country;
        public CountryDiscountService(string country)
        {
            _country = country;
        }
        public override int DiscountPercentage
        {
            get
            {
                return _country switch
                {
                    "BE" => 20,
                    _ => 10,
                };
            }
        }
    }

    public class CodeDiscountService : DiscountService
    {
        private readonly Guid _code;
        public CodeDiscountService(Guid code)
        {
            _code = code;
        }
        public override int DiscountPercentage => 15;
    }

    public abstract class DiscountFactory
    {
        public abstract DiscountService CreateDiscountService();
    }

    public class CountryDiscountFactory : DiscountFactory
    {
        private readonly string _country;
        public CountryDiscountFactory(string country)
        {
            _country = country;
        }

        public override DiscountService CreateDiscountService()
        {
            return new CountryDiscountService(_country);
        }
    }

    public class CodeDiscountFactory : DiscountFactory
    {
        private readonly Guid _code;
        public CodeDiscountFactory(Guid code)
        {
            _code= code;
        }

        public override DiscountService CreateDiscountService()
        {
            return new CodeDiscountService(_code);
        }
    }
}
