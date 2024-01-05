using System;
using FilterByPredicate;

namespace FilterByPalindromic
{
    /// <summary>
    /// Palindrome predicate.
    /// </summary>
    public class ByPalindromicPredicate : IPredicate
    {
        /// <inheritdoc/>
        public bool IsMatch(int number)
        {
            var toString = number.ToString();
            if (toString == toString.Reverse())
            {
                return true;
            }

            return false;
        }
    }
}
