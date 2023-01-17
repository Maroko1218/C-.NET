namespace Task3 {
    class Task3 {
        static void task3(string[] args) {
            int count;
            while (true) {
                try {    
                   count = Convert.ToInt32(Console.ReadLine());
                   break;
                } catch {
                    Console.WriteLine("Sorry something went wrong please try again!");
                }
            }
            int[] buffer = new int[count];
            for (int i = 0; i < count; i++) {
                while (true) {
                    try {    
                        buffer[i] = Convert.ToInt32(Console.ReadLine());
                        break;
                    } catch {
                        Console.WriteLine("Sorry something went wrong please try again!");
                    }
                }
            }
            Array.Sort(buffer);
            Console.WriteLine("Smallest: {0} Biggest: {1}", buffer[0], buffer[count-1]);   
        }
    }
}