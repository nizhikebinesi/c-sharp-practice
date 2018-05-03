using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using InvestmentLib;
using System.Threading;

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
