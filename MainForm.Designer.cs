/*
 * Created by SharpDevelop.
 * User: CASPAR CG
 * Date: 11/27/2017
 * Time: 3:41 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace TimerMania
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.CheckBox cbUseBgImage;
		private System.Windows.Forms.Button btnBgImage;
		private System.Windows.Forms.NumericUpDown nmFontSize;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnBgColor;
		private System.Windows.Forms.Button btnFontColor;
		private System.Windows.Forms.Button btnInit;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.NumericUpDown nmTotalSecond;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnStartTimer;
		private System.Windows.Forms.Button btnStopTimer;
		private System.Windows.Forms.RadioButton rbModeMs;
		private System.Windows.Forms.RadioButton rbModeSec;
		public System.Windows.Forms.Timer timerClockSec;
		public System.Windows.Forms.Timer timerClockMs;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtFontFamily;
		private System.Windows.Forms.Button btnReset;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.txtFontFamily = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.rbModeMs = new System.Windows.Forms.RadioButton();
			this.cbUseBgImage = new System.Windows.Forms.CheckBox();
			this.btnBgImage = new System.Windows.Forms.Button();
			this.nmFontSize = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.btnBgColor = new System.Windows.Forms.Button();
			this.btnFontColor = new System.Windows.Forms.Button();
			this.btnInit = new System.Windows.Forms.Button();
			this.rbModeSec = new System.Windows.Forms.RadioButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnReset = new System.Windows.Forms.Button();
			this.btnStopTimer = new System.Windows.Forms.Button();
			this.btnStartTimer = new System.Windows.Forms.Button();
			this.nmTotalSecond = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.timerClockSec = new System.Windows.Forms.Timer(this.components);
			this.timerClockMs = new System.Windows.Forms.Timer(this.components);
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nmFontSize)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nmTotalSecond)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.txtFontFamily);
			this.groupBox3.Controls.Add(this.label2);
			this.groupBox3.Controls.Add(this.rbModeMs);
			this.groupBox3.Controls.Add(this.cbUseBgImage);
			this.groupBox3.Controls.Add(this.btnBgImage);
			this.groupBox3.Controls.Add(this.nmFontSize);
			this.groupBox3.Controls.Add(this.label4);
			this.groupBox3.Controls.Add(this.btnBgColor);
			this.groupBox3.Controls.Add(this.btnFontColor);
			this.groupBox3.Controls.Add(this.btnInit);
			this.groupBox3.Controls.Add(this.rbModeSec);
			this.groupBox3.Location = new System.Drawing.Point(3, 2);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(163, 178);
			this.groupBox3.TabIndex = 13;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Renderer";
			// 
			// txtFontFamily
			// 
			this.txtFontFamily.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtFontFamily.Location = new System.Drawing.Point(86, 151);
			this.txtFontFamily.Name = "txtFontFamily";
			this.txtFontFamily.Size = new System.Drawing.Size(69, 20);
			this.txtFontFamily.TabIndex = 18;
			this.txtFontFamily.Text = "Tahoma";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(9, 151);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(71, 21);
			this.label2.TabIndex = 17;
			this.label2.Text = "Font Family";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// rbModeMs
			// 
			this.rbModeMs.Checked = true;
			this.rbModeMs.Location = new System.Drawing.Point(86, 10);
			this.rbModeMs.Name = "rbModeMs";
			this.rbModeMs.Size = new System.Drawing.Size(69, 24);
			this.rbModeMs.TabIndex = 16;
			this.rbModeMs.TabStop = true;
			this.rbModeMs.Text = "ms mode";
			this.rbModeMs.UseVisualStyleBackColor = true;
			// 
			// cbUseBgImage
			// 
			this.cbUseBgImage.BackColor = System.Drawing.Color.Transparent;
			this.cbUseBgImage.Location = new System.Drawing.Point(16, 69);
			this.cbUseBgImage.Name = "cbUseBgImage";
			this.cbUseBgImage.Size = new System.Drawing.Size(14, 15);
			this.cbUseBgImage.TabIndex = 15;
			this.cbUseBgImage.UseVisualStyleBackColor = false;
			// 
			// btnBgImage
			// 
			this.btnBgImage.Location = new System.Drawing.Point(6, 60);
			this.btnBgImage.Name = "btnBgImage";
			this.btnBgImage.Size = new System.Drawing.Size(151, 33);
			this.btnBgImage.TabIndex = 14;
			this.btnBgImage.Text = "Use Background Image";
			this.btnBgImage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnBgImage.UseVisualStyleBackColor = true;
			this.btnBgImage.Click += new System.EventHandler(this.BtnBgImageClick);
			// 
			// nmFontSize
			// 
			this.nmFontSize.Location = new System.Drawing.Point(9, 121);
			this.nmFontSize.Maximum = new decimal(new int[] {
			1000,
			0,
			0,
			0});
			this.nmFontSize.Name = "nmFontSize";
			this.nmFontSize.Size = new System.Drawing.Size(55, 20);
			this.nmFontSize.TabIndex = 12;
			this.nmFontSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.nmFontSize.Value = new decimal(new int[] {
			180,
			0,
			0,
			0});
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(9, 96);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(55, 21);
			this.label4.TabIndex = 11;
			this.label4.Text = "Font Size";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnBgColor
			// 
			this.btnBgColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
			this.btnBgColor.Location = new System.Drawing.Point(70, 121);
			this.btnBgColor.Name = "btnBgColor";
			this.btnBgColor.Size = new System.Drawing.Size(87, 21);
			this.btnBgColor.TabIndex = 10;
			this.btnBgColor.Text = "BG COLOR";
			this.btnBgColor.UseVisualStyleBackColor = true;
			this.btnBgColor.Click += new System.EventHandler(this.BtnBgColorClick);
			// 
			// btnFontColor
			// 
			this.btnFontColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
			this.btnFontColor.ForeColor = System.Drawing.Color.White;
			this.btnFontColor.Location = new System.Drawing.Point(70, 97);
			this.btnFontColor.Name = "btnFontColor";
			this.btnFontColor.Size = new System.Drawing.Size(87, 21);
			this.btnFontColor.TabIndex = 10;
			this.btnFontColor.Text = "FONT COLOR";
			this.btnFontColor.UseVisualStyleBackColor = true;
			this.btnFontColor.Click += new System.EventHandler(this.BtnFontColorClick);
			// 
			// btnInit
			// 
			this.btnInit.Location = new System.Drawing.Point(6, 19);
			this.btnInit.Name = "btnInit";
			this.btnInit.Size = new System.Drawing.Size(74, 37);
			this.btnInit.TabIndex = 9;
			this.btnInit.Text = "Init Display";
			this.btnInit.UseVisualStyleBackColor = true;
			this.btnInit.Click += new System.EventHandler(this.BtnInitClick);
			// 
			// rbModeSec
			// 
			this.rbModeSec.Location = new System.Drawing.Point(86, 32);
			this.rbModeSec.Name = "rbModeSec";
			this.rbModeSec.Size = new System.Drawing.Size(75, 24);
			this.rbModeSec.TabIndex = 16;
			this.rbModeSec.Text = "sec mode";
			this.rbModeSec.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnReset);
			this.groupBox1.Controls.Add(this.btnStopTimer);
			this.groupBox1.Controls.Add(this.btnStartTimer);
			this.groupBox1.Controls.Add(this.nmTotalSecond);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(172, 2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 178);
			this.groupBox1.TabIndex = 14;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Gameplay";
			// 
			// btnReset
			// 
			this.btnReset.Location = new System.Drawing.Point(6, 139);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(186, 32);
			this.btnReset.TabIndex = 2;
			this.btnReset.Text = "RESET TIMER";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.BtnResetClick);
			// 
			// btnStopTimer
			// 
			this.btnStopTimer.Location = new System.Drawing.Point(6, 102);
			this.btnStopTimer.Name = "btnStopTimer";
			this.btnStopTimer.Size = new System.Drawing.Size(186, 32);
			this.btnStopTimer.TabIndex = 2;
			this.btnStopTimer.Text = "STOP TIMER";
			this.btnStopTimer.UseVisualStyleBackColor = true;
			this.btnStopTimer.Click += new System.EventHandler(this.BtnStopTimerClick);
			// 
			// btnStartTimer
			// 
			this.btnStartTimer.Location = new System.Drawing.Point(6, 64);
			this.btnStartTimer.Name = "btnStartTimer";
			this.btnStartTimer.Size = new System.Drawing.Size(186, 34);
			this.btnStartTimer.TabIndex = 2;
			this.btnStartTimer.Text = "START TIMER";
			this.btnStartTimer.UseVisualStyleBackColor = true;
			this.btnStartTimer.Click += new System.EventHandler(this.BtnStartTimerClick);
			// 
			// nmTotalSecond
			// 
			this.nmTotalSecond.Location = new System.Drawing.Point(51, 37);
			this.nmTotalSecond.Maximum = new decimal(new int[] {
			1000000,
			0,
			0,
			0});
			this.nmTotalSecond.Name = "nmTotalSecond";
			this.nmTotalSecond.Size = new System.Drawing.Size(110, 20);
			this.nmTotalSecond.TabIndex = 1;
			this.nmTotalSecond.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.nmTotalSecond.Value = new decimal(new int[] {
			5,
			0,
			0,
			0});
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(62, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(74, 14);
			this.label1.TabIndex = 0;
			this.label1.Text = "Total Second";
			// 
			// timerClockSec
			// 
			this.timerClockSec.Interval = 1000;
			this.timerClockSec.Tick += new System.EventHandler(this.TimerClockSecTick);
			// 
			// timerClockMs
			// 
			this.timerClockMs.Interval = 1;
			this.timerClockMs.Tick += new System.EventHandler(this.TimerClockMsTick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(377, 183);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox3);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "Timer Mania Controller";
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nmFontSize)).EndInit();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nmTotalSecond)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
