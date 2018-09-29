using System;
using UnitTest.Models;
using Xunit;

namespace NumberToRomanNumeral
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1,"I")]
        // [InlineData(2, "II")]
        // [InlineData(5, "V")]
        public void One_To_I(int number, string expectedRomanNumeral)
        {
            //Arrange
            var converter = new Converter();
            //Act
            var romanNumeral = converter.ConvertNumberToRomanNumeral(number);
            //Assert
            Assert.Equal(expectedRomanNumeral, romanNumeral);
        }
    }
}
