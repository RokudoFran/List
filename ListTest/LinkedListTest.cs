using List;
using NUnit.Framework;
using System;

namespace ListTest
{
    class LinkedListTest
    {
        
        //1
        [TestCase(4, new int[] { }, new int[] { 4 })]
        [TestCase(4, new int[] { 1, 2, 3 }, new int[] { 1, 2, 3, 4 })]
        public void AddValueToTheEnd(int value, int[] array, int[] expectedArray)
        {
            LinkedList expected = new LinkedList(expectedArray);
            LinkedList actual = new LinkedList(array);

            actual.AddValueToTheEnd(value);

            Assert.AreEqual(expected, actual);
        }

        //2
        [TestCase(4, new int[] { }, new int[] { 4 })]
        [TestCase(4, new int[] { 1, 2, 3 }, new int[] { 4, 1, 2, 3 })]
        public void AddValueToTheBegin(int value, int[] array, int[] expectedArray)
        {
            LinkedList expected = new LinkedList(expectedArray);
            LinkedList actual = new LinkedList(array);

            actual.AddValueToTheBegin(value);

            Assert.AreEqual(expected, actual);
        }

        //3
        [TestCase(4, 2, new int[] { 1, 2, 3 }, new int[] { 1, 2, 4, 3 })]
        public void AddValueByIndex(int value, int index, int[] array, int[] expectedArray)
        {
            LinkedList expected = new LinkedList(expectedArray);
            LinkedList actual = new LinkedList(array);

            actual.AddValueByIndex(value, index);

            Assert.AreEqual(expected, actual);
        }

        //4
        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 1, 2, 3 })]
        public void RemoveOneElementFromTheEnd(int[] array, int[] expectedArray)
        {
            LinkedList expected = new LinkedList(expectedArray);
            LinkedList actual = new LinkedList(array);

            actual.RemoveOneElementFromTheEnd();

            Assert.AreEqual(expected, actual);
        }

        //5
        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 2, 3, 4 })]
        public void RemoveOneElementFromTheBegin(int[] array, int[] expectedArray)
        {
            LinkedList expected = new LinkedList(expectedArray);
            LinkedList actual = new LinkedList(array);

            actual.RemoveOneElementFromTheBegin();

            Assert.AreEqual(expected, actual);
        }

        //6
        [TestCase(2, new int[] { 4, 1, 2, 3 }, new int[] { 4, 1, 3 })]
        public void RemoveOneElementByIndex(int index, int[] array, int[] expectedArray)
        {
            LinkedList expected = new LinkedList(expectedArray);
            LinkedList actual = new LinkedList(array);

            actual.RemoveOneElementByIndex(index);

            Assert.AreEqual(expected, actual);
        }

        //[TestCase(new int[] { 1, 2, 3 }, -2)]
        //public void RemoveOneElementByIndex(int[] array, int index)
        //{
        //    LinkedList actual = new LinkedList(array);

        //    Assert.Throws<ArgumentOutOfRangeException>(() => actual.RemoveOneElementByIndex(index));
        //}

        //7
        [TestCase(2, new int[] { 1, 2, 3, 4 }, new int[] { 1, 2 })]
        public void AddNElementOutOfConclushion(int n, int[] array, int[] expectedArray)
        {
            LinkedList expected = new LinkedList(expectedArray);
            LinkedList actual = new LinkedList(array);

            actual.RemoveToFinisNElement(n);

            Assert.AreEqual(expected, actual);
        }

        //[TestCase(new int[] { 1, 2, 3 }, 5)]
        //[TestCase(new int[] { 1, 2, 3 }, -5)]
        //public void RemoveToFinisNElement(int[] array, int value)
        //{
        //    LinkedList actual = new LinkedList(array);

        //    Assert.Throws<ArgumentOutOfRangeException>(() => actual.RemoveToFinisNElement(value));
        //}

        //8
        [TestCase(3, new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 4, 5, 6 })]
        public void AddNElementOutOgBegin(int value, int[] array, int[] expectedArray)
        {
            LinkedList expected = new LinkedList(expectedArray);
            LinkedList actual = new LinkedList(array);

            actual.RemoveToStartNElement(value);

            Assert.AreEqual(expected, actual);
        }

        //[TestCase(new int[] { 1, 2, 3 }, 5)]
        //[TestCase(new int[] { 1, 2, 3 }, -5)]
        //public void RemoveToStartNElement(int[] array, int value)
        //{
        //    LinkedList actual = new LinkedList(array);

        //    Assert.Throws<ArgumentOutOfRangeException>(() => actual.RemoveToStartNElement(value));
        //}

        //9 
        [TestCase(2, 3, new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 1, 2, 6 })]
        public void RemoveByIndex(int index, int n, int[] array, int[] expectedArray)
        {
            LinkedList expected = new LinkedList(expectedArray);
            LinkedList actual = new LinkedList(array);

            actual.RemoveByIndex(index, n);

            Assert.AreEqual(expected, actual);
        }

        //[TestCase(new int[] { 1, 2, 3 }, 1, 5)]
        //[TestCase(new int[] { 1, 2, 3 }, 1, -5)]
        //[TestCase(new int[] { 1, 2, 3 }, -5, 1)]
        //[TestCase(new int[] { 1, 2, 3 }, 5, 1)]
        //[TestCase(new int[] { 1, 2, 3 }, -5, 5)]
        //[TestCase(new int[] { 1, 2, 3 }, 5, -5)]
        //public void RemoveByIndex(int[] array, int index, int value)
        //{
        //    LinkedList actual = new LinkedList(array);

        //    Assert.Throws<ArgumentOutOfRangeException>(() => actual.RemoveByIndex(index, value));
        //}

        //10
        [TestCase(new int[] { 1, 2, 3, 4 }, 4)]
        public void Lenght(int[] array, int expected)
        {

            LinkedList linkedList = new LinkedList(array);

            int actual = linkedList.Length;

            Assert.AreEqual(expected, actual);
        }

        //11
        [TestCase(3, new int[] { 1, 2, 3, 4 }, 4)]
        public void GetValueByIndex(int index, int[] array, int expected)
        {
            LinkedList linkedList = new LinkedList(array);

            int actual = linkedList[index];

            Assert.AreEqual(expected, actual);
        }

        //[TestCase(new int[] { 1, 2, 3 }, -5)]
        //[TestCase(new int[] { 1, 2, 3 }, 5)]
        //public void GetValueByIndex(int[] array, int index)
        //{
        //    LinkedList actual = new LinkedList(array);

        //    Assert.Throws<ArgumentOutOfRangeException>(() => actual.GetValueByIndex(index));
        //}

        //12
        [TestCase(1, new int[] { 1, 2, 3, 4 }, 0)]
        public void GetIndexByValue(int value, int[] array, int expected)
        {
            LinkedList linkedList = new LinkedList(array);
            int actual = linkedList.GetIndexByValue(value);

            Assert.AreEqual(actual, expected);
        }

        //[TestCase(new int[] { }, -5)]
        //public void GetIndexByValue(int[] array, int value)
        //{
        //    LinkedList actual = new LinkedList(array);

        //    Assert.Throws<ArgumentOutOfRangeException>(() => actual.GetIndexByValue(value));
        //}

        //13
        [TestCase(2, 1, new int[] { 1, 2, 3 }, new int[] { 1, 2, 1 })]
        public void ChangeByIndex(int index, int value, int[] array, int[] expectedArray)
        {
            LinkedList expected = new LinkedList(expectedArray);
            LinkedList actual = new LinkedList(array);

            actual.ChangeByIndex(index, value);

            Assert.AreEqual(expected, actual);
        }

        //[TestCase(new int[] { 1, 2, 3 }, -5, 5)]
        //[TestCase(new int[] { }, 1, 6)]
        //public void ChangeByIndex(int[] array, int index, int value)
        //{
        //    LinkedList actual = new LinkedList(array);

        //    Assert.Throws<ArgumentOutOfRangeException>(() => actual.ChangeByIndex(index, value));
        //}

        //14
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 3, 2, 1 })]
        public void Revers(int[] array, int[] expectedArray)
        {
            LinkedList actual = new LinkedList(array);
            LinkedList expected = new LinkedList(expectedArray);

            actual.Revers();

            Assert.AreEqual(expected, actual);
        }

        //[TestCase(new int[] { })]
        //public void Revers(int[] array)
        //{
        //    LinkedList actual = new LinkedList(array);

        //    Assert.Throws<ArgumentOutOfRangeException>(() => actual.Revers());
        //}

        //15
        [TestCase(new int[] { 1, 2, 3, 4 }, 4)]
        public void FindMaxValue(int[] array, int expected)
        {
            LinkedList linkedList = new LinkedList(array);

            int actual = linkedList.FindMaxValue();

            Assert.AreEqual(expected, actual);
        }

        //[TestCase(new int[] { })]
        //public void FindMaxValue(int[] array)
        //{
        //    LinkedList actual = new LinkedList(array);

        //    Assert.Throws<ArgumentOutOfRangeException>(() => actual.FindMaxValue());
        //}

        //16 
        [TestCase(new int[] { 1, 2, 3, 4 }, 1)]
        public void FindMinValue(int[] array, int expected)
        {
            LinkedList linkedList = new LinkedList(array);

            int actual = linkedList.FindMinValue();

            Assert.AreEqual(expected, actual);
        }

        //[TestCase(new int[] { })]
        //public void FindMinValue(int[] array)
        //{
        //    LinkedList actual = new LinkedList(array);

        //    Assert.Throws<ArgumentOutOfRangeException>(() => actual.FindMinValue());
        //}

        //17
        [TestCase(new int[] { 1, 2, 2, 4, 6, 8, 2 }, 5)]
        public void FindIndexMaxValue(int[] array, int expected)
        {
            LinkedList linkedList = new LinkedList(array);

            int actual = linkedList.FindIndexMaxValue();

            Assert.AreEqual(expected, actual);
        }

        //[TestCase(new int[] { })]
        //public void FindIndexMaxValue(int[] array)
        //{
        //    LinkedList actual = new LinkedList(array);

        //    Assert.Throws<ArgumentOutOfRangeException>(() => actual.FindIndexMaxValue());
        //}

        //18
        [TestCase(new int[] { 1, 2, 2, 4, 6, 8, 2 }, 0)]
        public void FindIndexMinValue(int[] array, int expected)
        {
            LinkedList linkedList = new LinkedList(array);

            int actual = linkedList.FindIndexMinValue();

            Assert.AreEqual(expected, actual);
        }

        //[TestCase(new int[] { })]
        //public void FindIndexMinValue(int[] array)
        //{
        //    LinkedList actual = new LinkedList(array);

        //    Assert.Throws<ArgumentOutOfRangeException>(() => actual.FindIndexMinValue());
        //}

        //19
        [TestCase(new int[] { 4, 8, 1, 6, 2 }, new int[] { 1, 2, 4, 6, 8 })]
        public void SortAscending(int[] array, int[] expectedArray)
        {
            LinkedList actual = new LinkedList(array);
            LinkedList expected = new LinkedList(expectedArray);

            actual.SortAscending();

            Assert.AreEqual(expected, actual);
        }

        //[TestCase(new int[] { })]
        //public void SortAscending(int[] array)
        //{
        //    LinkedList actual = new LinkedList(array);

        //    Assert.Throws<ArgumentOutOfRangeException>(() => actual.SortAscending());
        //}

        //20
        //[TestCase(new int[] { 4, 8, 1, 6, 2 }, new int[] { 8, 6, 4, 2, 1 })]
        //public void SortDescending(int[] array, int[] expectedArray)
        //{
        //    LinkedList actual = new LinkedList(array);
        //    LinkedList expected = new LinkedList(expectedArray);

        //    actual.SortDescending();

        //    Assert.AreEqual(expected, actual);
        //}

        //[TestCase(new int[] { })]
        //public void SortDescending(int[] array)
        //{
        //    LinkedList actual = new LinkedList(array);

        //    Assert.Throws<ArgumentOutOfRangeException>(() => actual.SortDescending());
        //}

        //21
        [TestCase(2, new int[] { 1, 2, 2, 4, 6, 8, 2 }, 1)]
        public void RemoveByValueOne(int value, int[] array, int expected)
        {
            LinkedList linkedList = new LinkedList(array);

            int actual = linkedList.RemoveByValueOne(value);

            Assert.AreEqual(expected, actual);
        }

        //[TestCase(new int[] { }, 3)]
        //public void RemoveByValueOne(int[] array, int value)
        //{
        //    LinkedList actual = new LinkedList(array);

        //    Assert.Throws<ArgumentOutOfRangeException>(() => actual.RemoveByValueOne(value));
        //}

        //22
        [TestCase(2, new int[] { 1, 2, 2, 4, 6, 2, 8, 2 }, 4)]
        public void RemoveByValueAll(int value, int[] array, int expected)
        {
            LinkedList linkedList = new LinkedList(array);

            int actual = linkedList.RemoveByValueAll(value);

            Assert.AreEqual(expected, actual);
        }

        //[TestCase(new int[] { }, 3)]
        //public void RemoveByValueAll(int[] array, int value)
        //{
        //    LinkedList actual = new LinkedList(array);

        //    Assert.Throws<ArgumentOutOfRangeException>(() => actual.RemoveByValueAll(value));
        //}

        //24
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 1, 2, 3, 4, 5, 6 })]
        public void AddListToTheEnd(int[] arrayOne, int[] arrayTwo, int[] expectedArray)
        {
            LinkedList actual = new LinkedList(arrayOne);
            LinkedList linkedList = new LinkedList(arrayTwo);
            LinkedList expected = new LinkedList(expectedArray);

            actual.AddListToTheEnd(linkedList);

            Assert.AreEqual(expected, actual);
        }

        //25
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 4, 5, 6, 1, 2, 3 })]
        public void AddListTheBegin(int[] arrayOne, int[] arrayTwo, int[] expectedArray)
        {
            LinkedList actual = new LinkedList(arrayOne);
            LinkedList linkedList = new LinkedList(arrayTwo);
            LinkedList expected = new LinkedList(expectedArray);

            actual.AddListTheBegin(linkedList);

            Assert.AreEqual(expected, actual);
        }

        //26
        [TestCase(new int[] { 1, 2, 3 }, 2, new int[] { 4, 5, 6 }, new int[] { 1, 2, 4, 5, 6, 3 })]
        public void AddListTheIndex(int[] arrayOne, int index, int[] arrayTwo, int[] expectedArray)
        {
            LinkedList actual = new LinkedList(arrayOne);
            LinkedList linkedList = new LinkedList(arrayTwo);
            LinkedList expected = new LinkedList(expectedArray);

            actual.AddListTheIndex(linkedList, index);

            Assert.AreEqual(expected, actual);
        }
    }
}
