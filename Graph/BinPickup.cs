using System;
using System.Linq;
using System.Windows.Forms.DataVisualization.Charting;

namespace Graph
{
    public class BinPickup
    {
        public int BinAmount { get; set; } = 0;
        public int Interation { get; set; } = 0;
        public int Bin { get; set; } = 0;

        private readonly Random rand = new();

        public Series Execute()
        {
            if (BinAmount == 0 || Interation == 0 || Bin == 0)
                return null;
            int[] bins = new int[Bin];
            for (int i = 0; i < bins.Length; i++)
            {
                bins[i] = BinAmount;
            }

            for (int i = 0; i < Interation; i++)
            {
                int index1 = rand.Next(0, bins.Length);
                while (bins[index1] == 0)
                {
                    index1 = rand.Next(0, bins.Length);
                }
                bins[index1] -= 1;
                int index2 = rand.Next(0, bins.Length);
                while (index1 == index2)
                {
                    index1 = rand.Next(0, bins.Length);
                }
                bins[index2] += 1;
            }
            Series s1 = new();
            for (int i = bins.Min(); i <= bins.Max(); i++)
            {
                var amount = bins.Where(x => x == i).Count();
                s1.Points.AddXY(i, amount);
            }
            return s1;
        }
    }
}
