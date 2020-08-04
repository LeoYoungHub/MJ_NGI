using HZH_Controls;
using NgiInterface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace MJ_NGI
{
	public partial class Form1 : Form
	{
		INgiInterfaces NGIDevice;
		public Form1()
		{
			NGIDevice = new NgiInterfaces();
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			//NGIDevice.DeviceSetScanStartID();
			NGIDevice.DeviceLoad();

			if (!File.Exists("MJ_NGI_Device.xml"))
			{
				NGIDevice.DeviceShowDlgConfig();
			}

			GetDevice();
		}



		private void Button1_Click(object sender, EventArgs e)
		{
			NGIDevice.WriteUint(2, 1);
			//NGIDevice.DeviceSetScanStartID(0);
		}

		private void Button2_Click(object sender, EventArgs e)
		{
			string[] vs = textBox1.Text.Split(' ');
			NGIDevice.DeviceSetScanParameter(Convert.ToInt32(vs[0]), Convert.ToInt32(vs[1]), Convert.ToInt32(vs[2]));
		}

		private void Button3_Click(object sender, EventArgs e)
		{
			NGIDevice.DeviceShowDlgConfig();
			GetDevice();

		}

		Dictionary<string, UC> devices = new Dictionary<string, UC>();
		public void GetDevice()
		{
			try
			{
				flowLayoutPanel1.Controls.Clear();
				XmlDocument xmldoc = new XmlDocument();
				xmldoc.Load("MJ_NGI_Device.xml");

				XmlNodeList topRoot = xmldoc.SelectNodes("//Head");
				string deviceCount = topRoot[0]["ItemCount"].InnerText;
				//获取节点列表 
				XmlNodeList topM = xmldoc.SelectNodes("//Items");
				devices.Clear();
				foreach (XmlElement item in topM[0])
				{
					string ch = item["SystemID"].InnerText;
					string ip = item["LanIP"].InnerText;

					UC uC = new UC();
					uC.Open(ip, ch);
					string vi = ConfigManager.GetConfig(ch);
					devices.Add(ch, uC);
					if (!string.IsNullOrEmpty(vi))
					{
						uC.V = Convert.ToSingle(vi.Split('|')[0]);
						uC.I = Convert.ToSingle(vi.Split('|')[1]);
					}
				}

				foreach (var item in devices)
				{
					flowLayoutPanel1.Controls.Add(item.Value);
				}
			}
			catch (Exception)
			{

			}
		}

		private void Button5_Click(object sender, EventArgs e)
		{
			//NGIDevice.WriteFloat(6, Convert.ToSingle(txtI.Text));
		}

		private void Button4_Click(object sender, EventArgs e)
		{
			//NGIDevice.WriteFloat(4, Convert.ToSingle(txtV1.Text));
		}

		private void Button6_Click(object sender, EventArgs e)
		{
			int ret = NGIDevice.open(txtIp.Text, 7000, 0);
			if (ret == 1)
			{
				//timer1.Enabled = true;
			}
		}

		private void Button7_Click(object sender, EventArgs e)
		{
			var btn = sender as Button;
			NGIDevice.WriteUint(2, Convert.ToUInt32(btn.Tag));
		}

		float ReadValue(int addr)
		{
			//Random r = new Random();
			//float i = Convert.ToSingle(r.Next(0, 1000)) / 100;

			//return i;
			float a = 0;
			NGIDevice.ReadFloat(addr, out a);

			return float.Parse(a.ToString("F2"));
		}

		int ReadIntValue(int addr)
		{
			//Random r = new Random();
			//float i = Convert.ToSingle(r.Next(0, 1000)) / 100;

			//return i;
			int a = 0;
			NGIDevice.ReadInt(addr, out a);

			return a;
		}

		private void Button11_Click(object sender, EventArgs e)
		{
			NGIDevice.WriteUint(2, 0);
		}

		private void Button12_Click(object sender, EventArgs e)
		{
			NGIDevice.close();
		}

		private void TrackBar1_Scroll(object sender, EventArgs e)
		{

		}

		private void Button9_Click(object sender, EventArgs e)
		{
			MessageBox.Show(ReadValue(44).ToString());
		}

		private void Button10_Click(object sender, EventArgs e)
		{
			MessageBox.Show(ReadValue(46).ToString());
		}

		private void Button4_Click_1(object sender, EventArgs e)
		{
			MessageBox.Show(NGIDevice.WriteFloat(6, Convert.ToSingle(textBox2.Text)).ToString());
		}

		private void Button5_Click_1(object sender, EventArgs e)
		{
			MessageBox.Show(NGIDevice.WriteFloat(4, Convert.ToSingle(textBox3.Text)).ToString());

		}

		private void Button7_Click_1(object sender, EventArgs e)
		{
			MessageBox.Show(ReadIntValue(1).ToString());
		}

		private void Button8_Click(object sender, EventArgs e)
		{
			MessageBox.Show(ReadIntValue(0).ToString());
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			foreach (var item in devices)
			{
				ConfigManager.SetConfig(item.Key, $"{item.Value.V}|{item.Value.I}");
			}
		}
	}
}
