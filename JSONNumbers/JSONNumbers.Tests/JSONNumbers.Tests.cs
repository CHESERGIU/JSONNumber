using System;
using Xunit;

namespace JSONNumbers.Tests
{
    public class JSONNumbersTests
    {
        [Fact]
        public void Initial_Test()
        {
            string console = "0";
            Program.IsValidJSONNumber(console);
        }
        [Fact]
        public void For_a_number_to_validate()
        {
            string console = "100";
            bool success = true;
            Assert.Equal(success, Program.IsValidJSONNumber(console));
        }
        [Fact]
        public void For_a__minus_number_to_validate()
        {
            string console = "-100";
            bool success = true;
            Assert.Equal(success, Program.IsValidJSONNumber(console));
        }
        [Fact]
        public void For_a__number_with_decimal_point_to_validate()
        {
            string console = "12.34";
            bool success = true;
            Assert.Equal(success, Program.IsValidJSONNumber(console));
        }
        [Fact]
        public void For_a__number_with_exponent_to_validate()
        {
            string console = "12.123e3";
            bool success = true;
            Assert.Equal(success, Program.IsValidJSONNumber(console));
        }
        [Fact]
        public void For_a__number_with_Exponent_plus_to_validate()
        {
            string console = "12.123E+3";
            bool success = true;
            Assert.Equal(success, Program.IsValidJSONNumber(console));
        }
        [Fact]
        public void For_a__number_with_Exponent_minus_to_validate()
        {
            string console = "12.123E-2";
            bool success = true;
            Assert.Equal(success, Program.IsValidJSONNumber(console));
        }
    }
}
