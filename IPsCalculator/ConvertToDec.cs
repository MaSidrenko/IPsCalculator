using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPsCalculator
{
	static internal class ConvertToDec
	{
		static double dec;

		static private List<string> GetBins(string[] split)
		{
			List<string> bins = new List<string>();
			foreach (string s in split)
			{
				bins.AddRange(s.Split(' '));
			}
			return bins;
		}

		public static double[] BinToDec(string bin)
		{
			string[] bins = bin.Split(' ');
			List<double> decs = new List<double>();

			int counter = 7;

			for (int i = 0; i < bins.Length; i++)
			{
				if (bins[i] == "1")
				{
					dec += Math.Pow(2, counter);
					counter--;
				}
				else if (bins[i] == "0")
				{
					counter--;
				}
				if (bins[i] == ".")
				{
					decs.Add(dec);
					dec = 0;
					counter = 7;
				}
			}

			if (counter != 7)
			{
				decs.Add(dec);
			}
			dec = 0;
			return decs.ToArray();
		}
	}
}
