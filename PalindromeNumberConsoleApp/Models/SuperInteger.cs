namespace PalindromeNumberConsoleApp.Models
{
    public class SuperInteger
    {
        #region snippet_PowerfulMethods

        /// <summary>
        /// Checks if the number is a palindrome
        /// </summary>
        /// <param name="number"></param>
        /// <returns>If the number is a palindrome returns true otherwise false</returns>
        public static bool IsPalindrome(int number)
        {
            if (number < 0 || (number % 10 == 0 && number != 0))
            {
                return false;
            }

            int revertedNumber = 0;

            while (number > revertedNumber)
            {
                revertedNumber = revertedNumber * 10 + number % 10;
                number /= 10;
            }

            return number == revertedNumber || number == revertedNumber / 10;
        }

        #endregion
    }
}
