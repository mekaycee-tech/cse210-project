using System;

class Program
{
    static void Main(string[] args)
    {
        // --- ORDER 1 (USA Customer) ---
        Address address1 = new Address("123 Main Street", "Rexburg", "ID", "USA");
        Customer customer1 = new Customer("John Doe", address1);

        Product product1 = new Product("Wireless Mouse", "P101", 25.50m, 2);
        Product product2 = new Product("Mechanical Keyboard", "P102", 75.00m, 1);
        Product product3 = new Product("USB-C Cable", "P103", 8.99m, 3);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        // --- ORDER 2 (International Customer) ---
        Address address2 = new Address("456 Market Road", "Lagos", "Lagos State", "Nigeria");
        Customer customer2 = new Customer("Kelechi David", address2);

        Product product4 = new Product("HD Monitor", "P201", 180.00m, 1);
        Product product5 = new Product("Desk Mat", "P202", 15.00m, 2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);

        // --- DISPLAY RESULTS ---
        DisplayOrderDetails(order1, 1);
        Console.WriteLine("\n========================================\n");
        DisplayOrderDetails(order2, 2);
    }

    static void DisplayOrderDetails(Order order, int orderNum)
    {
        Console.WriteLine($"=== ORDER #{orderNum} DETAILS ===");
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order.CalculateTotalCost():F2}");
    }
}