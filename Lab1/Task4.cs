using System.Text.RegularExpressions;

namespace Task4 {
    class Task4 {
        static void task4(string[] args) {
            string testString = "AB";
            string inputString = Console.ReadLine();
            Console.WriteLine(Regex.Matches(inputString, testString).Count);
        }
    }
}