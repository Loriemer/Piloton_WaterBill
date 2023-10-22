using System;

namespace Piloton_WaterBill
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the previous bill: ");
            double previousbill = double.Parse(Console.ReadLine());

            Console.Write("Enter the current bill: ");
            double currentbill = double.Parse(Console.ReadLine());

            double gallonsUsed = currentbill - previousbill;
            double totalCharge;

            if ((gallonsUsed / 1000.0) * 7 < 16.67)
            {
                totalCharge = 16.67;
            }
            else
            {
                totalCharge = (gallonsUsed / 1000.0) * 7;
            }
            Console.WriteLine("Number of gallons used: " + gallonsUsed);
            Console.WriteLine("Total charge for meter: " + totalCharge.ToString("F2") + "pesos");
        }
    }
}