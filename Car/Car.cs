using System.Security.Cryptography.X509Certificates;

namespace Car
{
    internal class Car
    {
        // Eigenschaften (1. Großbuchstabe)
        public string Brand { get; private set; } // Werte können  hier mit = "Wert" direkt gesetzt werden.
        public string Model { get; private set; }
        public int Year { get; private set; }
        public float FuelConsumptionRate { get; private set; }
        
        // KOnstruktor
        public Car(string brand, string model, int year, float fuelConsumptionRate)
        {
            Brand = brand;
            Model = model;
            Year = year;
            FuelConsumptionRate = fuelConsumptionRate;
        }

        // Methode zum Hupen (Platzhalter)
        public void Honk()
        {
            Console.WriteLine(Brand + " hupt!\n");
        }

        // WriteLIne Methode zum Anzeigen der Auto-Infos
        public void viewCar()
        {
            Console.WriteLine(
                "Write Methode\n" +
                "Brand: " + Brand + "\n" +
                "Model: " + Model + "\n" +
                "Year: " + Year + "\n" +
                "Fuel Consumption Rate: " + FuelConsumptionRate + "\n");
        }

        // Objekt-Methode zum Rückgeben der Auto-Infos als Objekt(Konsolenausgabe muss nicht inkludiert!)
        public string GetFullInfo()
        {
            return $"Brand: {Brand}\nModel: {Model}\nYear: {Year}\nFuel Consumption Rate: {FuelConsumptionRate}\n";

        }

        // Methode zum Berechnen des Verbrauchs 
        public float CalculateFuelConsumption(int kilometres)
        {
            float consumptionPerKm = FuelConsumptionRate / 100.0f;
            return kilometres * consumptionPerKm;
        }

        // Methode zum Anzeigen des Verbrauchs
        public string GetFuelConsumption(int kilometres)
        {
            return $"Der Verbrauch des {Model}s für {kilometres} km beträgt {CalculateFuelConsumption(kilometres)} Liter.\n";
        }
    }
}
