using ENAE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MABT.CadenaTextoUnitTes.AppUnit
{
    public class StringManipulatorTests
    {
        [Fact]
        public void ReverseString_ShouldReturnReversedString()
        {
            // Arrange
            ENAEStringManipulator manipulator = new ENAEStringManipulator();
            string input = "hello";
            string expected = "olleh";

            // Act
            string result = manipulator.ReverseString(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ReverseString_ShouldHandleEmptyString()
        {
            // Arrange
            ENAEStringManipulator manipulator = new ENAEStringManipulator();
            string input = "";
            string expected = "";

            // Act
            string result = manipulator.ReverseString(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ReverseString_ShouldThrowArgumentNullException_WhenInputIsNull()
        {
            // Arrange
            ENAEStringManipulator manipulator = new ENAEStringManipulator();

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => manipulator.ReverseString(null));
        }

        [Fact]
        public void RemoveSpaces_ShouldReturnStringWithoutSpaces()
        {
            // Arrange
            ENAEStringManipulator manipulator = new ENAEStringManipulator();
            string input = "hello world";
            string expected = "helloworld";

            // Act
            string result = manipulator.RemoveSpaces(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void RemoveSpaces_ShouldHandleStringWithNoSpaces()
        {
            // Arrange
            ENAEStringManipulator manipulator = new ENAEStringManipulator();
            string input = "helloworld";
            string expected = "helloworld";

            // Act
            string result = manipulator.RemoveSpaces(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void RemoveSpaces_ShouldThrowArgumentNullException_WhenInputIsNull()
        {
            // Arrange
            ENAEStringManipulator manipulator = new ENAEStringManipulator();

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => manipulator.RemoveSpaces(null));
        }
    }
}
