using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("24 Michigan Avenue", "Chicago", "Illinois", "USA");
        Address address2 = new Address("123 Broadway", "Miami", "Florida", "USA");


        Customer customer1 = new Customer("Kunle Adeyemi", address1);
        Customer customer2 = new Customer("Grace Abraham", address2);

        Product product1 = new Product("IPhone", "Ip13", 1200, 2 );
        Product product2 = new Product("Screen Guard", "Sg06", 4, 2);
        Product product3 = new Product("JBL Speaker", "JBL-2109", 200, 1);

        Product product4 = new Product("Apple Laptop", "APL2886", 1300, 3);
        Product product5 = new Product("Phone Charger", "N3119", 5, 2);
        Product product6 = new Product("Laptop Charger", "JEV170", 12, 1);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Console.WriteLine("ORDER 1");
        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine($"Total Cost: ${order1.GetTotalCost()}");

        Console.WriteLine();

        Order order2 = new Order(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);
        order2.AddProduct(product6);

        Console.WriteLine("ORDER 2");
        Console.WriteLine(order2.GetPackingLabel());

        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine($"Total Cost: ${order2.GetTotalCost()}");



        
    }
}