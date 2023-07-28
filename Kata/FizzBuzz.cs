namespace Kata;

public class FizzBuzz
{
    public string execute(int number)
    {
        if (isDivisibleByThree(number) && isDivisibleByFive(number))
        {
            return "FizzBuzz";
        }
        
        if (isDivisibleByThree(number))
        {
            return "Fizz";
        }

        if (isDivisibleByFive(number))
        {
            return "Buzz";
        }
        return "1";
    }

    private  bool isDivisibleByFive(int number)
    {
        return number % 5 == 0;
    }

    private bool isDivisibleByThree(int number)
    {
        return number % 3 == 0;
    }
}
