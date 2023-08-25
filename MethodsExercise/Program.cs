using System.ComponentModel;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Mad1();

            Console.WriteLine("");

            Sum(9, 3);
            Sub(9, 3);
            Mul(9, 3);
            Div(9, 3);
            Mod(9, 3);
            //multiNum BegNum(36, 8, 4);

        }//Main

        public static void Mad1()
        {
            Console.WriteLine("type a name");
            var name = Console.ReadLine();
            Console.WriteLine("type a color");
            var color = Console.ReadLine();
            Console.WriteLine("type a animal");
            var animal = Console.ReadLine();
            Console.WriteLine("type a action");
            var action = Console.ReadLine();
            Console.WriteLine($"{name} went to the animal shelter and got a {color}{animal} and the first thing the {animal} did was " +
                $"{action}, {name} knew that he now has his hands full");
        }//Mad1

 
        public static int Sum(int num1, int num2) 
        {
            int slime = (num1 + num2);

            Console.WriteLine(slime);  //(num1 + num2)  (write out i.e STRING!, APPEND implicit int to string conversion)
            return slime;
        }
        public static int Sub(int num1, int num2)
        {
            int mines = (num1 - num2);

            Console.WriteLine(mines);  //(num1 + num2)  (write out i.e STRING!, APPEND implicit int to string conversion)
            return mines;
        }//sum
        public static int Mul(int num1, int num2)
        {
            int Mult = (num1 * num2);

            Console.WriteLine(Mult);  //(num1 + num2)  (write out i.e STRING!, APPEND implicit int to string conversion)
            return Mult;
        }//sum
        public static int Div(int num1, int num2)
        {
            int Divid = (num1 / num2);

            Console.WriteLine(Divid);  //(num1 + num2)  (write out i.e STRING!, APPEND implicit int to string conversion)
            return Divid;
        }//sum
        public static int Mod(int num1, int num2)
        {
            int Mod1 = (num1 % num2);

            Console.WriteLine(Mod1);  //(num1 + num2)  (write out i.e STRING!, APPEND implicit int to string conversion)
            return Mod1;
        }//sum

    }//program
}//namespace
