using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestmentLib
{
    [Serializable()]
    public class InvalidInvestmentPeriodException : System.Exception
    {
        public InvalidInvestmentPeriodException() : base() { }
        public InvalidInvestmentPeriodException(string message) : base(message) { }
        public InvalidInvestmentPeriodException(string message, System.Exception inner) : base(message, inner) { }

        // A constructor is needed for serialization when an
        // exception propagates from a remoting server to the client. 
        protected InvalidInvestmentPeriodException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context)
        { }
    }

    [Serializable()]
    public class InvalidInvestmentCapitalException : System.Exception
    {
        public InvalidInvestmentCapitalException() : base() { }
        public InvalidInvestmentCapitalException(string message) : base(message) { }
        public InvalidInvestmentCapitalException(string message, System.Exception inner) : base(message, inner) { }

        // A constructor is needed for serialization when an
        // exception propagates from a remoting server to the client. 
        protected InvalidInvestmentCapitalException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context)
        { }
    }

    [Serializable()]
    public class InvalidProbabilityException : System.Exception
    {
        public InvalidProbabilityException() : base() { }
        public InvalidProbabilityException(string message) : base(message) { }
        public InvalidProbabilityException(string message, System.Exception inner) : base(message, inner) { }

        // A constructor is needed for serialization when an
        // exception propagates from a remoting server to the client. 
        protected InvalidProbabilityException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context)
        { }
    }

    [Serializable()]
    public class InvalidProfitException : System.Exception
    {
        public InvalidProfitException() : base() { }
        public InvalidProfitException(string message) : base(message) { }
        public InvalidProfitException(string message, System.Exception inner) : base(message, inner) { }

        // A constructor is needed for serialization when an
        // exception propagates from a remoting server to the client. 
        protected InvalidProfitException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context)
        { }
    }

    class MyMath
    {
        public static decimal power(decimal a, int n)
        {
            if (n < 0)
            {
                throw new ArithmeticException();
            }
            decimal result = 1m;

            while (n > 0)
            {
                if ((n & 1) > 0)
                {
                    result *= a;
                }
                a *= a;
                n >>= 1;
            }

            return result;
        }
    }

    public struct Asset
    {
        public decimal profit;
        public decimal prob;

        public Asset(decimal profit, decimal prob)
        {
            if (prob > 1 || prob < 0)
            {
                throw new InvalidProbabilityException();
            }
            this.profit = profit;
            this.prob = prob;
        }
    }

    public class InvestmentPlan
    {
        public IList<Tuple<decimal, decimal>> plan;

        public InvestmentPlan(IList<Tuple<decimal, decimal>> plan)
        {
            this.plan = plan;
        }

        public IList<Tuple<decimal, decimal>> Plan
        {
            get
            {
                return plan;
            }
        }

        public decimal GetFinalProfit()
        {
            return plan.Last().Item2;
        }
    }

    public class Investor
    {
        private int periodLength;
        private decimal capital;

        private IList<Asset> assets;

        public Investor(int periodLength, decimal capital, IList<Asset> assets)
        {
            if (periodLength < 0)
            {
                throw new InvalidInvestmentPeriodException();
            }
            if (capital < 0)
            {
                throw new InvalidInvestmentCapitalException();
            }
            this.periodLength = periodLength;
            this.capital = capital;
            this.assets = assets;
        }


        public decimal Capital
        {
            get
            {
                return capital;
            }

            set
            {
                if (capital < 0)
                {
                    throw new InvalidInvestmentCapitalException();
                }
                capital = value;
            }
        }

        public int PeriodLength
        {
            get
            {
                return periodLength;
            }

            set
            {
                if (periodLength < 0)
                {
                    throw new InvalidInvestmentPeriodException();
                }
                periodLength = value;
            }
        }

        public IList<Asset> Assets
        {
            get
            {
                return assets;
            }

            set
            {
                assets = value;
            }
        }
    }

    public class InvestmentsSolver
    {
        private Investor investor;
        private IList<decimal> investments = new List<decimal>();
        //private IList<decimal> realInvestment = new List<decimal>();
        private IList<Asset> assets;
        private decimal startCapital;
        private int periodLength;

        public InvestmentsSolver(Investor investor)
        {
            this.investor = investor;
            assets = investor.Assets;
            this.startCapital = investor.Capital;
            this.periodLength = investor.PeriodLength;
        }

        public InvestmentPlan TheoreticalProfitPlan()
        {
            // item1 - real investment
            // item2 - profit from investment
            IList<Tuple<decimal, decimal>> realProfitInvestments = new List<Tuple<decimal, decimal>>(periodLength);

            // for first state computing...
            //Tuple<decimal, decimal> first = new Tuple<decimal, decimal>(0m, startCapital);
            Tuple<decimal, decimal> first = new Tuple<decimal, decimal>(startCapital, startCapital);

            realProfitInvestments.Add(first);

            decimal _r = 0m;
            foreach (Asset asset in assets)
            {
                _r += asset.prob * asset.profit;
            }

            System.Console.WriteLine("_r = {0}", _r);

            for (int i = 1; i < periodLength + 1; i++)
            {
                Tuple<decimal, decimal> tmp;
                decimal y, fy;

                if (_r <= 0m)
                {
                    y = 0m;
                    fy = realProfitInvestments[i - 1].Item2;
                }
                else
                {
                    y = realProfitInvestments[i - 1].Item2;
                    fy = y * (1 + _r);//*MyMath.power(_r, i);
                }

                tmp = new Tuple<decimal, decimal>(y, fy);
                realProfitInvestments.Add(tmp);
            }

            return new InvestmentPlan(realProfitInvestments);
        }

    }
}

