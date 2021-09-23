using System;
using System.Collections.Generic;
using System.Linq;

namespace NameHelper
{
    /// <summary>
    /// Type to represent a Person 
    /// </summary>
    public class Person
    {
        #region properties

        /// <summary>
        /// First Name of the person
        /// </summary>
        public string FirstName { get; private set; }
        /// <summary>
        /// Last name of the person
        /// </summary>
        public string LastName { get; private set; }
        /// <summary>
        /// primary email of the person
        /// </summary>
        public string Email { get; private set; }
        /// <summary>
        /// Date of birth
        /// </summary>
        public DateTime Birthday { get; private set; }
        /// <summary>
        /// Age of the person
        /// </summary>
        public int Age { get; private set; }
        /// <summary>
        /// Is the date of birth valid ?
        /// </summary>
        public bool IsAdult { get; private set; }
        /// <summary>
        /// Username suggestion for the person
        /// </summary>
        public List<string> UserNames { get; private set; }
        /// <summary>
        /// Birthday message / Number of days for next birthday
        /// </summary>
        public string BirthdayMessage { get; private set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="firstName">FirstName</param>
        /// <param name="lastName">LastName</param>
        /// <param name="email">Email</param>
        /// <param name="birthday">Birthday</param>
        public Person(string firstName, string lastName, string email, DateTime birthday)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Birthday = birthday;

            SetValues(firstName, lastName, email, birthday);
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="firstName">FirstName</param>
        /// <param name="lastName">LastName</param>
        /// <param name="email">Email</param>
        public Person(string firstName, string lastName, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;

            SetValues(firstName, lastName, email, DateTime.Now);
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="firstName">FirstName</param>
        /// <param name="lastName">LastName</param>
        /// <param name="birthday">Birthday</param>
        public Person(string firstName, string lastName, DateTime birthday)
        {
            FirstName = firstName;
            LastName = lastName;
            Birthday = birthday;

            SetValues(firstName, lastName, string.Empty, birthday);
        }

        #endregion

        #region private methods

        /// <summary>
        /// Sets all the properties
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="email"></param>
        /// <param name="birthday"></param>
        private void SetValues(string firstName, string lastName, string email, DateTime birthday)
        {
            TimeSpan span = DateTime.Now - birthday;
            Age = GetAge(birthday, span);
            IsAdult = CheckIsAdult(span);
            BirthdayMessage = GetBirthdayMessage(birthday, Age);
            UserNames = SetUserNames(firstName, lastName, Email, birthday, Age);
        }

        /// <summary>
        /// Calculated the age of the person
        /// </summary>
        /// <param name="birthday"></param>
        /// <param name="span"></param>
        /// <returns></returns>
        private int GetAge(DateTime birthday, TimeSpan span)
        {
            int age = DateTime.Now.Year - birthday.Year;
            if (birthday.Date > DateTime.Now.AddYears(-age)) { age--; }
            return age;
        }

        /// <summary>
        /// Checks whether the person is adult or not
        /// </summary>
        /// <param name="age"></param>
        /// <returns></returns>
        private bool CheckIsAdult(TimeSpan age)
        {
            return age.TotalDays > (365 * 18);
        }

        /// <summary>
        /// Get Birthday Message based on the given date
        /// </summary>
        /// <param name="birthday"></param>
        /// <returns></returns>
        private string GetBirthdayMessage(DateTime birthday, int age)
        {
            if (birthday.Date == DateTime.Now.Date)
            {
                return $"🙄 Born today ? Really ? 🤣";
            }
            else if (age > Constants.MaxHumanAge)
            {
                return $"🙄 Age {age}. Is that a Joke ? 🙄";
            }
            else if (birthday.Date.Month == DateTime.Now.Month && birthday.Date.Day == DateTime.Now.Day)
            {
                return $"🎉 Happy {Age.AppendOrdinal()} Birthday 🥳";
            }
            else
            {
                DateTime nextBirthday = new DateTime(DateTime.Now.Year, birthday.Month, birthday.Day);

                if (nextBirthday < DateTime.Now)
                {
                    nextBirthday = new DateTime(DateTime.Now.Year + 1, birthday.Month, birthday.Day);
                }

                return $"{(nextBirthday - DateTime.Now.Date).TotalDays} days remaining for next Birthday.";
            }
        }

        private List<string> SetUserNames(string firstName, string lastName, string email, DateTime birthday, int age)
        {
            List<string> relevantNames = new List<string>
            {
                $"{firstName}.",
                $"{lastName}.",
                $"{firstName.First()}.",
                $"{lastName.First()}.",
                $"{birthday.Day}.",
                $"{birthday.Month}.",
                $"{birthday.Year}.",
                birthday.Year.ToString().Substring(2),
                email.Split(new char[] { '@' }, StringSplitOptions.RemoveEmptyEntries).First()
            };

            List<string> combinationOfThree = GetCombinations(relevantNames, 3);
            List<string> combinationOfFour = GetCombinations(relevantNames, 4);

            List<string> suggestions = new List<string>();
            suggestions.AddRange(combinationOfThree);
            suggestions.AddRange(combinationOfFour);

            // Get rid of the most shorter and longer ones and keep only the medium lenth suggestions for realistic suggestion
            return suggestions.OrderByDescending(o => o.Length).Skip(suggestions.Count / 5).Take(suggestions.Count / 4).Distinct().ToList();
        }

        /// <summary>
        /// Gets the combination of keywords for suggestion of username
        /// </summary>
        /// <param name="relevantNames">all relevant keywords</param>
        /// <param name="length">combinations to try for each name</param>
        /// <returns></returns>
        private List<string> GetCombinations(List<string> relevantNames, int length)
        {
            return relevantNames.Combinations(length).Select(s => string.Join("", s.Distinct()))
                                .Select(s => s.RecursiveReplace("..", ".").TrimStart(new[] { '.' }).TrimEnd(new[] { '.' })).ToList();
        }

        #endregion
    }
}