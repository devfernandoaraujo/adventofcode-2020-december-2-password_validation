using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.Immutable;

namespace PasswordValidation
{
    /// <summary>
    /// Validate passwords in general
    /// </summary>
    public class PasswordValidator
    {
        /// <summary>
        /// Return the number of passwords valid
        /// </summary>
        /// <param name="isValidateByNewPolicy">new Policy of validation in Place</param>
        /// <returns>Integer Value</returns>
        public int CountValidPasswords(bool isValidateByNewPolicy)
        {
            int countPasswords = 0;

            short numberCharacterFound = 0;

            if (isValidateByNewPolicy)
                return CountValidPasswords();

            foreach (Password p in Puzzle.GetPasswords())
            {
                numberCharacterFound = 0;

                foreach (char c in p.password.ToCharArray())
                {
                    if (p.charcarter == c)
                    {
                        numberCharacterFound++;
                    }
                }

                if (numberCharacterFound >= p.minCharacters && numberCharacterFound <= p.maxCharacters)
                    countPasswords++;

            }

            return countPasswords;

        }

        /// <summary>
        /// Validate the passwords according to the new policy in place Puzzle part 2
        /// </summary>
        /// <returns>Integer Value</returns>
        private int CountValidPasswords()
        {
            int countPasswords = 0;


            foreach (Password p in Puzzle.GetPasswords())
            {
                char[] array = p.password.ToCharArray();

                if (array[p.minCharacters - 1] == p.charcarter && array[p.maxCharacters - 1] == p.charcarter)
                    continue; //invalid: both position contain the specific character

                else if (array[p.minCharacters - 1] != p.charcarter && array[p.maxCharacters - 1] != p.charcarter)
                    continue; // invalid: neither position contains the specific character

                countPasswords++;
            }

            return countPasswords;
        }
    }
}