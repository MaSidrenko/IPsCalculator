using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPsCalculator
{
	static class ConvertToBin
	{
		static int[] bin_num = new int[8];
		static private int[] DecToBin(int dec_num)
		{
			for (int i = 7; i >= 0; i--)
			{
				bin_num[i] = dec_num % 2;
				dec_num /= 2;
			}
			return bin_num;
		}
		static public string Clear(string input)
		{
			return new string(input.Where(_ => _ == '0' || _ == '1').ToArray());
		}
		static public string GetIP_Str(int dec_num)
		{
			string binIP_str = "";
			DecToBin(dec_num);
			for (int i = 0; i < bin_num.Length; i++)
			{
				binIP_str += bin_num[i];
				if (i % 1 == 0)
				{
					binIP_str += " ";
				}
				if(i == 3)
				{
					binIP_str += ". ";
				}
			}
			return binIP_str;
		}


	}
}
