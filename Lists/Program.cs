using System.Security.Cryptography.X509Certificates;

namespace Lists
{
    internal class Program
    {

        static void Main(string[] args)
        {
            /*
             * Fixe Anzahl an Elementen -> Array
             * Dynanische Anzahl an Elementen -> List
             * 
             */

            // Array - feste Größe
            int[] numbers = new int[3] { 1,2,3};
            
            // List - dynamische Größe
            List<int> ints = new List<int>();
            
            // Add 
            ints.Add(100);
            ints.Add(-200);

            // Remove - entfernt das erste Vorkommen des Elements
            bool success = ints.Remove(-200);

            // Clear - löscht alle Elemente
            ints.Clear();

            // Insert - fügt ein Element an einer bestimmten Position ein
            ints.Insert(0, 500);

            // RemoveAt - entfernt ein Element an einer bestimmten Position
            ints.RemoveAt(0);

            // Index holen
            int index = ints.IndexOf(500);

            // Count - Anzahl der Elemente zeige
            int count = ints.Count;

            // Namensliste anlegen und Elemente hinzufügen
            List<string> names = new List<string>()
            {
                "Lexi",
                "Paxi",
                "Fixi"
            };

            // Änderung eines Elements
            Console.WriteLine(names[1]);
            names[1] = "Maxi";
            Console.WriteLine(names[1]);


            // Übungsaufgabe "Student"
            Console.WriteLine("\n\nÜbungsaufgabe 'Studenten'");
            List<Student> students = new List<Student>();
            students.Add(new Student(1, "Max", 2.3f));
            students.Add(new Student(2, "Moritz", 1.8f));
            students.Add(new Student(3, "Mimi", 2.1f));            

            // 
            Console.WriteLine(students.Count+" Studenten in der Liste");
            Console.Write("\nErfasste Studentenbewertungen: " );

            float totalGradePoints = 0;
            foreach (Student student in students)
            {
                Console.Write(student.AvgGrade + " ");
                totalGradePoints += student.AvgGrade;
            }

            float avgRatingStudents = totalGradePoints / students.Count;

            Console.WriteLine("Der Durchschnittswert aller erfassten Studenten liegt bei "+avgRatingStudents);
        }
    }
}