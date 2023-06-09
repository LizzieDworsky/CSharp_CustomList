using CustomList;
namespace CustomListTests
{
    [TestClass]
    public class AddMethodTests
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
    }
}