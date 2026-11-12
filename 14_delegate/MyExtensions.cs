using System;
using System.Collections.Generic;
using System.Text;

namespace _14_delegate
{
    public static class MyExtensions
    {
        public static IEnumerable<T> Where<T>(
            this IEnumerable<T> collection,
            Func<T, bool> predicate)
        {
            foreach (T item in collection)
            {
                
                if (predicate(item))
                {
                    yield return item;
                }
            }
        }

        public static T FirstOrDefault<T>(
            this IEnumerable<T> collection,
            Func<T, bool> predicate)
        {
            foreach (T item in collection)
            {
                
                if (predicate(item))
                {
                    return item;
                }
            }

            
            return default(T);
        }

        public static bool Any<T>(
            this IEnumerable<T> collection,
            Func<T, bool> predicate)
        {
            foreach (T item in collection)
            {
                
                if (predicate(item))
                {
                    return true;
                }
            }

            return false;
        }

        public static bool All<T>(
            this IEnumerable<T> collection,
            Func<T, bool> predicate)
        {
            foreach (T item in collection)
            {
                
                if (!predicate(item))
                {
                    return false;
                }
            }

            return true;
        }

        public static int Count<T>(
            this IEnumerable<T> collection,
            Func<T, bool> predicate = null)
        {
            int count = 0;

            foreach (T item in collection)
            {
                
                if (predicate == null || predicate(item))
                {
                    count++;
                }
            }

            return count;
        }
    }
}
