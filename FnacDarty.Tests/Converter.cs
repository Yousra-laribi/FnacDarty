using System;
using System.Collections.Generic;
using System.Text;

namespace FnacDarty.Tests
{
    public class Converter : IConverter
    {
        private readonly Dictionary<string, int> _unitaryValues = new Dictionary<string, int>()
        {
            { "I", 1 },
            { "V", 5 }
        };
        public int? RomanToArabic(string? value)
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
            {
                return null;
            }

            if(value.Length == 1)
            {
                return _unitaryValues[value.ToUpper()];
            }

            else return 0;
        }
    }
}
