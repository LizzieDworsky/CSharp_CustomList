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
        public void ToString_StringifyAllDoubleValuesInItemsArray_ReturnStringifiedDoubleValues()
        {
            // Arrange
            CustomList<double> myCustomList = new CustomList<double>();
            myCustomList.Add(2.2);
            myCustomList.Add(4.4);
            myCustomList.Add(6.6);

            // Act
            string stringifiedList = myCustomList.ToString();

            // Assert
            Assert.AreEqual("2.24.46.6", stringifiedList);

        }

        [TestMethod]
        public void ToString_StringifyAllBooleanValuesInItemsArray_ReturnStringifiedBooleanValues()
        {
            // Arrange
            CustomList<bool> myCustomList = new CustomList<bool>();
            myCustomList.Add(false);
            myCustomList.Add(true);

            // Act
            string stringifiedList = myCustomList.ToString();

            // Assert
            Assert.AreEqual("FalseTrue", stringifiedList);

        }

        [TestMethod]
        public void ToString_StringifyAllListValuesInItemsArray_ReturnEmptyString()
        {
            // Arrange
            CustomList<List<string>> myCustomList = new CustomList<List<string>>();
            myCustomList.Add(new List<string>());
            myCustomList.Add(new List<string>());

            // Act
            string stringifiedList = myCustomList.ToString();

            // Assert
            Assert.AreEqual("", stringifiedList);

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