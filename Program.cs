using System;
using System.Collections.Generic;

namespace InventoryManagement
{
    class Program
    {
        static List<Product> products = new List<Product>();
        static List<Customer> customers = new List<Customer>();

        static void Main(string[] args)
        {
            
            InitializeSampleData();

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\nInventory Management System");
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. Remove Product");
                Console.WriteLine("3. View Products");
                Console.WriteLine("4. Add Customer");
                Console.WriteLine("5. Remove Customer");
                Console.WriteLine("6. View Customers");
                Console.WriteLine("7. Exit");

                string? choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        AddProduct();
                        break;
                    case "2":
                        RemoveProduct();
                        break;
                    case "3":
                        ViewProducts();
                        break;
                    case "4":
                        AddCustomer();
                        break;
                    case "5":
                        RemoveCustomer();
                        break;
                    case "6":
                        ViewCustomers();
                        break;
                    case "7":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }

       
        static void InitializeSampleData()
        {
            
            customers = new List<Customer>()
            {
                new Customer(1, "John Doe", "john.doe@gmail.com", "123-456-7890", "123 Main St", new DateTime(2020, 5, 1), true),
                new Customer(2, "Jane Smith", "jane.smith@gmail.com", "234-567-8901", "456 Oak St", new DateTime(2021, 3, 12), false),
                new Customer(3, "Alice Johnson", "alice.johnson@gmail.com", "345-678-9012", "789 Maple St", new DateTime(2022, 7, 5), true),
                
            };

            
            products = new List<Product>()
            {
                new Product(1, "Smartphone", 699.99m, 50),
                new Product(2, "Laptop", 999.99m, 25),
                new Product(3, "Smart TV", 1200.00m, 10),
                
            };
        }

        static void AddProduct()
        {
            Console.Write("Enter Product ID: ");
            string? idInput = Console.ReadLine();
            if (int.TryParse(idInput, out int id))
            {
                Console.Write("Enter Product Name: ");
                string? name = Console.ReadLine() ?? string.Empty;

                Console.Write("Enter Product Price: ");
                string? priceInput = Console.ReadLine();
                if (decimal.TryParse(priceInput, out decimal price))
                {
                    products.Add(new Product { Id = id, Name = name, Price = price });
                    Console.WriteLine("Product added successfully.");
                }
                else
                {
                    Console.WriteLine("Invalid price.");
                }
            }
            else
            {
                Console.WriteLine("Invalid product ID.");
            }
        }

        static void RemoveProduct()
        {
            Console.Write("Enter Product ID to remove: ");
            string? idInput = Console.ReadLine();
            if (int.TryParse(idInput, out int id))
            {
                Product? productToRemove = products.Find(p => p.Id == id);
                if (productToRemove != null)
                {
                    products.Remove(productToRemove);
                    Console.WriteLine("Product removed successfully.");
                }
                else
                {
                    Console.WriteLine("Product not found.");
                }
            }
            else
            {
                Console.WriteLine("Invalid product ID.");
            }
        }

        static void ViewProducts()
        {
            Console.WriteLine("\nList of Products:");
            foreach (var product in products)
            {
                Console.WriteLine($"ID: {product.Id}, Name: {product.Name}, Price: {product.Price}");
            }
        }

        static void AddCustomer()
        {
            Console.Write("Enter Customer ID: ");
            string? idInput = Console.ReadLine();
            if (int.TryParse(idInput, out int id))
            {
                Console.Write("Enter Customer Name: ");
                string? name = Console.ReadLine() ?? string.Empty;

                Console.Write("Enter Customer Email: ");
                string? email = Console.ReadLine() ?? string.Empty;

                customers.Add(new Customer { Id = id, Name = name, Email = email });
                Console.WriteLine("Customer added successfully.");
            }
            else
            {
                Console.WriteLine("Invalid customer ID.");
            }
        }

        static void RemoveCustomer()
        {
            Console.Write("Enter Customer ID to remove: ");
            string? idInput = Console.ReadLine();
            if (int.TryParse(idInput, out int id))
            {
                Customer? customerToRemove = customers.Find(c => c.Id == id);
                if (customerToRemove != null)
                {
                    customers.Remove(customerToRemove);
                    Console.WriteLine("Customer removed successfully.");
                }
                else
                {
                    Console.WriteLine("Customer not found.");
                }
            }
            else
            {
                Console.WriteLine("Invalid customer ID.");
            }
        }

        static void ViewCustomers()
        {
            Console.WriteLine("\nList of Customers:");
            foreach (var customer in customers)
            {
                Console.WriteLine($"ID: {customer.Id}, Name: {customer.Name}, Email: {customer.Email}");
            }
        }
    }
}
