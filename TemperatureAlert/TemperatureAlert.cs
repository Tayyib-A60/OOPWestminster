using System;
namespace TemperatureAlert
{
    public static class TemperatureAlert
    {
        public static void Do()
        {
            // a. Output invalid measurement when temp < 0 or > 100
            // b. i.    Allow multiple temperature values
            //    ii.   Keep track of Number of Critical, Warning, and Invalid measurements
            //    iii.  Terminate the loop after 3 invalid measurements and print the sensor is broken message
            //    iv.   Print a report

            int noOfCritical = 0;
            int noOfWarning = 0;
            int noOfInvalid = 0; // When == 3, terminate

            while (noOfInvalid < 3)
            {
                int temperature;

                Console.WriteLine("Insert measurement:");

                temperature = Convert.ToInt32(Console.ReadLine()); // This is still wrong

                if (temperature < 0 || temperature > 100)
                {
                    noOfInvalid++;
                    Console.WriteLine("Invalid measurement \n");
                }
                else
                {
                    switch (temperature)
                    {
                        case > 30:
                            noOfCritical++;
                            Console.WriteLine("Critical \n");
                            break;
                        case > 24:
                            noOfWarning++;
                            Console.WriteLine("Warning \n");
                            break;
                        default:
                            Console.WriteLine("Normal \n");
                            break;
                    }
                    //if (temperature > 30)
                    //{
                    //    noOfCritical++;
                    //    Console.WriteLine("Critical \n");
                    //}
                    //else if (temperature > 24)
                    //{
                    //    noOfWarning++;
                    //    Console.WriteLine("Warning \n");
                    //}
                    //else
                    //{
                    //    Console.WriteLine("Normal \n");
                    //}
                }
            }

            if (noOfInvalid == 3)
            {
                Console.WriteLine("The sensor is broken \n");
                Console.WriteLine($"No of Critical: {noOfCritical} \n No of Warning: {noOfWarning} \n No of Invalid: {noOfInvalid}");
            }
        }
    }
}
