namespace sortedLists;

public class Program
{
    public static void Main(string[] args)
    {
        
    }
}

public class SortedList<T> where T: IComparable<T>
{
    public IEnumerable<T> Items { get; }

    public SortedList(IEnumerable<T> items)
    {
        var asList = items.ToList();
        asList.Sort();
        Items = asList;
    }
}
    
public class FullName : IComparable<FullName>
{
    public string FirstName { get; init; }
    public string LastName { get; init; }

    //sort my last name first then first name if
    /*Kenji Narasaki is first because his last name is first in alphabetical order.
    Two people with the same last name (John Smith and Anna Smith) are ordered by 
    their first names. The last in the order is John Watson because his 
    last name is last in alphabetical order.*/
    public int CompareTo(FullName other)
    {
        int result = this.LastName.CompareTo(other.LastName);
        if (result == 0)
        {
            result = this.FirstName.CompareTo(other.FirstName);
        }

        return result;
    }

    public override string ToString() => $"{FirstName} {LastName}";
    
}