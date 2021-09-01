using CustomQueue.Tests.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using CS = CustomQueue.Tests.Models;

namespace CustomQueue.Tests
{
    [TestClass]
    public class JSONTests
    {
        [TestMethod]
        public void QueueSerializationTest()
        {
            //arrange
            OGParent parent = new OGParent
            {
                Name = "TestObject",
                Queue = new Queue(new List<int>() { 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 })
            };

            //act
            string json = JsonConvert.SerializeObject(parent);
            OGParent newParent = JsonConvert.DeserializeObject<OGParent>(json);

            //assert
            Assert.IsNotNull(newParent);
            Assert.AreEqual("TestObject", newParent.Name);
            Assert.AreEqual(14, newParent.Queue.Count);
        }

        [TestMethod]
        public void CustomQueueSerializationTest()
        {
            //arrange
            CustomParent parent = new CustomParent
            {
                Name = "TestObject",
                Queue = new CS.CustomQueue(new List<int>() { 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 })
            };

            //act
            string json = JsonConvert.SerializeObject(parent);
            CustomParent newParent = JsonConvert.DeserializeObject<CustomParent>(json);

            //assert
            Assert.IsNotNull(newParent);
            Assert.AreEqual("TestObject", newParent.Name);
            Assert.AreEqual(14, newParent.Queue.Count);
        }

    }
}
