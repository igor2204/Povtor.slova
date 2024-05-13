using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите строку:");
        string inputString = Console.ReadLine();

        string outputString = HighlightRepeatedWords(inputString);

        Console.WriteLine(outputString);
    }

    static string HighlightRepeatedWords(string input)
    {
        // Регулярное выражение для поиска повторяющихся слов
        string pattern = @"\b(\w+)\b(?=.*\b\1\b)";

        // Заменяем найденные слова на выделенные тегами <strong>
        string result = Regex.Replace(input, pattern, "<strong>$1</strong>");

        return result;
    }
}