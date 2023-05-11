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
    [TestFixture]
    public class TestInventory
    {
        string testlist;
        Inventory inventory = new Inventory();
        Item _testhammer = new Item(new string[] { "hammer" }, "a metal hammer", " a large metal hammer");
        Item _testsword = new Item(new string[] { "sword" }, "a long sword", "a razor sharp long sword");

        [SetUp()]
        public void SetUp()
        {
            testlist = $"\t{_testsword.ShortDescription}\n\t{_testhammer.ShortDescription}\n";
            inventory.Put(_testsword);
            inventory.Put(_testhammer);
        }

        [Test]
        public void TestHasItem()
        {

            Assert.IsTrue(inventory.HasItem("sword"));
            Assert.IsTrue(inventory.HasItem("hammer"));
            Assert.IsFalse(inventory.HasItem("sink"));
        }

        [Test]
        public void TestDoesNotHaveItem()
        {
            Assert.IsFalse(inventory.HasItem("hat"));
            Assert.IsFalse(inventory.HasItem("glasses"));
        }

        [Test]
        public void TestFetchItem()
        {
            Assert.That(inventory.Fetch("sword"), Is.EqualTo(_testsword));
            Assert.IsTrue(inventory.HasItem("sword"));
        }

        [Test]
        public void TestTakeItem()
        {
            Assert.AreEqual(inventory.Take("sword"), _testsword);
            Assert.IsFalse(inventory.HasItem("sword"));
        }

        [Test]
        public void TestItemList() 
        {
            Assert.AreEqual($"\ta long sword (sword)\n\ta metal hammer (hammer)\n", inventory.ItemList);
        }
    }
}
