//برنامه ای بنویسید که عددی را خوانده و با استفاده از تابع توان 2 و توان 3 ان را حساب کرد و در تابع مین نمایش دهد  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2
{

    class power
    {
        double num1;
        private double p2()
        {
            return num1 * num1;
        }
        private double p3()
        {
            return num1 * num1 * num1;
        }
        public void data()
        {
            Console.WriteLine("please enter a number :");
            num1 = Convert.ToDouble(Console.ReadLine());

        }
        public void show()
        {
            Console.WriteLine(num1 + "^2" + "=" + p2());
            Console.WriteLine(num1 + "^3" + "=" + p3());
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            power tavan = new power();
            tavan.data();
            tavan.show();
            Console.ReadKey();

        }
    }
}