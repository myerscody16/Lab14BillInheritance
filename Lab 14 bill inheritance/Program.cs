using System;

namespace Lab_14_bill_inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Bill total = new Bill()
            {
                Subtotal = 15.80,
                TaxRate = 0.06
            };
            Pay(total);
            TippableBill totalWithTip = new TippableBill()
            {
                Subtotal = 8.50,
                TaxRate = 0.06,
                Tip = 2.00
            };
            Pay(totalWithTip);
        }
        public static void Pay(Bill bill)
        {
            double total = bill.CalcTotal();
            Console.WriteLine($"The total bill is ${total}.");
        }
        
    }
}
