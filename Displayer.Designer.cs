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
	partial class Displayer
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		public System.Windows.Forms.Label labelText;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Displayer));
			this.labelText = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// labelText
			// 
			this.labelText.BackColor = System.Drawing.Color.Transparent;
			this.labelText.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelText.Font = new System.Drawing.Font("Courier New", 150F, System.Drawing.FontStyle.Bold);
			this.labelText.ForeColor = System.Drawing.Color.White;
			this.labelText.Location = new System.Drawing.Point(0, 0);
			this.labelText.Name = "labelText";
			this.labelText.Size = new System.Drawing.Size(1194, 576);
			this.labelText.TabIndex = 1;
			this.labelText.Text = "00:00:00";
			this.labelText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Displayer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1194, 576);
			this.ControlBox = false;
			this.Controls.Add(this.labelText);
			this.DoubleBuffered = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Displayer";
			this.Text = "Displayer [Help Ctrl+H]";
			this.ResumeLayout(false);

		}
	}
}
