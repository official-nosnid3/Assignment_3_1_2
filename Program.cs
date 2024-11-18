namespace Assignment_3_1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Assignment 3.1.2
             * If year is leap
             * Given a year as integer, write a method that checks if year is leap.
             * Expected input and output
             * IfYearIsLeap(2016) → true IfYearIsLeap(2018) → false
             * 
             * Use nested if statements in one example
             * Use a logical AND OR formula for another example
             */

            while (true)
            {
                try
                {
                    Console.Clear();

                    Console.WriteLine("Is this year a leap year?\n\nEnter a year: ");
                    int entry = Convert.ToInt32(Console.ReadLine());

                    if (IfYearIsLeap(entry))
                        Console.WriteLine($"\n{entry} is a leap year");
                    else Console.WriteLine($"\n{entry} is not a leap year");

                    Console.WriteLine("\nPress the enter key to try another year");
                    Console.ReadLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }

        static bool IfYearIsLeap(int year)
        {
            /*
             * A year is a leap year if it is divisible by 4.
             * However, if the year is also divisible by 100, it is not a leap year.
             * Unless the year is also divisible by 400, in which case it is a leap year.
            */
            
            //bool result = false;

            //if (year % 4 == 0)
            //{
            //    result = true;
            //    if (year % 100 == 0)
            //    {
            //        result = false;
            //        if (year % 400 == 0)
            //            result = true;
            //    }
            //}

            //return result;

            if ( (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0) )
                return true;
            return false;
        }
    }
}
