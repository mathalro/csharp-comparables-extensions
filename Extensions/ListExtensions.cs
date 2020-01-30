using System.Collections.Generic;

namespace extensions
{
    public static class ListExtensions
    {
        public static List<T> AddRange<T>(this List<T> list, params T[] items)
        {
            foreach (var item in items)
            {
                list.Add(item);
            }

            return list;
        }
    }
}