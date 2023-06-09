using CustomList;
namespace CustomListTests
{
    [TestClass]
    public class RemoveMethodTests
    {
        // Remove Method Tests
        [TestMethod]
        public void Remove_RemoveOneItem_CountDecreasesByOne()
        {
            // Arrange
            CustomList<int> myCustomList = new CustomList<int>();
            myCustomList.Add(2);
            myCustomList.Add(4);
            myCustomList.Add(6);

            // Act
            myCustomList.Remove(4);

            // Assert
            Assert.AreEqual(2, myCustomList.Count);
        }

        [TestMethod]
        public void Remove_RemoveOneItem_ReturnsTrue()
        {
            // Arrange
            CustomList<int> myCustomList = new CustomList<int>();
            myCustomList.Add(2);
            myCustomList.Add(4);
            myCustomList.Add(6);

            // Act
            bool isRemoved = myCustomList.Remove(4);

            // Assert
            Assert.IsTrue(isRemoved);
        }

        [TestMethod]
        public void Remove_TryToRemoveItemNotInList_CountStaysTheSame()
        {
            // Arrange
            CustomList<int> myCustomList = new CustomList<int>();
            myCustomList.Add(2);
            myCustomList.Add(4);
            myCustomList.Add(6);

            // Act
            myCustomList.Remove(8);

            // Assert
            Assert.AreEqual(3, myCustomList.Count);
        }

        [TestMethod]
        public void Remove_RemoveItemAtZeroIndex_ItemsShiftBackPreviousFirstIndexNowAtZero()
        {
            // Arrange
            CustomList<int> myCustomList = new CustomList<int>();
            int secondItem = 4;
            myCustomList.Add(2);
            myCustomList.Add(secondItem);
            myCustomList.Add(6);

            // Act
            myCustomList.Remove(2);

            // Assert
            Assert.AreEqual(secondItem, myCustomList[0]);
        }

        [TestMethod]
        public void Remove_RemoveItemAtFirstIndex_ItemsShiftBackPreviousSecondIndexNowAtFirst()
        {
            // Arrange
            CustomList<int> myCustomList = new CustomList<int>();
            int thirdItem = 6;
            myCustomList.Add(2);
            myCustomList.Add(4);
            myCustomList.Add(thirdItem);

            // Act
            myCustomList.Remove(4);

            // Assert
            Assert.AreEqual(thirdItem, myCustomList[1]);
        }

        [TestMethod]
        public void Remove_RemoveOneItemThatIsDuplicate_DuplicateStillInItemsArray()
        {
            // Arrange
            CustomList<int> myCustomList = new CustomList<int>();
            myCustomList.Add(4);
            myCustomList.Add(4);
            myCustomList.Add(6);

            // Act
            myCustomList.Remove(4);
            int index = Array.IndexOf(myCustomList.Items, 4);

            // Assert
            Assert.AreNotEqual(-1, index);
        }
    }
}