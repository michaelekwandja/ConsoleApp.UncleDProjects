// Welcome
Console.WriteLine();
Console.WriteLine("******************** Temperature Converter ********************");
Console.WriteLine();
Console.WriteLine("This is a program that converts temperature between Fahrenheit and Celsius. Press 'Enter' to proceed to program");
Console.ReadLine();

int Temperature = 0;

while (Temperature != -1)
{
    try
    {
        // Menu 
        Console.WriteLine();
        Console.WriteLine("Select Convertion option");
        Console.WriteLine("1 - Fahrenheit");
        Console.WriteLine("2 - Celsius");
        Console.WriteLine("0 - Exit");
        Console.Write("Select option: ");
        Temperature = Convert.ToInt32(Console.ReadLine());

        //Conditions
        string TemperatureF = "Fahrenheit";
        string TemperatureC = "Celsius";

        if (!Temperature.Equals(1))
        {
            Console.WriteLine();
            Console.Write(TemperatureF + ": ");
            int TempF = Convert.ToInt32(Console.ReadLine());
            double TempFToC = ((TempF - 32) / 1.8);
            // Convert to Celsius
            Console.WriteLine();
            Console.Write(TemperatureC + " = ");
            Console.WriteLine(Math.Round(TempFToC, 2));
            Console.WriteLine();
            Console.WriteLine("Thank You for Using Temperature Converter by Michael Mosoko");
            Console.ReadLine();
            Console.Clear();
        }
        else if (Temperature == 2)
        {
            Console.WriteLine();
            Console.Write(TemperatureC + ": ");
            int TempF = Convert.ToInt32(Console.ReadLine());
            double TempFToC = ((TempF * 1.8) + 32);
            // Convert to Celsius
            Console.WriteLine();
            Console.Write(TemperatureF + " = ");
            Console.WriteLine(Math.Round(TempFToC, 2));
            Console.WriteLine();
            Console.WriteLine("Thank You for Using Temperature Converter by Michael Mosoko");
            Console.ReadLine();
            Console.Clear();
        }
        else if (Temperature == 0)
        {
            break;
        }
        else
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("***** Invalid Option *****");
            Console.WriteLine(" Press 'Enter' to Try Again");
            Console.ReadLine();
            Console.Clear();

        }


    } catch (Exception)
    {
        Console.WriteLine();
        Console.WriteLine("***** Invalid Option *****");
        Console.WriteLine("Please Enter Numeric values");
        Console.WriteLine(" Press 'Enter' to Try Again");
        Console.ReadLine();
        Console.Clear();

    }

}
Console.Clear();
Console.WriteLine();
Console.WriteLine("Thank You for Using Temperature Converter by Michael Mosoko");
