
// Heading of Application
Console.WriteLine("Press Enter to Launch Application.");
var start = Console.ReadLine();
int menuOption = 0;


while (start != "4")
{
    Console.Clear();
    // When option is selected
    try
    {
        Console.WriteLine();
        Console.WriteLine("Welcome to Class Management Application");
        Console.WriteLine();
        Console.WriteLine("********** Menu **********");
        Console.WriteLine();
        Console.WriteLine("1 - Create class");
        Console.WriteLine("2 - Exit App");
        Console.WriteLine();
        Console.Write("Insert number of operation: ");

        menuOption = Convert.ToInt32(Console.ReadLine());
   
        switch (menuOption)
        {
            case 1:
                Console.Clear();
                Console.WriteLine("********** Create Class **********");
                Console.WriteLine();
                Console.WriteLine("1 - Add 5 New Students to your class");
                Console.WriteLine("2 - Exit App");
                Console.Write("Insert number of operation: ");
                int createClassNext = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                switch (createClassNext)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("*************** Add 5 New Students ***************");
                        int student = 1;
                        for (int i = student; i <= 5; i++)
                        {
                            Console.WriteLine("New Student " + i);
                            Console.WriteLine();
                            Console.Write("First-Name: ");
                            string FirstName = Console.ReadLine();
                            Console.Write("Last-Name: ");
                            string LastName = Console.ReadLine();
                            Console.Write("Grade (in %): ");
                            int Grade = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();
                            Console.WriteLine("****************************************************************");
                            Console.WriteLine();
                        }
                        Console.WriteLine("You have SUCCESSFULLY added 5 New Students!!!");
                        Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine("What would you like to do next?");
                        Console.WriteLine("1 - View Class");
                        Console.WriteLine("2 - Exit");
                        int next = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        switch (next)
                        {
                            case 1:
                                Console.WriteLine("Feature not available yet!!!");
                                break;
                            case 2:
                                Console.WriteLine("Thank you for using the Class Management Application");
                                break;
                        }
                        break;

                    case 2:
                        Console.WriteLine("Thank you for using the Class Management Application");
                        break;
                    default:
                        Console.WriteLine("Invalid Option... please choose value from the menu.");
                        Console.ReadLine();
                        continue;
                }
                break;
            case 2:
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Thank you for using the Class Management Application");
                break;
            default:
                Console.WriteLine("Invalid Option... please choose value from the menu.");
                Console.ReadLine();
                continue;
        }
        break;
    }
    catch (Exception)
    {
        Console.WriteLine();
        Console.WriteLine("Invalid Option.... Press enter to return to menu.");
        Console.ReadLine();
    }
}





