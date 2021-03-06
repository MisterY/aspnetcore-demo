﻿using DataModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        [Fact]
        public void CanInsertDrumset()
        {
            context.Tom.Add(new Tom
            {
                Name = "PDX-100"
            });
            // fails because there is already the same tom in the database.
            context.SaveChanges();
        }

        [Fact]
        public void CanRead()
        {
            int recordCount = context.Cymbal.Count();
            Debug.WriteLine($"Records: {recordCount}");
            Assert.True(recordCount > 0);
        }
    }
}
