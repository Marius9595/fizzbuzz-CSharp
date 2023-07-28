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
    private int MAX = 100;
    private int MIN = 0;
    
    [Fact]
    public void turn_into_printable_not_special_numbers()
    {
        var generatorOfNotSpecialNumbers = Gen
            .Choose(MIN, MAX)
            .Where(number => !IsDivisibleByThree(number))
            .Where(number => !IsDivisibleByFive(number))
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
            .Choose(MIN, MAX)
            .Where(number => IsDivisibleByThree(number))
            .Where(number => !IsDivisibleByFive(number))
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
            .Choose(MIN, MAX)
            .Where(number => !IsDivisibleByThree(number))
            .Where(number => IsDivisibleByFive(number))
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
        var generatorOfNotSpecialNumbers = Gen
            .Choose(MIN, MAX)
            .Where(number => IsDivisibleByThree(number))
            .Where(number => IsDivisibleByFive(number))
            .ToArbitrary();
        
        Prop.ForAll<int>(
            generatorOfNotSpecialNumbers, (int number) =>
            {
                new FizzBuzz().execute(number).Should().Be("FizzBuzz");
            }).QuickCheckThrowOnFailure();
    }
    
    private bool IsDivisibleByThree(int number)
    {
        return number % 3 == 0;
    }
    private bool IsDivisibleByFive(int number)
    {
        return number % 5 == 0;
    }
}
