using System;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace NameHelper
{
    public static class Extensions
    {
        /// <summary>
        /// Regular Expression to check whether a string contains only alphabets
        /// </summary>
        public static readonly string ALPHABETS = @"^[a-zA-Z]+$";
        /// <summary>
        /// Regular Expression to check whether an email is perfectly valid
        /// </summary>
        public static readonly string EMAIL_REGEX = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";

        /// <summary>
        /// Checks if the string contains only alphabets and also checks if the string atleast has a minumum length of characters
        /// </summary>
        /// <param name="text">input</param>
        /// <param name="length">min length check</param>
        /// <returns>true if the input string is only alphabets and has characters equal or greater than the min length</returns>
        public static bool IsText(this string text, int length)
        {
            return text.IsText() && text.Length >= length;
        }

        /// <summary>
        /// Checks if the string contains only alphabets
        /// </summary>
        /// <param name="text">input</param>
        /// <returns>true if the input string is only alphabets</returns>
        public static bool IsText(this string text)
        {
            return Regex.IsMatch(text, ALPHABETS, RegexOptions.IgnoreCase);
        }

        /// <summary>
        /// Checks if the email is valid and also checks if the string atleast has a minumum length of characters
        /// </summary>
        /// <param name="email">email</param>
        /// <param name="length">min length check</param>
        /// <returns>true if the input string is only alphabets and has characters equal or greater than the min length</returns>
        public static bool IsValidEmail(this string email, int length)
        {
            return email.IsValidEmail() && email.Length >= length;
        }

        /// <summary>
        /// Checks if the email is valid and also checks if the string atleast has a minumum length of characters
        /// </summary>
        /// <param name="email">email</param>
        /// <returns>true if the input string is only alphabets</returns>
        public static bool IsValidEmail(this string email)
        {
            return Regex.IsMatch(email, EMAIL_REGEX, RegexOptions.IgnoreCase);
        }

        /// <summary>
        /// Checks if the given date is from the past
        /// </summary>
        /// <param name="date">input date</param>
        /// <returns>true if the given date is from the past</returns>
        public static bool IsPast(this DateTime date)
        {
            return DateTime.Compare(DateTime.Today, date.Date) > 0;
        }

        /// <summary>
        /// Appends 1st, 2nd, 3rd, 4th,... nth Orinal to the given number
        /// </summary>
        /// <param name="number">given number</param>
        /// <returns>string with appended ordinal alongside the number</returns>
        public static string AppendOrdinal(this int number)
        {
            string ordinal;

            switch (number % 10)
            {
                case 1: ordinal = "st"; break;
                case 2: ordinal = "nd"; break;
                case 3: ordinal = "rd"; break;
                default: ordinal = "th"; break;
            }

            return $"{number} {ordinal}";
        }

        /// <summary>
        /// Replaces the string recursively untill all repetitions are removed
        /// </summary>
        /// <param name="value">given string</param>
        /// <param name="find">string to find</param>
        /// <param name="replace">string to replace</param>
        /// <returns></returns>
        public static string RecursiveReplace(this string value, string find, string replace)
        {
            string result = value.Replace(find, replace);
            if (result.Contains(find))
            {
                result.RecursiveReplace(find, replace);
            }
            return result;
        }

        /// <summary>
        /// Gets all the possible Combinations 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="input">the list of input values</param>
        /// <param name="length">length of each combination</param>
        /// <returns>Collection of all possible combinations</returns>
        public static IEnumerable<T[]> Combinations<T>(this IEnumerable<T> input, int length)
        {
            List<T[]> result = new List<T[]>();

            if (length == 0)
            {
                result.Add(new T[0]); // single combination: empty set
            }
            else
            {
                int current = 1;
                foreach (T element in input)
                {
                    result.AddRange(input // combine each element with (k - 1)-combinations of subsequent elements
                        .Skip(current++).Combinations(length - 1)
                        .Select(combination => (new T[] { element }).Concat(combination).ToArray()));
                }
            }

            return result;
        }
    }
}