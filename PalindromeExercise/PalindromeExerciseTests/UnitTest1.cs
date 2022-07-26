using PalindromeExercise;
using System;
using Xunit;


namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("rotor", true)]
        [InlineData("taco", false)]
        [InlineData("civic", true)]
        [InlineData("madam", true)]
        [InlineData("hotpocket", false)]
        [InlineData("", false)]

        public void IsAPalindromeTest(string word, bool expected)
        {
            //Arrange
            var wordSmith = new WordSmith();

            //Act
            var actual = wordSmith.IsAPalindrome(word, expected);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
