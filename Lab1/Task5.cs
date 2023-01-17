namespace Task5 {
    class Task5 {
        static void task5(string[] args) {
            float[] floatArray = new float [10];   
            for (int i = 0; i < 10; i++) {
                floatArray[i] = float.Parse(Console.ReadLine().Replace(".", ","));
            }
            Array.Sort(floatArray);
            Console.WriteLine("Median: {0} Mean: {1}", (floatArray[4] + floatArray[5]) / 2, Enumerable.Sum(floatArray)/10);
        }
    }
}