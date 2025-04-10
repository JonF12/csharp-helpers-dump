namespace CsharpHelpersDump.Extensions;

public static class ListExtensions
{
    public static List<T> SelfAddRange<T>(this List<T> l, List<T> r)
    {
        l.AddRange(r);
        return l;
    }
    public static List<T> SelfAdd<T>(this List<T> l, T r)
    {
        l.Add(r);
        return l;
    }
    public static List<T> SelfInsert<T>(this List<T> l, int index, T item)
    {
        l.Insert(index, item);
        return l;
    }
    public static List<T> SelfInsertRange<T>(this List<T> l, int index, IEnumerable<T> collection)
    {
        l.InsertRange(index, collection);
        return l;
    }
    public static List<T> SelfRemove<T>(this List<T> l, T item)
    {
        l.Remove(item);
        return l;
    }
    public static List<T> SelfRemoveAt<T>(this List<T> l, int index)
    {
        l.RemoveAt(index);
        return l;
    }
    public static List<T> SelfRemoveRange<T>(this List<T> l, int index, int count)
    {
        l.RemoveRange(index, count);
        return l;
    }
    public static List<T> SelfRemoveAll<T>(this List<T> l, Predicate<T> match)
    {
        l.RemoveAll(match);
        return l;
    }
    public static List<T> SelfClear<T>(this List<T> l)
    {
        l.Clear();
        return l;
    }
    public static List<T> SelfSort<T>(this List<T> l)
    {
        l.Sort();
        return l;
    }
    public static List<T> SelfSort<T>(this List<T> l, IComparer<T> comparer)
    {
        l.Sort(comparer);
        return l;
    }
    public static List<T> SelfSort<T>(this List<T> l, Comparison<T> comparison)
    {
        l.Sort(comparison);
        return l;
    }
    public static List<T> SelfReverse<T>(this List<T> l)
    {
        l.Reverse();
        return l;
    }
}
