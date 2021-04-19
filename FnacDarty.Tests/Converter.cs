using System;
using System.Collections.Generic;
using System.Text;

namespace FnacDarty.Tests
{
    public class Converter : IConverter
    {
        private readonly Dictionary<char, int> _values = new Dictionary<char, int>()
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 },
        };
        public int? RomanToArabic(string? value)
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
            {
                return null;
            }

            int number = 0;
            for (int i = 0; i < value.Length; i++)
            {
                if (!_values.ContainsKey(char.ToUpper(value[i]))) return null;
                if (i + 1 < value.Length && 
                    _values[char.ToUpper(value[i])] < _values[char.ToUpper(value[i + 1])] &&
                    !(char.ToUpper(value[i + 1]) == 'I' && (char.ToUpper(value[i+1]) == 'C' || char.ToUpper(value[i]) == 'L'))
                    )
                {
                    number -= _values[char.ToUpper(value[i])];
                }
                else
                {
                    number += _values[char.ToUpper(value[i])];
                }
            }
            return number;
        }
    }
}
