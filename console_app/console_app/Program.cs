using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

using System.Text.RegularExpressions;

using InvestmentLib;



namespace console_app
{

    class Program
    {

        private static String answerToString(InvestmentPlan plan, CultureInfo ci)
        {
            StringBuilder s = new StringBuilder();

            foreach (Tuple<decimal, decimal> x in plan.Plan)
            {
                String tmp = "|"
                    + x.Item1.ToString(ci)
                    + ","
                    + x.Item2.ToString(ci)
                    + "|";
                s.Append(tmp);
            }

            return s.ToString();
        }
        
        static void Main(string[] args)
        {
            
            CultureInfo ci = CultureInfo.CreateSpecificCulture("en-US");

            if (args.Length > 0 && args[0] != "")
            {
                string filename = args[0];//"another_sample.txt";
                                          //args[0];

                Tranche tranche = ReadWriteTools.ReadConditionFromTextFile(filename);

                InvestmentPlan plan = EasySolve.solve(tranche);

                //Console.WriteLine(answerToString(plan, ci));

                String s = answerToString(plan, ci);//.Split(new char[] { '|', ',' }, StringSplitOptions.RemoveEmptyEntries);

                /*foreach (String t in s)
                {
                    Console.WriteLine(t);
                }*/

                //Console.WriteLine(s.Count());

                Console.WriteLine(s);

                /*ReadWriteTools.WriteConditionToFile(
                    "sample",
                    ReadWriteTools.MakeSimpleTranche()
                    );

                Tranche tranche = ReadWriteTools.ReadConditionFromFile("sample");


                Investor investor = new Investor(tranche.period, tranche.capital, tranche.assets);

                InvestmentsSolver solver = new InvestmentsSolver(investor);

                InvestmentPlan plan = solver.TheoreticalProfitPlan();

                foreach (Tuple<decimal, decimal> x in plan.Plan)
                {
                    System.Console.WriteLine(x);
                }

                System.Console.WriteLine(plan.GetFinalProfit());*/
            }
        }
    }
}
