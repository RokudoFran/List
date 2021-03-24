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
            Length++;
            _tail.Next = new Node(value);
            _tail = _tail.Next;
        }

        //2. метод добавление значения в начало
        public void AddValueToTheBegin(int value)
        {
            Node tmp = _root;
            _root = new Node(value);
            _root.Next = tmp;
            Length++;
        }

        //3. метод добавление значения по индексу
        public void AddValueByIndex(int value, int index)
        {
            Node current = _root;

            for (int i = 1; i < index; i++)
            {
                current = current.Next;
            }

            Node tmp = current;
            current.Next = tmp;
            current = new Node(value);

            Length++;
        }

        //4. метод удаление из конца одного элемента
        public void RemoveOneElementFromTheEnd()
        {
            Node current = _root;

            for (int i = 1; i < Length-1; i++)
            {
                current = current.Next;
            }

            _tail=current;
            Length--;
        }

        //5. метод удаление из начала одного элемента
        public void RemoveOneElementFromTheBegin()
        {
            _root = _root.Next;
            Length++;
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

            for (int i = 1; i < Length - 1-n; i++)
            {
                current = current.Next;
            }

            _tail = current;
            Length-=n;
        }

        //8.удаление из начала N элементов
        public void RemoveToStartNElement(int n)
        {
            Node current = _root;

            for (int i = 1; i < n ; i++)
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
            Node enddTmp = _root;
            Node tmp = _root;

            for (int i=1; i<index+n;i++)
            {
                tmp = tmp.Next;
                if (i==index-1)
                {
                    firstTmp = tmp;
                }
                else if (i==index+n-1)
                {
                    enddTmp = tmp;
                }

            }
            firstTmp = enddTmp;

            Length=Length - n - 1;
        }




    }
}
