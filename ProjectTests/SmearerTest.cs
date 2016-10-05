using SmearerMiddleware;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace ProjectTests
{
    public class SmearerTest
    {
        public SmearerTest()
        {
            testObject = new Smearer();
        }

        private Smearer testObject;

        [Fact]
        //[Theory]
        //[InlineData()]
        public void CanInstantiate()
        {
            Assert.True(testObject != null);
        }
    }
}
