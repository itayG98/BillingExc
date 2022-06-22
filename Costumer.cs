using System.Globalization;

namespace BillingExc
{
    public abstract class Costumer
    {
        private string _name;
        private double _balance;
        private readonly int _id;

        static private int _count;
        private const int _kidomet = 1000000;

        public string Name
        {
            get { return _name; }
            private set { _name = value; }
        }
        public double Balance
        {
            get { return _balance; }
            protected set { _balance = value; }
        }
        public float ID
        {
            get { return _id; }
        }

        static Costumer()
        {
            _count = 0;
        }
        public Costumer(string name, double balance = 0)
        {
            _count++;
            _name = name;
            _balance = balance;
            _id = _count + _kidomet;
        }

        public abstract void AddedToBalance(double amount);

        public override string ToString()
        {
            return $"{Name}\t\t{ID} \tbalance :{Balance:c}";
        }
    }
}
