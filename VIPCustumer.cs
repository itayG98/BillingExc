namespace BillingExc
{
    public class VIPCustumer : Costumer
    {
        private const int VIPDiscountPerCent = -20;
        public VIPCustumer(string name, double balance = 0) : base(name, balance)
        {
        }

        public override void AddedToBalance(double amount)
        {
            Balance += amount * (100 + VIPDiscountPerCent) / 100;
        }

        public override string ToString()
        {
            return "VIP costumer "+base.ToString();
        }
    }
}
