using CustomList;
namespace CustomListTests
{
    [TestClass]
    public class CustomListTests
    {

        // Add Method Tests
        [TestMethod]
        public void Add_AddOneItem_CountShouldIncreaseToOne()
        {
            // Arrange
            CustomList<int> myCustomList = new CustomList<int>();

            // Act
            myCustomList.Add(4);

            // Assert
            Assert.AreEqual(1, myCustomList.Count);

        }

        [TestMethod]
        public void Add_AddOneItem_ItemAtZeroIndex()
        {
            // Arrange
            CustomList<int> myCustomList = new CustomList<int>();
            int item = 4;

            // Act
            myCustomList.Add(item);

            // Assert
            Assert.AreEqual(item, myCustomList.Items[0]);

        }

        [TestMethod]
        public void Add_AddTwoItems_SecondItemAtOneIndex()
        {
            // Arrange
            CustomList<int> myCustomList = new CustomList<int>();
            int itemOne = 4;
            int itemTwo = 2;

            // Act
            myCustomList.Add(itemOne);
            myCustomList.Add(itemTwo);

            // Assert
            Assert.AreEqual(itemTwo, myCustomList.Items[1]);

        }

        [TestMethod]
        public void Add_AddFiveItems_CapactityIncreasesByFour()
        {
            // Arrange
            CustomList<int> myCustomList = new CustomList<int>();
            int itemOne = 1;
            int itemTwo = 2;
            int itemThree = 3;
            int itemFour = 4;
            int itemFive = 5;

            // Act
            myCustomList.Add(itemOne);
            myCustomList.Add(itemTwo);
            myCustomList.Add(itemThree);
            myCustomList.Add(itemFour);
            myCustomList.Add(itemFive);

            // Assert
            Assert.AreEqual(8, myCustomList.Capacity);

        }

        [TestMethod]
        public void Add_AddFiveItems_FirstItemAtZeroIndex()
        {
            // Arrange
            CustomList<int> myCustomList = new CustomList<int>();
            int itemOne = 1;
            int itemTwo = 2;
            int itemThree = 3;
            int itemFour = 4;
            int itemFive = 5;

            // Act
            myCustomList.Add(itemOne);
            myCustomList.Add(itemTwo);
            myCustomList.Add(itemThree);
            myCustomList.Add(itemFour);
            myCustomList.Add(itemFive);

            // Assert
            Assert.AreEqual(itemOne, myCustomList.Items[0]);

        }


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
            Assert.AreEqual(secondItem, myCustomList.Items[0]);
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
            Assert.AreEqual(thirdItem, myCustomList.Items[1]);
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


        // ToString Method Tests
        [TestMethod]
        public void ToString_StringifyAllStringValuesInItemsArray_ReturnStringValuesCombinedInOneString()
        {
            // Arrange
            CustomList<string> myCustomList = new CustomList<string>();
            myCustomList.Add("Hello ");
            myCustomList.Add("World");

            // Act
            string stringifiedList = myCustomList.ToString();

            // Assert
            Assert.AreEqual("Hello World", stringifiedList);

        }

        [TestMethod]
        public void ToString_StringifyAllIntValuesInItemsArray_ReturnStringifiedIntValues()
        {
            // Arrange
            CustomList<int> myCustomList = new CustomList<int>();
            myCustomList.Add(2);
            myCustomList.Add(4);
            myCustomList.Add(6);

            // Act
            string stringifiedList = myCustomList.ToString();

            // Assert
            Assert.AreEqual("246", stringifiedList);

        }

        [TestMethod]
        public void ToString_AttemptToStringafy_ReturnEmptyString()
        {
            // Arrange
            CustomList<int> myCustomList = new CustomList<int>();

            // Act
            string stringifiedList = myCustomList.ToString();

            // Assert
            Assert.AreEqual("", stringifiedList);

        }

        // Plus Operator Overload Tests
        [TestMethod]
        public void PlusOperator_CombineTwoListsFirstLonger_ReturnsListwithCombinesValuesOfBothLists()
        {
            // Arrange


            // Act


            // Assert

        }

        [TestMethod]
        public void PlusOperator_CombineTwoListsSecondLonger_ReturnsListwithCombinesValuesOfBothLists()
        {
            // Arrange


            // Act


            // Assert

        }

        [TestMethod]
        public void PlusOperator_CombineTwoListsEqualLength_ReturnsListwithCombinesValuesOfBothLists()
        {
            // Arrange


            // Act


            // Assert

        }

        [TestMethod]
        public void PlusOperator_CombineTwoListsOneEmpty_ReturnsUnchangedListWithInitialValues()
        {
            // Arrange


            // Act


            // Assert

        }

        // Minus Operator Overload Tests
        [TestMethod]
        public void MinusOperator_SubtractValuesFromFirstListInSecondFirstListIsLonger_ReturnFirstListMinusValuesInSecondList()
        {
            // Arrange


            // Act


            // Assert

        }

        [TestMethod]
        public void MinusOperator_SubtractValuesFromFirstListInSecondSecondListIsLonger_ReturnFirstListMinusValuesInSecondList()
        {
            // Arrange


            // Act


            // Assert

        }

        [TestMethod]
        public void MinusOperator_SubtractValuesFromFirstListInSecondListsSameLength_ReturnFirstListMinusValuesInSecondList()
        {
            // Arrange


            // Act


            // Assert

        }

        [TestMethod]
        public void MinusOperator_SubtractValuesFromFirstListInSecondSecondListIsEmpty_ReturnsUnchangedFirstList()
        {
            // Arrange


            // Act


            // Assert

        }

        [TestMethod]
        public void MinusOperator_SubtractOnlyOneInstanceFromFirstListInSecondIfDuplicatesInFirstListNotSecond_ReturnFirstListWithDuplicateValuesIfNoDuplicatesInSecondList()
        {
            // Arrange


            // Act


            // Assert

        }

    }
}