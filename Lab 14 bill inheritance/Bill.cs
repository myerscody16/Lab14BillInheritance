using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_14_bill_inheritance
{
    class Bill
    {
        public double Subtotal { get; set; }
        public double TaxRate { get; set; }
        public Bill ()
        {

        }
        public Bill (double subtotal, double taxrate)
        {
            Subtotal = subtotal;
            TaxRate = taxrate;
        }
        public virtual double CalcTotal()
        {
            double total = Subtotal * (1 + TaxRate);
            return total;
        }
    }
}
