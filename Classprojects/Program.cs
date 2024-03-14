
using System;

class Program
{
    static void Main()
    {
        //1
        Console.WriteLine("Please write one letter");
        char l1 = char.Parse(Console.ReadLine());
        Console.WriteLine("Please write one more letter");
        char l2 = char.Parse(Console.ReadLine());
        Console.WriteLine("The charachters in reverse order {0} {1}", l2, l1);
        char temp = l1;
        l1 = l2;
        l2 = temp;
        Console.WriteLine("The characters after swapping: {0} {1}", l1, l2);


        //2.1 x=7 y=2 int3=3
        Console.WriteLine("write a number");
        int int1 = int.Parse(Console.ReadLine());
        Console.WriteLine("write another number");
        int int2 = int.Parse(Console.ReadLine());
        int int3 = int1 / int2;
        Console.WriteLine(int3);
        //2.2 x=7 y=2 int3=3.5 (double) -> converts just 1 time, to force double, has to be saved as double hence 'double 3'
        double double3 = (double) int1 / (double) int2;
        Console.WriteLine(double3);

        //3 generate random number 0-10
        int random_num;
        Random rnd = new Random();
        random_num = rnd.Next(11); // (100-200)
        Console.WriteLine("The random number is:" + random_num);

        //4 a- פולינדרום
        int num, units, hundreds;
        Console.WriteLine("הננס מספר תלת ספרתי");
        num = int.Parse(Console.ReadLine());
        // b- פרוק ספרות אחדות ומאות
        units = num % 10;
        hundreds = num / 100;
        // c- הוראה לביצוע - בתנאי
        if (units==hundreds)
        Console.WriteLine("{0} is a polindrom", num);
        else Console.WriteLine("{0} is not a polindrom", num);

        //5
        Console.WriteLine("Enter your first number");
        float float1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter your second number");
        float float2 = float.Parse(Console.ReadLine());
        if ((float1 < 0 && float2 > 0) || (float1 > 0 && float2 < 0))
            {
            Console.WriteLine("True");
            }
        else
            {
            Console.WriteLine("False");
            }
        
        //calculator +,-,*,/ 1 תרגיל לבית
        Console.WriteLine("write a number");
        double num1 = double.Parse(Console.ReadLine());
        Console.WriteLine("write another number");
        double num2 = double.Parse(Console.ReadLine());
        double plusnum = num1 + num2;
        double minusnum = num1 - num2;
        double multiplynum = num1 * num2;
        double dividenum = num1 / num2;
        Console.WriteLine("Plus: " + plusnum);
        Console.WriteLine("Minus: " + minusnum);
        Console.WriteLine("Multiply: " + multiplynum);
        Console.WriteLine("divide: " + dividenum);
        string operation = Console.ReadLine();
        
        
        //normal calculator the one above is sh*t



        //d-2 תרגיל לבית
        Console.WriteLine("Enter your first number");
        int fn1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter your first number");
        int fn2 = int.Parse(Console.ReadLine());
        int fn3 = fn1 + fn2;
        if (fn3 < 100)
            {
            Console.WriteLine("Small " + fn3);
            }
        else if (fn3 > 100)
            {
            Console.WriteLine("Big " + fn3);
            }
    }
}