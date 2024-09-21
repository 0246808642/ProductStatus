using System.Globalization;

namespace ProductStatus.Entities
{
    public class UsedProduct : Product
    {
        public DateTime ManuFactureDate { get; set; }

        public UsedProduct() { }

        public UsedProduct(string name, double price, DateTime manuFactureDate)
           : base (name, price)
        {
          ManuFactureDate = manuFactureDate;
        }

       
        public override string  PriceTag()
        {
            return Name
                + " (used) $ "
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + " (Manufacture date: "
                + ManuFactureDate.ToString("dd/MM/yyyy")
                + ")";
        }
    }
}
