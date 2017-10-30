using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers
{
    class Human
    {
        protected string firstName;
        protected string lastName;

        public Human()
        {
            this.firstName = null;
            this.lastName = null;
        }
        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
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

        public string Name
        {
            get
            {
                return this.firstName + this.lastName;
            }
        }
    }

    class Student : Human
    {
        private int grade;

        public Student():base()
        {
            this.grade = 0;
        }

        public Student(string firstName, string lastName, int grade):base(firstName,lastName)
        {
            this.grade = grade;
        }

        public int Grade
        {
            get
            {
                return this.grade;
            }
            set
            {
                this.grade = value;
            }
        }
    }

    class Worker : Human
    {
        private int salary;

        public Worker():base()
        {
            this.salary = 0;
        }

        public Worker(string firstName, string lastName, int salary):base(firstName,lastName)
        {
            this.salary = salary;
        }

        public int WeekSalary
        {
            get
            {
                return this.salary;
            }
            set
            {
                this.salary = value;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student one = new Student("Vi", "tsa", 5);
            Student two = new Student("Va", "tsa", 2);
            Student three = new Student("Vrr", "tsav", 4);
            Student four= new Student("Vass", "tsag", 6);
            Student five = new Student("Vvv", "tsas", 5);
            Student[] arr = { one, two, three, four, five };

            var grades =
                from student in arr
                orderby student.Grade
                select student;

            foreach(Student i in grades)
            {
                Console.WriteLine("Name {0} Grade {1} ", i.Name, i.Grade);
            }
        }
    }
}
