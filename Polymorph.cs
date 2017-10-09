using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Student
    {
        private string firstName;
        private string lastName;
        private string personalNumber;
        private double averageGrade;

        public Student()
        {
            this.firstName = null;
            this.lastName = null;
            this.personalNumber = null;
            this.averageGrade = 0;
        }

        public Student(string firstName, string lastName, string personalNumber, double averageGrade)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.personalNumber = personalNumber;
            this.averageGrade = averageGrade;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                this.lastName = value;
            }
        }

        public string PersonalNumber
        {
            get
            {
                return this.personalNumber;
            }
            set
            {
                this.personalNumber = value;
            }
        }

        public double AverageGrade
        {
            get
            {
                return this.averageGrade;
            }
            set
            {
                this.averageGrade = value;
            }
        }

        public virtual void Print()
        {
            Console.Write("First Name : {0} \n" +
                "Last Name : {1} \n" +
                "Personal Number : {2} \n" +
                "Average Grade : {3} \n", this.firstName, this.lastName, this.personalNumber, this.averageGrade);
        }

    }

    class Freshman : Student
    {
        private string highschool;
        private double averageHighschoolGrade;

        public Freshman():base()
        {
            this.highschool = null;
            this.averageHighschoolGrade = 0;
        }

        public Freshman(string firstName, string lastName, string personalNumber, double averageGrade, string highschool, double averageHighschoolGrade):base(firstName,lastName,personalNumber,averageGrade)
        {
            this.highschool = highschool;
            this.averageHighschoolGrade = averageHighschoolGrade;
        }

        public string Highschool
        {
            get
            {
                return this.highschool;
            }
            set
            {
                this.highschool = value;
            }
        }

        public double AverageHighschoolGrade
        {
            get
            {
                return this.averageHighschoolGrade;
            }
            set
            {
                this.averageHighschoolGrade = value;
            }
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Highschool : {0} \n" +
                "Average Highschool Grade : {1} ", this.highschool, this.averageHighschoolGrade);
        }
    }

    class Sophmore : Student
    {
        private bool isAlreadyDepressed;

        public Sophmore():base()
        {
            this.isAlreadyDepressed = true;
        }

        public Sophmore(string firstName, string lastName, string personalNumber, double averageGrade, bool isAlreadyDepressed):base(firstName,lastName,personalNumber,averageGrade)
        {
            this.isAlreadyDepressed = isAlreadyDepressed;
        }

        public bool IsAlreadyDepressed
        {
            get
            {
                return this.isAlreadyDepressed;
            }
            set
            {
                this.isAlreadyDepressed = value;
            }
        }

        public override void Print()
        {
            base.Print();
            if(isAlreadyDepressed)
            {
                Console.WriteLine("Is Depressed");
            }
            else
            {
                Console.WriteLine("Is Not Depressed");
            }
        }
    }

    class Junior : Student
    {
        private bool isThereHope;
        

        public Junior():base()
        {
            this.isThereHope = true;
        }

        public Junior(string firstName, string lastName, string personalNumber, double averageGrade, bool isThereHope):base(firstName,lastName,personalNumber,averageGrade)
        {
            this.isThereHope = isThereHope;
        }

        public bool IsThereHope
        {
            get
            {
                return this.isThereHope;
            }
            set
            {
                this.isThereHope = value;
            }
        }

        public override void Print()
        {
            base.Print();
            if (isThereHope)
            {
                Console.WriteLine("There is hope");
            }
            else
            {
                Console.WriteLine("No hope left");
            }
        }
    }

    class Senior : Student
    {
        private bool willGraduate;

        public Senior():base()
        {
            this.willGraduate = true;
        }
        
        public Senior(string firstName, string lastName, string personalNumber, double averageGrade, bool willGraduate) :base(firstName,lastName,personalNumber,averageGrade)
        {
            this.willGraduate = willGraduate;
        }

        public bool WillGraduate
        {
            get
            {
                return this.willGraduate;
            }
            set
            {
                this.willGraduate = value;
            }
        }

        public override void Print()
        {
            base.Print();
            if (willGraduate)
            {
                Console.WriteLine("Will Graduate");
            }
            else
            {
                Console.WriteLine("Will Not Graduate");
            }
        }
    }

    class StudentService
    {
        List<Student> arrayOfStudents = new List<Student>();
        
        public void AddStudent(Student forAdd)
        {
            arrayOfStudents.Add(forAdd);
        }

        public void RemoveStudent(string EGN)
        {
            for(int i = 0; i < arrayOfStudents.Count;i++)
            {
                if( arrayOfStudents[i].PersonalNumber == EGN)
                {
                    arrayOfStudents.RemoveAt(i);
                }
            }
        }
        
        public void PrintAll()
        {
            foreach(Student i in arrayOfStudents)
            {
                i.Print();
                Console.WriteLine("I am {0} year " ,i.GetType().Name);
            }
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Freshman vqra = new Freshman("Viara", "Tsakova", "ne znam", 6.00, "TBG", 5.00);
            Sophmore vqra1 = new Sophmore("Vyara", "Tsakova", "sad", 5.00, true);
            Junior vqra2 = new Junior("Vara", "Cakova", "21", 4.22, false);
            Senior vqra3 = new Senior("Vara", "Cakua", "asd", 4.21, true);

            //vqra.Print();
            //vqra1.Print();
            //vqra2.Print();
            //vqra3.Print();

            StudentService test = new StudentService();

            test.AddStudent(vqra);
            test.AddStudent(vqra1);
            test.AddStudent(vqra2);
            test.AddStudent(vqra3);

            test.RemoveStudent("21");

            test.PrintAll();
        }
    }
}
