using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string word, bool expected)
        {
            return word == null || word != word.Reverse() ? false : true;
        }
    }
}
