namespace Car
{
    internal class Hauptklasse
    {
        // just meant to call the other classes
        static void Main(string[] args)
        {

            /* OOP (Object Oriented Programming)
             * 
             * Autos mit Eigenschaften über die Modelklasse Car erstellen
             * und mit Werten initialisieren.
             */             
            Car mustang = new Car("Ford", "Mustang", 1969, 14.5f);
            Car golf = new Car("VW", "Golf", 2010, 6.5f);

            // Methode der Modelklasse Car aufrufen
            mustang.Honk();

            // Details des Autos anzeigen (Write und Objektmethode)
            mustang.viewCar();
            Console.WriteLine("Objekt Methode\n" + golf.GetFullInfo());

            // Verbrauch abfrgaen
            Console.WriteLine(golf.GetFuelConsumption(200) + mustang.GetFuelConsumption(200));


        }
    }
}

