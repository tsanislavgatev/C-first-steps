using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Pet
    {
        private bool type; // true for dog, false for cat
        private string name;
        private uint age;
        private bool gender; // true for male, fallse for female
        private uint idNumber;
        private bool isHere;

        public Pet()
        {
            this.type = false;
            this.name = "";
            this.age = 0;
            this.gender = false;
            this.idNumber = 0;
            this.isHere = false;
        }

        public void InitValues(bool type,string name, uint age, bool gender, uint idNumber, bool isHere)
        {
            this.type = type;
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.idNumber = idNumber;
            this.isHere = isHere;
        }

        public Pet(bool type, string name, uint age, bool gender, uint idNumber, bool isHere) => InitValues(type, name, age, gender, idNumber, isHere);

        public void print()
        {
            Console.WriteLine("The name of the pet is : {0}", name);
            if(type)
            {
                Console.WriteLine("The type of the pet is dog. ");
            }
            else
            {
                Console.WriteLine("The type of the pet is cat. ");
            }
            if(gender)
            {
                Console.WriteLine("The gender of the pet is male. ");
            }
            else
            {
                Console.WriteLine("The gender of the pet is female. ");
            }
            Console.WriteLine("The age of the pet is : {0} ", age);
            Console.WriteLine("The Id number of the pet is : {0} ", idNumber);

            if (isHere)
            {
                Console.WriteLine("The pet is in the hotel. ");
            }
            else
            {
                Console.WriteLine("The pet is not in the hotel. ");
            }
        }

        public string getName()
        {
            return this.name;
        }

        public bool getIsHere()
        {
            return isHere;
        }

        public void changeStatus()
        {
            this.isHere = !isHere;
        }
    }

    class PetHotel
    {
        private Pet[] hotelArray = new Pet[20];
        private uint countOfPets;

        public PetHotel()
        {
            for(int i = 0; i < 20; i++)
            {
                hotelArray[i] = new Pet();
            }

            countOfPets = 0;
        }

        public void changeStatus(string name)
        {
            foreach(Pet i in hotelArray)
            {
                if(i.getName() == name)
                {
                    i.changeStatus();
                }
            }
        }

        public bool addPet(Pet forAdd)
        {
            for(int i = 0; i < 20; i++)
            {
                if (!hotelArray[i].getIsHere())
                {
                    hotelArray[i] = forAdd;
                    return true;
                }
            }
            Console.WriteLine("No place for this pet ! ");
            return false;
        }

        public void print()
        {
            foreach(Pet i in hotelArray)
            {
                i.print();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
