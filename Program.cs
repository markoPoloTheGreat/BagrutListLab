using ListLab;

public class Program
{
    private static void Main(string[] args)
    {
        Node<int> lst1 = new Node<int>(10);
        Node<int> currNode= new Node<int>(9,lst1);
        lst1 = currNode;
        currNode= new(8,lst1);
        lst1 = currNode;
        currNode = new(6,lst1);
        lst1 = currNode;
        currNode = new(5,lst1);
        lst1 = currNode;
        currNode = new(4,lst1);
        lst1 = currNode;
        currNode = new(3,lst1);
        lst1 = currNode;
        currNode = new(2,lst1);
        lst1 = currNode;
        Console.WriteLine("sum is:"+SumLinked(lst1));
        Console.WriteLine("amount of evens:"+ EvenInList(lst1));
        InsertSortedList(lst1,7);
        Console.WriteLine(lst1);

    }
    public static int SumLinked(Node<int> first)
    {
        Node<int> pos = first;
        int sum = 0;
        while (pos != null)
        {
            sum += pos.GetValue();
            pos = pos.GetNext();
        }
        return sum;
    }
    public static int EvenInList(Node<int> first)
    {
        Node<int> pos = first;
        int evens = 0;
        while (pos != null)
        {
            if (pos.GetValue() % 2 == 0)
            {
                evens++;
            }
            pos = pos.GetNext();
        }
        return evens;
    }
    public static int BiggestInList (Node<int> first)
    {
        Node<int> pos = first;
        int biggest=pos.GetValue();
        while (pos != null)
        {
            if (pos.GetValue() > biggest)
            {
                biggest = pos.GetValue();
            }
            pos = pos.GetNext();
        }
        return biggest;

    }
    public static void InsertSortedList(Node<int> first,int hadash)
    {
        Node<int> pos= first;
        Node<int> insert = new(hadash);
        while (pos.GetNext().GetValue() < insert.GetValue())
        {
            pos = pos.GetNext();
        }
        insert.SetNext(pos.GetNext());
        pos.SetNext(insert);
    }

}