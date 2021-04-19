using System;

namespace FnacDarty.Display
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please enter roman value");
                var romanValue = Console.ReadLine();
                Tests.Converter converter = new Tests.Converter();
                var arabicValue = converter.RomanToArabic(romanValue);
                var correspondingMsg = arabicValue.HasValue ? arabicValue.Value.ToString() : "Conversion failed";
                Console.WriteLine($"{romanValue} => {correspondingMsg}");
            }
        }
    }
}
