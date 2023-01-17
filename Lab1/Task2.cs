namespace Task2 {
    class Task2 {
        static void task2(string[] args) {
            int input;
            while (true) {
                try {
                    input = Convert.ToInt32(Console.ReadLine());
                    break;
                } catch {
                    Console.WriteLine("Sorry something went wrong please try again!");
                }
            }
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