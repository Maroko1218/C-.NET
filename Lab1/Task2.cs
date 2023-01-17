namespace Task2 {
    class Task2 {
        static void task2(string[] args) {
            int input = Convert.ToInt32(Console.ReadLine());
            if (input > 0) {
                Console.WriteLine("The number is positive");
            } else if (input < 0) {
                Console.WriteLine("The number is negative");
            } else {
                Console.WriteLine("The number is zero!");
            }
        }
    }
}