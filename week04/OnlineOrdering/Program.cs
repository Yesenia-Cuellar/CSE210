
using System;

class Program
{
    static void Main(string[] args)
    {
        // Create the first customer in the USA
        Address address1 = new Address(
            "123 Main Street",
            "Miami",
            "Florida",
            "USA"
        );

        Customer customer1 = new Customer("John Smith", address1);

        // Create the first order
        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Laptop", "P101", 800, 1));
        order1.AddProduct(new Product("Mouse", "P102", 25, 2));
        order1.AddProduct(new Product("Keyboard", "P103", 45, 1));

        // Create the second customer in Costa Rica
        Address address2 = new Address(
            "Avenida Central",
            "San Jose",
            "San Jose",
            "Costa Rica"
        );

        Customer customer2 = new Customer("Maria Lopez", address2);

        // Create the second order
        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("Headphones", "P201", 50, 2));
        order2.AddProduct(new Product("Phone Case", "P202", 15, 3));

        // Display the first order
        Console.WriteLine("========== ORDER 1 ==========");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalCost():F2}");

        // Display the second order
        Console.WriteLine();
        Console.WriteLine("========== ORDER 2 ==========");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalCost():F2}");
    }
}
