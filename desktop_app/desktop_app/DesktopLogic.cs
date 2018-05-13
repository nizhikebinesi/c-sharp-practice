using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

using InvestmentLib;
using System.Threading;
using System.Globalization;

namespace desktop_app
{
    class DesktopLogic
    {
        public static void f()
        {
            Tranche tranche = ReadWriteTools.MakeSimpleTranche();
            ReadWriteTools.WriteConditionToTextFile("another_sample.txt", tranche);

            Tranche t = ReadWriteTools.ReadConditionFromTextFile("another_sample.txt");
            ReadWriteTools.WriteConditionToTextFile("just_sample.txt", t);
        }

        public static Tranche trancheFromForm(Form1 form1)
        {
            Tranche tranche = new Tranche();



            return tranche;
        }

        public static InvestmentPlan planFromProcess(string filename)
        {
            Process p = new Process();
            p.StartInfo.FileName = "console_app.exe";
            p.StartInfo.Arguments = filename;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;

            p.Start();

            String output = (String)p.StandardOutput.ReadToEnd();

            p.Close();

            return parseFromString(output);
        }

        public static InvestmentPlan parseFromString(String s)
        {
            CultureInfo ci = ReadWriteTools.ci;

            InvestmentPlan plan;

            IList<Tuple<decimal, decimal>> l = new List<Tuple<decimal, decimal>>();

            string[] parseTmp = s.Split(new char[] { '|', ',' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < parseTmp.Count() / 2; i += 1)
            {
                l.Add(
                    new Tuple<decimal, decimal>(
                        Decimal.Parse(parseTmp[2 * i], ci),
                        Decimal.Parse(parseTmp[2 * i + 1], ci)
                    ));
            }

            plan = new InvestmentPlan(l);

            return plan;
        }

        public static InvestmentPlan planFromThread(Tranche tranche)
        {
            object t = null;
            var thread = new Thread(
                () =>
                {
                    t = EasySolve.solve(tranche);
                }
                );
            thread.Start();
            thread.Join();

            return (InvestmentPlan)t;
        }
        // пиши обертки(
        /*public static InvestmentPlan solveInOtherThread(Tranche tranche)
        {
            Thread t = new Thread(someSolve);
            t.Start(tranche);
            return 
        }

        private static object someSolve(object tranche)
        {
            return EasySolve.solve((Tranche)tranche);
        }*/
    }
}
