using System.Diagnostics;
using System.Net;

namespace My_First_C_console_application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task4();
            Task5();
            Task6();
            Task7();
            Task8();
            Task9();
            Task10();   
            Task11();
            Task12();

        }
        static void Task1()
        {
            Console.WriteLine("Task#1: Display the number pi in different ways.\n");
            //
            float pi_num = 3.14f;
            string pi_str = "3.14";
            //
            Console.WriteLine(pi_num);
            Console.WriteLine(pi_str);
            Console.WriteLine("\u03C0 or \uFF30\uFF49, whatever you likes more)");
            Console.WriteLine("\n");

        }
        static void Task2()
        {
            Console.WriteLine("Task#2: Class System.Environment. Write a program to display information about the computer on the console.\n");
            string output = "";
            var proc = new ProcessStartInfo("cmd.exe", "/c systeminfo")
            {
                CreateNoWindow = true,
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                WorkingDirectory = @"C:\Windows\System32\"
            };
            Process p = Process.Start(proc);
            p.OutputDataReceived += (sender, args1) => { output += args1.Data + Environment.NewLine; };
            p.BeginOutputReadLine();
            p.WaitForExit();
            Console.WriteLine(output);
            Console.WriteLine("\n");

        }
        static void Task3()
        {
            Console.WriteLine("Task#3: The distance is given in centimeters. Find the number of complete meters in it.\n");
            //
            Console.WriteLine("Enter measure in cm: ");
            int measure_inp = Convert.ToInt32(Console.ReadLine());
            int measure_meters = measure_inp / 100;
            //
            Console.WriteLine("Full meters: " + measure_meters);
            Console.WriteLine("\n");
        }
        static void Task4()
        {
            Console.WriteLine("Task#4: At some point, 234 days have passed. How many full weeks have passed during this period?\n");
            //
            int days = 234;
            int weeks = days / 7;
            //
            Console.WriteLine("Full weeks: " + weeks);
            Console.WriteLine("\n");
        }
        static void Task5()
        {
            Console.WriteLine("Task#5: Given a rectangle with dimensions 543 x 130 mm. How many squares of side 130 mm can be cut from it?\n");
            //
            int area_total = 543 * 130;
            int area_rect = 130 * 130;
            int rect_count = area_total / area_rect;
            //
            Console.WriteLine("Full squares 130x130 count: " + rect_count);
            Console.WriteLine("\n");
        }
        static void Task6()
        {
            Console.WriteLine("Task#6: Create a program that calculates the arithmetic average of two numbers.\n");
            //
            Console.WriteLine("Enter first num: ");
            int first_num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second num: ");
            int second_num = Convert.ToInt32(Console.ReadLine());
            //
            float average_of_two = (first_num + second_num) / 2.0f;
            //
            Console.WriteLine("Average of two: " + average_of_two);
            Console.WriteLine("\n");
        }
        static void Task7()
        {
            Console.WriteLine("Task#7: Create a program that calculates the square of any given number\n");
            //
            Console.WriteLine("Enter random num: ");
            double num_inp = Convert.ToDouble(Console.ReadLine());
            //
            double squared_num = num_inp * num_inp;
            //
            Console.WriteLine("Squared number: " + squared_num);
            Console.WriteLine("\n");
        }
        static void Task8()
        {
            Console.WriteLine("Task#8: Create a program that prompts the user for two numbers and displays their sum, difference, product, and quotient.\n");
            //
            Console.WriteLine("Enter first num: ");
            int first_num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second num: ");
            int second_num = Convert.ToInt32(Console.ReadLine());
            //
            double sum = first_num + second_num;
            double subt = first_num - second_num;
            double mul = first_num * second_num;
            double div = first_num / second_num;
            //
            Console.WriteLine("Sum is " + sum + "\n");
            Console.WriteLine("Subtraction is " + subt + "\n");
            Console.WriteLine("Multiplying is " + mul + "\n");
            Console.WriteLine("Division is " + div);
            Console.WriteLine("\n");
        }
        static void Task9()
        {
            Console.WriteLine("Task#9: Create a program that asks the user for his or her year of birth and calculates his or her age.\n");
            //
            Console.WriteLine("Enter your born year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            //
            var year_act = DateTime.Today;
            var age = year_act.Year - year;
            //
            Console.WriteLine("You are " + age + " years old.");
            Console.WriteLine("\n");
        }
        static void Task10()
        {
            Console.WriteLine("Task#10: Create a program that asks the user for the length of the sides of a right triangle and then calculates its hypotenuse using the formula c = √(a² + b²).\n");
            //
            Console.WriteLine("Enter first side length: ");
            double first_side = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second side length: ");
            double second_side = Convert.ToInt32(Console.ReadLine());
            //
            double hyp = Math.Sqrt(first_side * first_side + second_side * second_side);
            //
            Console.WriteLine("Hypotenuse is " + hyp);
            Console.WriteLine("\n");
        }
        static void Task11()
        {
            Console.WriteLine("Task#11: Create a program that asks the user for the amount of money in dollars and converts it to euros at the current exchange rate.\n");
            //
            Console.WriteLine("Enter count in dollars: ");
            double dol = Convert.ToDouble(Console.ReadLine());
            //
            WebRequest request = WebRequest.Create("https://www.floatrates.com/widget/00002403/ef9b44086b90031919968504c6b78e9b/usd.json");
            request.Credentials = CredentialCache.DefaultCredentials;
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            string sRateBegin = "\"rate\":";
            string sRateEnd = ",";
            string sRate = responseFromServer.Substring(responseFromServer.IndexOf(sRateBegin) + sRateBegin.Length);
            sRate = sRate.Substring(0, sRate.IndexOf(sRateEnd));
            double currency = Convert.ToDouble(sRate);
            //
            Console.WriteLine("Actuall currency is 1 UDS = " + currency + " EUR\n");
            double eur = dol * currency;
            //
            Console.WriteLine("Your " + dol + " dollars could be converted to " + eur +" euros.\n");
        }
        static void Task12()
        {
            Console.WriteLine("Task#12: Create a program that asks a user for their height in feet and inches, and then converts it to centimetres using the formula 1 foot = 30.48 cm, 1 inch = 2.54 cm..\n");
            //
            Console.WriteLine("Enter you height. Feets first: ");
            double feet = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Inches: ");
            double inches = Convert.ToDouble(Console.ReadLine());
            //
            double cm = feet * 30.48 + inches * 2.54;
            //
            Console.WriteLine("Your height in cm is " + cm);
            Console.WriteLine("\n");
        }
    }
}
