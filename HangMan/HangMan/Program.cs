using System;

namespace HangMan
{
    class HangMan
    {
        class Program
        {
            static void Main(string[] args)
            {
                string[] words = { "banana", "coding", "money", "ambulance", "movie", "hacking", "science", "university" };
                Random randomGenerator = new Random();
                int randomNum = randomGenerator.Next(0, words.Length);

                string chosenWord = words[randomNum];
                string hiddenWord = "";

                for (int i = 0; i < chosenWord.Length; i++)
                {
                    hiddenWord += "*";
                }

                while (hiddenWord.Contains("*"))
                {
                    Console.WriteLine($"Word: {hiddenWord}");
                    Console.Write("Guess the letter >>");
                    char letter = char.Parse(Console.ReadLine());
                    bool containsLetter = false;
                    for (int i = 0; i < chosenWord.Length; i++)
                    {
                        if (chosenWord[i] == letter)
                        {
                            hiddenWord = hiddenWord.Remove(i, 1);
                            hiddenWord = hiddenWord.Insert(i, letter.ToString());
                            containsLetter = true;
                        }
                    }
                    if (containsLetter == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"The letter {letter} is there");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"{letter} is not in there");
                    }
                    Console.ResetColor();

                }
                Console.WriteLine($"Congratulatioins you win, the word was {chosenWord}");
            }
        }
    }
}