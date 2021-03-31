using System;
using System.Collections.Generic;
using System.Text;

namespace List
{
    public class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }

        public Node(int value)
        {
            Value = value;
            Next = null;
        }

    }

    public class LinkedList
    {
        public int Length { get; private set; }
        public int this[int index]
        {
            get
            {
                Node current = _root;

                for (int i = 1; i <= index; i++)
                {
                    current = current.Next;
                }
                return current.Value;
            }

            set
            {
                Node current = _root;

                for (int i = 1; i <= index; i++)
                {
                    current = current.Next;
                }

                current.Value = value;
            }
        }

        private Node _root;
        private Node _tail;

        public LinkedList()
        {
            Length = 0;
            _root = null;
            _tail = null;
        }

        public LinkedList(int value)
        {
            Length = 1;
            _root = new Node(value);
            _tail = _root;
        }

        public LinkedList(LinkedList listOne)
        {
            Length = listOne.Length;
            Node current = listOne._root;
            if (listOne.Length != 0)
            {
                _root = current;
                _tail = _root;

                for (int i = 1; i < listOne.Length; i++)
                {
                    current = current.Next;
                    _tail.Next = current;
                    _tail = _tail.Next;

                }
            }
            else
            {
                _root = null;
                _tail = null;
            }
        }

        public LinkedList(int[] values)
        {
            Length = values.Length;

            if (values.Length != 0)
            {
                _root = new Node(values[0]);
                _tail = _root;

                for (int i = 1; i < values.Length; i++)
                {
                    _tail.Next = new Node(values[i]);
                    _tail = _tail.Next;
                }
            }
            else
            {
                _root = null;
                _tail = null;
            }
        }

        public override string ToString()
        {
            if (Length != 0)
            {
                Node current = _root;
                string s = current.Value + " ";

                while (!(current.Next is null))
                {
                    current = current.Next;
                    s += current.Value + " ";
                }

                return s;
            }
            else
            {
                return String.Empty;
            }
        }

        public override bool Equals(object obj)
        {
            LinkedList list = (LinkedList)obj;

            if (this.Length != list.Length)
            {
                return false;
            }

            Node currentThis = this._root;
            Node currentList = list._root;

            do
            {
                if (currentThis.Value != currentList.Value)
                {
                    return false;
                }
                currentList = currentList.Next;
                currentThis = currentThis.Next;
            }
            while (!(currentThis.Next is null));

            return true;
        }
        //1. метод добавление значения в конец
        public void AddValueToTheEnd(int value)
        {
            if (Length == 0)
            {
                Length = 1;
                _root = new Node(value);
                _tail = _root;
            }
            else
            {
                Length++;
                _tail.Next = new Node(value);
                _tail = _tail.Next;
            }
        }

        //2. метод добавление значения в начало
        public void AddValueToTheBegin(int value)
        {
            Length++;

            Node tmp = _root;
            _root = new Node(value);
            _root.Next = tmp;
            
        }

        //3. метод добавление значения по индексу
        public void AddValueByIndex(int value, int index)
        {
            Node current = _root;

            for (int i = 0; i < index - 1; i++)
            {
                current = current.Next;
            }

            Node tmp = new Node(value);
            tmp.Next = current.Next;
            current.Next = tmp;


            Length++;
        }

        //4. метод удаление из конца одного элемента
        public void RemoveOneElementFromTheEnd()
        {
            Node current = _root;

            for (int i = 1; i < Length - 1; i++)
            {
                current = current.Next;
            }

            _tail = current;
            Length--;
        }

        //5. метод удаление из начала одного элемента
        public void RemoveOneElementFromTheBegin()
        {
            _root = _root.Next;
            Length--;
        }

        //6. метод удаление по индексу одного элемента
        public void RemoveOneElementByIndex(int index)
        {
            Node current = _root;

            for (int i = 1; i < index; i++)
            {
                current = current.Next;
            }

            current.Next = current.Next.Next;

            Length--;
        }

        //7. удаление из конца N элементов
        public void RemoveToFinisNElement(int n)
        {
            Node current = _root;

            for (int i = 1; i < Length - 1 - n; i++)
            {
                current = current.Next;
            }

            _tail = current;
            Length -= n;
        }

        //8.удаление из начала N элементов
        public void RemoveToStartNElement(int n)
        {
            Node current = _root;

            for (int i = 0; i < n; i++)
            {
                current = current.Next;
            }

            _root = current;
            Length -= n;
        }

        //9.удаление по индексу N элементов
        public void RemoveByIndex(int index, int n)
        {
            Node firstTmp = _root;
            Node endTmp = _root;
            Node tmp = _root;

            for (int i = 0; i < index + n; i++)
            {
                if (i == index - 1)
                {
                    firstTmp = tmp;
                }
                else if (i == index + n + 1)
                {
                    endTmp = tmp;
                }

                tmp = tmp.Next;

            }

            firstTmp = endTmp;

            Length = Length - n;
        }

        //11. метод доступ по индексу
        public int GetValueByIndex(int index)
        {
            Node current = _root;

            for (int i = 1; i < index - 1; i++)
            {
                current = current.Next;
            }

            return current.Value;
        }

        //12. метод первый индекс по значению
        public int GetIndexByValue(int value)
        {
            int index = -1;
            Node current = _root;

            for (int i = 0; i < Length - 1; i++)
            {
                if (current.Value == value)
                {
                    index = i;
                    break;
                }

                current = current.Next;
            }

            return index;
        }

        //13. метод изменение по индексу
        public void ChangeByIndex(int index, int value)
        {
            Node current = _root;

            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }

            current.Value = value;
        }

        //14. метод реверс (123 -> 321)
        public void Revers()
        {
            Node current = _root;
            Node tmp = new Node(1);

            while (current.Next != null)
            {
                tmp = current.Next;
                current.Next = tmp.Next;
                tmp.Next = _root;
                _root = tmp;
            }
        }

        //15. метод поиск значения максимального элемента
        public int FindMaxValue()
        {
            Node current = _root;
            int maxValue = current.Value;

            for (int i = 0; i < Length; i++)
            {
                if (current.Value > maxValue)
                {
                    maxValue = current.Value;
                }
                current = current.Next;
            }

            return maxValue;
        }

        //16. метод поиск значения минимального элемента
        public int FindMinValue()
        {
            Node current = _root;
            int minValue = current.Value;

            for (int i = 1; i < Length; i++)
            {
                if (current.Value < minValue)
                {
                    minValue = current.Value;
                }
                current = current.Next;
            }

            return minValue;
        }

        //17. метод поиск индекс максимального элемента
        public int FindIndexMaxValue()
        {
            Node current = _root;
            int maxValue = current.Value;
            int index = 0;

            for (int i = 1; i < Length - 1; i++)
            {
                if (current.Value > maxValue)
                {
                    maxValue = current.Value;
                    index = i;
                }
                current = current.Next;
            }

            return index;
        }

        //18. метод поиск индекс минимального элемента
        public int FindIndexMinValue()
        {
            Node current = _root;
            int minValue = current.Value;
            int index = 0;

            for (int i = 1; i < Length - 1; i++)
            {
                if (current.Value < minValue)
                {
                    minValue = current.Value;
                    index = i;
                }
                current = current.Next;
            }

            return index;
        }

        //19. метод сортировка по возрастанию
        public void SortAscending()
        {
            Node tmp = _root;
            Node current = _root;

            for (int i = 0; i < Length; i++)
            {
                for (int j = i; j < Length; j++)
                {
                    if (current.Next.Value > current.Value)
                    {
                        tmp = current.Next;
                        current.Next = current;
                        current = tmp;
                    }
                }
            }

        }

        //21. метод удаление по значению первого (?вернуть индекс)
        public int RemoveByValueOne(int value)
        {
            Node current = _root;
            Node firstTmp = current;
            Node secondTmp = current;
            int index = -1;
            for (int i = 0; i < Length; i++)
            {
                if (current.Value == value)
                {
                    firstTmp = current;
                    secondTmp = current.Next;
                    index = i;
                    break;
                }
                current = current.Next;

            }

            firstTmp = secondTmp;

            Length = Length - 1;

            return index;
        }

        //22. метод удаление по значению всех (?вернуть кол-во)
        public int RemoveByValueAll(int value)
        {
            Node current = _root;
            Node firstTmp = current;
            Node secondTmp = current;
            int kol = 0;
            for (int i = 0; i < Length; i++)
            {
                if (current.Value == value)
                {
                    firstTmp = current;
                    secondTmp = current.Next;

                    kol++;

                    firstTmp = secondTmp;
                }
                current = current.Next;

            }
            Length -= kol;
            return kol;
        }

        //24. метод добавление списка (вашего самодельного) в конец
        public void AddListToTheEnd(LinkedList listOne)
        {
            LinkedList tmplist = new LinkedList(listOne);
            Length += tmplist.Length;
            _tail.Next = tmplist._root;
        }

        //25. добавление списка в начало
        public void AddListTheBegin(LinkedList listOne)
        {
            LinkedList tmpList = new LinkedList(listOne);
            Length += listOne.Length;
            tmpList._tail.Next = _root;
            _root = tmpList._root;

        }

        //26. добавление списка по индексу
        public void AddListTheIndex(LinkedList listOne, int index)
        {
            LinkedList tmpList = new LinkedList(listOne);
            Length += listOne.Length;
            Node current = _root;

            for(int i = 0; i<index-1; i++)
            {
                current = current.Next;
            }

            Node tmp = current;
            current.Next = tmpList._root;
            tmpList._tail.Next = tmp.Next;

        }
    }
}
