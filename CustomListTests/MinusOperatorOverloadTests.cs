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
        public void MinusOperator_SubtractValuesInSecondListFromFirstListListsString_ReturnFirstListMinusValuesInSecondList()
        {
            // Arrange
            CustomList<string> compareList = new CustomList<string>();
            compareList.Add("Hello");
            CustomList<string> listOne = new CustomList<string>();
            listOne.Add("Hello");
            listOne.Add("World");
            CustomList<string> listTwo = new CustomList<string>();
            listTwo.Add("World");
            listTwo.Add("Goodbye");

            // Act
            CustomList<string> resultsList = listOne - listTwo;

            // Assert
            for (int i = 0; i < compareList.Count; i++)
            {
                Assert.AreEqual(compareList[i], resultsList[i]);
            }

        }

        [TestMethod]
        public void MinusOperator_SubtractValuesInSecondListFromFirstListListsDouble_ReturnFirstListMinusValuesInSecondList()
        {
            // Arrange
            CustomList<double> compareList = new CustomList<double>();
            compareList.Add(4.4);
            CustomList<double> listOne = new CustomList<double>();
            listOne.Add(2.2);
            listOne.Add(4.4);
            CustomList<double> listTwo = new CustomList<double>();
            listTwo.Add(2.2);
            listTwo.Add(3.3);

            // Act
            CustomList<double> resultsList = listOne - listTwo;

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

        [TestMethod]
        public void MinusOperator_AttemptToMinusListOfLists_ReturnNull()
        {
            // Arrange
            CustomList<List<string>> myCustomList = new CustomList<List<string>>();
            myCustomList.Add(new List<string>());
            myCustomList.Add(new List<string>());
            CustomList<List<string>> mySecondCustomList = new CustomList<List<string>>();
            myCustomList.Add(new List<string>());
            myCustomList.Add(new List<string>());

            // Act
            CustomList<List<string>> results = myCustomList - mySecondCustomList;

            // Assert
            Assert.AreEqual(null, results);

        }

    }
}