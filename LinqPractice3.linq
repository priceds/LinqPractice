<Query Kind="Statements" />

string word1 = "helloooo";
string word2 = "help";

Console.WriteLine(word1.Distinct());

var interSect =  word1.Intersect(word2);
Console.WriteLine(interSect);


var union = word1.Union(word2);

Console.WriteLine(union);


Console.WriteLine(word1.Except(word2));