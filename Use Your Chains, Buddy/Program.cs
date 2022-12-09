using System.Text;
using System.Text.RegularExpressions;

namespace Use_Your_Chains__Buddy
{
    internal class Program
    {
        private static string Rot13String(string input) 
        {
            var result = new StringBuilder();
            



            foreach (var letter in input)
            {
                result.Append(Rot13(letter));
            }
            return result.ToString();
        }

        private static char Rot13(char letter)
        {
            if (!char.IsLetter(letter))
            {
                return letter;
            }
            var offset = char.IsUpper(letter) ? 'A' : 'a';

            char rotatedLetter = (char)((char)(letter - offset+13)%26+ offset);
            return rotatedLetter;
        }

        static void Main(string[] args)
        {
            var paragraphRegex = new Regex(@"<p>(?<message>.+?)<\/p>");

            var text = Console.ReadLine();

            var paragraphs = paragraphRegex.Matches(text)
                .Cast<Match>()
                .Select(a => a.Groups["message"].Value)
                .Select(a => Regex.Replace(a, @"[^a-z0-9]", " "))
                .Select(a => Regex.Replace(a, @"\s+", " "))
                .ToArray();

            for (int i = 0; i < paragraphs.Length; i++)
            {
                paragraphs[i] = Rot13String(paragraphs[i]);
            }
            var result = new StringBuilder();

            foreach (var paragraph in paragraphs)
            {
                result.Append(paragraph.ToString());
            }

            Console.WriteLine(result);

        }
    }
}