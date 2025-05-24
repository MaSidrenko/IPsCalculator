using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPsCalculator
{
	public partial class IPsCalculator : Form
	{
		Dictionary<TextBox, Label> d_IPs_Labels;
		Dictionary<TextBox, Label> d_Maskes_Labels;
		public IPsCalculator()
		{
			InitializeComponent();
			this.CenterToParent();
			d_IPs_Labels = new Dictionary<TextBox, Label>
			{
				[IPBox1] = lblIPBin1,
				[IPBox2] = lblIPBin2,
				[IPBox3] = lblIPBin3,
				[IPBox4] = lblIPBin4
			};
			d_Maskes_Labels = new Dictionary<TextBox, Label>
			{
				[MaskBox1] = lblMaskBin1,
				[MaskBox2] = lblMaskBin2,
				[MaskBox3] = lblMaskBin3,
				[MaskBox4] = lblMaskBin4
			};
			PrefixMaskBox.Visible = false;
			lblPrefixMask.Visible = false;
			lblPrefixMask.Text = "";
		}
		private void AllIPtb_TextChanged(object sender, EventArgs e)
		{
			TextBox IPsBox = (sender as TextBox);

			if (IPsBox.Text == "")
			{
				if(d_IPs_Labels.TryGetValue(IPsBox, out Label label))
				{
					label.Text = "";
				}
			}

			if (IPsBox.Text != "")
			{
				if (Convert.ToInt32(IPsBox.Text) >= 256)
				{
					MessageBox.Show("Превышино максимальное значение!" +
									"\nБудет установленно максимальное значение!" +
									"\nМаксимальное значение равно 255!",
									"Max Value Error",
									MessageBoxButtons.OK,
									MessageBoxIcon.Error);
					IPsBox.Text = "255";
				}

				if (d_IPs_Labels.TryGetValue(IPsBox, out Label label))
				{
					label.Text = ConvertToBin.GetIP_Str(Convert.ToInt32(IPsBox.Text));
				} 
			}
		}

		private void AllMaskbox_TextChanged(object sender, EventArgs e)
		{
			TextBox MaskesBox = (sender as TextBox);
			if(MaskesBox.Text == "")
			{
				if (d_Maskes_Labels.TryGetValue(MaskesBox, out Label label))
				{
					label.Text = "";
				}
			}
			if (MaskesBox.Text != "" && !cbPreficsMask.Checked)
			{
				if (Convert.ToInt32(MaskesBox.Text) >= 256)
				{
					MessageBox.Show("Превышино максимальное значение!" +
								"\nБудет установленно максимальное значение!" +
								"\nМаксимальное значение равно 255!",
								"Max Value Error",
								MessageBoxButtons.OK,
								MessageBoxIcon.Error);
					MaskesBox.Text = "255";
				}
				if (d_Maskes_Labels.TryGetValue(MaskesBox, out Label label))
				{
					label.Text = ConvertToBin.GetIP_Str(Convert.ToInt32(MaskesBox.Text));
				}
			}
		}
		private void cbPreficsMask_CheckedChanged(object sender, EventArgs e)
		{
			if (cbPreficsMask.Checked == true)
			{
				PrefixMaskBox.Visible = true;
				lblPrefixMask.Visible = true;

				label8.Visible = false;
				label7.Visible = false;
				label6.Visible = false;

				MaskBox1.Visible = false;
				MaskBox2.Visible = false;
				MaskBox3.Visible = false;
				MaskBox4.Visible = false;

				MaskBox1.Text = "";
				MaskBox2.Text = "";
				MaskBox3.Text = "";
				MaskBox4.Text = "";

				lblMaskBin1.Text = " ";
				lblMaskBin2.Text = "";
				lblMaskBin3.Text = "";
				lblMaskBin4.Text = "";
			}
			else if (cbPreficsMask.Checked == false)
			{
				PrefixMaskBox.Visible = false;
				lblPrefixMask.Visible = false;

				label8.Visible = true;
				label7.Visible = true;
				label6.Visible = true;

				MaskBox1.Visible = true;
				MaskBox2.Visible = true;
				MaskBox3.Visible = true;
				MaskBox4.Visible = true;

				PrefixMaskBox.Text = "";
				lblPrefixMask.Text = "";
			}
		}

		private void btnNetAddres_Click(object sender, EventArgs e)
		{
			string sum_IPs;
			string sum_Masks;
			uint network_addres;
			string bin_network;
			string sep_dots_bin_network;
			string sep_spaces_bin_network;
			double[] result;
			string output;
			if (IPBox1.Text != "" && IPBox2.Text != "" && IPBox3.Text != "" && IPBox4.Text != "" && MaskBox1.Text != "" && MaskBox2.Text != "" && MaskBox3.Text != "" && MaskBox4.Text != "")
			{
				sum_IPs = ConvertToBin.Clear(lblIPBin1.Text + lblIPBin2.Text + lblIPBin3.Text + lblIPBin4.Text);
				sum_Masks = ConvertToBin.Clear(lblMaskBin1.Text + lblMaskBin2.Text + lblMaskBin3.Text + lblMaskBin4.Text);

				network_addres = Convert.ToUInt32(sum_IPs, 2) & Convert.ToUInt32(sum_Masks, 2);
				bin_network = Convert.ToString(network_addres, 2);

				sep_dots_bin_network = string.Join(".", Enumerable.Range(0, bin_network.Length / 8).Select(_ => bin_network.Substring(_ * 8, 8)));
				sep_spaces_bin_network = string.Join(" ", Enumerable.Range(0, sep_dots_bin_network.Length / 1).Select(_ => sep_dots_bin_network.Substring(_ * 1, 1)));

				result = ConvertToDec.BinToDec(sep_spaces_bin_network);
				output = string.Join(".", result);

				MessageBox.Show("Network Addres = " + output);
			}
			else if (IPBox1.Text != "" && IPBox2.Text != "" && IPBox3.Text != "" && IPBox4.Text != "" && cbPreficsMask.Checked && PrefixMaskBox.Text != "")
			{
				sum_IPs = ConvertToBin.Clear(lblIPBin1.Text + lblIPBin2.Text + lblIPBin3.Text + lblIPBin4.Text);
				sum_Masks = ConvertToBin.Clear(lblPrefixMask.Text);

				network_addres = Convert.ToUInt32(sum_IPs, 2) & Convert.ToUInt32(sum_Masks, 2);
				bin_network = Convert.ToString(network_addres, 2);

				sep_dots_bin_network = string.Join(".", Enumerable.Range(0, bin_network.Length / 8).Select(_ => bin_network.Substring(_ * 8, 8)));
				sep_spaces_bin_network = string.Join(" ", Enumerable.Range(0, sep_dots_bin_network.Length / 1).Select(_ => sep_dots_bin_network.Substring(_ * 1, 1)));

				result = ConvertToDec.BinToDec(sep_spaces_bin_network);
				output = string.Join(".", result);

				MessageBox.Show("Network Addres = " + output);
			}
		}

		private void btnBroadcastNet_Click(object sender, EventArgs e)
		{
			string sum_IPs;
			string sum_Masks;

			uint broadcast_network;
			string bin_broadcast;

			string sep_dots_bin_broadcast;
			string sep_spaces_bin_broadcast;

			double[] result;
			string output;
			if (IPBox1.Text != "" && IPBox2.Text != "" && IPBox3.Text != "" && IPBox4.Text != "" && MaskBox1.Text != "" && MaskBox2.Text != "" && MaskBox3.Text != "" && MaskBox4.Text != "")
			{
				sum_IPs = ConvertToBin.Clear(lblIPBin1.Text + lblIPBin2.Text + lblIPBin3.Text + lblIPBin4.Text);
				sum_Masks = ConvertToBin.Clear(lblMaskBin1.Text + lblMaskBin2.Text + lblMaskBin3.Text + lblMaskBin4.Text);

				broadcast_network = Convert.ToUInt32(sum_IPs, 2) | ~Convert.ToUInt32(sum_Masks, 2);
				bin_broadcast = Convert.ToString(broadcast_network, 2);

				sep_dots_bin_broadcast = string.Join(".", Enumerable.Range(0, bin_broadcast.Length / 8).Select(_ => bin_broadcast.Substring(_ * 8, 8)));
				sep_spaces_bin_broadcast = string.Join(" ", Enumerable.Range(0, sep_dots_bin_broadcast.Length / 1).Select(_ => sep_dots_bin_broadcast.Substring(_ * 1, 1)));

				result = ConvertToDec.BinToDec(sep_spaces_bin_broadcast);
				output = string.Join(".", result);
				MessageBox.Show("Broadcast Network = " + output);
			}
			else if (IPBox1.Text != "" && IPBox2.Text != "" && IPBox3.Text != "" && IPBox4.Text != "" && cbPreficsMask.Checked && PrefixMaskBox.Text != "")
			{
				sum_IPs = ConvertToBin.Clear(lblIPBin1.Text + lblIPBin2.Text + lblIPBin3.Text + lblIPBin4.Text);
				sum_Masks = ConvertToBin.Clear(lblPrefixMask.Text);

				broadcast_network = Convert.ToUInt32(sum_IPs, 2) | ~Convert.ToUInt32(sum_Masks, 2);
				bin_broadcast = Convert.ToString(broadcast_network, 2);

				sep_dots_bin_broadcast = string.Join(".", Enumerable.Range(0, bin_broadcast.Length / 8).Select(_ => bin_broadcast.Substring(_ * 8, 8)));
				sep_spaces_bin_broadcast = string.Join(" ", Enumerable.Range(0, sep_dots_bin_broadcast.Length / 1).Select(_ => sep_dots_bin_broadcast.Substring(_ * 1, 1)));

				result = ConvertToDec.BinToDec(sep_spaces_bin_broadcast);
				output = string.Join(".", result);
				MessageBox.Show("Broadcast Network = " + output);
			}
		}

		private void btnHost_Click(object sender, EventArgs e)
		{
			if (MaskBox4.Text != "")
			{
				string host = ConvertToBin.Clear(lblMaskBin4.Text + lblMaskBin1.Text + lblMaskBin2.Text + lblMaskBin3.Text);
				string[] hosts = host.Split('0');
				double count = 0;
				for (int i = 0; i < hosts.Length; i++)
				{
					count = Math.Pow(2, i);
				}
				MessageBox.Show("Counts Hosts: " + count);
			}
			else if (cbPreficsMask.Checked && PrefixMaskBox.Text != "")
			{
				string host = ConvertToBin.Clear(lblPrefixMask.Text);
				string[] hosts = host.Split('0');

				double count = 0;
				for (int i = 0; i < hosts.Length; i++)
				{
					count = Math.Pow(2, i);
				}
				MessageBox.Show("Counts Hosts: " + count);
			}
		}

		private void MaskPreficsBox_TextChanged(object sender, EventArgs e)
		{
			if (cbPreficsMask.Checked && PrefixMaskBox.Text != "")
			{
				int lenght = 32;
				string prefix = "";
				if (PrefixMaskBox.Text.Length < 1)
					lblPrefixMask.Text = "";
				if (Convert.ToInt32(PrefixMaskBox.Text) <= 32)
				{

					for (int i = 0; i < Convert.ToInt32(PrefixMaskBox.Text); i++)
					{
						prefix += "1";
					}
					for (int i = 0; i < lenght - Convert.ToInt32(PrefixMaskBox.Text); i++)
					{
						prefix += "0";
					}
				}
				string prefix_with_spaces = string.Join(" ", Enumerable.Range(0, prefix.Length / 4).Select(_ => prefix.Substring(_ * 4, 4)));

				lblPrefixMask.Text = prefix_with_spaces;
			}
		}
	}
}
