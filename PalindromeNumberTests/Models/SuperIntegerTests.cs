using PalindromeNumberConsoleApp.Models;
using Xunit;

namespace PalindromeNumberTests.Models
{
    public class SuperIntegerTests
    {
        [Fact]
        public void IsPalindrome_Should_Return_True()
        {
            var number = 121;
            var result = SuperInteger.IsPalindrome(number);

            Assert.True(result);
        }

        [Fact]
        public void IsPalindrome_Should_Return_False()
        {
            var number = 123;
            var result = SuperInteger.IsPalindrome(number);

            Assert.False(result);
        }
    }
}
