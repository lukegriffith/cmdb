using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConfigItems;
using System.Collections.Generic;


namespace CITests
{
    [TestClass]
    public class ServiceTests
    {
        
        CIService _service { get; set; }

        [TestMethod]
        public void ReturnsList()
        {            
            Assert.IsTrue(_service.GetItem().Count > 0);
        }
        
        [TestMethod]
        public void TestNameSearch()
        {
            var a = _service.GetItem("item1");
            Assert.AreEqual("item1", a.Name);
        }

        public ServiceTests()
        {
            _service = new CIService();
        }
    }
}
