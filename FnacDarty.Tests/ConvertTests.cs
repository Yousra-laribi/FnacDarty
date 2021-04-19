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
            var actual = service.RomanToArabic("I");
            var expected = 1;

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
    }
}
