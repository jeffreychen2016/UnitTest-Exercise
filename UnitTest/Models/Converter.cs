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
                { 1, "I" }
            };
        }

        public string ConvertNumberToRomanNumeral(int number)
        {
            var result = "";
            foreach (var item in _numberToRomanNumeralDictionary)
            {
                result = item.Value;
            }

            return result;
        }
    }
}
