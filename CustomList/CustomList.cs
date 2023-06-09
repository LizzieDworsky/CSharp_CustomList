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
        //Member Variables (HAS A)
        private T[] items;
        private int capacity;
        private int count;

        //Constructor
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
        

        //Member Methods (CAN DO)
        public void Add(T item)
        {
            //'item' parameter should be added to internal 'items' array
            //if items array is at capacity, double capacity and create new array
            //transfer all items to new array
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
            //If 'item' exists in the 'items' array, remove its first instance
            //Any items coming after the removed item should be shifted down so there is no empty index.
            //If 'item' was removed, return true. If no item was removed, return false.
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
            //returns a single string that contains all items from array
            return " ";
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
            //returns a single CustomList<T> that contains all items from firstList and all items from secondList 
            return null;
        }

        public static CustomList<T> operator -(CustomList<T> firstList, CustomList<T> secondList)
        {
            //returns a single CustomList<T> with all items from firstList, EXCEPT any items that also appear in secondList
            return null;
        }


    }
}
