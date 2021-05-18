# The brief

[kata from codewars](https://www.codewars.com/kata/5682e809386707366d000024/csharp)
The original [PatternCraft series (by John Lindquist)](https://www.youtube.com/playlist?list=PL8B19C3040F6381A2)

Complete the code so that when a Viking is flying its position increases by 10 each time it moves. If it is walking then the position is increased by 1.

In this Kata, Viking starts as a ground unit when it is created.

You have 3 classes:

Viking: has a position, moveBehavior and move method.
Fly and Walk: the move behaviors with the move(unit) method. Fly has to move 10 positions at a time and Walk has to move 1.

# To Run
requires .net sdk

```
cd strategy
dotnet build
dotnet run
```

# To Test

```
cd strategy.tests
dotnet build
dotnet test
```