using FluentAssertions;

namespace Kata.Tests;

/*
     1 -> '1'
     3 -> 'Fizz'
     5 -> 'Buzz'
     15 -> 'FizzBuzz'
     13 -> 'Fizz'
     33 -> 'FizzFizz'
     51 -> 'Buzz'
     55 -> 'BuzzBuzz'
     35 -> 'FizzBuzzBuzz'
 */

public class FizzBuzzShould
{
    
    [Fact]
    public void turn_into_printable_not_special_numbers()
    {
        int NOT_SPECIAL_NUMBER = 1;
        FizzBuzz.execute(NOT_SPECIAL_NUMBER).Should().Be("1");
    }
}
