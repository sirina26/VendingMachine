using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineProject
{
    public class Produit
    {
        public Produit()
        {

        }
        VendingMachine vm = new VendingMachine();
        public void DisplaySelection()
        {
            Console.WriteLine("The menu!!!");
            Console.WriteLine("1--Kinder");
            Console.WriteLine("2--Chips");
            Console.WriteLine("3--Cake");
            Console.WriteLine("4--Jus");
            Console.WriteLine();
            Console.WriteLine("Please make a selection");
            vm.MakeSelection(Convert.ToInt32(Console.ReadLine()));
        }
    }
}
