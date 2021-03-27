# Raindrops
Simple app that contains solutions for a programming challenge

## The challenge

```
Write a function that takes as its input a number (n) and converts it to a string, the contents of which depend on the numbers factors

- if the number has a factor of 3, output 'Pling'
- if the number has a factor of 5, output 'Plang'
- if the number has a factor of 7, output 'Plong'
- if the number does not have any of the above as a factor simply return the numbers digits

Examples

- 28's factors are 1, 2, 4, 7, 14 and 28: this would be a simple 'Plong'
- 30's factors are 1, 2, 3, 5, 6, 10, 15, 30: this would be a 'PlingPlang'
- 34 has four factors: 1, 2, 17, and 34: this would be '34'
```

## How to run it

1. Clone repository
2. Open Visual Studio
3. Run the solution file called Raindrop.sln
4. Open Test Explorer and run the unit tests

The main method that solves the challenge is Raindrops.Solve() inside the class Raindrops.cs, and the accompanying unit tests test different scenarios for this method.

## Project structure

This repository contains two visual studio projects, one with the corresponding unit tests and one holding the logic for solving the challenge.

- RaindropApp
  - Program.cs
  - Raindrops.cs
- RaindropTests
  - TestsWithDefaultSettings.cs
  - TestsWithUserDefinedSettings.cs

## Solution presented

This project solves the challenge presented above and was approached with the SOLID principles in mind and being aware of Code Smells.

**Readability and code smells**

There are many solutions to this challenge, one way to solve it is by using various if else statements. These can make the method difficult to follow, cluttering it many with conditional tests, making the method long and having many duplicate lines. My solution addresses these code smells by instead consisting of one conditional test and a helper method inside, within a loop.

```c#
public string Solve(int inputNum)
{
    // edge cases: num is 0 and negatives
    if (inputNum == 0) return inputNum.ToString();
    int num = Math.Abs(inputNum);

    for (int possibleFactor = 1; possibleFactor <= num; possibleFactor++)
    {
        if (IsFactor(possibleFactor, num))
        {
            Solution += GetRaindropSoundOrDefault(possibleFactor);
        }
    }
    return Solution == "" ? inputNum.ToString() : Solution;
}
```

**Easy to maintain and extend**

The solution presented allows developers to easily extend the functionality like being able to add another rule without changing many variables in many different places of the code. Consider the following examples:

- Adding "2" as a factor-to-check and returning "Zing" or "Zang", can easily be done and in one line.

This flexibility and extendibility is achieved by not depending on magic numbers all over the method's body and instead having the "settings" in one place. 

There is also an overload for the constructor to allow different settings if you don't want the default behaviour of "Pling", "Plang", "Plong".

```c#
private Dictionary<int, string> Settings { get; set; } = new Dictionary<int, string>();

/// Default constructor
public Raindrops()
{
    Settings.Add(1, "");
    Settings.Add(3, "Pling");
    Settings.Add(5, "Plang");
    Settings.Add(7, "Plong");
}
/// Overload constructor: User Defined factors
public Raindrops(Dictionary<int, string> userSettings)
{
    Settings = userSettings;
}
```

It is also easy to maintain as the methods are small and are responsible of one thing only, making the tracing of bugs and modifications easy.

```c#
/// helper method to test for factors
private bool IsFactor(int possibleFactor, int num)
{
    return num % possibleFactor == 0;
}

/// helper method that returns correct sound for a given factor
private string GetRaindropSoundOrDefault(int num)
{
    return Settings.ContainsKey(num) ? Settings[num] : "";
}
```

