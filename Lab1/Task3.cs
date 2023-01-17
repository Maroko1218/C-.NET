namespace Task3 {
    class Task3 {
        static void task3(string[] args) {
            int count = Convert.ToInt32(Console.ReadLine());
            int[] buffer = new int[count];
            for (int i = 0; i < count; i++) {
                buffer[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(buffer);
            Console.WriteLine("Smallest: {0} Biggest: {1}", buffer[0], buffer[count-1]);   
        }
    }
}