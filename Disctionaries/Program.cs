namespace Dictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Dictionaries

            /* Key-Value pairs
               Key is unique
               Value can be duplicated
            */

            // ENGLISCH | DEUTSCH
            // Cart | Warenkorb
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("Cart", "Warenkorb");
            dic.Remove("Cart");

            // PRODUKT | PREIS
            // Milch | 1.49f
            Dictionary<string, float> products = new Dictionary<string, float>();
            products.Add("Milch", 1.49f);
            products.Remove("Milch");

            // ID | PERSON
            // 50 | Lexi
            Dictionary<int, Person> people = new Dictionary<int, Person>();
            people.Add(50, new Person());
            people.Remove(50);

            people.Clear(); // removes ALL key-value pairs

            // # "Time Complexity", "Big O Notation" for in-depth knowledge


        }
    }
    public class Person // hier nur symbiotisch
    {
        // Properties placeholder
    }
}
