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
    public class TestBag
    {
        Bag b1;
        Bag b2;
        Inventory inventory;
        Item _testhammer = new Item(new string[] { "hammer" }, "a metal hammer", " a large metal hammer");
        Item _testsword = new Item(new string[] { "sword" }, "a long sword", "a razor sharp long sword");

        [SetUp()]
        public void Setup()
        {
            b1 = new Bag(new string[] { "bag" }, "carry bag", "a large carry bag to hold things");
            b2 = new Bag(new string[] { "bag 2" }, "backpack bag", "a backpack to hold stuff");
            b1.Inventory.Put(_testsword);
            b2.Inventory.Put(_testhammer);
        }

        [Test]
        public void TestLocatesItems()
        {
            Assert.AreEqual(b1.Locate("sword"), _testsword);
            Assert.AreEqual(b2.Locate("hammer"), _testhammer);

            Assert.That(b1.Inventory.HasItem("sword"), Is.True);
            Assert.That(b2.Inventory.HasItem("hammer"), Is.True);
        }

        [Test]
        public void TestLocatesSelf()
        {
            Assert.AreEqual(b1, b1.Locate("bag"));
        }

        [Test]
        public void TestLocatesNull()
        {
            Assert.AreEqual(null, b1.Locate("chair"));
        }

        [Test]
        public void TestFullDesc()
        {
            Assert.AreEqual($"In the carry bag you can see:\n\ta long sword (sword)\n", b1.FullDescription);
        }

        [Test]
        public void TestBagInBag()
        {
            b1.Inventory.Put(b2);
            Assert.AreEqual(b1.Locate("bag 2"), b2);
            Assert.AreEqual(b1.Locate("sword"), _testsword);
            Assert.AreEqual(b1.Locate("hammer"), null);
        }
    }
}
