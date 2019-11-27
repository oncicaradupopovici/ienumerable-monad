using System;
using System.Collections.Generic;
using Xunit;

namespace EnumerableMonad.Tests
{
    public class MonadLaws
    {

        [Fact]
        public void LeftIdentity()
        {
            Func<int, IEnumerable<string>> f = x => x.ToString().Split();
            var a = 5;
            
            Assert.Equal(Fun.Return(a).Bind(f), f(a));
        }



    }
}
