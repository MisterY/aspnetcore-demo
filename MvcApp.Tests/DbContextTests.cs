using MvcApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MvcApp.Tests
{
    public class DbContextTests
    {
        public DbContextTests()
        {
            this.context = new DrumsContext();
        }

        private DrumsContext context;

        [Fact]
        public void CanInstantiate()
        {
            Assert.True(context != null);
        }

        [Fact]
        public void CanGetData()
        {
            var allSets = context.Drumset.ToList();

            Assert.True(allSets.Count() > 0);
        }
    }
}
