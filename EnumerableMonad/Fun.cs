using System;
using System.Collections.Generic;

namespace EnumerableMonad
{
    public class Fun
    {
        public static T Identity<T>(T x) => x;
        public static Func<T1, T3> Compose<T1, T2, T3>(Func<T2, T3> f, Func<T1, T2> g) => x => f(g(x));
        public static Func<IEnumerable<T1>, IEnumerable<T2>> Map<T1, T2>(Func<T1, T2> selector) => x => x.Map(selector);
        public static Func<IEnumerable<T1>, IEnumerable<T2>> Bind<T1, T2>(Func<T1, IEnumerable<T2>> kFunc) => x => x.Bind(kFunc);

        public static Func<T1, IEnumerable<T3>> ComposeK<T1, T2, T3>(Func<T2, IEnumerable<T3>> f, Func<T1, IEnumerable<T2>> g) =>
            x => g(x).Bind(f);

        public static IEnumerable<T> Join<T>(IEnumerable<IEnumerable<T>> seqOfSeq) => seqOfSeq.Bind(Identity);
    }
}
