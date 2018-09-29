using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTest.Models
{
    public class Converter
    {
        private readonly Dictionary<int, string> _numberToRomanNumeralDictionary;

        public Converter()
        {
            _numberToRomanNumeralDictionary = new Dictionary<int, string>
            {
                { 10, "X"},
                { 9, "IX"},
                { 5, "V" },
                { 4, "IV" },
                { 1, "I" }
            };
        }

        public string ConvertNumberToRomanNumeral(int number)
        {
            var result = new StringBuilder();
            foreach (var item in _numberToRomanNumeralDictionary)
            {
                while (number >= item.Key)
                {
                    result.Append(item.Value);
                    number -= item.Key;
                }
            }

            return result.ToString();
        }
    }
}
