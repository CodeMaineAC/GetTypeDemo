using System;

namespace GetTypeDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            int var = 5;
            Turtle turt = new Turtle();
            double num = 8.3;

            CheckType(var);
            CheckType(turt);
            CheckType(num);


            
        }

        public static void CheckType(object obj)
        {
            if (obj.GetType() == typeof(int))
            {
                Console.WriteLine("This is an integer");
            }
            else if(obj.GetType() == typeof(Turtle))
            {
                Console.WriteLine("This a Turtle, it would be cool if it could draw");
            }
            else Console.WriteLine("I don't know what this is");
        }
    }

    class Turtle
    {

    }
}
