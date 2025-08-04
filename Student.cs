
namespace classes
{
    internal class Student
    {
        public string Name;
        public string Surname;
        public string Group;
        public int Point;
        public bool IsGraduated;

        public Student(string name, string surname, string group, int point)
        {
            Name = name;
            Surname = surname;
            Group = group;
            Point = point;

            IsGraduated = point >= 65;
        }
        public void PrintInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Surname: " + Surname);
            Console.WriteLine("Group: " + Group);
            Console.WriteLine("Point: " + Point);
            Console.WriteLine("Is Graduated: " + (IsGraduated ? "Yes" : "No"));
        }
        public void CheckGraduation()
        {
            if (IsGraduated)
            {
                Console.WriteLine($"{Name} {Surname} Graduated");
            }
            else
            {
                Console.WriteLine($"{Name} {Surname} Couldnt Graduated ");
            }

        }
        public void GetDiplomDegree()
        {
            if (Point < 65)
            {
                Console.WriteLine("No Diploma");
            }
            else if (Point < 80)
            {
                Console.WriteLine("simple diploma.");
            }
            else if (Point < 90)
            {
                Console.WriteLine("Honor diploma.");
            }
            else
            {
                Console.WriteLine("High honor diploma.");
            }
        }
    }
}
