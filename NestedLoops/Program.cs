namespace NestedLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Nested loops
            List<Product> products = new List<Product>();
            {
                // create some products with ratings(1-5)
                products.Add(new Product("Bratpfanne", new List<int> { 1, 2, 3 }));
                products.Add(new Product("Toaster", new List<int> { 1, 1, 3 }));
                products.Add(new Product("Wasserkocher", new List<int> { 2, 1, 4, 1 }));
                products.Add(new Product("Kontaktgrill", new List<int> { 3, 3, 4, 5 }));

                // foreach-loop through all products
                Console.WriteLine("_Nested foreach-loop_");
                foreach (Product product in products)                   // outer loop
                {
                    Console.WriteLine($"Product: {product.Name}");
                    foreach (int rating in product.Ratings)             // inner loop
                    {
                        Console.WriteLine($"{rating} * für das Produkt {product.Name}");
                    }
                }

                // for-loop through all products
                Console.WriteLine("\n_Nested for-loop_");
                for (int i = 0; i < products.Count; i++)                // outer loop
                {

                    if (products[i].Name == "Toaster")
                    {
                        continue;                                       // skip the toaster and continue with the next product
                    }

                    Console.WriteLine($"Product: {products[i].Name}");
                    for (int j = 0; j < products[i].Ratings.Count; j++) // inner loop
                    {
                        Console.WriteLine($"{products[i].Ratings[j]} * für das Produkt {products[i].Name}");
                        if (products[i].Ratings[j] == 1)
                        {
                            Console.WriteLine("Das Produkt enthält eine 1er Bewertung! Springe zum nächsten Produkt.");
                            break;                                      // breaks the INNER loop when a 1 * rating is found
                        }
                    }
                }
            }
        }
    }

    /* this is a class that represents a product
       and usually it WOULD BE IN A SEPARATE FILE!
       It is here only for the sake of the example.
     */
    internal class Product
    {
        // Properties
        public string Name { get; private set; }
        public List<int> Ratings { get; private set; } // 5 * rating system

        // Constructor 
        public Product(string name, List<int> ratings)
        {
            Name = name;
            Ratings = ratings;
        }

    }
}
