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
    public class IdentifiableObjectTest
    {
        IdentifiableObject testObjectAreYouAddFirst, testObjectCase, testObjectNullFirstId;

        [SetUp]
        public void Setup()
        {

            testObjectAreYouAddFirst = new IdentifiableObject(new string[] { "apple", "orange" });
            testObjectCase = new IdentifiableObject(new string[] { "ApPlE", "oRAngE" });
            testObjectNullFirstId = new IdentifiableObject(new string[] { });
        }

        [Test]
        public void TestAreYou()
        {
            Assert.IsTrue(testObjectAreYouAddFirst.AreYou("apple"));
        }
        [Test]
        public void TestNotAreYou()
        {
            Assert.IsFalse(testObjectAreYouAddFirst.AreYou("pear"));
        }
        [Test]
        public void TestCase()
        {
            Assert.IsTrue(testObjectCase.AreYou("apple"));
        }
        [Test]
        public void TestNullFirstId()
        {
            Assert.IsTrue(testObjectNullFirstId.FirstId == "");
        }
        [Test]
        public void TestFirstId()
        {
            StringAssert.AreEqualIgnoringCase("apple", testObjectAreYouAddFirst.FirstId);
        }
        [Test]
        public void TestAddIdentifier()
        {
            testObjectAreYouAddFirst.AddIdentifier("mango");
            Assert.IsTrue(testObjectAreYouAddFirst.AreYou("apple"));
            Assert.IsTrue(testObjectAreYouAddFirst.AreYou("orange"));
            Assert.IsTrue(testObjectAreYouAddFirst.AreYou("mango"));
        }
    }
}