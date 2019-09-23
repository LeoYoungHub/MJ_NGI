namespace MJ_NGI
{
	partial class UC
	{
		/// <summary> 
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region 组件设计器生成的代码

		/// <summary> 
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.ucPanelTitle1 = new HZH_Controls.Controls.UCPanelTitle();
			this.ucNumI = new HZH_Controls.Controls.UCNumTextBox();
			this.ucWaveI = new HZH_Controls.Controls.UCWaveChart();
			this.ucNumV = new HZH_Controls.Controls.UCNumTextBox();
			this.ucWaveV = new HZH_Controls.Controls.UCWaveChart();
			this.ucTrackI = new HZH_Controls.Controls.UCTrackBar();
			this.ucTrackV = new HZH_Controls.Controls.UCTrackBar();
			this.ucSwitch1 = new HZH_Controls.Controls.UCSwitch();
			this.ucSwitch2 = new HZH_Controls.Controls.UCSwitch();
			this.ucPanelTitle1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ucPanelTitle1
			// 
			this.ucPanelTitle1.BackColor = System.Drawing.Color.Transparent;
			this.ucPanelTitle1.BorderColor = System.Drawing.Color.Gray;
			this.ucPanelTitle1.ConerRadius = 10;
			this.ucPanelTitle1.Controls.Add(this.ucNumI);
			this.ucPanelTitle1.Controls.Add(this.ucWaveI);
			this.ucPanelTitle1.Controls.Add(this.ucNumV);
			this.ucPanelTitle1.Controls.Add(this.ucWaveV);
			this.ucPanelTitle1.Controls.Add(this.ucTrackI);
			this.ucPanelTitle1.Controls.Add(this.ucTrackV);
			this.ucPanelTitle1.Controls.Add(this.ucSwitch2);
			this.ucPanelTitle1.Controls.Add(this.ucSwitch1);
			this.ucPanelTitle1.FillColor = System.Drawing.Color.White;
			this.ucPanelTitle1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.ucPanelTitle1.IsCanExpand = false;
			this.ucPanelTitle1.IsExpand = false;
			this.ucPanelTitle1.IsRadius = true;
			this.ucPanelTitle1.IsShowRect = true;
			this.ucPanelTitle1.Location = new System.Drawing.Point(0, 0);
			this.ucPanelTitle1.Margin = new System.Windows.Forms.Padding(0);
			this.ucPanelTitle1.Name = "ucPanelTitle1";
			this.ucPanelTitle1.RectColor = System.Drawing.Color.Gray;
			this.ucPanelTitle1.RectWidth = 1;
			this.ucPanelTitle1.Size = new System.Drawing.Size(660, 387);
			this.ucPanelTitle1.TabIndex = 13;
			this.ucPanelTitle1.Title = "IP";
			// 
			// ucNumI
			// 
			this.ucNumI.BackColor = System.Drawing.Color.DodgerBlue;
			this.ucNumI.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
			this.ucNumI.InputType = HZH_Controls.TextInputType.Number;
			this.ucNumI.IsNumCanInput = true;
			this.ucNumI.KeyBoardType = HZH_Controls.Controls.KeyBoardType.UCKeyBorderNum;
			this.ucNumI.Location = new System.Drawing.Point(489, 93);
			this.ucNumI.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
			this.ucNumI.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.ucNumI.Name = "ucNumI";
			this.ucNumI.Num = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.ucNumI.Padding = new System.Windows.Forms.Padding(2);
			this.ucNumI.Size = new System.Drawing.Size(152, 36);
			this.ucNumI.TabIndex = 17;
			this.ucNumI.NumChanged += new System.EventHandler(this.UcNumI_NumChanged);
			// 
			// ucWaveI
			// 
			this.ucWaveI.ConerRadius = 1;
			this.ucWaveI.FillColor = System.Drawing.Color.LightSkyBlue;
			this.ucWaveI.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.ucWaveI.GridLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
			this.ucWaveI.GridLineTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
			this.ucWaveI.IsRadius = true;
			this.ucWaveI.IsShowRect = true;
			this.ucWaveI.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
			this.ucWaveI.LineTension = 0.5F;
			this.ucWaveI.Location = new System.Drawing.Point(342, 137);
			this.ucWaveI.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ucWaveI.Name = "ucWaveI";
			this.ucWaveI.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
			this.ucWaveI.RectWidth = 1;
			this.ucWaveI.Size = new System.Drawing.Size(299, 197);
			this.ucWaveI.SleepTime = 1000;
			this.ucWaveI.TabIndex = 11;
			this.ucWaveI.TopY = 12;
			this.ucWaveI.WaveWidth = 50;
			// 
			// ucNumV
			// 
			this.ucNumV.BackColor = System.Drawing.Color.Salmon;
			this.ucNumV.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
			this.ucNumV.InputType = HZH_Controls.TextInputType.Number;
			this.ucNumV.IsNumCanInput = true;
			this.ucNumV.KeyBoardType = HZH_Controls.Controls.KeyBoardType.Null;
			this.ucNumV.Location = new System.Drawing.Point(489, 43);
			this.ucNumV.MaxValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.ucNumV.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.ucNumV.Name = "ucNumV";
			this.ucNumV.Num = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.ucNumV.Padding = new System.Windows.Forms.Padding(2);
			this.ucNumV.Size = new System.Drawing.Size(152, 36);
			this.ucNumV.TabIndex = 9;
			this.ucNumV.NumChanged += new System.EventHandler(this.UcNumTextBox2_NumChanged);
			// 
			// ucWaveV
			// 
			this.ucWaveV.ConerRadius = 1;
			this.ucWaveV.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
			this.ucWaveV.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.ucWaveV.GridLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
			this.ucWaveV.GridLineTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
			this.ucWaveV.IsRadius = true;
			this.ucWaveV.IsShowRect = true;
			this.ucWaveV.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
			this.ucWaveV.LineTension = 0.5F;
			this.ucWaveV.Location = new System.Drawing.Point(14, 137);
			this.ucWaveV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ucWaveV.Name = "ucWaveV";
			this.ucWaveV.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
			this.ucWaveV.RectWidth = 1;
			this.ucWaveV.Size = new System.Drawing.Size(313, 197);
			this.ucWaveV.SleepTime = 1000;
			this.ucWaveV.TabIndex = 11;
			this.ucWaveV.TopY = 12;
			this.ucWaveV.WaveWidth = 50;
			// 
			// ucTrackI
			// 
			this.ucTrackI.DcimalDigits = 2;
			this.ucTrackI.IsShowTips = true;
			this.ucTrackI.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
			this.ucTrackI.LineWidth = 10F;
			this.ucTrackI.Location = new System.Drawing.Point(14, 95);
			this.ucTrackI.MaxValue = 10F;
			this.ucTrackI.MinValue = 0F;
			this.ucTrackI.Name = "ucTrackI";
			this.ucTrackI.Size = new System.Drawing.Size(469, 30);
			this.ucTrackI.TabIndex = 10;
			this.ucTrackI.Text = "ucTrackBar1";
			this.ucTrackI.TipsFormat = null;
			this.ucTrackI.Value = 0F;
			this.ucTrackI.ValueColor = System.Drawing.Color.DodgerBlue;
			this.ucTrackI.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UcTrackI_MouseDown);
			this.ucTrackI.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UcTrackI_MouseUp);
			// 
			// ucTrackV
			// 
			this.ucTrackV.DcimalDigits = 2;
			this.ucTrackV.IsShowTips = true;
			this.ucTrackV.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
			this.ucTrackV.LineWidth = 10F;
			this.ucTrackV.Location = new System.Drawing.Point(15, 44);
			this.ucTrackV.MaxValue = 10F;
			this.ucTrackV.MinValue = 0F;
			this.ucTrackV.Name = "ucTrackV";
			this.ucTrackV.Size = new System.Drawing.Size(468, 30);
			this.ucTrackV.TabIndex = 10;
			this.ucTrackV.Text = "ucTrackBar1";
			this.ucTrackV.TipsFormat = null;
			this.ucTrackV.Value = 0F;
			this.ucTrackV.ValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
			this.ucTrackV.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UcTrackBar1_MouseDown);
			this.ucTrackV.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UcTrackBar1_MouseUp);
			// 
			// ucSwitch1
			// 
			this.ucSwitch1.BackColor = System.Drawing.Color.Transparent;
			this.ucSwitch1.Checked = false;
			this.ucSwitch1.FalseColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
			this.ucSwitch1.Location = new System.Drawing.Point(342, 347);
			this.ucSwitch1.Name = "ucSwitch1";
			this.ucSwitch1.Size = new System.Drawing.Size(299, 31);
			this.ucSwitch1.SwitchType = HZH_Controls.Controls.SwitchType.Quadrilateral;
			this.ucSwitch1.TabIndex = 18;
			this.ucSwitch1.Texts = new string[] {
        "输出",
        "未输出"};
			this.ucSwitch1.TrueColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
			// 
			// ucSwitch2
			// 
			this.ucSwitch2.BackColor = System.Drawing.Color.Transparent;
			this.ucSwitch2.Checked = false;
			this.ucSwitch2.FalseColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
			this.ucSwitch2.Location = new System.Drawing.Point(14, 347);
			this.ucSwitch2.Name = "ucSwitch2";
			this.ucSwitch2.Size = new System.Drawing.Size(313, 31);
			this.ucSwitch2.SwitchType = HZH_Controls.Controls.SwitchType.Quadrilateral;
			this.ucSwitch2.TabIndex = 18;
			this.ucSwitch2.Texts = new string[] {
        "连接",
        "已断开"};
			this.ucSwitch2.TrueColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			// 
			// UC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.ucPanelTitle1);
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "UC";
			this.Size = new System.Drawing.Size(660, 387);
			this.Load += new System.EventHandler(this.UC_Load);
			this.ucPanelTitle1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private HZH_Controls.Controls.UCPanelTitle ucPanelTitle1;
		private HZH_Controls.Controls.UCNumTextBox ucNumI;
		private HZH_Controls.Controls.UCWaveChart ucWaveI;
		private HZH_Controls.Controls.UCNumTextBox ucNumV;
		private HZH_Controls.Controls.UCWaveChart ucWaveV;
		private HZH_Controls.Controls.UCTrackBar ucTrackI;
		private HZH_Controls.Controls.UCTrackBar ucTrackV;
		private HZH_Controls.Controls.UCSwitch ucSwitch1;
		private HZH_Controls.Controls.UCSwitch ucSwitch2;
	}
}
