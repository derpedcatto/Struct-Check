using System;

namespace Check
{
    class Program
    {
        static void Main()
        {
            Check a = new(1);
            a.AddItem("A", 110, 10, Discount.Regular);
            a.Print();
        }
    }
}