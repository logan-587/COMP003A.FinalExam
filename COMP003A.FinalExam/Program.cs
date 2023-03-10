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
            Applicant.BirthYear = Convert.ToInt32(Inputty("birthyear"));

            Console.WriteLine("\nWhat is your gender?");
            Console.Write("Please type F (female), M (male), N (nonbinary), G (genderfluid), O  (other): ");
            Applicant.Gender = Convert.ToChar(Inputty("gender"));

            Console.Write("\nWhat is your mailing address: ");
            Applicant.MailingAddress = Inputty("default");

            Console.Write("\nWhat is your City: ");
            Applicant.City = Inputty("default");

            Console.WriteLine("\nWhat is your state: ");
            Console.Write("Please input a two letter abbreviation: ");
            Applicant.State = Inputty("state");


            Console.Write("\nWhat is your email address: ");
            Applicant.EmailAddress = Inputty("email");

            Console.Write("\nWhat is your phone number: ");
            Applicant.PhoneNumber = Inputty("phone");








        }


        ///<summary>
        ///Method to handle input and input validation
        ///</summary>
        ///<param name="type">Type of input (email, name, phone, gender, birthyear, state, or else for other)</param>
        ///<returns>Validated string input</returns>
        static string Inputty(string type)
        {
            string realVar = null;
            int i = 0;
            string tempVar = null;
            


            while (i == 0)
            {
                int z = 0;
                //switch statement to handle data validation   
                tempVar = Console.ReadLine();        
                switch(type)
                {
                    case "email":
                        string badChars = @"\|!#$%&/()=?*+»«£§€{};'<>_,";
                        foreach(var item in badChars) // tests if the inputted string has any of the bad characters
                        {
                            if ((tempVar.Contains(item)) || !ConvertTest(tempVar, "string"))
                            {
                                z++;
                            }
                            
                        }
                        break;


                    case "name":
                        badChars = @"1234567890\|!#$%&/().=?*+»«@£§€{}-;'<>_,";
                        foreach (var item in badChars)
                        {
                            if ((tempVar.Contains(item)))
                            {
                                z++;
                            }                           
                        }
                        if(!ConvertTest(tempVar, "string"))
                        {
                            z++;
                        }
                        break;


                    case "phone":
                       // tempVar = Console.ReadLine();
                        badChars = @"abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRUTUVWXYZ\|!#$%&/.=?+»«@£§€{};'<>_,";
                        foreach (var item in badChars)
                        {
                            if ((tempVar.Contains(item)))
                            {
                                z++;
                            }

                        }
                        break;

                    case "state":
                        int position = 0;
                        List<string> stateAb = new List<string> {"DNE123", "AI", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "FL", "GA", "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ", "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI", "WY", "DC", "GU", "MH", "MP", "PR", "VI"};
                        position = stateAb.IndexOf(tempVar);
                        if(position > 0)
                        {
                            realVar = stateAb[position];
                        }
                        else
                        {
                            z++;
                        }

                        break;

                    case "birthyear":
                        if(!ConvertTest(tempVar, "int"))
                        {
                            z++;
                        }
                        else //in else so things don't mess up if input is bad
                        {
                            if(Convert.ToInt32(tempVar) <= 1900){ z++;}
                        }
                        break;

                    case "gender":
                        badChars = @"abcdefghijklmnopqrstuvwxyzABCDEHIJKLPQRSTUVWXYZ1234567890\|!#$%&/().=?*+»«@£§€{}-;'<>_,";
                        if(!ConvertTest(tempVar,"char"))
                        {
                            z++;
                        }
                        foreach(var item in badChars)
                        {
                            if(tempVar.Contains(item))
                            {
                                z++;
                            }
                        }
                        break;


                    default:
                      //  tempVar = Console.ReadLine();
                        badChars = @"\|$%&/()@=*+»«£§€{};'<>";
                        foreach (var item in badChars)
                        {
                            if ((tempVar.Contains(item)) || !ConvertTest(tempVar, "string"))
                            {
                                z++;
                            }
                           
                        }
                        break;
                
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

            return realVar;

        }




        ///<summary>
        ///Tests if converting string (typically user input) is okay
        ///Dual purpose - prevents null
        ///</summary>
        ///<param name="intake">String input to test against</param>
        ///<param name="type">String input for type (int, char; string to check against null)</param>
        ///<returns>Boolean: True (can convert) False (cannot convert)</returns>
        static bool ConvertTest(string intake, string type)
        {
            bool end = true;
            try
            {
                switch (type)
                {
                    case "int":
                    Convert.ToInt32(intake);
                    break;

                    case "char":
                    Convert.ToChar(intake);
                    break;

                    case "string":
                    if(intake == null) {end = false;}
                    break;
                }

            }
            catch (System.FormatException)
            {
                end = false;
            }

            return end;
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


        
    }
}