using System;
using System.Collections.Generic;
using System.Linq;

namespace EnumerableMonad
{
    public static class EnumerableMonadExtensions
    {
        public static IEnumerable<TResult> Bind<T, TResult>(this IEnumerable<T> sequence,
            Func<T, IEnumerable<TResult>> computation) =>
            sequence.SelectMany(computation);

        public static IEnumerable<T> Return<T>(T value)
        {
            yield return value;
        }

        public static IEnumerable<T> Pure<T>(T value) => Return(value);
    }
}
