namespace StudentGradeManage
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("John", "A", "Math"));
            students.Add(new Student("Jane", "B", "Science")); 
            students.Add(new Student("Jim", "C", "History"));

            Console.WriteLine("Welcome to the Student Grade Management System");
            while (true)
            {    
                try
                {
                    Console.WriteLine("[ 1 ] Add Student");
                    Console.WriteLine("[ 2 ] View All Students");
                    Console.WriteLine("[ 3 ] Exit");

                    string input = Console.ReadLine();
                    if (!int.TryParse(input, out int choice))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                        continue;
                    }

                    if (choice == 1)
                    {
                        Console.WriteLine("Enter student details (format: 'Name, Grade, Course'):");
                        string input2 = Console.ReadLine();
                        try
                        {
                            string[] studentDetails = input2.Split(',');
                            if(studentDetails.Length != 3)
                            {
                                Console.WriteLine("Invalid input. Please enter the correct number of details.");
                                continue;
                            }
                            students.Add(new Student(studentDetails[0].Trim(), studentDetails[1].Trim(), studentDetails[2].Trim()));
                            Console.WriteLine("Student added successfully!");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error adding student: {ex.Message}");
                        }
                    }
                    else if (choice == 2)
                    {
                        if (students.Count == 0)
                        {
                            Console.WriteLine("No students found.");
                        }
                        else
                        {
                            foreach (Student student in students)
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
                    else
                    {
                        Console.WriteLine("Invalid choice. Please select 1, 2, or 3.");
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
