using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmiCalculatorApp.Models
{
    internal class Person
    {
        static int DEFAULT_HEIGHT = 5;
        static int DEFAULT_WEIGHT = 50;
        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public double Height { get; set; } = DEFAULT_HEIGHT;

        public double Weight { get; set; } = DEFAULT_WEIGHT;

        public Person(int id , string name , int age) { 
            Id = id;    
            Name = name;
            Age = age;
        
        }

        public Person(int id , string name , int age  , double height , double weight ):this( id , name , age) 
        { 
            Weight = weight;
            Height = height;
            
        }

        public double CalcuateTheBmi() {

            double bmi = Weight / (Height * Height);  

            return Math.Round(bmi, 2);

        }

        public string GetBodyType(double bmi)
        {
            if (bmi <= 18.4)
                return "Underweight";
            else if (bmi > 18.4 && bmi < 25.0)
                return "Normal";
            else if (bmi >= 25.0 && bmi < 40.0)
                return "Overweight";
            else
                return "Obese";
                    
        }

        public override string ToString() {
            return $"Id : {Id} \nName : {Name} \nAge : {Age} \nHeight : {Height} \nWeight : {Weight}";
        }
    }
}
