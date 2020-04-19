using System;
using System.Linq;
using System.Windows.Forms.DataVisualization.Charting;

namespace Graph
{
    public class BinThrow
    {
        public int Throw { get; set; } = 0;
        public int Bin { get; set; } = 0;

        Random rand = new Random();

        public Series Execute()
        {
            int[] bins = new int[Bin];
            for (int i = 0; i < bins.Length; i++)
            {
                bins[i] = 0;
            }

            for (int i = 0; i < Throw; i++)
            {
                int index1 = rand.Next(0, bins.Length);
                bins[index1] += 1;
            }
            Series s1 = new Series();
            for (int i = bins.Min(); i <= bins.Max(); i++)
            {
                var amount = bins.Where(x => x == i).Count();
                s1.Points.AddXY(i, amount);
            }
            return s1;
        }
    }
}
