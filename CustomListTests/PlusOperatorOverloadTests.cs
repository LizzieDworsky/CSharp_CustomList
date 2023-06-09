using CustomList;
namespace CustomListTests
{
    [TestClass]
    public class PlusOperatorOverloadTests
    {
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
    }
}