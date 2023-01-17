namespace Task7 {
    class Task7 {
        
        static void IsAlpha(char chr) {
            string alphabet = "abcdefghijklmnopqrstuvwxyzåäö";
            if (alphabet.Contains(char.ToLower(chr))) {
                Console.WriteLine("The letter is in the Swedish alphabet!");
            } else {
                Console.WriteLine("The letter is not in the Swedish alphabet!");
            }
        }
        static void task7(string[] args) {
            char inputChar = (char)Console.Read();
            IsAlpha(inputChar);
        }
    }
}