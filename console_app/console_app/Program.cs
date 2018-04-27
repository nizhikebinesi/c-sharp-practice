using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using InvestmentLib;



namespace console_app
{

    class Program
    {
        
        static void Main(string[] args)
        {
            ReadWriteTools.WriteConditionToFile(
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

            System.Console.WriteLine(plan.GetFinalProfit());
        }
    }
}
