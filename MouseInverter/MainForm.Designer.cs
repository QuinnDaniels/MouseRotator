namespace MouseInverter
{
	public partial class MainForm : global::System.Windows.Forms.Form
	{
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.chkRotate90 = new System.Windows.Forms.CheckBox();
            this.chkRotate270 = new System.Windows.Forms.CheckBox();
            this.notifiyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiRotate90 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRotate270 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTitle = new System.Windows.Forms.Label();
            this.notifyMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkRotate90
            // 
            this.chkRotate90.AutoSize = true;
            this.chkRotate90.Location = new System.Drawing.Point(164, 87);
            this.chkRotate90.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.chkRotate90.Name = "chkRotate90";
            this.chkRotate90.Size = new System.Drawing.Size(137, 29);
            this.chkRotate90.TabIndex = 0;
            this.chkRotate90.Text = "Rotate 90";
            this.chkRotate90.UseVisualStyleBackColor = true;
            this.chkRotate90.CheckedChanged += new System.EventHandler(this.chkRotate90_CheckedChanged);
            // 
            // chkRotate270
            // 
            this.chkRotate270.AutoSize = true;
            this.chkRotate270.Location = new System.Drawing.Point(164, 163);
            this.chkRotate270.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.chkRotate270.Name = "chkRotate270";
            this.chkRotate270.Size = new System.Drawing.Size(149, 29);
            this.chkRotate270.TabIndex = 1;
            this.chkRotate270.Text = "Rotate 270";
            this.chkRotate270.UseVisualStyleBackColor = true;
            this.chkRotate270.CheckedChanged += new System.EventHandler(this.chkRotate270_CheckedChanged);
            // 
            // notifiyIcon
            // 
            this.notifiyIcon.BalloonTipTitle = "Mouse Inverter";
            this.notifiyIcon.ContextMenuStrip = this.notifyMenu;
            this.notifiyIcon.Text = "Mouse Inverter";
            this.notifiyIcon.Visible = true;
            this.notifiyIcon.DoubleClick += new System.EventHandler(this.notifiyIcon_DoubleClick);
            // 
            // notifyMenu
            // 
            this.notifyMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.notifyMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRotate90,
            this.tsmiRotate270});
            this.notifyMenu.Name = "notifyMenu";
            this.notifyMenu.Size = new System.Drawing.Size(301, 124);
            // 
            // tsmiRotate90
            // 
            this.tsmiRotate90.CheckOnClick = true;
            this.tsmiRotate90.Name = "tsmiRotate90";
            this.tsmiRotate90.Size = new System.Drawing.Size(300, 38);
            this.tsmiRotate90.Text = "Rotate 90";
            this.tsmiRotate90.Click += new System.EventHandler(this.tsmiRotate90_Click);
            // 
            // tsmiRotate270
            // 
            this.tsmiRotate270.CheckOnClick = true;
            this.tsmiRotate270.Name = "tsmiRotate270";
            this.tsmiRotate270.Size = new System.Drawing.Size(300, 38);
            this.tsmiRotate270.Text = "Rotate 270";
            this.tsmiRotate270.Click += new System.EventHandler(this.tsmiRotate270_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(24, 17);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(379, 26);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Mouse Inverter v1.1 by Polynomial";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 237);
            this.Controls.Add(this.chkRotate270);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.chkRotate90);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Mouse Rotator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.LocationChanged += new System.EventHandler(this.MainForm_LocationChanged);
            this.notifyMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		private global::System.ComponentModel.IContainer components;

		private global::System.Windows.Forms.CheckBox chkRotate90;

		private global::System.Windows.Forms.CheckBox chkRotate270;

		private global::System.Windows.Forms.NotifyIcon notifiyIcon;

		private global::System.Windows.Forms.ContextMenuStrip notifyMenu;

		private global::System.Windows.Forms.ToolStripMenuItem tsmiRotate90;

		private global::System.Windows.Forms.ToolStripMenuItem tsmiRotate270;

		private global::System.Windows.Forms.Label lblTitle;
	}
}
