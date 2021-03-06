﻿/*Matt Clark
 * Program 3 Due: January 30, 2018
 * None
 * This will program will calculate information about a Gronala Bar sale including total made, total profits, percentage to give away and amounts sold.
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MClark_Prog2
{
    class GranolaSales2
    {
        static void Main(string[] args)
        {
            const double GOV_PERCENT = 0.1275;
            decimal costPerCase = 110m;
            decimal costPerBar = 1.50m;
            int numBarsPerCase = 100;


            Greeting();
            int casesSold = GetCases();
            int totBars = BarsSold(casesSold, numBarsPerCase);
            decimal totCost = TotalCost(casesSold, costPerCase);
            decimal grossIncome = GrossIncome(costPerBar, totBars);
            decimal netIncome = NetIncome(grossIncome, totCost);
            decimal govCut = DonateAmount(netIncome, GOV_PERCENT);
            decimal finalProfit = FinalProfit(netIncome, govCut);
            WriteLine("Number of cases of granola sold: {0, 37:F0}", casesSold);
            WriteLine("Cost per case: {0, 55:C}", costPerCase);
            WriteLine("Total cost incurred: {0, 49:C}", totCost);
            WriteLine("Number of bars in each case: {0, 41:F0}", numBarsPerCase);
            WriteLine("Total number of bars were sold: {0, 38:F0}", totBars);
            WriteLine("Cost per bar: {0, 56:C}", costPerBar);
            WriteLine("Gross income:{0, 57:C}", grossIncome);
            WriteLine("Net income <Gross income - Total cost incurred>:{0, 22:C}", netIncome);
            WriteLine("Percent to be given to student government: {0, 27:P}", GOV_PERCENT);
            WriteLine("Amount of net income to be given to student government: {0, 14:C}", govCut);
            WriteLine();
            WriteLine("Final Profit for the Nerd Squad: {0, 37:C}", finalProfit);

        }

        public static void Greeting()
        {
            WriteLine("Welcome to the IWCC Nerd Squad Granola Sales Project Final Report");
            WriteLine();
        }

        public static int GetCases()
        {
            Write("Enter the number of cases sold:  ");
            int cases = int.Parse(ReadLine());
            WriteLine();
            return cases;
        }

        public static int BarsSold(int cSold, int barPerCase)
        {
            int allBars = cSold * barPerCase;
            return allBars;
        }

        public static decimal TotalCost(int cSold, decimal costCase)
        {
            decimal totIncome = cSold * costCase;
            return totIncome;
        }

        public static decimal GrossIncome(decimal barCost, int cSold)
        {
            decimal gIncome = barCost * cSold;
            return gIncome;
        }

        public static decimal NetIncome(decimal gIncome, decimal cost)
        {
            decimal income = gIncome - cost;
            return income;
        }

        public static decimal DonateAmount(decimal income, double percent)
        {
            decimal donate = income * (decimal)percent;
            return donate;
        }

        public static decimal FinalProfit(decimal income, decimal cut)
        {
            decimal profit = income - cut;
            return profit;
        }
    }
}
