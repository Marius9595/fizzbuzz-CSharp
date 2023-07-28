using System.Linq.Expressions;
using FluentAssertions;
using FsCheck;
using FsCheck.Fluent;
using Microsoft.FSharp.Core;

namespace Kata.Tests;

/*
     1 -> '1' ✔
     3 -> 'Fizz' ✔
     5 -> 'Buzz' ✔
     15 -> 'FizzBuzz' ✔
 */
public class FizzBuzzShould
{
    [Fact]
    public void turn_into_printable_not_special_numbers()
    {
        var generatorOfNotSpecialNumbers = Gen
            .Choose(0, 100)
            .Where(number => number % 3 != 0)
            .Where(number => number % 5 != 0)
            .ToArbitrary();

        Prop.ForAll<int>(
            generatorOfNotSpecialNumbers, (int number) =>
            {
                new FizzBuzz().execute(number).Should().Be(number.ToString());
            }).QuickCheckThrowOnFailure();
    }

    [Fact]
    public void turn_into_number_divisible_by_three_to_Fizz_word()
    {
        var generatorOfNotSpecialNumbers = Gen
            .Choose(0, 100)
            .Where(number => number % 3 == 0)
            .Where(number => number % 5 != 0)
            .ToArbitrary();
        
        Prop.ForAll<int>(
            generatorOfNotSpecialNumbers, (int number) =>
            {
                new FizzBuzz().execute(number).Should().Be("Fizz");
            }).QuickCheckThrowOnFailure();
    }
    
    [Fact]
    public void turn_into_number_divisible_by_five_to_Buzz_word()
    {
        var generatorOfNotSpecialNumbers = Gen
            .Choose(0, 100)
            .Where(number => number % 3 != 0)
            .Where(number => number % 5 == 0)
            .ToArbitrary();
        
        Prop.ForAll<int>(
            generatorOfNotSpecialNumbers, (int number) =>
            {
                new FizzBuzz().execute(number).Should().Be("Buzz");
            }).QuickCheckThrowOnFailure();
    }
    
    [Fact]
    public void turn_into_number_divisible_by_five_and_three_to_FizzBuzz_word()
    {
        int NUMBER_DIVISIBLE_BY_FIVE = 15;
        new FizzBuzz().execute(NUMBER_DIVISIBLE_BY_FIVE).Should().Be("FizzBuzz");
    }
}
