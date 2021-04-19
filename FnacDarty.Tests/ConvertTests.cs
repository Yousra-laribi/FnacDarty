using FluentAssertions;
using Xunit;

namespace FnacDarty.Tests
{
    public class ConvertTests
    {
        [Theory]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData(null)]
        public void Should_Roman_To_Arabic_Returns_Null(string? value)
        {
            var service = new Converter();
            var actual = service.RomanToArabic(value);
            int? expected = null;

            actual.Should().Equals(expected);

        }

        [Fact]
        public void Should_Roman_To_Arabic_Returns_Unitary_Value()
        {
            var service = new Converter();
            var actual = service.RomanToArabic("L");
            var expected = 50;

            actual.Should().Equals(expected);

        }

        [Fact]
        public void Should_Roman_To_Arabic_Returns_Unitary_Value_Lower()
        {
            var service = new Converter();
            var actual = service.RomanToArabic("i");
            var expected = 1;

            actual.Should().Equals(expected);

        }

        [Theory]
        [InlineData("iii", 3)]
        [InlineData("viii", 8)]
        [InlineData("iv", 4)]
        [InlineData("cm", 900)]
        [InlineData("xlix", 49)]
        [InlineData("xcix", 99)]
        [InlineData("mxxx", 1030)]
        [InlineData("xxxm", 970)]
        public void Should_Roman_To_Arabic_Returns_Correct_Value(string roman, int arabic)
        {
            var service = new Converter();
            var actual = service.RomanToArabic(roman);

            arabic.Should().Be(actual);

        }
    }
}
