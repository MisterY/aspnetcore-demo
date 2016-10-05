using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace ProjectTests
{
    public class DataLayerTests
    {
        public DataLayerTests()
        {
            this.context = new MyContext();
        }

        private MyContext context { get; set; }

        [Fact]
        public void CanInstantiate()
        {
            Assert.True(context != null);
        }
    }
}
