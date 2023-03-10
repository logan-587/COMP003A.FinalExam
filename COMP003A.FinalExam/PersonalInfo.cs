#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.FinalExam
{
    internal class PersonalInfo : IInfo
    {

        /***************************************************************************/
        //Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public PersonalInfo() { }


        /// <summary>
        /// Constructor for Applicant personal information
        /// </summary>
        /// <param name="firstName">String input</param>
        /// <param name="lastName">String Input</param>
        /// <param name="birthYear">Int Input</param>
        /// <param name="gender">Char Input</param>
        /// <param name="mailingAddress">String Input</param>
        /// <param name="emailAddress">String Input</param>
        /// <param name="phoneNumber">String Input</param>
        public PersonalInfo(string firstName, string lastName, int birthYear, char gender, string mailingAddress, string city, string state, string postal, string emailAddress, string phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthYear = birthYear;
            Gender = gender;
            MailingAddress = mailingAddress;
            City = city;
            State = state;
            Postal = postal;
            EmailAddress = emailAddress;
            PhoneNumber = phoneNumber;
            
        }
        
        /******************************************************************************/
        //Properties

        /// <summary>
        /// Retrieve/Store First Name
        /// </summary>
        public string FirstName
        { get; set; }

        /// <summary>
        /// Retrieve/Store Last Name
        /// </summary>
        public string LastName
        { get; set; }

        /// <summary>
        /// Retrieve/Store Birth Year
        /// </summary>
        public int BirthYear
        { get; set; }

        /// <summary>
        /// Retrieve/Store Gender
        /// </summary>
        public char Gender
        { get; set; }

        /// <summary>
        /// Retrieve/Store Mailing Address
        /// </summary>
        public string MailingAddress
        { get; set; }

        /// <summary>
        /// Retrieve/Store Email Address
        /// </summary>
        public string EmailAddress
        { get; set; }

        /// <summary>
        /// Retrieve/Store Phone Number
        /// </summary>
        public string PhoneNumber
        { get; set; }


        ///<summary>
        ///Retrieve/Store Postal Code Info
        ///</summary>
        public string Postal
        { get; set;}

        ///<summary>
        ///Retrieve/Store City Info
        ///</summary>
        public string City
        { get; set;}


        ///<summary>
        ///Retrieve/Store State Info
        ///</summary>
        public string State
        { get; set;}


        /******************************************************/
        //Method Implementation
        public virtual void PrintInfo()
        {
            Console.WriteLine($"Your first name is: {FirstName}.");
            Console.WriteLine($"Your last name is: {LastName}.");
            Console.WriteLine($"You are {BirthYear - DateTime.Now.Year} years old.");
            Console.WriteLine($"You are: {Gender}");
            Console.WriteLine($"Your address is: {MailingAddress}, {City}, {State} {Postal}, United States.");
            Console.WriteLine($"Your email address is: {EmailAddress}");
            Console.WriteLine($"Your phone number is: {PhoneNumber}");
        }
    }
}
