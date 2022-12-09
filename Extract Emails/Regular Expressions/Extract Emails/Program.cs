using System.Text.RegularExpressions;

namespace Extract_Emails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var regex = new Regex (@"(?<=\s)[a-z0-9]+([-.]\w*)*@[a-z]+([-.]w*)*(\.[a-z]+)");
            var text = Console.ReadLine();

            var emails = regex.Matches(text);

            foreach (var email in emails)
            {
                Console.WriteLine(email);
            }
        }
    }
}