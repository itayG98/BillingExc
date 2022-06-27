using System;
using System.Text;

namespace BillingExc
{
    public class BillingSystem
    {
        public const int LIMIT = 100;
        private Costumer[] _costumersArr = new Costumer[LIMIT];
        private int _costumerCounter;
        private bool _isFull;

        private Costumer[] CostumersArr
        {
            get { return _costumersArr; }
            set { _costumersArr = value; }
        }

        public int CostumerCounter
        {
            get { return _costumerCounter; }
            private set { _costumerCounter = value; }
        }

        public bool IsFull
        {
            get { return _isFull; }
        }

        public Costumer this[int index]
        {
            get
            {
                if (index > CostumerCounter - 1 || index < 0)
                {
                    return null;
                }
                return CostumersArr[index];
            }
        }

        public int this[string name]
        {
            get
            {
                for (int i = 0; i < CostumerCounter; i++)
                {
                    if (CostumersArr[i].Name == name)
                        return i;
                }
                return -1;
            }
        }

        public BillingSystem()
        {
            _isFull = false;
            _costumerCounter = 0;
        }

        public BillingSystem(params Costumer[] costumersParam) : this()
        {
            foreach (Costumer c in costumersParam)
            {
                AddCostumer(c);
            }
        }

        public void AddCostumer(Costumer c)
        {
            if (IsFull) 
            {
                throw new TooManyCustomersExcpetion("The billing system is full ", LIMIT);
            }
            else if (CostumerCounter < LIMIT && IsFull == false)
            {
                _costumersArr[CostumerCounter] = c;
                CostumerCounter++;
            }
            else if (CostumerCounter >= LIMIT && IsFull == false)
            {
                _isFull = true;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("Billing data :\n\n");
            for (int i = 0; i < CostumerCounter; i++)
            {
                sb.AppendLine(CostumersArr[i].ToString() + "\n");
            }
            return sb.ToString();
        }

        public void AddToBalance(double amount)
        {
            for (int i = 0; i < CostumerCounter; i++)
            {
                CostumersArr[i].AddedToBalance(amount);
            }
        }

        public void SortCostuArr() //FixMe
        {
            Array.Sort(CostumersArr,0,CostumerCounter); 
        }

    }
}
