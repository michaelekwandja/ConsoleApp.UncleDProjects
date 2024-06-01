
// Launch App
using System;
using System.Globalization;
using System.Net.Cache;

Console.WriteLine();
Console.WriteLine("********** - Welcome to the Insurance Rating Engine - **********");
Console.WriteLine("---- Press Enter to launch Application ----");
string launchApp = Console.ReadLine();
Console.WriteLine();

double id;
string firstName;
string lastName;
int age;
char gender;
string genderFull = "Null"; 
int userInsuranceCover;
string back;
var today = DateOnly.FromDateTime(DateTime.Now);
// health insurance conditions
char iSmoke;
char iWorkOut;
char iHaveHIV;
char iHaveCancer;
double healthInsuranceprice = 500; //per month
                                   // Car insurance conditions
double carRegistrationNum;
string carCompany;
string carModel;
char carUse;
string carUseFull = "Null";
double carInsurancePrice = 4000; // per month 

double lifeInsurancePrice = 200; // per month , for a cover of 1 mil
double finalPrice = 0;


// Program 
while (string.IsNullOrEmpty(launchApp))
{
    Console.Clear();
    Console.WriteLine();
    Console.WriteLine("********** - INSURANCE RATING ENGINE - **********");
    Console.WriteLine();
    Console.WriteLine("Welcome to the Insurance Rating program. Please answer the following quetions:");
    Console.WriteLine();
    try
    {
        Console.Write("ID Number: ");
        id = Convert.ToDouble(Console.ReadLine());

        Console.Write("First-Name: ");
        firstName = Console.ReadLine();

        Console.Write("Last-Name: ");
        lastName = Console.ReadLine();

        Console.Write("Age: ");
        age = Convert.ToInt32(Console.ReadLine());

        if (age < 18 || age > 100)
        {
            Console.WriteLine();
            Console.WriteLine($"{firstName}, you are under the legal age for Insurance");
            Console.WriteLine("Thank you for Using our App");
            break;
        }

        Console.Write("Gender (M / F): ");
        gender = Convert.ToChar(Console.ReadLine());

        if (gender.Equals('M'))
        {
            genderFull = "Male";
        }
        else if (gender.Equals('F'))
        {
            genderFull = "Female";
        }
        Console.WriteLine();

        Console.WriteLine("Press Enter to Continue.");
        Console.ReadLine();
        try
        {
            // Insurance Menu
            Console.Clear();
            Console.WriteLine($"{firstName}, which Insurance would you like to cover with us?");
            Console.WriteLine("1. Health Insurance");
            Console.WriteLine("2. Car Insurance");
            Console.WriteLine("3. Life Insurance");
            Console.WriteLine("4. Exit");
            Console.Write("Enter the number of the Insurance policy you would like to cover: ");
            userInsuranceCover = Convert.ToInt32(Console.ReadLine());
        }
        catch (Exception ex) 
        {
            Console.WriteLine();
            Console.WriteLine(ex.Message);
            Console.WriteLine("Press enter to try again.");
            Console.ReadLine();
            // Insurance Menu
            Console.Clear();
            Console.WriteLine($"{firstName}, which Insurance would you like to cover with us?");
            Console.WriteLine("1. Health Insurance");
            Console.WriteLine("2. Car Insurance");
            Console.WriteLine("3. Life Insurance");
            Console.WriteLine("4. Exit");
            Console.Write("Enter the number of the Insurance policy you would like to cover: ");
            userInsuranceCover = Convert.ToInt32(Console.ReadLine());
        }

        Console.Clear();
        switch (userInsuranceCover)
        {
            case 1: // Health Insurance 

                Console.WriteLine("Health Insurance premium Calculator.");
                Console.WriteLine("Press ENTER to continue OR -1 EXIT");
                back = Console.ReadLine();

                if (back is "-1")
                {
                    break;
                }

                Console.WriteLine();
                Console.WriteLine($"{firstName}, Please answer the following question (Y / N):");
                Console.WriteLine();
                Console.Write("Do you smoke? ");
                iSmoke = Convert.ToChar(Console.ReadLine());
                Console.Write("Do you Workout/ play sport? ");
                iWorkOut = Convert.ToChar(Console.ReadLine());
                Console.Write("Do you have HIV? ");
                iHaveHIV = Convert.ToChar(Console.ReadLine());
                Console.Write("Do you have Cancer? ");
                iHaveCancer = Convert.ToChar(Console.ReadLine());

                // Conditions

                if (age >= 18 && age <= 25)
                {
                    finalPrice = healthInsuranceprice;
                }
                else if (age >= 26 && age <= 45)
                {
                    finalPrice = healthInsuranceprice + 500;
                }
                else if (age >= 46 && age <= 55)
                {
                    finalPrice = healthInsuranceprice + 1000;
                }
                else if (age >= 56)
                {
                    finalPrice = healthInsuranceprice + 1500;
                }
                // If you smoke multiply by 20%
                if (iSmoke is 'Y')
                {
                    finalPrice = healthInsuranceprice + 400;
                }
                // if you Workout multiply by 10%
                if (iWorkOut is 'Y')
                {
                    finalPrice = healthInsuranceprice + 100;
                }
                // if you have HIV multiply by 20%
                if (iHaveHIV is 'Y')
                {
                    finalPrice = healthInsuranceprice + 300;
                }
                // if you have Cancer multiply by 20%
                if (iHaveCancer is 'Y')
                {
                    finalPrice = healthInsuranceprice + 300;
                }

                Console.WriteLine();
                Console.WriteLine($"Press Enter to get Quotation for {firstName} {lastName}'s Insurance premium");

                Console.Clear();
                Console.WriteLine();
                Console.WriteLine($"********** - Health Insurance premium Quatation - **********");
                Console.WriteLine($"{today}");
                Console.WriteLine();
                Console.WriteLine($"ID: {id}");
                Console.WriteLine($"Full Name: {firstName.ToUpper()} {lastName.ToUpper()}");
                Console.WriteLine($"Age: {age}");
                Console.WriteLine($"Gender: {genderFull.ToUpper()}");
                Console.WriteLine($"Do you smoke? {iSmoke}");
                Console.WriteLine($"Do you Workout/ play sport? {iWorkOut}");
                Console.WriteLine($"Do you have HIV? {iHaveHIV}");
                Console.WriteLine($"Do you have Cancer? {iHaveCancer}");
                Console.WriteLine();
                Console.WriteLine($"Your Health Insurance Premium is R {finalPrice} pm");
                Console.WriteLine();
                Console.WriteLine("****************************************************************");
                Console.ReadLine();
                break;
            case 2: // Car Insurance 

                Console.WriteLine("Health Insurance premium Calculator.");
                Console.WriteLine("Press ENTER OR -1 EXIT");
                back = Console.ReadLine();

                if (back is "-1")
                {
                    break;
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine($"{firstName.ToUpper()} {lastName.ToUpper()}, Please answer the following question ((-1) to go back):");
                Console.WriteLine();
                Console.Write("Car Registration Number (6-digits long):");
                carRegistrationNum = Convert.ToDouble(Console.ReadLine());
                Console.Write("Name of Car: ");
                carCompany = Console.ReadLine();
                Console.Write("Car Model: ");
                carModel = Console.ReadLine();
                Console.Write("Car was bought: ");
                DateOnly yearCarWasBought = DateOnly.ParseExact(Console.ReadLine(), "yyyy", new CultureInfo("en-CA"));
                Console.Write("Is your car Used for Business or Personal? (B/P):");
                carUse = Convert.ToChar(Console.ReadLine());
                if (carUse is 'B')
                {
                    carUseFull = "Business";
                }
                else if (carUse is 'P')
                {
                    carUseFull = "Personal";
                }

                // Conditions
                if (age >= 18 || age <= 25)
                {
                    finalPrice = carInsurancePrice + 1500;
                }
                else if (age >= 26 || age <= 55)
                {
                    finalPrice = carInsurancePrice;
                }
                else if (age >= 56)
                {
                    finalPrice = carInsurancePrice - 500;
                }
                if (carUse is 'B')
                {
                    finalPrice = carInsurancePrice + 1500;
                }

                Console.WriteLine();
                Console.WriteLine($"Press Enter to get Quotation for {firstName.ToUpper()} {lastName.ToUpper()}'s Insurance premium");

                Console.Clear();
                Console.WriteLine();
                Console.WriteLine($"********** - Car Insurance premium Quatation - **********");
                Console.WriteLine();
                Console.WriteLine($"ID: {id}");
                Console.WriteLine($"Full Name: {firstName.ToUpper()} {lastName.ToUpper()}");
                Console.WriteLine($"Age: {age}");
                Console.WriteLine($"Gender: {genderFull.ToUpper()}");
                Console.WriteLine($"Car Registration Number: {carRegistrationNum}");
                Console.WriteLine($"Car Name: {carCompany}");
                Console.WriteLine($"Car Model: {carModel}");
                Console.WriteLine($"Year car was bought: {yearCarWasBought}");
                Console.WriteLine($"Car is Used for: {carUseFull}");
                Console.WriteLine();
                Console.WriteLine($"Your Car Insurance Premium is R {finalPrice} pm");
                Console.WriteLine();
                Console.WriteLine("****************************************************************");
                Console.ReadLine();
                break;
            case 3: // LIfe Insurance 

                // Conditions

                if (age <= 30)
                {
                    finalPrice = lifeInsurancePrice + 500;
                }
                else if (age >= 26 || age <= 55)
                {
                    finalPrice = lifeInsurancePrice;
                }
                else if (age >= 56)
                {
                    finalPrice = lifeInsurancePrice - 500;
                }

                Console.WriteLine();
                Console.WriteLine($"Press Enter to get Quotation for {firstName.ToUpper()} {lastName.ToUpper()}'s Insurance premium");

                Console.Clear();
                Console.WriteLine();
                Console.WriteLine($"********** - Life Insurance premium Quatation - **********");
                Console.WriteLine();
                Console.WriteLine($"ID: {id}");
                Console.WriteLine($"Full Name: {firstName.ToUpper()} {lastName.ToUpper()}");
                Console.WriteLine($"Age: {age}");
                Console.WriteLine($"Gender: {genderFull.ToUpper()}");
                Console.WriteLine();
                Console.WriteLine($"Your Car Insurance Premium is R {finalPrice} pm");
                Console.WriteLine();
                Console.WriteLine("****************************************************************");
                Console.ReadLine();
                break;
            case 4:
                break;
            default:
                Console.WriteLine();
                Console.WriteLine("You selected an Invalid option!");
                Console.WriteLine("Press Enter to Try again.");
                Console.ReadLine();

                // Insurance Menu
                Console.WriteLine($"{firstName.ToUpper()} {lastName.ToUpper()}, which Insurance would you like to cover with us?");
                Console.WriteLine("1. Health Insurance");
                Console.WriteLine("2. Car Insurance");
                Console.WriteLine("3. Life Insurance");
                Console.WriteLine("4. Exit");
                Console.Write("Enter the number of the Insurance policy you would like to cover: ");
                userInsuranceCover = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                break;
        }
        break;
    }

    catch (Exception ex)
    {
        Console.WriteLine();
        Console.WriteLine(ex.Message);
        Console.ReadLine();
    }
}

Console.WriteLine();
Console.WriteLine("Thank you for Using our Insurance Rating Engine...:)");
