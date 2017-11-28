/*
 * Created by SharpDevelop.
 * User: AGUS SIGIT WISNUBROTO
 * Date: 11/27/2017
 * Time: 3:41 PM
 */
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace TimerMania
{
	public partial class MainForm : Form
	{
		[DllImport("user32.dll")]
		private static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
		[DllImport("user32.dll")]
		private static extern bool InsertMenu (IntPtr hMenu, 
		Int32 wPosition, Int32 wFlags, Int32 wIDNewItem, 
		string lpNewItem);
		
		public const Int32 WM_SYSCOMMAND = 0x112;
		public const Int32 MF_SEPARATOR = 0x800;
		public const Int32 MF_BYPOSITION = 0x400;
		public const Int32 MF_STRING = 0x0;
		public const Int32 IDM_CUSTOMITEM1  = 1000;
		public const Int32 IDM_CUSTOMITEM2 = 1001;
		
		public Displayer mainRenderer = new Displayer();
		public MainForm()
		{
			InitializeComponent();
			
			IntPtr sysMenuHandle = GetSystemMenu(this.Handle, false);
			//It would be better to find the position at run time of the 'Close' item, but...
			
			InsertMenu(sysMenuHandle, 5, MF_BYPOSITION | MF_SEPARATOR, 0, string.Empty);
			InsertMenu(sysMenuHandle, 6, MF_BYPOSITION , IDM_CUSTOMITEM1, "CREATED BY");
			InsertMenu(sysMenuHandle, 7, MF_BYPOSITION , IDM_CUSTOMITEM2, "A. Sigit W. www.asw.web.id");
			InsertMenu(sysMenuHandle, 8, MF_BYPOSITION , IDM_CUSTOMITEM2, "aswzen@gmail.com");
			
		}
		
		void BtnInitClick(object sender, EventArgs e)
		{
			if(mainRenderer.IsDisposed){
				mainRenderer = new Displayer();
			}
			mainRenderer.Show();
			mainRenderer.SetDesktopLocation(this.Location.X + this.Size.Width, this.Location.Y);
			
			if(cbUseBgImage.Checked){
				mainRenderer.BackgroundImage = Image.FromFile(btnBgImage.Tag.ToString());
				mainRenderer.BackgroundImageLayout = ImageLayout.Stretch;
			} else {
				mainRenderer.BackgroundImage = null;
			}
	
			mainRenderer.labelText.Font = new Font(txtFontFamily.Text, int.Parse(nmFontSize.Value.ToString()), FontStyle.Bold);
			mainRenderer.labelText.ForeColor = btnFontColor.ForeColor;
			mainRenderer.BackColor = btnBgColor.ForeColor;
		}
		void BtnBgImageClick(object sender, EventArgs e)
		{
			OpenFileDialog boxFile = new OpenFileDialog();
			boxFile.Title = "Background Image";
		    boxFile.Filter = "JPG/JPEG/PNG/BMP/GIF files |*.jpg;*.png;*.jpeg;*.bmp;*.gif";
		    if (boxFile.ShowDialog() == DialogResult.OK)
		    {
		    	this.btnBgImage.Text = boxFile.SafeFileName;
		    	this.btnBgImage.Tag = boxFile.FileName;
		    }
		}
		void BtnFontColorClick(object sender, EventArgs e)
		{
			ColorDialog cdWindow = new ColorDialog();
			if (cdWindow.ShowDialog() == DialogResult.OK)
		    {
				this.btnFontColor.ForeColor = cdWindow.Color;
		    }
		}
		void BtnBgColorClick(object sender, EventArgs e)
		{
			ColorDialog cdWindow = new ColorDialog();
			if (cdWindow.ShowDialog() == DialogResult.OK)
		    {
				this.btnBgColor.ForeColor = cdWindow.Color;
		    }
		}
		void BtnStartTimerClick(object sender, EventArgs e)
		{
			origTimeS = int.Parse(nmTotalSecond.Value.ToString());
			origTimeMS = int.Parse(nmTotalSecond.Value.ToString()) * 1000;
			btnStartTimer.Enabled = false;
			
			timerClockSec.Stop();
			timerClockMs.Stop();
			
			if(rbModeMs.Checked){
				finalClock = DateTime.Now;
				finalClock = finalClock.AddSeconds(double.Parse(nmTotalSecond.Value.ToString()));
				timerClockMs.Start();
			} else {
				timerClockSec.Start();
			}
		}
		void BtnStopTimerClick(object sender, EventArgs e)
		{
			timerClockMs.Stop();
			timerClockSec.Stop();
			btnStartTimer.Enabled = true;
		}
		
		public int origTimeS = 0;
		public int origTimeMS = 0;
		public DateTime finalClock; 
		
		void TimerClockMsTick(object sender, EventArgs e)
		{
	     	origTimeMS--;
	     	TimeSpan time;
			time = finalClock - DateTime.Now;
			
			if(time.Milliseconds < 0){
				timerClockMs.Stop();
				timerClockSec.Stop();
				btnStartTimer.Enabled = true;
	     	}
			
			//Debug.WriteLine(String.Format("{0}:{1}:{2}", time.Minutes.ToString().PadLeft(2, '0'), time.Seconds.ToString().PadLeft(2, '0'), time.Milliseconds.ToString().PadLeft(3, '0')));
			
			string ms = time.Milliseconds.ToString().PadLeft(3, '0');
			if(time.Milliseconds < 0){
				ms = "000";
			}
			mainRenderer.labelText.Text = String.Format("{0}:{1}:", time.Minutes.ToString().PadLeft(2, '0'), time.Seconds.ToString().PadLeft(2, '0') )+ms;
		    
		}
		void TimerClockSecTick(object sender, EventArgs e)
		{
		     origTimeS--;
		     if(origTimeS <= 0){
				timerClockMs.Stop();
				timerClockSec.Stop();
				btnStartTimer.Enabled = true;
		     }
		     mainRenderer.labelText.Text = (origTimeS/60).ToString().PadLeft(2, '0') + ":" + ((origTimeS % 60) >= 10 ?  (origTimeS % 60).ToString() : "0" + origTimeS % 60);
		}
		void BtnResetClick(object sender, EventArgs e)
		{
			timerClockMs.Stop();
			timerClockSec.Stop();
			btnStartTimer.Enabled = true;
			if(rbModeMs.Checked){
				mainRenderer.labelText.Text = "00:00:00";
			} else {
				mainRenderer.labelText.Text = "00:00";
			}
		}
	}
}
