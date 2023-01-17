namespace Task9 {
    class Task9 {
        static void task9(string[] args) {
            Random r = new Random();
            while (true) {
                int[] lottoRow = new int[7];
                for (int i = 0; i < 7; i++) {
                    int nextNum = r.Next(1,37);
                    while (lottoRow.Contains(nextNum)) {
                        nextNum = r.Next(1, 37);
                    }
                    lottoRow[i] = nextNum;
                }
                Console.ReadLine();
                foreach (var num in lottoRow) {
                    Console.Write(num);
                    Console.Write(" ");
                }
            }
        }
    }
}