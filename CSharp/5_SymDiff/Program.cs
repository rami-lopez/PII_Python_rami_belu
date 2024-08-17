using System.Collections;

ArrayList list1 = new ArrayList { 1, 2, 3 };
ArrayList list2 = new ArrayList { 3, 4, 5 };
ArrayList list3 = new ArrayList { };

Functions.SymmetricDifference(list1, list2, list3);

foreach (int element in list3)
{
    Console.WriteLine(element);
}

public static class Functions
{
    public static void SymmetricDifference(ArrayList list1, ArrayList list2, ArrayList list3)
    {
        foreach (int i in list1)
        {
            if (list2.Contains(i) == false)
            {
                list3.Add(i);
            }
        }

        foreach (int i in list2)
        {
            if (list1.Contains(i) == false)
            {
                list3.Add(i);
            }
        }
    }
}