using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    /// <summary>
    /// A custom implementation of a dynamic array (list) in C#, similar to <see cref="List{T}"/>.
    /// </summary>
    /// <typeparam name="T">The type of elements in the list.</typeparam>
    /// <remarks>
    /// This class supports adding and removing items, checking the count of items, and accessing items by index.
    /// The initial capacity of the list is set to 4 and grows as needed when items are added.
    /// This class also provides methods to concatenate the string representation of the elements in the list, and overloads the addition (+) and subtraction (-) operators to merge two lists or remove the items of the second list from the first one, respectively.
    /// It implements <see cref="IEnumerable"/> interface, allowing its instances to be used in foreach loops.
    /// </remarks>
    public class CustomList<T> : IEnumerable where T : IComparable<T>
    {
        private T[] items;
        private int capacity;
        private int count;

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomList{T}"/> class.
        /// </summary>
        /// <remarks>
        /// The initial capacity is set to four, and the count is set to zero.
        /// </remarks>
        public CustomList()
        {
            
            capacity = 4;
            items = new T[capacity];
            count = 0;
        }

        /// <summary>
        /// Gets the capacity of the CustomList.
        /// </summary>
        public int Capacity { get { return capacity; } }
        
        /// <summary>
        /// Gets the current count of items in the CustomList.
        /// </summary>
        public int Count { get { return count; } }

        /// <summary>
        /// Gets or sets the item at the specified index in the CustomList.
        /// </summary>
        /// <param name="index">The zero-based index of the item to get or set.</param>
        /// <value>
        /// The item at the specified index.
        /// </value>
        /// <exception cref="IndexOutOfRangeException">
        /// index is not a valid index in the CustomList.
        /// </exception>
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

        /// <summary>
        /// Adds the specified item to the CustomList array.
        /// </summary>
        /// <remarks>
        /// If capacity is reached, this method doubles the capacity before adding the item.
        /// </remarks>
        /// <param name="item">The item to add to the CustomList.</param>
        public void Add(T item)
        {
            if (capacity == count)
            {
                items = DoubleCapacity();
            }
            items[count] = item;
            count++;
        }

        /// <summary>
        /// Creates a new array with double the current capacity and copies the existing items into it.
        /// </summary>
        /// <returns>A new array of type T with double the capacity of the current array, containing all the current items.</returns>
        private T[] DoubleCapacity()
            {
                capacity *= 2;
                T[] tempArray = new T[capacity];      
                for (int i = 0; i < count; i++)
                {
                    tempArray[i] = items[i];
                }
                return tempArray;
            }

        /// <summary>
        /// Removes the specified item from the CustomList array.
        /// </summary>
        /// <remarks>
        /// Shifts items to fill in the gap if item was removed.
        /// </remarks>
        /// <param name="item">The item to remove from CustomList</param>
        /// <returns>True if item was successfully removed, false otherwise.</returns>
        public bool Remove(T item)
        {
            int index = Array.IndexOf(items, item);
            if (index == -1)
            {
                return false;
            }

            ShiftItemsLeft(index);
            count--;
            items[count] = default(T);

            return true;
        }

        /// <summary>
        /// Shifts the items in the array backwards to override the item to be removed, maintaining the original capacity.
        /// </summary>
        /// <param name="indexOfItem">The index of the item to remove.</param>
        private void ShiftItemsLeft(int startIndex)
        {
            for (int i = startIndex; i < count; i++)
            {
                items[i] = items[i + 1];
            }
        }

        /// <summary>
        /// Concatenates the string representations of all items in the CustomList, regardless of their type.
        /// </summary>
        /// <remarks>
        /// Each item's ToString method is called to obtain its string representation, and these representations are concatenated directly without any separator.
        /// For example, a list containing the elements [1, "apple", true] would be converted to "1appleTrue".
        /// This method provides a universal string representation of the list's contents, suitable for debugging or logging purposes.
        /// </remarks>
        /// <returns>
        /// A single string consisting of the concatenated string representations of all the items in the CustomList.
        /// If the list is empty, an empty string is returned.
        /// </returns>
        public override string ToString()
        {
            string results = "";
            for (int i = 0; i < count; i++)
            {
                results += $"{items[i]}";
            }
            return results;
        }

        /// <summary>
        /// Returns an enumerator that iterates through the CustomList.
        /// </summary>
        /// <returns>
        /// An IEnumerator object that can be used to iterate through the collection.
        /// </returns>
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return items[i];
            }
        }

        /// <summary>
        /// Overloads the addition (+) operator to combine two CustomList instances into one.
        /// </summary>
        /// <param name="firstList">The first CustomList instance.</param>
        /// <param name="secondList">The second CustomList instance.</param>
        /// <returns>A new CustomList instance that contains all elements from both input lists.</returns>
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

        /// <summary>
        /// Overloads the subtraction (-) operator to create a new CustomList instance that contains only the elements of the first list that are not present in the second list. 
        /// </summary>
        /// <param name="firstList">The first CustomList instance from which elements will be subtracted.</param>
        /// <param name="secondList">The second CustomList instance whose elements will be subtracted from the first list.</param>
        /// <returns>A new CustomList instance that contains only the elements found in the first list but not in the second. If the lists contain elements of a type other than string, int, or double, this method returns null.</returns>
        public static CustomList<T> operator -(CustomList<T> firstList, CustomList<T> secondList)
        {
            Type elementType = firstList.items.GetType().GetElementType();
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
