using System;
using FilterByPredicate;

namespace FilterByDigit
{
    /// <summary>
    /// Predicate that determines the presence of some digit in integer.
    /// </summary>
    public class ByDigitPredicate : IPredicate
    {
        private int digit;

        /// <summary>
        /// Gets or sets a digit.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when Digit more than 9 or less than 0.</exception>
        public int Digit
        {
            get => this.digit;
            set
            {
                if (value > 9 || value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }

                this.digit = value;
            }
        }

        /// <inheritdoc/>
        public bool IsMatch(int number)
        {
            int remainNumber;
            int newNumber = Math.Abs(number);
            while (newNumber > 0)
            {
                remainNumber = newNumber % 10;
                if (remainNumber == this.digit)
                {
                    return true;
                }

                newNumber /= 10;
            }

            return false;
        }
    }
}
