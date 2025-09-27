using System;


class Program
{
    static void Main(string[] args)
    {
        Address ad1 = new Address("485 Ryker St", "Seattle", "WA", "USA");
        Customer c1 = new Customer("Donald", ad1);
        Order o1 = Order.CreateOrder(c1);

        Product p1 = new Product("Book", "B001", 20.99, 2);
        Product p2 = new Product("Pen", "P001", 4.56, 4);
        Product p3 = new Product("Notebook", "N001", 8.32, 3);

        o1.AddProduct(p1);
        o1.AddProduct(p2);
        o1.AddProduct(p3);

        Console.WriteLine("\nPacking Label: Order 1");
        o1.CreatePackingLabel();

        Console.WriteLine("\nShipping Label: Order 1");
        Console.WriteLine(o1.CreateShippingLabel(c1));

        Console.WriteLine($"Sub Total: ${o1.GetBaseCost().ToString("F2")}");
        Console.WriteLine($"Shipping; ${o1.GetShippingCost().ToString("F2")}");
        Console.WriteLine($"Total Price: ${o1.TotalPrice().ToString("F2")}");

        Console.WriteLine("-----------------------------------------------------");

        Address ad2 = new Address("5966 Elm Avenue", "Fort Simpson", "NT, K5P 9KU", "Canada");
        Customer c2 = new Customer("Donald", ad2);
        Order o2 = Order.CreateOrder(c2);

        Product p4 = new Product("Bread", "BR76", 8.20, 5);
        Product p5 = new Product("Milk", "M00", 5.23, 4);
        Product p6 = new Product("Television", "T3CH", 500.68, 2);

        o2.AddProduct(p4);
        o2.AddProduct(p5);
        o2.AddProduct(p6);

        Console.WriteLine("\nPacking Label: Order 2");
        o2.CreatePackingLabel();

        Console.WriteLine("\nShipping Label: Order 2");
        Console.WriteLine(o2.CreateShippingLabel(c2));

        Console.WriteLine($"Sub Total: ${o2.GetBaseCost().ToString("F2")}");
        Console.WriteLine($"Shipping; ${o2.GetShippingCost().ToString("F2")}");
        Console.WriteLine($"Total Price: ${o2.TotalPrice().ToString("F2")}");


    }
}