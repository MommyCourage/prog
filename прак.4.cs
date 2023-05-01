using System;

namespace Studying

{

class Program

{

static void Main(string[] args)

{

string sentence = "It is a big sentence";

string[] wordsInSentence = sentence.Split(' ');

string firstWord = wordsInSentence[0];

string lastWord = wordsInSentence[wordsInSentence.Length - 1];

wordsInSentence[0] = lastWord;

wordsInSentence[wordsInSentence.Length - 1] = firstWord;

string newSentence = string.Join(" ", wordsInSentence);

Console.WriteLine($"Start sentence: {sentence}.");

Console.WriteLine($"Final sentence: {newSentence}.");

}

}

}