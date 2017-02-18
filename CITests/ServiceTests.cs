using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConfigItems;
using ConfigItems.Models;


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
            var items = _service.GetItem("item1");
            Assert.AreEqual("item1", items.Name);
        }

        [TestMethod]
        public void TestUserSearch()
        {
            var items = _service.GetItemByUser("Luke");
            Assert.IsTrue(items.Count == 4);
        }

        [TestMethod]
        public void TestOwnerSearch()
        {
            var items = _service.GetItemByOwner("Ops");
            Assert.IsTrue(items.Count == 3);
        }


        [TestMethod]
        public void TestAdd()
        {
            ConfigItem newItem = new ConfigItem { Name = "TestItem" };

            int BeforeCount = _service.GetItem().Count;

            _service.AddItem(newItem);

            int AfterCount = _service.GetItem().Count;

            Assert.IsTrue(AfterCount == BeforeCount + 1);
        }

        public ServiceTests()
        {
            _service = new CIService();
        }
    }
}
