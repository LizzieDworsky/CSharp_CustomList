using CustomList;
namespace CustomListTests
{
    [TestClass]
    public class ToStringMethodTests
    {
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
    }
}