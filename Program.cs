using System;
using System.Globalization;

namespace BillingExc
{
    public class program
    {

        static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US"); /*Dollars currency*/
            CultureInfo.DefaultThreadCurrentCulture.NumberFormat.CurrencyNegativePattern = 1; /*Negative symbol*/

            Costumer cs = new RegualrCosumer("Asher",10.0);
            Costumer[] costumers1 =
            {
               new RegualrCosumer("Itay",45.56),
               new RegualrCosumer("Josh",-45.56),
               new RegualrCosumer("Tomer"),
               new VIPCustumer("Tom",-125.124423),
               new VIPCustumer("John",2000),
               cs
            };

            BillingSystem bs = new BillingSystem(costumers1);
            bs.AddCostumer(new VIPCustumer("Ariel", -10.5));
            bs.AddCostumer(new RegualrCosumer("Shon", -10.5));
            bs.AddCostumer(new RegualrCosumer("David", -10.5));

            bs.AddToBalance(100);
            Console.WriteLine(bs.ToString());

/*            bs.SortCostuArr();
*/            Console.WriteLine(bs);

            Console.ReadLine();
        }
    }
}
