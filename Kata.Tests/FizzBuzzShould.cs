using FluentAssertions;

namespace Kata.Tests;

/*
     1 -> '1' ✔
     3 -> 'Fizz' ✔
     5 -> 'Buzz' ✔
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
    
    [Fact]
    public void turn_into_number_divisible_by_three_to_Fizz_word()
    {
        int NUMBER_DIVISIBLE_BY_THREE = 3;
        FizzBuzz.execute(NUMBER_DIVISIBLE_BY_THREE).Should().Be("Fizz");
    }
    
    [Fact]
    public void turn_into_number_divisible_by_five_to_Buzz_word()
    {
        int NUMBER_DIVISIBLE_BY_FIVE = 5;
        FizzBuzz.execute(NUMBER_DIVISIBLE_BY_FIVE).Should().Be("Buzz");
    }
    
    [Fact]
    public void turn_into_number_divisible_by_five_and_three_to_FizzBuzz_word()
    {
        int NUMBER_DIVISIBLE_BY_FIVE = 15;
        FizzBuzz.execute(NUMBER_DIVISIBLE_BY_FIVE).Should().Be("FizzBuzz");
    }
}
