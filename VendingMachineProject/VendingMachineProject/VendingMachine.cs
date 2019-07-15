using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineProject
{
    public class VendingMachine
    {
 

        const double _KinderCost = 1.5;
        double _total;
        Money money = new Money();

       
        public VendingMachine()
        {
        }
        //check money if valid or not
        public void DepositCoin(double money)
        {
            switch (money)
            {
                case (0.01):
                    _total += 0.01;
                    break;
                case (0.05):
                    _total += 0.05;
                    break;
                case (0.1):
                    _total += 0.1;
                    break;
                case (0.2):
                    _total += 0.2;
                    break;
                case (0.5):
                    _total += 0.5;
                    break;
                case (1):
                    _total += 1;
                    break;
                case (2):
                    _total += 2;
                    break;
                default:
                    Console.WriteLine("Invalid money");
                    break;

            }
        }
     
       public void MakeSelection(int selection)
        {
            bool Isselected = false;
            while (!Isselected)
            {
                switch (selection)
                {
                    case 1:
                        Console.WriteLine("Your choice is Kinder");
                        Isselected = true;
                        money.ReturnChange();
                        break;
                    case 2:
                        Console.WriteLine("Your choice is Chips");
                        Isselected = true;
                        money.ReturnChange();
                        break;
                    case 3:
                        Console.WriteLine("Your choice is Cake");
                        Isselected = true;
                        money.ReturnChange();
                        break;
                    case 4:
                        Console.WriteLine("Your choice is Jus");
                        Isselected = true;
                        money.ReturnChange();
                        break;
                    default:
                        Console.WriteLine("Invalid selection. PLease re-enter your selection");
                        selection = Convert.ToInt32(Console.ReadLine());
                        Isselected = false;
                        break;
                }
            }
        }
      
    }
}
