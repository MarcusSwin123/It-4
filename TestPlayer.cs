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
    public class TestPlayer
    {
        Player testplayer;
        Inventory _inventory;
        string playerfulldesc;
        Item _testhammer = new Item(new string[] { "hammer" }, "(a metal hammer)", " a large metal hammer");
        Item _testsword = new Item(new string[] { "sword" }, "(a long sword)", "a razor sharp long sword");

        [SetUp()]
        public void Setup()
        {
            //testplayer = new Player("Marcus", "super cool guy");
            _inventory = new Inventory();
            testplayer = new("testplayer", "a player for testing");
            //playerfulldesc = $"You are testplayer, a player for testing.\nYou are carrying:\n{_inventory.ItemList}";
            testplayer.Inventory.Put(_testsword);
            testplayer.Inventory.Put(_testhammer);
        }

        [Test]
        public void TestAreYouPlayer()
        {
            Assert.IsTrue(testplayer.AreYou("me"));
            Assert.IsTrue(testplayer.AreYou("inventory"));
        }

        [Test]
        public void TestLocate()
        {
            Assert.AreEqual(testplayer.Locate("sword"), _testsword);
            Assert.That(testplayer.Inventory.HasItem("sword"), Is.True);
        }

        [Test]
        public void TestFullDesc()
        {
            Assert.AreEqual($"You are testplayer, a player for testing.\nYou are carrying:\n\t(a long sword) (sword)\n\t(a metal hammer) (hammer)\n", (testplayer.FullDescription));
        }
    }
}
