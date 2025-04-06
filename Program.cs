using BagrutListLab;
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
        lst1 = new(1, lst1);
        Console.WriteLine(lst1);
        Console.WriteLine("size is: "+ SizeLst(lst1));
        Node<int> lst2 = new Node<int>(6);
        lst2 = new(0, lst2);
        lst2 = new(8, lst2);
        lst2 = new(1, lst2);
        lst2 = new(1, lst2);
        lst2 = new(1, lst2);
        Console.WriteLine("is it perf: "+CheckPerfLst(lst2));
        Ranges r1 = new(1, 5);
        Ranges r2 = new(8, 10);
        Ranges r3 = new(11, 15);
        Node<BagrutListLab.Ranges> lst3 = new(r3);
        lst3 = new(r2, lst3);
        lst3 = new(r1, lst3);
        Console.WriteLine("hi");
        Console.WriteLine("is 8 in the ranges: "+CheckInRange(lst3,8));
        CreateRangeForNum(lst3, 6);
        Console.WriteLine(lst3);
        Node<int> lst4 = null;
        Console.WriteLine(InsertSortedList(lst4, 7));
        Student s1 = new(92, "lya m");
        Student s2 = new(98, "liya bt");
        Student s3 = new(45, "lior");
        Student s4 = new(20, " sex");

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
    public static Node<int> InsertSortedList(Node<int> lst, int hadash)
    {
        Node<int> newNode = new(hadash);
        if (lst == null || lst.GetValue() > newNode.GetValue())
        {
            newNode.SetNext(lst);
            return newNode;
        }
        Node<int> currNode = lst;
        while (currNode.HasNext() && currNode.GetNext().GetValue() < newNode.GetValue())
        {
            currNode = currNode.GetNext();
        }
        newNode.SetNext(currNode.GetNext());
        currNode.SetNext(newNode);
        return lst;
    }
    public static int SizeLst(Node<int> first)
    {
        Node<int> pos = first;
        int size = 0;
        while (pos != null)
        {
            size++;
            pos = pos.GetNext();
        }
        return size;
    }
    public static bool CheckPerfLst(Node<int> first)
    {
        Node<int> last = first;
        Node<int> pos = first;
        for(int i = 0;i<SizeLst(first)/2; i++)
        {
            last = last.GetNext();
        }
        for (int i = 0; i<SizeLst(first)/2; i++)
        {
            for(int j = 0; j<SizeLst(first)/2; j++)
            {
                if(last.GetValue() < pos.GetValue())
                {
                    return false;
                }
                pos = pos.GetNext();
            }
            last = last.GetNext();
            pos = first;
        }
        return true;
    }
    public static bool CheckInRange(Node<Ranges> first, int num)
    {
        Node<BagrutListLab.Ranges> pos = first;
        while (pos != null)
        {
            if ((num >= pos.GetValue().GetLow()) && (num <= pos.GetValue().GetHigh()))
            {
                return true;
            }
            pos = pos.GetNext();

        }
        return false;
    }
    public static void CreateRangeForNum(Node<BagrutListLab.Ranges> first,int num)
    {
        Node<BagrutListLab.Ranges> pos=first;
        while (num > pos.GetNext().GetValue().GetHigh())
        {
            pos = pos.GetNext();
            if (!pos.HasNext())
            {
                break;
            }
        }
        int upper;
        if ((pos.HasNext()) && (pos.GetNext().GetValue().GetLow() > 5 + num))
        {
            upper = num + 5;
        }
        else if((pos.HasNext()) && (pos.GetNext().GetValue().GetLow() <= 5 + num))
        {
            upper = pos.GetNext().GetValue().GetLow()-1;
        }
        else 
        {
            upper = num + 5;
        }
        int lower;
        if ((pos.HasNext()) && (pos.GetNext().GetValue().GetLow() < num-5))
        {
            lower = num -5;
        }
        else if ((pos.HasNext()) && (pos.GetNext().GetValue().GetLow() >= num-5))
        {
            lower = pos.GetNext().GetValue().GetLow()-1;
        }
        else 
        {
            lower = num - 5;
        }
        if(num<pos.GetValue().GetLow())
        {
            upper = pos.GetValue().GetLow() - 1;
            lower = num - 5;
        }
        Ranges hadashR=new(lower,upper);
        Node<BagrutListLab.Ranges> hadash = new(hadashR, pos.GetNext());
        pos.SetNext(hadash);
    }
    public static Node<Student> InsertInStudentList(Node<Student> lst, Node<Student> newNode)
    {
        if (lst == null || lst.GetValue().GetGrade() > newNode.GetValue().GetGrade())
        {
            newNode.SetNext(lst);
            return newNode;
        }
        Node<Student> currNode = lst;
        while (currNode.HasNext() && currNode.GetNext().GetValue().GetGrade() < newNode.GetValue().GetGrade())
        {
            currNode = currNode.GetNext();
        }
        newNode.SetNext(currNode.GetNext());
        currNode.SetNext(newNode);
        return lst;
    }
}