using System;

namespace FnacDarty.Display
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter roman value");
            var romanValue = Console.ReadLine();
            Tests.Converter converter = new Tests.Converter();
            var arabicValue = converter.RomanToArabic(romanValue);
            Console.WriteLine($"{romanValue} => {arabicValue}");
        }
    }
}
