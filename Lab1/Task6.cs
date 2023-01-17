namespace Task6 {
    class Task6 {
        static void task6(string[] args) {
            while (true) {
                try {    
                    Console.WriteLine(Convert.ToInt32(Console.ReadLine()) + Convert.ToInt32(Console.ReadLine()));
                    break;
                } catch {
                    Console.WriteLine("Sorry something went wrong please try again!");
                }
            }
        }
    }
}