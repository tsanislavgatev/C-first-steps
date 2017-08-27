using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class CarChar
    {
        private string name;
        private int idNumber;
        private uint power;

        public CarChar(string name, int idNumber, uint power)
        {
            this.name = name;
            this.idNumber = idNumber;
            this.power = power;
        }

        public void print()
        {
            Console.WriteLine(" Name Of Car : {0} ", name);
            Console.WriteLine(" Power : {0} ", power);
        }
        
        public CarChar()
        {
            name = "";
            idNumber = 0;
            power = 0;
        }

        public void SetAll(string _name, int _idNumber, uint _power)
        {
            name = _name;
            idNumber = _idNumber;
            power = _power;
        }

        public string getName()
        {
            return name;
        }

        public int getId()
        {
            return idNumber;
        }

        public uint getPower()
        {
            return power;
        }
    }
    class Car
    {
        private string nameOfOwner;
        private int idNumber;
        private int carNumber;

        private CarChar[] carTypes = new CarChar[4];
        

        public Car(string _nameOfOwner, int _idNumber, int _carNumber)
        {
            for(int i = 0; i < 4; i++)
            {
                carTypes[i] = new CarChar();
            }
            InitCars();
            nameOfOwner = _nameOfOwner;
            idNumber = _idNumber;
            carNumber = Math.Abs(_carNumber);
        }

        public void print()
        {
            Console.WriteLine(" Name Of Owner : {0} ", nameOfOwner);
            Console.WriteLine(" Id Number : {0} ", idNumber);
            Console.WriteLine(" Car Number : {0} ", carNumber);
            carTypes[idNumber].print();
        }

        public string getName()
        {
            return nameOfOwner;
        }

        public int getId()
        {
            return idNumber;
        }

        public int getCarNumber()
        {
            return carNumber;
        }


        private void InitCars()
        {
            carTypes[0].SetAll("Lamborgini", 0, 670);
            carTypes[1].SetAll("Mercedes", 1, 503);
            carTypes[2].SetAll("Pagani", 2, 740);
            carTypes[3].SetAll("Bugatti", 3, 1020);
        }

        public CarChar getCarChar()
        {
            return carTypes[this.idNumber];
        }


    }

    class Garage
    {
        private List<Car> arrayOfOwners;

        public Garage()
        {
            arrayOfOwners = new List<Car>();
        }

        public void addCar(Car forAdd)
        {
            arrayOfOwners.Add(forAdd);
        }

        public void testPrint()
        {
            foreach(Car i in arrayOfOwners)
            {
                i.print();
                Console.WriteLine();
            }
        }

        public double averagePower()
        {
            uint countOfCars = 0;
            uint sumOfPower = 0;
            double averagePower = 0;

            foreach(Car i in arrayOfOwners)
            {
                countOfCars++;
                sumOfPower += i.getCarChar().getPower();
            }

            Console.WriteLine("SUM : {0} ", sumOfPower);
            Console.WriteLine("Count : {0} ", countOfCars);

            averagePower = sumOfPower / countOfCars;

            return averagePower;
        }

        public void saveInFile()
        {
            //FileStream fileStream = new FileStream("test.txt", FileMode.OpenOrCreate, FileAccess.Write, FileShare.Write);
            using (System.IO.StreamWriter fileStream = new System.IO.StreamWriter(@"test.txt"))
                foreach (Car i in arrayOfOwners)
                {
                    fileStream.WriteLine(i.getName().ToString());
                    //Console.WriteLine(i.getName().ToString());

                    fileStream.WriteLine(i.getId().ToString());
                    //Console.WriteLine(i.getId().ToString());

                    fileStream.WriteLine(i.getCarNumber().ToString());
                    //Console.WriteLine(i.getCarNumber().ToString());

                    fileStream.WriteLine();
                    //Console.WriteLine();
                }
        }
    }
    class Program
    {
        static bool isFourDigit(int number)
        {
            int counter = 0;
            
            while (number != 0)
            {
                //Console.WriteLine("Number Now : {0} ", number);
                number /= 10;
                counter++;
            }

            if (counter == 4) return true;

            return false;
        }

        static void Main(string[] args)
        {
            //int test;
            //Console.WriteLine("Enter Four Digit Number : ");
            //test = int.Parse(Console.ReadLine());
            Car carOne = new Car("Tsanislav", 1, 4155);
            Car carTwo = new Car("Tsani", 1, 4455);
            Car carThree = new Car("Tsani Gatev", 2, 4425);
            Car carFour = new Car("Viara Tsakova", 3, 2315);

            Garage myGarage = new Garage();
            myGarage.addCar(carOne);
            myGarage.addCar(carTwo);
            myGarage.addCar(carThree);
            myGarage.addCar(carFour);

            //myGarage.testPrint();

            Console.WriteLine(myGarage.averagePower());

            //myGarage.saveInFile();
        }
    }
}
