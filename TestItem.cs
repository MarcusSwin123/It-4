using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using NUnit.Framework;
using SwinAdventure_It_3;

namespace SwinAdventureTests3It3
{
    public class TestItem
    {
        Item testitem;
        string testShortDesc;
        [SetUp()]
        public void Setup()
        {
            testitem = new(new string[] { "sword" }, "long sword", "a razor sharp long sword");
            //testShortDesc = "a long sword (sword)";
        }

        [Test]
        public void TestAreYou()
        {
            Assert.IsTrue(testitem.AreYou("sword"));
        }

        [Test]
        public void TestShortDesc()
        {
            Assert.AreEqual(testitem.ShortDescription, "long sword (sword)");
        }

        [Test]
        public void TestFullDesc()
        {
            Assert.AreEqual(testitem.FullDescription, "a razor sharp long sword");
        }
    }
}
