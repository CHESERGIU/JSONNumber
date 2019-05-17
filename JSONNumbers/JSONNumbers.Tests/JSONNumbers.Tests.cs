using System;
using Xunit;

namespace JSONNumbers.Tests
{
    public class JSONNumbersTests
    {
        [Fact]
        public void Initial_Test()
        {
            string console = "0.0";
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
        [Fact]
        public void For_a__number_with_Exponent_invalid_to_validate()
        {
            string console = "12.123E";
            bool success = false;
            Assert.Equal(success, Program.IsValidJSONNumber(console));
        }
        [Fact]
        public void For_a__number_with_leading_zero_to_validate()
        {
            string console = "012";
            bool success = false;
            Assert.Equal(success, Program.IsValidJSONNumber(console));
        }
        [Fact]
        public void For_a_DECIMAL_number_with_leading_zero_to_validate()
        {
            string console = "0.12";
            bool success = true;
            Assert.Equal(success, Program.IsValidJSONNumber(console));
        }
    }
}
