namespace StudentGradeManage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Student Grade Management System");
            Console.WriteLine("[ 1 ] Add Student");
            Console.WriteLine("[ 2 ] View All Students");
            Console.WriteLine("[ 3 ] Exit");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter the student's name: ");
                    string name = Console.ReadLine();
            }

            Student[] students = new Student[3];
            students[0] = new Student("John", "A", "Math");
            students[1] = new Student("Jane", "B", "Science");
            students[2] = new Student("Jim", "C", "History");

            foreach (Student student in students)
            {
                Console.WriteLine($"Name: {student.Name}, Grade: {student.Grade}, Course: {student.Course}");
            }

            Console.ReadLine();

        }
    }

    class Student
    {
        private string name;
        private string grade;
        private string course;

        public Student(string name, string grade, string course)
        {
            this.name = name;
            this.grade = grade;
            this.course = course;
        }

        // Properties for encapsulation
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Grade
        {
            get { return grade; }
            set { grade = value; }
        }

        public string Course
        {
            get { return course; }
            set { course = value; }
        }

        public double GetGrade()
        {
            // Add logic to convert string grade to double
            if (double.TryParse(grade, out double numericGrade))
            {
                return numericGrade;
            }
            return 0.0;
        }
    }
}

