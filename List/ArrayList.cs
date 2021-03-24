using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace List
{
    public class ArrayList
    {
        public int Length { get; private set; }  // свойство
        
        private int[] _array;                    // поле

        public int this[int index]
        {
            get
            {
                return _array[index];
            }
            
            set
            {
                _array[index] = value;
            }
        }


        // конструктор пустой 
        public ArrayList()
        {
            Length = 0;                    //длина пользов
            _array = new int[10];          // реальная длина массива
        }

        // конструктор на основе одного элемента
        public ArrayList(int value)
        {
            Length = 1;
            _array = new int[10];
            _array[0] = value;
        }

        // конструктор на основе массива
        public ArrayList(int[] value)
        {
            Length = value.Length;
            _array = new int[value.Length + 10];
            _array = value;
        }

        public override bool Equals(object obj)
        {
            ArrayList other = (ArrayList)obj;

            if (other.Length != Length)
            {
                return false;
            }

            for (int i = 0; i < Length; i++)
            {
                if (other._array[i] != _array[i])
                {
                    return false;
                }
            }

            return true;
        }

        public override string ToString()
        {
            return String.Join(" ", _array.Take(Length));

        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        //1. метод добавление значения в конец
        public void AddValueToTheEnd(int value)
        {
            if (Length == _array.Length)
            {
                UpSize();
            }
            
            _array[Length] = value;
            
            Length++;
        }

        //2. метод добавление значения в начало
        public void AddValueToTheBegin(int value)
        {
            AddValueByIndex(value, 0);
        }

        //3. метод добавление значения по индексу
        public void AddValueByIndex(int value, int index)
        {
            ReturnTheErrorIndex(index);

            if (Length == _array.Length)
            {
                UpSize();
            }

            ShiftToRight(index, 1);

            _array[index] = value;
            
            Length++;
        }

        //4. метод удаление из конца одного элемента
        public void RemoveOneElementFromTheEnd()
        {
            Length--;
            
            if (Length <= (_array.Length / 2))
            {
                DownSize();
            }
        }

        //5. метод удаление из начала одного элемента
        public void RemoveOneElementFromTheBegin()
        {
            RemoveOneElementByIndex(0);
        }

        //6. метод удаление по индексу одного элемента
        public void RemoveOneElementByIndex(int index)
        {
            ReturnTheErrorIndex(index);

            int n = 1;
            
            _array = ShiftToLeft(index, n);
            
            Length--;

            if (Length <= (_array.Length / 2))
            {
                DownSize();
            }
        }

        //7. удаление из конца N элементов
        public void RemoveToFinisNElement(int n)
        {

            ReturnTheErrorN(n);
            
            Length -= n;
            
            if (Length <= (_array.Length / 2))
            {
                DownSize();
            }
        }

        //8.удаление из начала N элементов
        public void RemoveToStartNElement(int n)
        {
            ReturnTheErrorN(n);

            RemoveByIndex(0, n);
        }

        //9.удаление по индексу N элементов
        public void RemoveByIndex(int index, int n)
        {
            ReturnTheErrorN(n);
            
            ReturnTheErrorIndex(index);
            
            for (int i = index; i < Length - n; i++)
            {
                _array[i] = _array[i + n];
            }
            
            Length-=n;
            
            if (Length <= (_array.Length / 2))
            {
                DownSize();
            }

        }

        //11. метод доступ по индексу 
        public int GetValueByIndex(int index)
        {
            ReturnTheErrorIndex(index);
            
            return _array[index];
        }

        //12. метод первый индекс по значению
        public int GetIndexByValue(int value)
        {
            ReturnTheErrorLength(Length);
            int index = -1;
            
            for (int i = 0; i < Length; i++)
            {
                if (_array[i] == value)
                {
                    index=i;
                    
                    break;
                }
            }

            return index;
        }

        //13. метод изменение по индексу
        public void ChangeByIndex(int index, int value)
        {
            ReturnTheErrorLength(Length);
            ReturnTheErrorIndex(index);
            
            _array[index] = value;

        }

        //14. метод реверс (123 -> 321)
        public void Revers()
        {
            ReturnTheErrorLength(Length);
            int tmp=0;
            
            for (int i = 0; i < Length / 2; i++)
            {
                tmp = _array[i];
                _array[i] = _array[Length - i - 1];
                _array[Length - i - 1] = tmp;
            }
        }

        //15. метод поиск значения максимального элемента
        public int FindMaxValue()
        {
            ReturnTheErrorLength(Length);
            return _array[FindIndexMaxValue()];
        }

        //16. метод поиск значения минимального элемента
        public int FindMinValue()
        {
            ReturnTheErrorLength(Length);
            return _array[FindIndexMinValue()];
        }

        //17. метод поиск индекс максимального элемента
        public int FindIndexMaxValue()
        {
            ReturnTheErrorLength(Length);

            int max = _array[0], indexMax = 0;
            
            for (int i = 0; i < Length; i++)
            {
                if (max <= _array[i])
                {
                    max = _array[i];
                    indexMax = i;
                }
            }
            
            return indexMax;
        }

        //18. метод поиск индекс минимального элемента
        public int FindIndexMinValue()
        {
            ReturnTheErrorLength(Length);

            int min = _array[0], indexMin = 0;
            
            for (int i = 1; i < Length; i++)
            {
                if (min > _array[i])
                {
                    min = _array[i];
                    indexMin = i;
                }
            }
            
            return indexMin;
        }

        //19. метод сортировка по возрастанию
        public int[] SortAscending()
        {
            ReturnTheErrorLength(Length);

            int tmp;
            
            for (int i = 0; i < Length; i++)
            {
                for (int j = Length - 1; j > i; j--)
                {
                    if (_array[j - 1] > _array[j])
                    {
                        tmp = _array[j - 1];
                        _array[j - 1] = _array[j];
                        _array[j] = tmp;
                    }
                }
            }
            
            return _array;
        }

        //20. метод сортировка по убыванию
        public int[] SortDescending()
        {
            ReturnTheErrorLength(Length);

            int tmp;
            
            for (int i = 0; i < Length - 1; i++)
            {
                int indexOfMax = i;
                
                for (int j = i; j < Length; j++)
                {
                    if (_array[indexOfMax] < _array[j])
                    {
                        indexOfMax = j;
                    }
                }
                
                tmp = _array[i];
                _array[i] = _array[indexOfMax];
                _array[indexOfMax] = tmp;
            }
            
            return _array;
        }

        //21. метод удаление по значению первого (?вернуть индекс)
        public int RemoveByValueOne(int value)
        {
            ReturnTheErrorLength(Length);

            int index = GetIndexByValue(value);
            
            RemoveOneElementByIndex(index);
            
            return index;
        }

        //22. метод удаление по значению всех (?вернуть кол-во)
        public int RemoveByValueAll(int value)
        {
            ReturnTheErrorLength(Length);

            int kol = 0;
            int index = GetIndexByValue(value);
            
            while (index!=-1)
            {
                RemoveOneElementByIndex(index);
                
                kol++;
                
                index = GetIndexByValue(value);
            }

            return kol;
        }

        //24. метод добавление списка (вашего самодельного) в конец
        public void AddListToTheEnd(ArrayList listOne)
        {
            AddListTheIndex(listOne, Length);
        }

        //25. добавление списка в начало
        public void AddListTheBegin(ArrayList listOne)
        {
            int index = 0;
            
            AddListTheIndex(listOne, index);
        }

        //26. добавление списка по индексу
        public void AddListTheIndex(ArrayList listOne, int index)
        {
            UpSize(listOne.Length);
            
            Length += listOne.Length;
            
            _array = ShiftToRight(index, listOne.Length);
            
            for (int i = 0; i < listOne.Length; i++)
            {
                _array[i+index] = listOne[i];
            }
        }

        private void UpSize() // увеличение длины массива
        {
            int newLength = (int)(_array.Length * 1.33d + 1);
            
            int[] tmpArray = new int[newLength];
            
            for (int i = 0; i < _array.Length; i++)
            {
                tmpArray[i] = _array[i];
            }
            
            _array = tmpArray;
        }

        private void UpSize(int Length)
        {
            int newLength = (int)((_array.Length + Length) * 1.33d);
            
            int[] tmpArray = new int[newLength];
            
            for (int i = 0; i < _array.Length; i++)
            {
                tmpArray[i] = _array[i];
            }
            
            _array = tmpArray;
        }

        private void DownSize() //уменьшение длинны массивы
        {
            int newLength = (int)(_array.Length * 0.67d + 1);
            
            int[] tmpArray = new int[newLength];
            
            for (int i = 0; i < tmpArray.Length; i++)
            {
                tmpArray[i] = _array[i];
            }

            _array = tmpArray;
        }

        private int[] ShiftToLeft(int index, int n) // сдвиг влево
        {
            if (Length == _array.Length / 2)
            {
                DownSize();
            }

            for (int i = index; i < Length - n; i++)
            {
                _array[i] = _array[i + n];
            }

            return _array;

        }

        private int[] ShiftToRight(int index, int n) //сдвиг вправо
        {
            if (Length + n < _array.Length)
            {
                UpSize(n);
            }

            for (int i = Length; i > index+n-1; i--)
            {
                _array[i] = _array[i - n];
                
            }

            return _array;
        }

        private void ReturnTheErrorIndex(int index)//вызови ошибку
        {
            if (index > Length || index < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        private void ReturnTheErrorN(int n)//вызови ошибку
        {
            if (n > Length || n < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        private void ReturnTheErrorLength(int Length)
        {
            if (Length==0)
            {
                throw new ArgumentOutOfRangeException();
            }

        }

    }
}
