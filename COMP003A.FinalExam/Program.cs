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
            if((DateTime.Now.Year - Applicant.BirthYear) < 18)
            {
                Console.WriteLine($"Thank you for considering Suprious CO, but minors cannot serve as volunteers,\nPlease try again in {DateTime.Now.Year + (18-(DateTime.Now.Year - Applicant.BirthYear))} when you are a legal adult.\n");
                System.Environment.Exit(0);
            }

            Console.WriteLine("\nWhat is your gender?");
            Console.Write("Please type F (female), M (male), N (nonbinary), G (genderfluid), O  (other): ");
            Applicant.Gender = Inputty("gender");

            Console.Write("\nWhat is your mailing address: ");
            Applicant.MailingAddress = Inputty("default");

            Console.Write("\nWhat is your City: ");
            Applicant.City = Inputty("default");

            Console.WriteLine("\nWhat is your state: ");
            Console.Write("Please input a two letter abbreviation: ");
            Applicant.State = Inputty("state");

            Console.Write("\nWhat is your Postal Code: ");
            Applicant.Postal = Inputty("phone"); //data validation already exists in phone


            Console.Write("\nWhat is your email address: ");
            Applicant.EmailAddress = Inputty("email");

            Console.Write("\nWhat is your phone number: ");
            Applicant.PhoneNumber = Inputty("phone");


            /**********************************************************************************************************/
            //Applicant questions section
            String[] questions = 
            {
                "Question #1: Why do you want to volunteer with Suprious Co.?",
                "Question #2: Which department do you intend to volunteer with?",
                "Question #3: What is your availability?",
                "Question #4: What kind of skills do you have?",
                "Question #5: Are you comfortable working with animals? Which ones?",
                "Question #6: How often do you volunteer?",
                "Question #7: What are your responsibilities when volunteering?",
                "Question #8: Do you have a valid driver's license and a clean driving record?",
                "Question #9: Would you be willing to participate in a vanpool?",
                "Question #10: By proceeding with this application, you consent to a background check. Is there anything we should know?"
            };
            Console.WriteLine("\n\nApplication Questions:\n-------------------------");
            
            List<string> answers = AnsInput(questions);
            

            /**********************************************************************************************************/
            //Review section
            Logo(false);
            Console.WriteLine("Thank you for submitting your application. Here's a summary of your Personal Information:\n");
            Applicant.PrintInfo();
            Console.WriteLine("\n\nHere's a summary of your application questions:");
            QATraverse(questions, answers);



            




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

                    case "state": //checks inputted state against list of states
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

                    case "birthyear": //checks if birthyear exists 
                        if(!ConvertTest(tempVar, "int"))
                        {
                            z++;
                        }
                        else //in else so things don't mess up if input is bad; checks if year is before 1900 or after current year
                        {
                            if(Convert.ToInt32(tempVar) <= 1900 || Convert.ToInt32(tempVar) > (DateTime.Now.Year)) { z++;} 
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
                        switch (tempVar)
                        {
                            case "F":
                                tempVar = "Female";
                                break;

                            case "M":
                                tempVar = "Male";
                                break;

                            case "N":
                                tempVar = "Nonbinary";
                                break;

                            case "G":
                                tempVar = "Genderfluid";
                                break;

                            case "O":
                                tempVar = "Other";
                                break;

                            default:
                                z++;
                                break;
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
                Console.WriteLine("\nAPPLICATION SUMMARY\n");
            }

            Console.WriteLine("".PadRight(25, '*'));
        }

        

        ///<summary>
        ///Method for putting in answers since the foreach loop in main ends the program for some reason
        ///</summary>
        ///<param name = "questions">String array of questions</param>
        ///<returns>Answer list output</returns>
        static List<string> AnsInput(string[] questions)
        {
            List<string> answers = new List<string>();
            foreach(var q in questions)
            {
                Console.WriteLine("\n"+q);
                Console.Write("Your answer: ");
                answers.Add(Inputty("default"));
            }

            return answers;
        }

        ///<summary>
        ///Prints questions and answers
        ///</summary>
        ///<param name="quesitons">Array input for questions</param>
        ///<param name="answers">List input for answers array</param>
        static void QATraverse(string[] questions, List<string> answers)
        {
            for(int i = 0; i < questions.Length;i++)
            {
                Console.WriteLine($"\n{questions[i]}\nYour answer: {answers[i]}");
            }
        }
        
    }
}