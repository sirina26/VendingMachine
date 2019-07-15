using System;

namespace VendingMachineProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var vendingMachine = new VendingMachine();
            var produit = new Produit();
            var money = new Money();
            //chek if enaugh of money
            while (!money.chekTotal())
            {
                Console.WriteLine("Please enter money Just ( 0.01, 0.05, 0.10, 0.20, 0.50, 1, 2 euros) accepted");
                vendingMachine.DepositCoin(Convert.ToDouble(Console.ReadLine()));
            }
            produit.DisplaySelection();
            money.ReturnChange();
            Console.ReadLine();

        }
    }
}
