using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NgiInterface;
using HZH_Controls.Forms;

namespace MJ_NGI
{
	public partial class UC : UserControl
	{
		INgiInterfaces NGIDevice;
		public UC()
		{
			NGIDevice = new NgiInterfaces();
			InitializeComponent();
		}
		private string ip = "192.168.2.0";
		public string IP { get { return ip; } set { ip = value; } }

		private string ch = "0";
		public string CH { get { return ch; } set { ch = value; } }

		public bool Open(string ip, string ch)
		{
			timer1.Dispose();
			timer1.Interval = 1000;
			timer1.Enabled = false;
			timer1.Tick += new EventHandler(timer1EventProcessor);//添加事件

			this.ch = ch;
			this.ip = ip;
			bool a = OpenLink();
			if (a)
			{
				ucSwitch2.Checked = true;
			}
			ucSwitch1.CheckedChanged += UcSwitch1_CheckedChanged;
			ucSwitch2.CheckedChanged += UcSwitch2_CheckedChanged;
			return a;
		}

		bool OpenLink()
		{
			ucPanelTitle1.Title = $"CH{ch} [{ip}]";
			int ret = NGIDevice.open(ip, 7000, 0);
			if (ret == 1)
			{
				timer1.Enabled = true;
				ucPanelTitle1.BorderColor = Color.FromArgb(255, 77, 59);
			}
			else
			{
				timer1.Enabled = false;
				ucPanelTitle1.BorderColor = Color.Gray;
			}
			return ret == 1;
		}

		private void UcTrackBar1_MouseUp(object sender, MouseEventArgs e)
		{
			ucNumV.NumChanged += UcNumTextBox2_NumChanged;
			ucNumV.Num = (decimal)ucTrackV.Value;

		}

		private void UcTrackBar1_MouseDown(object sender, MouseEventArgs e)
		{
			ucNumV.NumChanged -= UcNumTextBox2_NumChanged;
		}

		private void UcTrackI_MouseDown(object sender, MouseEventArgs e)
		{
			ucNumI.NumChanged -= UcNumI_NumChanged;
		}

		private void UcTrackI_MouseUp(object sender, MouseEventArgs e)
		{
			ucNumI.NumChanged += UcNumI_NumChanged;
			ucNumI.Num = (decimal)ucTrackI.Value;
		}
		private void UcNumI_NumChanged(object sender, EventArgs e)
		{
			ucTrackI.Value = (float)ucNumI.Num;
			NGIDevice.WriteFloat(6, ucTrackI.Value);
		}
		private void UcNumTextBox2_NumChanged(object sender, EventArgs e)
		{
			ucTrackV.Value = (float)ucNumV.Num;
			NGIDevice.WriteFloat(4, ucTrackV.Value);
		}
		Timer timer1 = new Timer();
		private void UC_Load(object sender, EventArgs e)
		{
			NGIDevice.DeviceLoad();		
		}

		public void timer1EventProcessor(object source, EventArgs e)
		{
			try
			{
				//电压
				float v = ReadValue(44);
				ucWaveV.AddSource(DateTime.Now.ToString("MM:ss"), v);


				//电流
				float I = ReadValue(45);
				ucWaveI.AddSource(DateTime.Now.ToString("MM:ss"), I);
			}
			catch (Exception)
			{
			}
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

		private void UcSwitch1_CheckedChanged(object sender, EventArgs e)
		{
			uint k = Convert.ToUInt32(ucSwitch1.Checked);
			int i = NGIDevice.WriteUint(2, k);
			if (k == 1)
			{
				if (i != 1)
				{
					FrmTips.ShowTips(this.ParentForm, "输出失败", 3000, false, ContentAlignment.BottomCenter, null, TipsSizeMode.Large, null, TipsState.Error);
					ucSwitch1.Checked = false;
				}
			}
		}

		private void UcSwitch2_CheckedChanged(object sender, EventArgs e)
		{
			if (ucSwitch2.Checked)
			{
				if (!OpenLink())
				{
					FrmTips.ShowTips(this.ParentForm, "连接失败", 3000, false, ContentAlignment.BottomCenter, null, TipsSizeMode.Large, null, TipsState.Error);
					ucSwitch2.Checked = false;
				}
			}
			else
			{
				NGIDevice.close();
			}
		}
	}
}
