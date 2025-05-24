using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPCalculator
{
	static internal class ConvertToBin
	{
		//static int dec_num = 0;
		static int[] bin_num = new int[8];
		//static List<int> IPs = new List<int>();

		static private int[] DecToBin(int dec_num)
		{
			for (int i = 7; i >= 0; i--)
			{
				bin_num[i] = dec_num % 2;
				dec_num /= 2;
			}
			return bin_num;
		}
		static public void ClearIPs()
		{
			//IPs.Clear();
		}
		static public string GetIP_Str(int dec_num)
		{
			string binIP_str = "";
			DecToBin(dec_num);
			for (int i = 0; i < bin_num.Length; i++)
			{
				binIP_str += bin_num[i];
				if (i == 3)
				{
					binIP_str += " ";
				}
			}
			return binIP_str;
		}


	}
}
