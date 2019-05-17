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
    }
}
