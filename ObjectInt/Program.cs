namespace ObjectInt;

internal class Program
{
    static void Main(string[] args)
    {
        int[] sizes = [1_000_000, 10_000_000, 100_000_000];

        Timer timer = new Timer();

        foreach (int size in sizes)
        {
            timer.timerIntObject(size);
        }

        timer.timerIntObject(sizes);
    }
}
