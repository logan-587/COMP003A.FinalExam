/*
 * Author: Logan Smith
 * Course: COMP-003A 
 * Assignment: Final Project
 * Purpose: An Intake Form for Volunteer Applications
 */
namespace COMP003A.FinalExam
{
    internal class Program
    {
        /*
        static void Main(string[] args)
        {
            Logo(true);
            Console.WriteLine("\n\nPersonal Information:\n-------------------------");
            PersonalInfo Applicant = new PersonalInfo();

            
            Console.Write("\nWhat is your first name: ");
            Applicant.FirstName = Inputty("name");

            Console.Write("\nWhat is your last name: ");
            Applicant.LastName = Inputty("name");

            Console.Write("\nWhat year were you born: ");
            //Applicant.BirthYear = Convert.ToInt32(Inputty("birthyear"));

            Console.WriteLine(Applicant.FirstName);
            Console.WriteLine(Applicant.LastName);
           // Console.WriteLine(Applicant.BirthYear);




        }


        static string Inputty(string type)
        {
            string realVar = null;
            int i = 0;
            string badChars = null;
            int z = 0;


            while (i == 0)
            {
                string tempVar = Console.ReadLine();

                switch (type)
                {
                    case "email":
                        badChars = @"\|!#$%&/()@=?*+»«@£§€{}.-;'<>_,";
                        break;
                    case "name":
                        badChars = @"1234567890\|!#$%&/()@.=?*+»«@£§€{}-;'<>_,";
                        break;
                    case "phone":
                        badChars = @"abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRUTUVWXYZ\|!#$%&/()@.=?+»«@£§€{};'<>_,";
                        break;
                    default:
                        badChars = @"\|!$%&/()@=?*+»«@£§€{};'<>";
                        break;
                }






                /*
                switch(type)
                {
                    case "email":
                        tempVar = Console.ReadLine();
                        string badChars = @"\|!#$%&/()@=?*+»«@£§€{}.-;'<>_,";
                        foreach(var item in badChars)
                        {
                            if ((tempVar.Contains(item)))
                            {
                                z++;
                            }

                            if(z == 0)
                            {
                                realVar = tempVar;
                                i = 1;
                            }
                            else
                            {
                                Console.Write("\nSorry, try again: ");
                            }

                        }
                        break;


                    case "name":
                        tempVar = Console.ReadLine();
                        badChars = @"1234567890\|!#$%&/()@.=?*+»«@£§€{}-;'<>_,";
                        foreach (var item in badChars)
                        {
                            if ((tempVar.Contains(item)))
                            {
                                z++;
                            }

                            if (z == 0)
                            {
                                realVar = tempVar;
                                i = 1;
                            }
                            else
                            {
                                Console.Write("\nSorry, try again: ");
                            }
                        }
                        break;


                    case "phone":
                        tempVar = Console.ReadLine();
                        badChars = @"abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRUTUVWXYZ\|!#$%&/()@.=?+»«@£§€{};'<>_,";
                        foreach (var item in badChars)
                        {
                            if ((tempVar.Contains(item)))
                            {
                                z++;
                            }

                            if (z == 0)
                            {
                                realVar = tempVar;
                                i = 1;
                            }
                            else
                            {
                                Console.Write("\nSorry, try again: ");
                                tempVar = null;
                            }
                        }
                        break;

                    case "birthyear":
                        try
                        {
                            Convert.ToInt32(tempVar);
                            i = 1;
                        }
                        catch (System.FormatException)
                        {
                            Console.Write("\nSorry, try again: ");
                            tempVar = null;
                        }
                        break;


                    default:
                        tempVar = Console.ReadLine();
                        badChars = @"\|!$%&/()@=?*+»«@£§€{};'<>";
                        foreach (var item in badChars)
                        {
                            if ((tempVar.Contains(item)))
                            {
                                z++;
                            }

                            if (z == 0)
                            {
                                realVar = tempVar;
                                i = 1;
                            }
                            else
                            {
                                Console.Write("\nSorry, try again: ");
                                tempVar = null;
                            }
                        }
                        break;
                
            }
                

                

            }

            return realVar;

        }






        ///<summary>
        ///Prints title for Form
        ///</summary>
        ///<param name="intake">Bool input for Intake (true) mode or print (false) mode.</param>
        static void Logo(bool intake)
        {
            Console.WriteLine("\n".PadRight(100,'*'));
            Console.WriteLine("SPURIOUS CO.");
            Console.WriteLine("Volunteer Applicant Intake Form");
            Console.WriteLine("".PadRight(100, '*'));

            Console.WriteLine("\n\n".PadRight(27, '*'));

            if (intake)
            {
                Console.WriteLine("\nNEW USER APPLICATION\n");
            } 
            else 
            {
                Console.WriteLine("\nAPPLICATION SUMMARY\nPlease Confirm Your Information\n");
            }

            Console.WriteLine("".PadRight(25, '*'));
        }


        */
    }
}