namespace Operators
{
    class Program
    {
        public static void Main()
        {

        // Assignment
        int x = 3;
        int y = 4;
        y = y + 2;
        Console.WriteLine(y);
        y += 2;
        Console.WriteLine(y);
        y /= 2;
        Console.WriteLine(y);
        x *= 2;
        Console.WriteLine(x);

        // Logical Operators
        bool isSucces = true;
        bool isCompleted = false;

        if (isSucces && isCompleted)
        {
            Console.WriteLine("Perfect");
        }

        if (isSucces || isCompleted)
        {
            Console.WriteLine("Great");
        }

        if (isSucces && !isCompleted)
        {
            Console.WriteLine("Fine");
        }

        // Relational Operators
        int a = 3;
        int b = 4;
        bool result = a < b;
        Console.WriteLine(result);

        result = a > b;
        Console.WriteLine(result);
        result = a <= b;
        Console.WriteLine(result);
        result = a >= b;
        Console.WriteLine(result);
        result = a == b;
        Console.WriteLine(result);
        result = a != b;
        Console.WriteLine(result);

        // Arithmetic Operators
        int number1 = 10;
        int number2 = 5;
        int res1 = number1 / number2;
        Console.WriteLine(res1);
        int res2 = number1 + number2;
        Console.WriteLine(res2);
        int res3 = number1 - number2;
        Console.WriteLine(res3);
        int res4 = number1 * number2;
        Console.WriteLine(res4);
        int res5 = number1++;
        Console.WriteLine(res5);

        // %: Modulus
        int re2 = 20 % 3;
        Console.WriteLine(re2);


        }
    }
}