namespace Dictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Dictionaries

               Key-Value pairs
               Key is unique
               Value can be duplicated

               o(1) = constant time
                      - queries to the key
                      - inserting
                      - deleting
                      - searching
               o(n) = linear time (long)
                      - queries to the value
               
               # "Time Complexity", "Big O Notation" for in-depth knowledge
            */


            // ENGLISCH | DEUTSCH
            // Cart | Warenkorb
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("Cart", "Warenkorb");
            dic.Remove("Cart");
            // ID | PERSON
            // 50 | Lexi
            Dictionary<int, Person> people = new Dictionary<int, Person>();
            people.Add(50, new Person());
            people.Remove(50);
            people.Clear(); // removes ALL key-value pairs


            // PRODUKT | PREIS
            // Milch | 1.49f
            Dictionary<string, float> products = new Dictionary<string, float>();
            products.Add("Milch", 1.49f);
            products.Add("Brot", 1.99f);
            products.Add("Wurst", 2.49f);

            // quick access to value. given key gets updated or automatically added
            products["Brote"] = 2.49f;  // Brote is not in the dictionary, so it gets added
            products["Brot"] = 1.79f;   // Brot is already in the dictionary, so it gets updated
            Console.WriteLine("Wert Brote: "+products["Brote"]+" "+ "\nWert Brot: "+products["Brot"]);

            // Iterating through the dictionary
            Console.WriteLine("\nInhalte von dict products:");
            foreach (KeyValuePair<string, float> product in products)
            {
                Console.WriteLine(product.Key + " " + product.Value);
            }

            // 3 methods to check for key or value:
            // Check if key or value exists
            if (products.ContainsKey("Milch"))
            {
                Console.WriteLine("\nMilch wurde gefunden");
            }

            // Check if value exists
            if (products.ContainsValue(1.49f))
            {
                Console.WriteLine("Der Wert 1.49 wurde gefunden");
            }

            // Get value by key (safe)
            if (products.TryGetValue("Milch", out float price))
            {
                Console.WriteLine("Milch wurde gefunden und hat den Wert: " + price +"\n");
            }
            else
            {
                Console.WriteLine("Milch wurde nicht gefunden\n");
            }

            // UseCaseScenario -  Checking if and how often a value occurs" 
            int[] numbers = new int[10]
                {
                    40, 60, 30, 20, 40, 30, 80, 90, 80, 30
                };
            Console.WriteLine("40, 60, 30, 20, 40, 30, 80, 90, 80, 30");
            Dictionary<int,int> numbersCount = new Dictionary<int, int>();
            foreach (int number in numbers)             // iterates through the array numbers[10]
            {
                if (numbersCount.ContainsKey(number))
                {
                    numbersCount[number]++;             // increases the counter of found number
                }
                else
                {
                    numbersCount.Add(number, 1);        // adds the number to the dictionary numbersCount<int, int>
                }
                Console.WriteLine(number + ": " + numbersCount[number] + " mal gefunden");

            }
        }
    }
    public class Person // just symbolic here, usually own class/file
    {
        // some kind of properties
    }
}
