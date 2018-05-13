using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using InvestmentLib;

namespace console_app
{


    public struct Tranche1
    {
        public decimal capital;
        public int period;
        public List<Asset> assets;
        public Tranche1(decimal capital, int period, List<Asset> assets)
        {
            this.capital = capital;
            this.period = period;
            this.assets = assets;
        }
    }


    public class ReadWriteTools1
    {

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

    }
}
