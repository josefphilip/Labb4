using System;
using System.IO;
using System.Linq;
using WordLibrary;

namespace ConsoleVersion
{
    public class Program
    {
        private static void Main(string[] args)
        {
            WordList currentWordList = null;
            WordList.CreateFolder();

            if (args.Length == 0)
            {
                Console.WriteLine("Use any of the following parameters:");
                Console.WriteLine("-lists");
                Console.WriteLine("-new <list name> <language 1> <language 2> .. <language n>");
                Console.WriteLine("-add <list name>");
                Console.WriteLine("-remove <list name> <language> <word 1> <word 2> .. <word n>");
                Console.WriteLine("-words <list name> <sortByLanguage> ");
                Console.WriteLine("-count <list name>");
                Console.WriteLine("-practice <list name>");
            }

            try
            {
                switch (userInput(args)[0])
                {
                    case "-lists":
                        ConsoleList();
                        break;
                    case "-new":
                        ConsoleNew();
                        break;
                    case "-add":
                        ConsoleAdd();
                        break;
                    case "-remove":
                        ConsoleRemove();
                        break;
                    case "-words":
                        ConsoleWords();
                        break;
                    case "-count":
                        ConsoleCount();
                        break;
                    case "-practice":
                        ConsolePractice();
                        break;
                }
            }
            catch (Exception)
            {
            }


            void ConsoleList()
            {
                var files = WordList.GetLists();
                foreach (var file in files) Console.WriteLine(file);
            }

            void ConsoleNew()
            {
                var newFile = userInput(args)[1];
                var languages = new string[userInput(args).Length - 2];

                if (File.Exists(WordList.GetLists() + newFile + ".dat"))
                {
                    Console.WriteLine($"{newFile} already exists. Try again with a different name.");
                    return;
                }

                for (var i = 0; i < languages.Length; i++) languages[i] = userInput(args)[i + 2];

                currentWordList = new WordList(newFile, languages);
                currentWordList.Save();
                ConsoleAdd();
            }

            void ConsoleAdd()
            {
                currentWordList = WordList.LoadList(userInput(args)[1]);
                if (currentWordList == null)
                {
                    Console.WriteLine("Invalid list.");
                }
                else
                {
                    var word = "";
                    do
                    {
                        var newWord = new string[currentWordList.Languages.Length];

                        for (var i = 0; i < currentWordList.Languages.Length; i++)
                        {
                            Console.Write($"Write a word in {currentWordList.Languages[i]}: ");
                            word = Console.ReadLine();

                            if (word == "") break;

                            newWord[i] = word;
                        }

                        if (!newWord.Contains(null)) currentWordList.Add(newWord);
                    } while (word != "");

                    currentWordList.Save();
                }
            }

            void ConsoleRemove()
            {
                currentWordList = WordList.LoadList(userInput(args)[1]);
                if (currentWordList == null)
                {
                    Console.WriteLine("Invalid list.");
                }
                else
                {
                    var language = userInput(args)[2];
                    var removeLanguage = 0;

                    for (var i = 0; i < currentWordList.Languages.Length; i++)
                        if (currentWordList.Languages[i] == language)
                            removeLanguage = i;

                    Console.WriteLine($"The following words were removed from list {userInput(args)[1]}.");
                    for (var i = 3; i < userInput(args).Length; i++)
                        if (currentWordList.Remove(removeLanguage, userInput(args)[i]))
                            Console.WriteLine($"- {userInput(args)[i]}");

                    currentWordList.Save();
                }
            }

            void ConsoleWords()
            {
                currentWordList = WordList.LoadList(userInput(args)[1]);
                if (currentWordList == null)
                {
                    Console.WriteLine("Invalid list.");
                }
                else
                {
                    var languageToSort = userInput(args)[2];
                    var numberOfLanguages = 0;

                    for (var i = 0; i < currentWordList.Languages.Length; i++)
                        if (languageToSort == currentWordList.Languages[i])
                            numberOfLanguages = i;

                    Console.WriteLine();

                    foreach (var t in currentWordList.Languages) Console.Write($"{t.PadRight(20).ToUpper()}");

                    Console.WriteLine();

                    Action<string[]> listWords = words =>
                    {
                        foreach (var t in words) Console.Write($"{t.PadRight(20)}");

                        Console.WriteLine();
                    };
                    currentWordList.List(numberOfLanguages, listWords);
                    Console.WriteLine();
                }
            }


            void ConsoleCount()
            {
                currentWordList = WordList.LoadList(userInput(args)[1]);
                if (currentWordList == null)
                    Console.WriteLine("Invalid list.");

                else
                    Console.WriteLine($"Number of words in {currentWordList.Name}: {currentWordList.Count()}");
            }

            void ConsolePractice()
            {
                currentWordList = WordList.LoadList(userInput(args)[1]);
                if (currentWordList == null)
                {
                    Console.WriteLine("Invalid list.");
                }
                else
                {
                    var wordTranslation = "";
                    var attemptedTranslations = 0.0;
                    var accurateTranslations = 0.0;

                    while (true)
                    {
                        Console.WriteLine();
                        var word = currentWordList.GetWordToPractice();
                        Console.WriteLine(
                            $"Translate {currentWordList.Languages[word.FromLanguage]}: {word.Translations[word.FromLanguage]}");
                        Console.Write($"To {currentWordList.Languages[word.ToLanguage]}: ");
                        wordTranslation = Console.ReadLine();
                        attemptedTranslations++;

                        if (wordTranslation == word.Translations[word.ToLanguage])
                        {
                            Console.WriteLine("Correct translation!");
                            accurateTranslations++;
                        }

                        if (wordTranslation != word.Translations[word.ToLanguage])
                        {
                            if (wordTranslation == "")
                            {
                                attemptedTranslations--;
                                Console.WriteLine();
                                break;
                            }

                            Console.WriteLine("Incorrect translation!");
                        }
                    }

                    if (string.IsNullOrWhiteSpace(wordTranslation))
                    {
                        Console.WriteLine();
                        Console.WriteLine(
                            $"Number of words you practiced: {attemptedTranslations}, Accurate amount of translations: {accurateTranslations}");
                        Console.WriteLine($"Your score: {accurateTranslations / attemptedTranslations * 100:0}%");
                    }
                }
            }
        }

        private static string[] userInput(string[] input)
        {
            var argsArray = new string[input.Length];
            for (var i = 0; i < input.Length; i++) argsArray[i] = input[i];
            return argsArray;
        }
    }
}