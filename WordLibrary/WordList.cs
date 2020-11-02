using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WordLibrary
{
    public class WordList
    {
        private static readonly string folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        private static readonly string specificFolder = Path.Combine(folder, "Glosor");

        public WordList(string name, params string[] languages)
        {
            Name = name;
            Languages = languages;
        }


        public string Name { get; }
        public string[] Languages { get; }

        private List<Word> ListOfTranslations { get; } = new List<Word>();

        public static string[] GetLists()
        {
            var files = Directory.GetFiles(specificFolder).Select(Path.GetFileNameWithoutExtension).ToArray();
            return files;
        }

        public static WordList LoadList(string name)
        {
            var filePath = specificFolder + "\\" + $"{name}.dat";
            if (File.Exists(filePath))
            {
                var sr = new StreamReader(specificFolder + "\\" + $"{name}.dat");
                var fileContent = sr.ReadLine();
                var languages = fileContent.TrimEnd(';').Split(';');
                var wordList = new WordList(name, languages);
                fileContent = sr.ReadLine();

                while (fileContent != null)
                {
                    var word = new Word(fileContent.TrimEnd(';').Split(';'));
                    wordList.ListOfTranslations.Add(word);
                    fileContent = sr.ReadLine();
                }

                sr.Close();
                return wordList;
            }

            return null;
        }


        public void Save()
        {
            var filePath = specificFolder + "\\" + $"{Name}.dat";
            if (File.Exists(filePath))
            {
                var sw = new StreamWriter(filePath);
                sw.WriteLine(Languages[0] + ";" + Languages[1]);
                foreach (var t in ListOfTranslations) sw.WriteLine(t.Translations[0] + ";" + t.Translations[1]);
                sw.Close();
            }
            else
            {
                var sw = new StreamWriter(filePath);
                sw.WriteLine(Languages[0] + ";" + Languages[1]);
                sw.Close();
                foreach (var t in ListOfTranslations) sw.WriteLine(t.Translations[0] + ";" + t.Translations[1]);
            }
        }

        public void Add(params string[] translations)
        {
            var newTranslations = new Word(translations);
            ListOfTranslations.Add(newTranslations);
        }

        public bool Remove(int translation, string word)
        {
            var removeIndex = 0;
            if (ListOfTranslations.Any(i => i.Translations[translation] == word))
                removeIndex =
                    ListOfTranslations.IndexOf(ListOfTranslations.First(i => i.Translations[translation] == word));
            ListOfTranslations.RemoveAt(removeIndex);
            return true;
        }

        public int Count()
        {
            return ListOfTranslations.Count;
        }

        public void List(int sortByTranslation, Action<string[]> showTranslations)
        {
            var sortedTranslations = ListOfTranslations.OrderBy(word => word.Translations[sortByTranslation]).ToList();
            foreach (var w in sortedTranslations) showTranslations(w.Translations);
        }

        public Word GetWordToPractice()
        {
            var rnd = new Random();
            var rndTranslation = rnd.Next(0, ListOfTranslations.Count);
            var fromLanguage = rnd.Next(0, Languages.Length);
            var toLanguage = rnd.Next(0, Languages.Length);

            while (toLanguage == fromLanguage) toLanguage = rnd.Next(0, Languages.Length);

            var words = new Word(fromLanguage, toLanguage, ListOfTranslations[rndTranslation].Translations);

            return words;
        }

        public static void CreateFolder()
        {
            Directory.CreateDirectory(specificFolder);
        }
    }
}