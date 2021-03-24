using List;
using NUnit.Framework;
using System;

namespace ListTest
{
    class LinkedListTest
    {
        [Test]
        public void AddValueToTheEnd()
        {
            LinkedList a = new LinkedList(new int[] { 1, 2, 3, 4 });
            LinkedList b = new LinkedList(new int[] { 1, 2, 3 });

            b.AddValueToTheEnd(4);
            Assert.AreEqual(a, b);
        }

        [TestCase(new int[] { 1, 2, 3 }, 2, new int[] { 2, 1, 2, 3 })]
        public void AddValueToTheBegin(int[] actualAr, int value, int[] arExpected)
        {
            LinkedList actual = new LinkedList(actualAr);
            LinkedList expected = new LinkedList(arExpected);

            actual.AddValueToTheBegin(value);

            Assert.AreEqual(expected, actual);
        }
    }
}
