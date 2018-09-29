using System;
using UnitTest.Models;
using Xunit;

namespace NumberToRomanNumeral
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1,"I")]
        [InlineData(2, "II")]
        [InlineData(3, "III")]
        [InlineData(4, "IV")]
        [InlineData(5, "V")]

        // [InlineData(5, "V")]
        public void number_To_RomanNumeral(int number, string expectedRomanNumeral)
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
