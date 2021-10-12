using System;

namespace ConsoleApp_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            OperatorExamples();
            TryAnIf();
            TrySomeLoops();
            TryAnIfElse();
            //string z;
            //string message = "the answer is" + z;
        }

        private static void TrySomeLoops()
        {
            int count = 0;
            while(count<10)
            {
                count = count + 1;

            }
            for(int i=0;i<5;i++)
            {
                count = count - 1;

            }
            Console.WriteLine("the answer is " + count);
        }

        private static void TryAnIf()
        {
            int someValue = 4;
            string name = "bobbo jr.";
            if ((someValue==3)&&(name =="joe"))
            {
                Console.WriteLine("x is 3 and the name is joe");
            }
            Console.WriteLine("this line runs no matter what");
        }
        private static void TryAnIfElse()
        {
            int x = 5;
            if(x==10)
            {
                Console.WriteLine("x must be 10");
            }
            else
            {
                Console.WriteLine("x isnt 10";
            }
        }

        private static void OperatorExamples()
        {
            // This statement declares a variable and sets it to 3
            int width = 3;
            // The ++ operator increments a variable (adds 1 to it)
            width++;
            // Declare two more int variables to hold numbers and
            // use the + and * operators to add and multiply values
            int height = 2 + 4;
            int area = width * height;
            Console.WriteLine(area); //24

            while (area<20)
            {
                height++;
                area = width * height;
            }

            do
            {
                width--;
                area = width * height;
            } while (area>25);
            // The next two statements declare string variables
            // and use + to concatenate them (join them together)
            string result = "The area";
            result = result + " is " + area;//the area is 24
            Console.WriteLine(result);
            // A Boolean variable is either true or false
            bool truthValue = true;
            Console.WriteLine(truthValue);
        }
    }
}
