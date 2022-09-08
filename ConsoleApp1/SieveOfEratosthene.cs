namespace ConsoleApp1;

public class SieveOfEratosthene
{
    private List<int> GenerateList(int MaxNumber)
    {
        List<int> list = new List<int>();

        for (int i = 2; i < MaxNumber; i++)
        {
            list.Add(i);
        }

        return list;
    }

    public List<int> GetPrimes(int maxNumber)
    {
        List<int> numbers = GenerateList(maxNumber);
        List<int> Primes = new List<int>();
        int p = 2;
        while(p < maxNumber)
        {
            for (int i = 1; i < maxNumber; i++)
            {
                if (i * p != p)
                {
                    numbers.Remove(i * p);
                }
            }
            Primes.Add(p);
            numbers.Remove(p);
            if (numbers.Count != 0)
            {
                p = numbers.Min();
            }
            else
            {
                p = maxNumber + 1;
            }
        }

        return Primes;
    }
}

