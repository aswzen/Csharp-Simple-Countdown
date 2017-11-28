/*
 * Created by SharpDevelop.
 * User: AGUS SIGIT WISNUBROTO
 * Date: 11/27/2017
 * Time: 3:41 PM
 */
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace TimerMania
{
	public partial class Displayer : Form
	{
		private int rendererCurrentScreen = 0;
		public Displayer()
		{
			InitializeComponent();
			this.GetType().GetMethod("SetStyle", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).Invoke(this, new object[] { System.Windows.Forms.ControlStyles.UserPaint | System.Windows.Forms.ControlStyles.AllPaintingInWmPaint | System.Windows.Forms.ControlStyles.DoubleBuffer, true });
	        this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
	        this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
	        this.SetStyle(ControlStyles.UserPaint, true);
	        DoubleBuffered = true;
		}
		
		protected override CreateParams CreateParams {
		    get {
		        CreateParams cp = base.CreateParams;
		        cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
		        return cp;
		    }
		}
		
		protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {
		  	if (keyData == (Keys.Control | Keys.E)) {
    			if(this.FormBorderStyle == FormBorderStyle.None){
					this.FormBorderStyle = FormBorderStyle.Fixed3D;
    			} else {
					this.FormBorderStyle = FormBorderStyle.None;
    			}
		    	return true;
		  	}
		  	if (keyData == (Keys.Control | Keys.M)) {
    			if(this.WindowState == FormWindowState.Maximized){
					this.WindowState = FormWindowState.Normal;
    			} else {
					this.WindowState = FormWindowState.Maximized;
    			}
		    	return true;
		  	}
		  	if (keyData == (Keys.Control | Keys.U)) {
				toggleScreenDrawer();
		  	}
		  	if (keyData == (Keys.Control | Keys.T)) {
				toggleTransparency();
				this.BackgroundImage = null;
				this.BackgroundImageLayout = ImageLayout.None;
		  	}
		  	if (keyData == (Keys.Control | Keys.H)) {
        		MessageBox.Show("Maximize CTRL+M\nToggle Header CTRL+E\nToggle Screen CTRL+U\nCTRL+T Toggle Transparency");
		    	return true;
		  	}
		  	return base.ProcessCmdKey(ref msg, keyData);
		}
		
		void toggleTransparency(){
			if(this.TransparencyKey == System.Drawing.Color.Black){
				this.AllowTransparency = false;
			} else {
				this.AllowTransparency = true;
				this.TransparencyKey = System.Drawing.Color.Black;
			}
		}
		
		void toggleScreenDrawer(){
			try
			{
				Screen[] sc;
	    		sc = Screen.AllScreens; 
    			if(rendererCurrentScreen == 1){    
				    this.WindowState = FormWindowState.Normal;
					this.Location = sc[2].Bounds.Location;
					this.rendererCurrentScreen = 2;
    			} else if(rendererCurrentScreen == 0){    
				    this.WindowState = FormWindowState.Normal;
					this.Location = sc[1].Bounds.Location;
					this.rendererCurrentScreen = 1;
    			} else {
    				this.WindowState = FormWindowState.Normal;
					this.Location = sc[0].Bounds.Location;
					this.rendererCurrentScreen = 0;
    			}
			} catch(Exception ex){
			}
		}
	}
}
