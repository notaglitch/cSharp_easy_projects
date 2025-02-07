namespace StudentGradeManage
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {    
                try
                {
                    List<Student> students = new List<Student>();
                    students[0] = new Student("John", "A", "Math");
                    students[1] = new Student("Jane", "B", "Science");
                    students[2] = new Student("Jim", "C", "History");

                    Console.WriteLine("Welcome to the Student Grade Management System");
                    Console.WriteLine("[ 1 ] Add Student");
                    Console.WriteLine("[ 2 ] View All Students");
                    Console.WriteLine("[ 3 ] Exit");

                    int choice = Console.ReadLine();
                    if (!int.TryParse(Console.ReadLine(), out choice))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                        continue;
                    }


                    if (choice == 1)
                    {
                        try
                        {
                            string[] studentDetails = Console.ReadLine().Split(',');
                            if(studentDetails.Length != 3)
                            {
                                Console.WriteLine("Invalid input. Please enter the correct number of details.");
                                continue;
                            }
                            students.Add(new Student(details[0].Trim(), details[1].Trim(), details[2].Trim()));
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error: {ex.Message}");
                        }



                        Console.WriteLine("Enter student details: 'John, A, Math'");
                        string studentDetails = Console.ReadLine();
                        students[students.Length - 1] = new Student(studentDetails);
                    }
                    else if (choice == 2)
                    {
                        foreach (Student student in students)
                        {
                            if (student != null)
                            {
                                Console.WriteLine($"Name: {student.Name}, Grade: {student.Grade}, Course: {student.Course}");
                            }
                        }

                    }
                    else if (choice == 3)
                    {
                        Console.WriteLine("Exiting the program...");
                        break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }
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
    }
}

