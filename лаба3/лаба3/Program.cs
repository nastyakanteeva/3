internal class Program
{
    private static void Main(string[] args)
    {
        int[] array = new int[1000];
        Random r = new();
        for (int i = 0; i < array.Length; i++)
            array[i] = r.Next(0, 10000);

        int min = 10000, max = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (i < min && i % 37 == 0)
                min = i;
            if (i > max && i % 73 == 0)
                max = i;
        }
        int pairCount = 0, buffIndex = 0, minSumma = 0;
        for (int i = 0; i < array.Length; i++)
        {
            int varArray = array[i];
            if (min > max)
            {
                if (varArray < min && varArray > max)
                {
                    buffIndex = i;
                    continue;
                }
            }
            else
            {
                if (varArray > min && varArray < max)
                {
                    buffIndex = i;
                    continue;
                }
            }
            if (buffIndex == i - 1 || buffIndex == i + 1)
            {
                pairCount++;
                if (minSumma == 0 || minSumma > varArray + array[buffIndex])
                {
                    minSumma = varArray + array[buffIndex];
                }
            }
        }
        Console.WriteLine(pairCount);
        Console.WriteLine(minSumma);
        Console.WriteLine(minSumma);
    }
}
