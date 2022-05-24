using System;

namespace Check
{
    public enum Discount
    {
        Default = 0, Regular = 5, VIP = 15
    }

    public struct Item
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Discount Discount { get; set; }

        public Item()
        {
            Name = "DefaultCheck";
            Quantity = 50;
            Price = 100;
            Discount = Discount.Regular;
        }
        public Item(string name, int quantity, double price, Discount discount)
        {
            this.Name = name;
            this.Quantity = quantity;
            this.Price = price;
            this.Discount = discount;
        }

        public void Print()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Quantity: " + Quantity);
            Console.WriteLine("Price: " + Price);
            Console.WriteLine("Discount: " + Discount);
            Console.WriteLine("Price (w/ discount): " + (Price - (Price / 100 * ((int)Discount))));
        }
    }

    public struct Check
    {
        List<Item> list = new List<Item>();

        public Check()
        {
            list.Add(new Item());
        }
        public Check(int count)
        {
            for (int i = 0; i < count; i++)
                list.Add(new Item());
        }

        public void Print()
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i].ToString() + "\n");
                list[i].Print();
                Console.WriteLine("\n");
            }
        }
        public void AddItem()
        {
            list.Add(new Item());
        }
        public void AddItem(string name, int quantity, double price, Discount discount)
        {
            list.Add(new Item(name, quantity, price, discount));
        }
    }
}