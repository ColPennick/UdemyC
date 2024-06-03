namespace Lists
{

    internal class Student
    {
        // Properties
        public int Id { get; private set; }
        public string Name { get; private set; }
        public float AvgGrade { get; private set; }

        // Konstruktor
        public Student(int id, string name, float avgGrade)
        {
            Id = id;
            Name = name;
            AvgGrade = avgGrade;
        }

    }
}

