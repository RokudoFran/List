using List;
using NUnit.Framework;
using System;

namespace ListTest
{
    public class Tests
    {
        //1
        [TestCase(4, new int[] { }, new int[] { 4 })]
        [TestCase(4, new int[] { 1, 2, 3 }, new int[] { 1, 2, 3, 4 })]
        public void AddValueToTheEnd(int value, int[] array, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(array);

            actual.AddValueToTheEnd(value);

            Assert.AreEqual(expected, actual);
        }

        //2
        [TestCase(4, new int[] { }, new int[] { 4 })]
        [TestCase(4, new int[] { 1, 2, 3 }, new int[] { 4, 1, 2, 3 })]
        public void AddValueToTheBegin(int value, int[] array, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(array);

            actual.AddValueToTheBegin(value);

            Assert.AreEqual(expected, actual);
        }

        //3
        [TestCase(4, 1, new int[] { 1, 2, 3 }, new int[] { 1, 4, 2, 3 })]
        public void AddValueByIndex(int value, int index, int[] array, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(array);

            actual.AddValueByIndex(value, index);

            Assert.AreEqual(expected, actual);
        }

        //4
        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 1, 2, 3 })]
        public void RemoveOneElementFromTheEnd(int[] array, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(array);

            actual.RemoveOneElementFromTheEnd();

            Assert.AreEqual(expected, actual);
        }

        //5
        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 2, 3, 4 })]
        public void RemoveOneElementFromTheBegin(int[] array, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(array);

            actual.RemoveOneElementFromTheBegin();

            Assert.AreEqual(expected, actual);
        }

        //6
        [TestCase(2, new int[] { 4, 1, 2, 3 }, new int[] { 4, 1, 3 })]
        public void RemoveOneElementByIndex(int index, int[] array, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(array);

            actual.RemoveOneElementByIndex(index);

            Assert.AreEqual(expected, actual);
        }

        [TestCase (new int[] {1,2,3}, -2 )]
        public void RemoveOneElementByIndex(int[] array,int index )
        {
            ArrayList actual = new ArrayList(array);

            Assert.Throws<ArgumentOutOfRangeException>(() => actual.RemoveOneElementByIndex(index));
        }

        //7
        [TestCase(2, new int[] { 1, 2, 3, 4 }, new int[] { 1, 2 })]
        public void AddNElementOutOfConclushion(int n, int[] array, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(array);
            
            actual.RemoveToFinisNElement(n);
            
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3 }, 5)]
        [TestCase(new int[] { 1, 2, 3 }, -5)]
        public void RemoveToFinisNElement(int[] array, int value)
        {
            ArrayList actual = new ArrayList(array);

            Assert.Throws<ArgumentOutOfRangeException>(() => actual.RemoveToFinisNElement(value));
        }

        //8
        [TestCase(2, new int[] { 1, 2, 3, 4 }, new int[] { 3, 4 })]
        public void AddNElementOutOgBegin(int value, int[] array, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(array);
            
            actual.RemoveToStartNElement(value);
            
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3 }, 5)]
        [TestCase(new int[] { 1, 2, 3 }, -5)]
        public void RemoveToStartNElement(int[] array, int value)
        {
            ArrayList actual = new ArrayList(array);

            Assert.Throws<ArgumentOutOfRangeException>(() => actual.RemoveToStartNElement(value));
        }

        //9 
        [TestCase(2, 2, new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 5 })]
        public void RemoveByIndex(int index, int n, int[] array, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(array);
            
            actual.RemoveByIndex(index, n);
            
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3 }, 1, 5)]
        [TestCase(new int[] { 1, 2, 3 }, 1, -5)]
        [TestCase(new int[] { 1, 2, 3 }, -5, 1)]
        [TestCase(new int[] { 1, 2, 3 }, 5, 1)]
        [TestCase(new int[] { 1, 2, 3 }, -5, 5)]
        [TestCase(new int[] { 1, 2, 3 }, 5, -5)]
        public void RemoveByIndex(int[] array, int index , int value)
        {
            ArrayList actual = new ArrayList(array);

            Assert.Throws<ArgumentOutOfRangeException>(() => actual.RemoveByIndex(index, value));
        }

        //10
        [TestCase(new int[] { 1, 2, 3, 4 }, 4)]
        public void Lenght(int[] array, int expected)
        {

            ArrayList arrayList = new ArrayList(array);
            
            int actual = arrayList.Length;
            
            Assert.AreEqual(expected, actual);
        }

        //11
        [TestCase(2, new int[] { 1, 2, 3, 4 }, 3)]
        public void GetValueByIndex(int index, int[] array, int expected)
        {
            ArrayList arrayList = new ArrayList(array);

            int actual = arrayList[index];

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3 }, -5)]
        [TestCase(new int[] { 1, 2, 3 }, 5)]
        public void GetValueByIndex(int[] array, int index)
        {
            ArrayList actual = new ArrayList(array);

            Assert.Throws<ArgumentOutOfRangeException>(() => actual.GetValueByIndex(index));
        }
        //12
        [TestCase(1, new int[] { 1, 2, 3, 4 }, 2)]
        public void GetIndexByValue(int index, int[] array, int expected)
        {
            ArrayList arrayList = new ArrayList(array);

            int actual = arrayList[index];

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] {  }, -5)]
        public void GetIndexByValue(int[] array, int value)
        {
            ArrayList actual = new ArrayList(array);

            Assert.Throws<ArgumentOutOfRangeException>(() => actual.GetIndexByValue(value));
        }

        //13
        [TestCase(1, 1, new int[] { 1, 2, 3 }, new int[] { 1, 1, 3 })]
        public void ChangeByIndex(int index, int value, int[] array, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(array);
            
            actual.ChangeByIndex(index, value);
            
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] {1,2,3}, -5, 5)]
        [TestCase(new int[] { }, 1, 6)]
        public void ChangeByIndex(int[] array,int index, int value)
        {
            ArrayList actual = new ArrayList(array);

            Assert.Throws<ArgumentOutOfRangeException>(() => actual.ChangeByIndex(index, value));
        }

        //14
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 3, 2, 1 })]
        public void Revers(int[] array, int[] expectedArray)
        {
            ArrayList actual = new ArrayList(array);
            ArrayList expected = new ArrayList(expectedArray);
            
            actual.Revers();
            
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { })]
        public void Revers(int[] array)
        {
            ArrayList actual = new ArrayList(array);

            Assert.Throws<ArgumentOutOfRangeException>(() => actual.Revers());
        }

        //15
        [TestCase(new int[] { 1, 2, 3, 4 }, 4)]
        public void FindMaxValue(int[] array, int expected)
        {
            ArrayList arrayList = new ArrayList(array);
            
            int actual = arrayList.FindMaxValue();
            
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { })]
        public void FindMaxValue(int[] array)
        {
            ArrayList actual = new ArrayList(array);

            Assert.Throws<ArgumentOutOfRangeException>(() => actual.FindMaxValue());
        }

        //16 
        [TestCase(new int[] { 1, 2, 3, 4 }, 1)]
        public void FindMinValue(int[] array, int expected)
        {
            ArrayList arrayList = new ArrayList(array);
            
            int actual = arrayList.FindMinValue();
            
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { })]
        public void FindMinValue(int[] array)
        {
            ArrayList actual = new ArrayList(array);

            Assert.Throws<ArgumentOutOfRangeException>(() => actual.FindMinValue());
        }

        //17
        [TestCase(new int[] { 1, 2, 2, 4, 6, 8, 2 }, 5)]
        public void FindIndexMaxValue(int[] array, int expected)
        {
            ArrayList arrayList = new ArrayList(array);
            
            int actual = arrayList.FindIndexMaxValue();
            
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { })]
        public void FindIndexMaxValue(int[] array)
        {
            ArrayList actual = new ArrayList(array);

            Assert.Throws<ArgumentOutOfRangeException>(() => actual.FindIndexMaxValue());
        }

        //18
        [TestCase(new int[] { 1, 2, 2, 4, 6, 8, 2 }, 0)]
        public void FindIndexMinValue(int[] array, int expected)
        {
            ArrayList arrayList = new ArrayList(array);
            
            int actual = arrayList.FindIndexMinValue();
            
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { })]
        public void FindIndexMinValue(int[] array)
        {
            ArrayList actual = new ArrayList(array);

            Assert.Throws<ArgumentOutOfRangeException>(() => actual.FindIndexMinValue());
        }

        //19
        [TestCase(new int[] { 4, 8, 1, 6, 2 }, new int[] { 1, 2, 4, 6, 8 })]
        public void SortAscending(int[] array, int[] expectedArray)
        {
            ArrayList actual = new ArrayList(array);
            ArrayList expected = new ArrayList(expectedArray);
            
            actual.SortAscending();
            
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { })]
        public void SortAscending(int[] array)
        {
            ArrayList actual = new ArrayList(array);

            Assert.Throws<ArgumentOutOfRangeException>(() => actual.SortAscending());
        }

        //20
        [TestCase(new int[] { 4, 8, 1, 6, 2 }, new int[] { 8, 6, 4, 2, 1 })]
        public void SortDescending(int[] array, int[] expectedArray)
        {
            ArrayList actual = new ArrayList(array);
            ArrayList expected = new ArrayList(expectedArray);
            
            actual.SortDescending();
            
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { })]
        public void SortDescending(int[] array)
        {
            ArrayList actual = new ArrayList(array);

            Assert.Throws<ArgumentOutOfRangeException>(() => actual.SortDescending());
        }

        //21
        [TestCase(2, new int[] { 1, 2, 2, 4, 6, 8, 2 }, 1)]
        public void RemoveByValueOne(int value, int [] array, int expected)
        {
            ArrayList arrayList = new ArrayList(array);
            
            int actual = arrayList.RemoveByValueOne(value);
            
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { }, 3)]
        public void RemoveByValueOne(int[] array, int value)
        {
            ArrayList actual = new ArrayList(array);

            Assert.Throws<ArgumentOutOfRangeException>(() => actual.RemoveByValueOne(value));
        }

        //22
        [TestCase(2, new int[] { 1, 2, 2, 4, 6, 8, 2 }, 3)]
        public void RemoveByValueAll(int value, int[] array, int expected)
        {
            ArrayList arrayList = new ArrayList(array);
            
            int actual = arrayList.RemoveByValueAll(value);
            
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { }, 3)]
        public void RemoveByValueAll(int[] array, int value)
        {
            ArrayList actual = new ArrayList(array);

            Assert.Throws<ArgumentOutOfRangeException>(() => actual.RemoveByValueAll(value));
        }

        //24
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 4,5,6 }, new int[] { 1,2,3,4,5,6 } )]
        public void AddListToTheEnd(int [] arrayOne, int [] arrayTwo, int [] expectedArray)
        {
            ArrayList actual = new ArrayList(arrayOne);
            ArrayList arrayList = new ArrayList(arrayTwo);
            ArrayList expected = new ArrayList(expectedArray);
            
            actual.AddListToTheEnd(arrayList);

            Assert.AreEqual(expected, actual);
        }

        //25
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 4, 5, 6, 1, 2, 3 })]
        public void AddListTheBegin(int[] arrayOne, int[] arrayTwo, int[] expectedArray)
        {
            ArrayList actual = new ArrayList(arrayOne);
            ArrayList arrayList = new ArrayList(arrayTwo);
            ArrayList expected = new ArrayList(expectedArray);

            actual.AddListTheBegin(arrayList);

            Assert.AreEqual(expected, actual);
        }

        //26
        [TestCase(new int[] { 1, 2, 3 }, 2 , new int[] { 4, 5, 6 }, new int[] { 1, 2, 4, 5, 6, 3 })]
        public void AddListTheIndex(int[] arrayOne, int index, int[] arrayTwo, int[] expectedArray)
        {
            ArrayList actual = new ArrayList(arrayOne);
            ArrayList arrayList = new ArrayList(arrayTwo);
            ArrayList expected = new ArrayList(expectedArray);

            actual.AddListTheIndex(arrayList,index);

            Assert.AreEqual(expected, actual);
        }
    }

}