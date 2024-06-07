using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal static class Extensions
    {
        internal static IEnumerable<T> OurersWhere<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            foreach (T person in source)
            {
                if (predicate(person))
                {
                    yield return person;
                }
            }
        }
    }
}
