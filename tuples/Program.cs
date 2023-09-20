namespace tuples;

public class Program
{
    public static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 5, 7, 6, 8, 9, 12, 3, 45 };

        twoInts minAndMax = GetMinAndMax(numbers);
        Console.WriteLine("Smallest number is " + minAndMax.Int1);
        Console.WriteLine("Largest number is " + minAndMax.Int2);
    }

    public static twoInts GetMinAndMax(IEnumerable<int> numbers)
    {
        int min = numbers.First();
        int max = numbers.First();
        if (!numbers.Any())
        {
            Console.WriteLine("List cannot be empty");
        }
        else
        {
            foreach (var item in numbers)
            {
                if (item > max)
                {
                    max = item;
                }

                if (item < min)
                {
                    min = item;
                }
            }
        }
        return new twoInts(min, max);
    }
    
    
}

public class twoInts
{
    public int Int1 { get;  }
    public int Int2 { get; }

    public twoInts(int int1, int int2)
    {
        Int1 = int1;
        Int2 = int2;
    }
}
