namespace StudentGradeManage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Student Grade Management System");


            Console.ReadLine();
    }
    class Student
    {
        string name; string grade; string course;

        public Student(string name, string grade, string course)
        {
            this.name = name;
            this.grade = grade;
            this.course = course;
        }
        static grade(name, grade, course)
        {
            if (grade >= 90)
            {
                Console.WriteLine("A");
            }
            else if (grade >= 80)
            {
                Console.WriteLine("B");
        }
    }
}

