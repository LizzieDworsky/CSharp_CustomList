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
            Assert.AreEqual(item, myCustomList[0]);

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
            Assert.AreEqual(itemTwo, myCustomList[1]);

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
        public void Add_AddNineItems_CapactityDoublesTwice()
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
            myCustomList.Add(itemOne);
            myCustomList.Add(itemTwo);
            myCustomList.Add(itemThree);
            myCustomList.Add(itemFour);

            // Assert
            Assert.AreEqual(16, myCustomList.Capacity);

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
            Assert.AreEqual(itemOne, myCustomList[0]);

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
        public void PlusOperator_CombineTwoListsFirstLonger_ReturnsListwithCombinedValuesOfBothLists()
        {
            // Arrange
            CustomList<int> compareList = new CustomList<int>();
            compareList.Add(2);
            compareList.Add(4);
            compareList.Add(3);
            CustomList<int> listOne = new CustomList<int>();
            listOne.Add(2);
            listOne.Add(4);
            CustomList<int> listTwo = new CustomList<int>();
            listTwo.Add(3);

            // Act
            CustomList<int> resultsList = listOne + listTwo;

            // Assert
            for (int i = 0; i < compareList.Count; i++)
            {
                Assert.AreEqual(compareList[i], resultsList[i]);
            }

        }

        [TestMethod]
        public void PlusOperator_CombineTwoListsSecondLonger_ReturnsListwithCombinedValuesOfBothLists()
        {
            // Arrange
            CustomList<int> compareList = new CustomList<int>();
            compareList.Add(2);
            compareList.Add(1);
            compareList.Add(3);
            CustomList<int> listOne = new CustomList<int>();
            listOne.Add(2);
            CustomList<int> listTwo = new CustomList<int>();
            listTwo.Add(1);
            listTwo.Add(3);

            // Act
            CustomList<int> resultsList = listOne + listTwo;

            // Assert
            for (int i = 0; i < compareList.Count; i++)
            {
                Assert.AreEqual(compareList[i], resultsList[i]);
            }

        }

        [TestMethod]
        public void PlusOperator_CombineTwoListsEqualLength_ReturnsListwithCombinedValuesOfBothLists()
        {
            // Arrange
            CustomList<int> compareList = new CustomList<int>();
            compareList.Add(2);
            compareList.Add(4);
            compareList.Add(1);
            compareList.Add(3);
            CustomList<int> listOne = new CustomList<int>();
            listOne.Add(2);
            listOne.Add(4);
            CustomList<int> listTwo = new CustomList<int>();
            listTwo.Add(1);
            listTwo.Add(3);

            // Act
            CustomList<int> resultsList = listOne + listTwo;

            // Assert
            for (int i = 0; i < compareList.Count; i++)
            {
                Assert.AreEqual(compareList[i], resultsList[i]);
            }

        }

        [TestMethod]
        public void PlusOperator_CombineTwoListsOneEmpty_ReturnsUnchangedListWithInitialValues()
        {
            // Arrange
            CustomList<int> compareList = new CustomList<int>();
            compareList.Add(2);
            compareList.Add(4);
            CustomList<int> listOne = new CustomList<int>();
            listOne.Add(2);
            listOne.Add(4);
            CustomList<int> listTwo = new CustomList<int>();

            // Act
            CustomList<int> resultsList = listOne + listTwo;

            // Assert
            for (int i = 0; i < compareList.Count; i++)
            {
                Assert.AreEqual(compareList[i], resultsList[i]);
            }

        }

        // Minus Operator Overload Tests
        [TestMethod]
        public void MinusOperator_SubtractValuesInSecondListFromFirstListFirstListIsLonger_ReturnFirstListMinusValuesInSecondList()
        {
            // Arrange
            CustomList<int> compareList = new CustomList<int>();
            compareList.Add(4);
            CustomList<int> listOne = new CustomList<int>();
            listOne.Add(2);
            listOne.Add(4);
            CustomList<int> listTwo = new CustomList<int>();
            listTwo.Add(2);

            // Act
            CustomList<int> resultsList = listOne - listTwo;

            // Assert
            for (int i = 0; i < compareList.Count; i++)
            {
                Assert.AreEqual(compareList[i], resultsList[i]);
            }

        }

        [TestMethod]
        public void MinusOperator_SubtractValuesInSecondListFromFirstListSecondListIsLonger_ReturnFirstListMinusValuesInSecondList()
        {
            // Arrange
            CustomList<int> compareList = new CustomList<int>();
            compareList.Add(4);
            CustomList<int> listOne = new CustomList<int>();
            listOne.Add(2);
            listOne.Add(4);
            CustomList<int> listTwo = new CustomList<int>();
            listTwo.Add(2);
            listTwo.Add(3);
            listTwo.Add(1);

            // Act
            CustomList<int> resultsList = listOne - listTwo;

            // Assert
            for (int i = 0; i < compareList.Count; i++)
            {
                Assert.AreEqual(compareList[i], resultsList[i]);
            }

        }

        [TestMethod]
        public void MinusOperator_SubtractValuesInSecondListFromFirstListListsSameLength_ReturnFirstListMinusValuesInSecondList()
        {
            // Arrange
            CustomList<int> compareList = new CustomList<int>();
            compareList.Add(4);
            CustomList<int> listOne = new CustomList<int>();
            listOne.Add(2);
            listOne.Add(4);
            CustomList<int> listTwo = new CustomList<int>();
            listTwo.Add(2);
            listTwo.Add(3);

            // Act
            CustomList<int> resultsList = listOne - listTwo;

            // Assert
            for (int i = 0; i < compareList.Count; i++)
            {
                Assert.AreEqual(compareList[i], resultsList[i]);
            }

        }

        [TestMethod]
        public void MinusOperator_SubtractValuesInSecondListFromFirstListSecondListIsEmpty_ReturnsUnchangedFirstList()
        {
            // Arrange
            CustomList<int> compareList = new CustomList<int>();
            compareList.Add(2);
            compareList.Add(4);
            CustomList<int> listOne = new CustomList<int>();
            listOne.Add(2);
            listOne.Add(4);
            CustomList<int> listTwo = new CustomList<int>();

            // Act
            CustomList<int> resultsList = listOne - listTwo;

            // Assert
            for (int i = 0; i < compareList.Count; i++)
            {
                Assert.AreEqual(compareList[i], resultsList[i]);
            }

        }

        [TestMethod]
        public void MinusOperator_SubtractOnlyOneInstanceFromFirstListIfDuplicatesInFirstListNotSecond_ReturnFirstListWithDuplicateValuesIfNoDuplicatesInSecondList()
        {
            // Arrange
            CustomList<int> compareList = new CustomList<int>();
            compareList.Add(4);
            CustomList<int> listOne = new CustomList<int>();
            listOne.Add(4);
            listOne.Add(4);
            CustomList<int> listTwo = new CustomList<int>();
            listTwo.Add(4);

            // Act
            CustomList<int> resultsList = listOne - listTwo;

            // Assert
            for (int i = 0; i < compareList.Count; i++)
            {
                Assert.AreEqual(compareList[i], resultsList[i]);
            }

        }

    }
}