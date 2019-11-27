using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace EnumerableMonad.Tests
{
    public class FunctorLaws
    {
        [Fact]
        public void FunctorFirstLaw()
        {
            var seq = Enumerable.Range(0, 100).ToArray();

            Assert.Equal(Fun.Map<int, int>(Fun.Identity)(seq), Fun.Identity(seq));
        }

        [Fact]
        public void FunctorSecondLaw()
        {
            Func<int, string> f = x => x.ToString();
            Func<string, int> g = x => x.Length;

            var seq = Enumerable.Range(0, 100).ToArray();
            
            Assert.Equal(Fun.Map(Fun.Compose(g, f))(seq), Fun.Compose(Fun.Map(g), Fun.Map(f))(seq));
        }



    }
}
