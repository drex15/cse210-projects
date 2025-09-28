using System;

class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        Address addr1 = new Address("123 Main St", "Salt Lake City", "UT", "USA");
        Address addr2 = new Address("45 Queen St", "Toronto", "ON", "Canada");

        // Create customers
        Customer cust1 = new Customer("John Doe", addr1);
        Customer cust2 = new Customer("Jane Smith", addr2);

        // Create first order
        Order order1 = new Order(cust1);
        order1.AddProduct(new Product("Laptop", "P1001", 999.99, 1));
        order1.AddProduct(new Product("Mouse", "P1002", 25.50, 2));

        // Create second order
        Order order2 = new Order(cust2);
        order2.AddProduct(new Product("Headphones", "P2001", 120.75, 1));
        order2.AddProduct(new Product("Monitor", "P2002", 250.00, 1));
        order2.AddProduct(new Product("Keyboard", "P2003", 45.00, 1));

        // Display results for order1
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalCost():F2}\n");

        // Display results for order2
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalCost():F2}");
    }
}
