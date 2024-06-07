using System.Globalization;

namespace SwitchAndEnum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Switch control structure
            Console.WriteLine("_Switch_\nBitte geben Sie einen Wochentag ein: (1-7)");
            int day = int.Parse(Console.ReadLine());        // read user input and convert to int

            switch (day)                                    // switch control structure with day as the variable
            {
                case 1:                                     // if day == 1
                    Console.WriteLine("Montag");
                    break;                                  // exit switch
                case 2:
                    Console.WriteLine("Dienstag");
                    break;
                case 3:
                    Console.WriteLine("Mittwoch");
                    break;
                case 4:
                    Console.WriteLine("Donnerstag");
                    break;
                case 5:
                    Console.WriteLine("Freitag");
                    break;
                case 6:
                    Console.WriteLine("Samstag");
                    break;
                case 7:
                    Console.WriteLine("Sonntag");
                    break;
                default:                                    // if no case matches
                    Console.WriteLine("Ungültige Eingabe");
                    break;
            }

            // Enums are a set of named integer constants (like a class with only static members)
            // and increase code readability as well as maintainability
            // Enum (Resolution.cs)
            Resolutions myResolution = Resolutions.HD;      // create an instance of the Resolutions enum
            myResolution = (Resolutions)2;                  // set myResolution to the third enum value 
            Console.WriteLine("\n_Enum_\n" + myResolution); // print myResolution


            // Enum with switch
            Console.WriteLine("\n_Enum with switch_\nBitte geben Sie eine Auflösung ein: (720, 1920, 3840)");
            int resolution = int.Parse(Console.ReadLine());       // read user input and convert to int
            Resolutions myResolution2 = (Resolutions)resolution;  // set myResolution2 to the enum value corresponding to resolution
            
            switch (myResolution2)                                  // switch control structure with myResolution2 as the variable
            {
                case Resolutions.SD:                                // if myResolution2 == Resolutions.SD
                    Console.WriteLine("Standard");
                    break;                                          // exit switch
                case Resolutions.HD:
                    Console.WriteLine("High Definition");
                    break;
                case Resolutions.UHD:
                    Console.WriteLine("Ultra High Defintion");
                    break;
                default:                                            // if no case matches
                    Console.WriteLine("Ungültige Eingabe");
                    break;
            }
 


        }
    }
}
