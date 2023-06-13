using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T> : IEnumerable
    {
        private T[] items;
        private int capacity;
        private int count;

        public CustomList()
        {
            items = new T[4];
            capacity = items.Length;
            count = 0;
        }

        public int Capacity { get { return capacity; } set { capacity = value; } }
        public int Count { get { return count; } }
        public T[] Items { get { return items; } set { items = value; } }
        public T this[int index] 
        { 
            get 
            {
                if (index < 0 || index >= count)
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    return items[index]; 
                }
            } 
            set 
            {
                if (index < 0 || index >= count)
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    items[index] = value; 
                }
                
            } 
        }
        
        public void Add(T item)
        {
            if (capacity == count)
            {
                items = DoubleCapacity();
                capacity = items.Length;
            }
            items[count] = item;
            count++;
        }

        private T[] DoubleCapacity()
        {
            T[] tempArray = new T[capacity*2];
            for (int i = 0; i < count; i++)
            {
                tempArray[i] = items[i];
            }
            return tempArray;
        }

        public bool Remove(T item)
        {
            bool itemExists = false;
            int index = Array.IndexOf(items, item);
            if (index >= 0)
            {
                itemExists = true;
                items = ShiftArray(index);
                count--;
            }
            return itemExists;
        }

        private T[] ShiftArray(int indexOfItem)
        {
            T[] tempArray = new T[capacity];
            for (int i = 0; i < count; i++)
            {
                if (i < indexOfItem)
                {
                    tempArray[i] = items[i];
                }
                else
                {
                    tempArray[i] = items[i + 1];
                }
            }
            return tempArray;
        }

        public override string ToString()
        {
            string results = "";
            int counter = 0;
            foreach (T item in items)
            {
                counter++;
                if (counter <= count)
                {
                    if (item is string strItem)
                    {
                        results += item;
                    }
                    else if (item is bool boolItem)
                    {
                        results += String.Format("{0}", boolItem);
                    }
                    else if (item is int intItem)
                    {
                        results += String.Format("{0}", intItem);
                    }
                    else if (item is double doubleItem)
                    {
                        results += String.Format("{0}", doubleItem);
                    }
                }
            }
            return results;
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return items[i];
            }
        }

        public static CustomList<T> operator +(CustomList<T> firstList, CustomList<T> secondList)
        {
            CustomList<T> tempList = new CustomList<T>();
            for (int i = 0; i < firstList.Count; i++)
            {
                tempList.Add(firstList[i]);
            }
            for (int i = 0; i < secondList.Count; i++)
            {
                tempList.Add(secondList[i]);
            }
            return tempList;
        }

        public static CustomList<T> operator -(CustomList<T> firstList, CustomList<T> secondList)
        {
            Type elementType = firstList.Items.GetType().GetElementType();
            if (elementType == typeof(string) || elementType == typeof(int) || elementType == typeof(double))
            {
                CustomList<T> tempList = new CustomList<T>();
                foreach (T item in firstList)
                {
                    tempList.Add(item);
                }

                for (int i = 0; i < secondList.Count; i++)
                {
                    tempList.Remove(secondList[i]);
                }
                return tempList;
            }
            else
            {
                return null;
            }
        }
    }
}
