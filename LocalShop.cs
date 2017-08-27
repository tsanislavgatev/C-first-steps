using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Tshirt
    {
        private string size;
        private string brand;
        private double price;
        private bool gender; // false - female, true - male

        public Tshirt()
        {
            size = "";
            brand = "";
            price = 0;
            gender = false;
        }

        public Tshirt(string s, string b, double p, bool g)
        {
            size = s;
            brand = b;
            price = p;
            gender = g; 
        }

        public string getBrand()
        {
            return brand;
        }

        public void printShirt()
        {
            Console.WriteLine("The Brand Of The Shirt Is : {0} ", brand);
            Console.WriteLine("The Size Of The Shirt Is : {0} ", size);
            Console.WriteLine("The Price Of The Shirt Is : {0} ", price);
            if(gender == true)
            {
                Console.WriteLine("The Shirt Is For Male");
            }
            else
            {
                Console.WriteLine("The Shirt Is For Female");
            }

        }
    }

    class Shop
    {
        private List<Tshirt> arry;

        public Shop()
        {
            arry = new List<Tshirt>();
        }

        public void addShirt(Tshirt tShirtForAdd)
        {
            arry.Add(tShirtForAdd);
        }

        public void searchByBrand(string b)
        {
            foreach(Tshirt i in arry)
            {
                if(i.getBrand() == b)
                {
                    i.printShirt();
                }
            }
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            Shop myShop = new Shop();
            Tshirt forAdd = new Tshirt("M", "Nike", 54, true);
            Tshirt forAdd2 = new Tshirt("L", "Nike", 33, false);
            Tshirt forAdd3 = new Tshirt("S", "Puma", 55, false);

            myShop.addShirt(forAdd);
            myShop.addShirt(forAdd2);
            myShop.addShirt(forAdd3);

            myShop.searchByBrand("Nike");
        }
    }
}
