using System.Diagnostics;

namespace ObjectInt;

internal class Timer
{
    public void timerIntObject(int size)
    {
        int[] sourceArray = new int[size];
        Random random = new Random();
        for (int i = 0; i < size; i++)
        {
            sourceArray[i] = random.Next();
        }

        int[] intArray = new int[size];
        object[] objectArray = new object[size];

        Stopwatch stopWatchInt = Stopwatch.StartNew();
        for (int j = 0; j < size; j++)
        {
            intArray[j] = sourceArray[j];
        }
        stopWatchInt.Stop();
        long intArrayTime = stopWatchInt.ElapsedMilliseconds;
        Console.WriteLine($"Time elapsed for int ({size} operations): {intArrayTime} ms");

        Stopwatch stopWatchObject = Stopwatch.StartNew();
        for (int h = 0; h < size; h++)
        {
            objectArray[h] = sourceArray[h];
        }
        stopWatchObject.Stop();
        long objectArrayTime = stopWatchObject.ElapsedMilliseconds;
        Console.WriteLine($"Time elapsed for object ({size} operations): {objectArrayTime} ms");

        Console.Write('\n');
    }

    public void timerIntObject(int[] sizes)
    {
        foreach (int size in sizes) 
        {
            int[] sourceArray = new int[size];
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                sourceArray[i] = random.Next();
            }

            int[] intArray = new int[size];
            object[] objectArray = new object[size];

            Stopwatch stopWatchInt = Stopwatch.StartNew();
            for (int j = 0; j < size; j++)
            {
                intArray[j] = sourceArray[j];
            }
            stopWatchInt.Stop();
            long intArrayTime = stopWatchInt.ElapsedMilliseconds;
            Console.WriteLine($"Time elapsed for int ({size} operations): {intArrayTime} ms");

            Stopwatch stopWatchObject = Stopwatch.StartNew();
            for (int h = 0; h < size; h++)
            {
                objectArray[h] = sourceArray[h];
            }
            stopWatchObject.Stop();
            long objectArrayTime = stopWatchObject.ElapsedMilliseconds;
            Console.WriteLine($"Time elapsed for object ({size} operations): {objectArrayTime} ms");

            Console.Write('\n');
        }
    }
}
