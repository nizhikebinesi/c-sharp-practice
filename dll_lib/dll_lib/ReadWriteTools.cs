using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Globalization;

using System.IO;

namespace InvestmentLib
{
    public struct Tranche
    {
        public decimal capital;
        public int period;
        public List<Asset> assets;
        public Tranche(decimal capital, int period, List<Asset> assets)
        {
            this.capital = capital;
            this.period = period;
            this.assets = assets;
        }
    }


    public class ReadWriteTools
    {

        public static CultureInfo ci = new CultureInfo("en-US");

        public static Tranche MakeSimpleTranche()
        {
            List<Asset> assets = new List<Asset>();
            assets.Add(new Asset(2m, 0.4m));
            assets.Add(new Asset(0m, 0.2m));
            assets.Add(new Asset(-1m, 0.4m));
            int period = 4;
            decimal capital = 10000m;

            return new Tranche(capital, period, assets);
        }

        public static void WriteConditionToFile(string fileName, Tranche tranche)
        {
            using (var bw = new BinaryWriter(File.OpenWrite(fileName + ".txt")))
            {
                bw.Write(tranche.capital);
                bw.Write(tranche.period);
                bw.Write(tranche.assets.Count);
                foreach (Asset asset in tranche.assets)
                {
                    bw.Write(asset.profit);
                    bw.Write(asset.prob);
                }
            }
        }

        public static Tranche ReadConditionFromFile(string fileName)
        {
            Tranche tranche;
            using (var br = new BinaryReader(File.OpenRead(fileName + ".txt")))
            {
                decimal capital = br.ReadDecimal();
                int period = br.ReadInt32();
                int length = br.ReadInt32();
                List<Asset> assets = new List<Asset>();
                for (int i = 0; i < length; i++)
                {
                    assets.Add(
                        new Asset(
                            br.ReadDecimal(),
                            br.ReadDecimal()
                            )
                            );
                }

                tranche = new Tranche(capital, period, assets);
            }

            return tranche;
        }

        public static Tranche ReadConditionFromTextFile(string fileName)
        {
            Tranche tranche;
            using (var sr = new StreamReader(fileName))
            {
                string line = sr.ReadLine();
                decimal C = Decimal.Parse(line, ci);
                line = sr.ReadLine();

                int period = int.Parse(line, ci);
                if (period < 1)
                {
                    throw new ArgumentException();
                }

                line = sr.ReadLine();
                int n = int.Parse(line, ci);
                if (n < 1)
                {
                    throw new ArgumentException();
                }

                List<Asset> assets = new List<Asset>();
                for (int i = 0; i < n; i++)
                {
                    line = sr.ReadLine();
                    decimal profit = Decimal.Parse(line, ci);
                    line = sr.ReadLine();
                    decimal prob = Decimal.Parse(line, ci);

                    assets.Add(
                        new Asset(profit, prob)
                        );
                }

                tranche = new Tranche(C, period, assets);
            }
            return tranche;
        }

        public static void WriteConditionToTextFile(string fileName, Tranche tranche)
        {
            using (var sw = new StreamWriter(fileName))
            {
                sw.WriteLine(tranche.capital.ToString(ci));
                sw.WriteLine(tranche.period.ToString(ci));
                sw.WriteLine(tranche.assets.Count.ToString(ci));
                for (int i = 0; i < tranche.assets.Count; i++)
                {
                    var tmp = tranche.assets[i];
                    
                    sw.WriteLine(tmp.profit.ToString(ci));
                    sw.WriteLine(tmp.prob.ToString(ci));
                }
            }
        }
    }
}
