<Query Kind="Statements" />

int[] numbers = {1,2,3,4,5};

Console.WriteLine("Are all numbers > 0?"+numbers.All(x=>x>0));

Console.WriteLine("Are all numbers odd numbers ?"+numbers.All(x=>x%2==1));

Console.WriteLine("Any numbers <2  ?"+numbers.Any(x=>x<2));

Console.WriteLine("Contains 5?"+numbers.Contains(5));