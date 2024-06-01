// Launch Basketball Team Management 
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Press enter to Launch Basketball Team Management...");
        string launch = Console.ReadLine();

        //Variables

        string teamName;
        int jerseyNum;


        string pFirstName1, pFirstName2, pFirstName3, pFirstName4, pFirstName5, pFirstName6, pFirstName7, pFirstName8, pFirstName9, pFirstName10, pFirstName11, pFirstName12;
        string pLastName1, pLastName2, pLastName3, pLastName4, pLastName5, pLastName6, pLastName7, pLastName8, pLastName9, pLastName10, pLastName11, pLastName12;
        int pAge1, pAge2, pAge3, pAge4, pAge5, pAge6, pAge7, pAge8, pAge9, pAge10, pAge11, pAge12;
        string pPostion1, pPostion2, pPostion3, pPostion4, pPostion5, pPostion6, pPostion7, pPostion8, pPostion9, pPostion10, pPostion11, pPostion12;
        int pHeight1, pHeight2, pHeight3, pHeight4, pHeight5, pHeight6, pHeight7, pHeight8, pHeight9, pHeight10, pHeight11, pHeight12; // in feet (e.g. ###cm)



        while (launch is not "-1")
        {
            try
            {
                Console.Clear();
                // Welcome
                Console.WriteLine();
                Console.WriteLine("*************** - Basketball Team Management - ***************");
                Console.WriteLine();
                Console.WriteLine("This program is used to manage a basketball team, allowing the user to add players to a team and display the team roster.");
                Console.WriteLine();

                // Create a Team
                Console.Write("Please Enter Team Name: ");
                teamName = Console.ReadLine();

                // ADD Players to Team
                Console.Clear();
                Player1();
                Console.Clear();
                Player2();
                Console.Clear();
                Player3();
                Console.Clear();
                Player4();
                Console.Clear();
                Player5();

                Console.WriteLine();
                Console.WriteLine("Press Enter to Contine");
                string next1 = Console.ReadLine();

                while (string.IsNullOrEmpty(next1))
                {
                    Console.Clear();
                    Console.WriteLine($"******************** - {teamName} Roster - ********************");
                    Console.WriteLine();

                    TeamRoster();

                    Console.WriteLine();
                    Console.WriteLine("Insert the player Number to view more.");
                    Console.WriteLine("Insert -1 to exit");
                    double next = Convert.ToDouble(Console.ReadLine());
                    Console.Clear();
                    if (next.Equals(-1))
                    {
                        break;
                    }
                    switch (next)
                    {
                        case 1:
                            Player1Info();
                            Console.WriteLine("Press enter to continue...");
                            Console.ReadLine();
                            break;
                        case 2:
                            Player2Info();
                            Console.WriteLine("Press enter to continue...");
                            Console.ReadLine();
                            break;
                        case 3:
                            Player3Info();
                            Console.WriteLine("Press enter to continue...");
                            Console.ReadLine();
                            break;
                        case 4:
                            Player4Info();
                            Console.WriteLine("Press enter to continue...");
                            Console.ReadLine();
                            break;
                        case 5:
                            Player5Info();
                            Console.WriteLine("Press enter to continue...");
                            Console.ReadLine();
                            break;
                        default:
                            Console.WriteLine("Player Number doesnt exist...");
                            Console.WriteLine("Press enter to continue...");
                            break;
                    }
                }break;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Press Enter to try again...");
                Console.ReadLine();
            }
        }

        Console.WriteLine();
        Console.WriteLine("Thank You for using the Application...");
        Console.WriteLine();

        // Methods
        void Player1()
        {
            Console.WriteLine($"*************** - {teamName} Basketball Club - ***************");
            Console.WriteLine();

            Console.WriteLine("Jersey Number: 1 "); // player number 1

            Console.Write("First-Name: ");
            pFirstName1 = Console.ReadLine();

            Console.Write("Last-Name: ");
            pLastName1 = Console.ReadLine();

            Console.Write("Age: ");
            pAge1 = Convert.ToInt16(Console.ReadLine());

            Console.Write("Position: ");
            pPostion1 = Console.ReadLine();

            Console.Write("height: ");
            pHeight1 = Convert.ToInt16(Console.ReadLine());
        }
        void Player1Info()
        {
            Console.WriteLine();
            Console.WriteLine($"Full Name: {pFirstName1} {pLastName1}");
            Console.WriteLine($"Postion: {pPostion1}");
            Console.WriteLine($"Age: {pAge1}");
            Console.WriteLine($"Height: {pHeight1}");
        }

        void Player2()
        {
            Console.WriteLine($"*************** - {teamName} Basketball Club - ***************");
            Console.WriteLine();

            Console.WriteLine("Jersey Number: 2 "); // player number 2

            Console.Write("First-Name: ");
            pFirstName2 = Console.ReadLine();

            Console.Write("Last-Name: ");
            pLastName2 = Console.ReadLine();

            Console.Write("Age: ");
            pAge2 = Convert.ToInt16(Console.ReadLine());

            Console.Write("Position: ");
            pPostion2 = Console.ReadLine();

            Console.Write("height: ");
            pHeight2 = Convert.ToInt16(Console.ReadLine());
        }
        void Player2Info()
        {
            Console.WriteLine($"Full Name: {pFirstName2} {pLastName2}");
            Console.WriteLine($"Postion: {pPostion2}");
            Console.WriteLine($"Age: {pAge2}");
            Console.WriteLine($"Height: {pHeight2}");
        }

        void Player3()
        {
            Console.WriteLine($"*************** - {teamName} Basketball Club - ***************");
            Console.WriteLine();

            Console.WriteLine("Jersey Number: 3 "); // player number 3

            Console.Write("First-Name: ");
            pFirstName3 = Console.ReadLine();

            Console.Write("Last-Name: ");
            pLastName3 = Console.ReadLine();

            Console.Write("Age: ");
            pAge3 = Convert.ToInt16(Console.ReadLine());

            Console.Write("Position: ");
            pPostion3 = Console.ReadLine();

            Console.Write("height: ");
            pHeight3 = Convert.ToInt16(Console.ReadLine());
        }
        void Player3Info()
        {
            Console.WriteLine($"Full Name: {pFirstName3} {pLastName3}");
            Console.WriteLine($"Postion: {pPostion3}");
            Console.WriteLine($"Age: {pAge3}");
            Console.WriteLine($"Height: {pHeight3}");
        }

        void Player4()
        {
            Console.WriteLine($"*************** - {teamName} Basketball Club - ***************");
            Console.WriteLine();

            Console.WriteLine("Jersey Number: 4 "); // player number 4

            Console.Write("First-Name: ");
            pFirstName4 = Console.ReadLine();

            Console.Write("Last-Name: ");
            pLastName4 = Console.ReadLine();

            Console.Write("Age: ");
            pAge4 = Convert.ToInt16(Console.ReadLine());

            Console.Write("Position: ");
            pPostion4 = Console.ReadLine();

            Console.Write("height: ");
            pHeight4 = Convert.ToInt16(Console.ReadLine());
        }
        void Player4Info()
        {
            Console.WriteLine($"Full Name: {pFirstName4} {pLastName4}");
            Console.WriteLine($"Postion: {pPostion4}");
            Console.WriteLine($"Age: {pAge4}");
            Console.WriteLine($"Height: {pHeight4}");
        }

        void Player5()
        {
            Console.WriteLine($"*************** - {teamName} Basketball Club - ***************");
            Console.WriteLine();

            Console.WriteLine("Jersey Number: 5 "); // player number 5

            Console.Write("First-Name: ");
            pFirstName5 = Console.ReadLine();

            Console.Write("Last-Name: ");
            pLastName5 = Console.ReadLine();

            Console.Write("Age: ");
            pAge5 = Convert.ToInt16(Console.ReadLine());

            Console.Write("Position: ");
            pPostion5 = Console.ReadLine();

            Console.Write("height: ");
            pHeight5 = Convert.ToInt16(Console.ReadLine());
        }
        void Player5Info()
        {
            Console.WriteLine($"Full Name: {pFirstName5} {pLastName5}");
            Console.WriteLine($"Postion: {pPostion5}");
            Console.WriteLine($"Age: {pAge5}");
            Console.WriteLine($"Height: {pHeight5}");
        }

        void TeamRoster()
        {
            Console.WriteLine($" 1.  {pFirstName1.Substring(0, 1)}.{pLastName1}");
            Console.WriteLine($" 2.  {pFirstName2.Substring(0,1)}.{pLastName2}");
            Console.WriteLine($" 3.  {pFirstName3.Substring(0, 1)}.{pLastName3}");
            Console.WriteLine($" 4.  {pFirstName4.Substring(0, 1)}.{pLastName4}");
            Console.WriteLine($" 5.  {pFirstName5.Substring(0, 1)}.{pLastName5}");
        }
    }
}