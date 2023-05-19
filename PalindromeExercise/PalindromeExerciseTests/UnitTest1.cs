using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("palindrome", false)]
        [InlineData("", false)]
        public void IsAPalindrome(string word, bool expected)
        {
            //Arrange
            WordSmith challenger = new WordSmith();
            //Act
            var actual = challenger.IsAPalindrome(word);

            //Assert
            Assert.Equal (expected, actual);
            

        }
    }
}
