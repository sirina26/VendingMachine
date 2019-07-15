using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineProject
{
    public class Money
    {

        const double _KinderCost = 1.5;
        double _total;

        internal Money(double total)
        {
            _total = total;
        }
         internal Money()
        {
        }
         

        public double Total
        {
            get;
            set;
        }

        public bool chekTotal()
        {
            return (_total >= _KinderCost);
        }

        public void ReturnChange()
        {
            if (_total >= _KinderCost)
                Console.WriteLine("Your change is{0}", _total - _KinderCost);
        }               

    }
}
