<Query Kind="Statements" />

var Numbers = Enumerable.Range(1,10);
var squares = Numbers.Select(x=>x*x);

Console.WriteLine(squares);

string sentence = "This is nice sentance";

var wordLength = sentence.Split().Select(w=>w.Length);

Console.WriteLine(wordLength);


 var wordsWithLength = sentence.Split().Select(word => new { Word=word, Size = word.Length });
 
 Console.WriteLine(wordsWithLength);