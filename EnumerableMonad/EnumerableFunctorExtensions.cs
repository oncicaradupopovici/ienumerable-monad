using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnumerableMonad
{
    public static class EnumerableFunctorExtensions
    {
        public static IEnumerable<TResult> Map<T, TResult>(this IEnumerable<T> sequence, Func<T, TResult> selector) =>
            sequence.Select(selector);
    }
}
