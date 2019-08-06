using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_14_bill_inheritance
{
    class TippableBill : Bill
    {
        public double Tip { get; set; }
        public TippableBill()
        {

        }
        public TippableBill(double subtotal, double taxrate, double tip)
        {
            Subtotal = subtotal;
            TaxRate = taxrate;
            Tip = tip;
        }
        public override double CalcTotal()
        {
            double total = Subtotal * (1 + TaxRate);
            total += Tip;
            return total;
        }
    }
}
