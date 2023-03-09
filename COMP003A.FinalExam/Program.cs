/*
 * Author: Logan Smith
 * Course: COMP-003A 
 * Assignment: Final Project
 * Purpose: An Intake Form for 
 */
namespace COMP003A.FinalExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }



        ///<summary>
        ///Prints title for Form
        ///</summary>
        ///<param name="intake">Bool input for Intake (true) mode or print (false) mode.</param>
        static void Logo(bool intake)
        {
            Console.WriteLine("\n".PadRight(102,'*'));
            Console.WriteLine("COMPANY NAME");
            Console.WriteLine("INTAKE FORM NAME");
            
            if(intake)
            {
                Console.WriteLine("\nNew User Profile:\n");
            } else {
                Console.WriteLine("\nProfile Summary:\n");
            }
        }



    }
}