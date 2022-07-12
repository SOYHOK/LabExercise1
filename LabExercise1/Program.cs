using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabExercise1
{
    class Car
    {
        public string strModel;
        public string strBrand;
        public float fltPrice;

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar1;
            myCar1 = new Car();

            Console.Write("What is your model of your car: ");
            myCar1.strModel = Console.ReadLine();
            Console.Write("What is your bramd of your car: ");
            myCar1.strBrand = Console.ReadLine();
            Console.Write("What is your price of your car: ");
            myCar1.fltPrice = float.Parse(Console.ReadLine());
            Console.WriteLine("Car Model is {0},brand is {1}, price is {2}", myCar1.strModel, myCar1.strBrand, myCar1.fltPrice);
        }
    }
}
