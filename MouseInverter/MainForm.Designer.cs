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
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::MouseInverter.MainForm));
			this.chkInvertX = new global::System.Windows.Forms.CheckBox();
			this.chkInvertY = new global::System.Windows.Forms.CheckBox();
			this.notifiyIcon = new global::System.Windows.Forms.NotifyIcon(this.components);
			this.notifyMenu = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.tsmiInvertX = new global::System.Windows.Forms.ToolStripMenuItem();
			this.tsmiInvertY = new global::System.Windows.Forms.ToolStripMenuItem();
			this.lblTitle = new global::System.Windows.Forms.Label();
			this.notifyMenu.SuspendLayout();
			base.SuspendLayout();
			this.chkInvertX.AutoSize = true;
			this.chkInvertX.Location = new global::System.Drawing.Point(82, 45);
			this.chkInvertX.Name = "chkInvertX";
			this.chkInvertX.Size = new global::System.Drawing.Size(63, 17);
			this.chkInvertX.TabIndex = 0;
			this.chkInvertX.Text = "Invert X";
			this.chkInvertX.UseVisualStyleBackColor = true;
			this.chkInvertX.CheckedChanged += new global::System.EventHandler(this.chkInvertX_CheckedChanged);
			this.chkInvertY.AutoSize = true;
			this.chkInvertY.Location = new global::System.Drawing.Point(82, 85);
			this.chkInvertY.Name = "chkInvertY";
			this.chkInvertY.Size = new global::System.Drawing.Size(63, 17);
			this.chkInvertY.TabIndex = 1;
			this.chkInvertY.Text = "Invert Y";
			this.chkInvertY.UseVisualStyleBackColor = true;
			this.chkInvertY.CheckedChanged += new global::System.EventHandler(this.chkInvertY_CheckedChanged);
			this.notifiyIcon.BalloonTipTitle = "Mouse Inverter";
			this.notifiyIcon.ContextMenuStrip = this.notifyMenu;
			this.notifiyIcon.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("notifiyIcon.Icon");
			this.notifiyIcon.Text = "Mouse Inverter";
			this.notifiyIcon.Visible = true;
			this.notifiyIcon.DoubleClick += new global::System.EventHandler(this.notifiyIcon_DoubleClick);
			this.notifyMenu.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.tsmiInvertX, this.tsmiInvertY });
			this.notifyMenu.Name = "notifyMenu";
			this.notifyMenu.Size = new global::System.Drawing.Size(115, 48);
			this.tsmiInvertX.CheckOnClick = true;
			this.tsmiInvertX.Name = "tsmiInvertX";
			this.tsmiInvertX.Size = new global::System.Drawing.Size(114, 22);
			this.tsmiInvertX.Text = "Invert X";
			this.tsmiInvertX.Click += new global::System.EventHandler(this.tsmiInvertX_Click);
			this.tsmiInvertY.CheckOnClick = true;
			this.tsmiInvertY.Name = "tsmiInvertY";
			this.tsmiInvertY.Size = new global::System.Drawing.Size(114, 22);
			this.tsmiInvertY.Text = "Invert Y";
			this.tsmiInvertY.Click += new global::System.EventHandler(this.tsmiInvertY_Click);
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblTitle.Location = new global::System.Drawing.Point(12, 9);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new global::System.Drawing.Size(202, 13);
			this.lblTitle.TabIndex = 3;
			this.lblTitle.Text = "Mouse Inverter v1.1 by Polynomial";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(226, 123);
			base.Controls.Add(this.chkInvertY);
			base.Controls.Add(this.lblTitle);
			base.Controls.Add(this.chkInvertX);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.Name = "MainForm";
			this.Text = "Mouse Inverter";
			base.Load += new global::System.EventHandler(this.MainForm_Load);
			base.LocationChanged += new global::System.EventHandler(this.MainForm_LocationChanged);
			this.notifyMenu.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private global::System.ComponentModel.IContainer components;

		private global::System.Windows.Forms.CheckBox chkInvertX;

		private global::System.Windows.Forms.CheckBox chkInvertY;

		private global::System.Windows.Forms.NotifyIcon notifiyIcon;

		private global::System.Windows.Forms.ContextMenuStrip notifyMenu;

		private global::System.Windows.Forms.ToolStripMenuItem tsmiInvertX;

		private global::System.Windows.Forms.ToolStripMenuItem tsmiInvertY;

		private global::System.Windows.Forms.Label lblTitle;
	}
}
