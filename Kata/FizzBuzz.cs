namespace Kata;

public class FizzBuzz
{
    public static string execute(int number)
    {
        if (number % 3 == 0)
        {
            return "Fizz";
        }

        if (number % 5 == 0)
        {
            return "Buzz";
        }
        return "1";
    }
}
