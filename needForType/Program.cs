namespace needForType;

public class needForType
{
    public static void Main(string[] args)
    {
        
    }

    IEnumerable<T> CreateCollectionOfRandomLenght<T>(int maxLength) where T: new()
    {
        var lenght = new Random().Next(maxLength + 1);

        var result = new List<T>();

        for (int i = 0; i < lenght; ++i)
        {
            result.Add(new T());
        }
        
        return result;
    }
}