using System;

namespace StudentAdmissionManagement
{
    // Abstract Class (Abstraction)
    abstract class Person
    {
        protected string name;
        protected int age;

        // Default Constructor
        public Person()
        {
            name = "";
            age = 0;
        }

        // Parameterized Constructor
        public Person(string n, int a)
        {
            name = n;
            age = a;
        }

        // Abstract Method
        public abstract void Display();
    }

    // Inheritance
    class Student : Person
    {
        // Encapsulation (Private Data Members)
        private int studentId;
        private string course;
        private double admissionFee;

        // Default Constructor
        public Student()
        {
            studentId = 0;
            course = "";
            admissionFee = 0;
        }

        // Parameterized Constructor
        public Student(int id, string n, int a, string c, double fee)
            : base(n, a)
        {
            studentId = id;
            course = c;
            admissionFee = fee;
        }

        // Getter Methods
        public int GetStudentId()
        {
            return studentId;
        }

        public string GetCourse()
        {
            return course;
        }

        public double GetFee()
        {
            return admissionFee;
        }

        // Setter Methods
        public void SetCourse(string c)
        {
            course = c;
        }

        public void SetFee(double fee)
        {
            admissionFee = fee;
        }

        // Method Overriding (Polymorphism)
        public override void Display()
        {
            Console.WriteLine("\n----- Student Admission Details -----");
            Console.WriteLine("Student ID : " + studentId);
            Console.WriteLine("Name       : " + name);
            Console.WriteLine("Age        : " + age);
            Console.WriteLine("Course     : " + course);
            Console.WriteLine("Admission Fee : " + admissionFee);
        }
    }

    // Main Class
    class Program
    {
        static void Main(string[] args)
        {
            // Creating Student Object
            Student s1 = new Student(
                101,
                "BATTA GOPALA KRISHNA",
                20,
                "BCA",
                15000.00
            );

            // Display Student Details
            s1.Display();

            // Updating Course and Fee
            s1.SetCourse("MCA");
            s1.SetFee(20000.00);

            Console.WriteLine("\n----- Updated Admission Details -----");
            s1.Display();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}