namespace TupleSwap;

public static class TupleSwapExercise
{
    public static Tuple<T2,T1> SwapTupleItems <T1,T2> (Tuple<T1,T2> items)
    {
        var newTuple = new Tuple<T2, T1>(items.Item2,items.Item1);

        return newTuple;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        
    }
}


/*
Implement the static SwapTupleItems method. 
Its purpose is to take a Tuple of two items as a parameter and, as a result, 
return a tuple in which those items are swapped.

For example:

for an input equal to Tuple<int, string>(1, "hello"), the result should be Tuple<string, int>("hello", 1)

for an input equal to Tuple<int, int>(1, 2), the result should be Tuple<int, int>(2, 1)
*/