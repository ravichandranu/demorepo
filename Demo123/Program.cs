 //optional

using System;
namespace Demo123
{
    class Program
    {
        static void Main(string[] args) // entry point
        {

            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            //Console.Write("Your name is:");
            //Console.WriteLine(name);
         
            Console.WriteLine("Enter Your Age");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your Height");
            double height = double.Parse(Console.ReadLine());


            Console.WriteLine("Are you married ? (Press true/false");
            bool marriedstatus = bool.Parse(Console.ReadLine());


            //Console.WriteLine("Your name is: " + name);
            //Console.WriteLine("Your age is :" + age);
            //Console.WriteLine("Your Height is :" + height);
            //Console.WriteLine("Your Married Status is :" + marriedstatus);

            //Console.WriteLine("Your name is :" + name + "\nyour age is:" + age + "\nyour height is:" + height + "Married status:" + marriedstatus);
            Console.WriteLine("Your name is {0}:  your age is {1}: your height is {2} : Married status {3}:", age, name, height, marriedstatus);


        }
    }
}
