using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BmiCalculatorApp.Models;

namespace BmiCalculatorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person(1, "Samuel", 21);

            Person person2 = new Person(2, "Saroj", 22, 1.75, 150);


            Console.WriteLine(person1);
            
            
            double person1Bmi = person1.CalcuateTheBmi();
            Console.WriteLine($"BMI : {person1Bmi} \nBody Type : {person1.GetBodyType(person1Bmi)}" );

            Console.WriteLine("\n===================================================");
            Console.WriteLine("\n" + person2);

            double person2Bmi = person2.CalcuateTheBmi();
            Console.WriteLine($"BMI : {person2Bmi} \nBody Type : {person2.GetBodyType(person2Bmi)}");



        }
    }
}
