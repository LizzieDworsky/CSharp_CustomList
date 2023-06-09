using CustomList;
namespace CustomListTests
{
    [TestClass]
    public class MinusOperatorOverloadTests
    {
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