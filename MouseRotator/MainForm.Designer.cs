namespace MouseRotator
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
            this.lblOriginalTitle = new System.Windows.Forms.Label();
            this.lblOriginalDisclaimer = new System.Windows.Forms.Label();
            this.lblWinText1 = new System.Windows.Forms.Label();
            this.lblHotkey1 = new System.Windows.Forms.Label();
            this.lblWinText2 = new System.Windows.Forms.Label();
            this.lblHotkey2 = new System.Windows.Forms.Label();
            this.notifyMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkRotate90
            // 
            this.chkRotate90.AutoSize = true;
            this.chkRotate90.Location = new System.Drawing.Point(95, 62);
            this.chkRotate90.Margin = new System.Windows.Forms.Padding(6);
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
            this.chkRotate270.Location = new System.Drawing.Point(95, 158);
            this.chkRotate270.Margin = new System.Windows.Forms.Padding(6);
            this.chkRotate270.Name = "chkRotate270";
            this.chkRotate270.Size = new System.Drawing.Size(149, 29);
            this.chkRotate270.TabIndex = 1;
            this.chkRotate270.Text = "Rotate 270";
            this.chkRotate270.UseVisualStyleBackColor = true;
            this.chkRotate270.CheckedChanged += new System.EventHandler(this.chkRotate270_CheckedChanged);
            // 
            // notifiyIcon
            // 
            this.notifiyIcon.BalloonTipTitle = "Mouse Rotator";
            this.notifiyIcon.ContextMenuStrip = this.notifyMenu;
            this.notifiyIcon.Text = "Mouse Rotator";
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
            this.notifyMenu.Size = new System.Drawing.Size(203, 80);
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
            this.lblTitle.Size = new System.Drawing.Size(405, 26);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Mouse Rotator v1.0 by QuillOfQuinn*";
            // 
            // lblOriginalTitle
            // 
            this.lblOriginalTitle.AutoSize = true;
            this.lblOriginalTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOriginalTitle.Location = new System.Drawing.Point(90, 259);
            this.lblOriginalTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblOriginalTitle.Name = "lblOriginalTitle";
            this.lblOriginalTitle.Size = new System.Drawing.Size(379, 26);
            this.lblOriginalTitle.TabIndex = 4;
            this.lblOriginalTitle.Text = "Mouse Inverter v1.1 by Polynomial";
            // 
            // lblOriginalDisclaimer
            // 
            this.lblOriginalDisclaimer.AutoSize = true;
            this.lblOriginalDisclaimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOriginalDisclaimer.Location = new System.Drawing.Point(15, 231);
            this.lblOriginalDisclaimer.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblOriginalDisclaimer.Name = "lblOriginalDisclaimer";
            this.lblOriginalDisclaimer.Size = new System.Drawing.Size(379, 26);
            this.lblOriginalDisclaimer.TabIndex = 5;
            this.lblOriginalDisclaimer.Text = "*A Modified fork of the original project:";
            // 
            // lblWinText1
            // 
            this.lblWinText1.AutoSize = true;
            this.lblWinText1.Font = new System.Drawing.Font("Microsoft Sans Serif", 3.15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinText1.Location = new System.Drawing.Point(137, 92);
            this.lblWinText1.Margin = new System.Windows.Forms.Padding(6);
            this.lblWinText1.Name = "lblWinText1";
            this.lblWinText1.Size = new System.Drawing.Size(31, 24);
            this.lblWinText1.TabIndex = 6;
            this.lblWinText1.Text = "⬛⬛\n⬛⬛";
            // 
            // lblHotkey1
            // 
            this.lblHotkey1.AutoSize = true;
            this.lblHotkey1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHotkey1.Location = new System.Drawing.Point(166, 92);
            this.lblHotkey1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblHotkey1.Name = "lblHotkey1";
            this.lblHotkey1.Size = new System.Drawing.Size(159, 26);
            this.lblHotkey1.TabIndex = 7;
            this.lblHotkey1.Text = "+ Ctrl + Shift + Home";
            // 
            // lblWinText2
            // 
            this.lblWinText2.AutoSize = true;
            this.lblWinText2.Font = new System.Drawing.Font("Microsoft Sans Serif", 3.15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinText2.Location = new System.Drawing.Point(137, 188);
            this.lblWinText2.Margin = new System.Windows.Forms.Padding(6);
            this.lblWinText2.Name = "lblWinText2";
            this.lblWinText2.Size = new System.Drawing.Size(31, 24);
            this.lblWinText2.TabIndex = 8;
            this.lblWinText2.Text = "⬛⬛\n⬛⬛";
            // 
            // lblHotkey2
            // 
            this.lblHotkey2.AutoSize = true;
            this.lblHotkey2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHotkey2.Location = new System.Drawing.Point(166, 188);
            this.lblHotkey2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblHotkey2.Name = "lblHotkey2";
            this.lblHotkey2.Size = new System.Drawing.Size(139, 26);
            this.lblHotkey2.TabIndex = 9;
            this.lblHotkey2.Text = "+ Ctrl + Shift + End";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 308);
            this.Controls.Add(this.lblHotkey2);
            this.Controls.Add(this.lblWinText2);
            this.Controls.Add(this.lblHotkey1);
            this.Controls.Add(this.lblWinText1);
            this.Controls.Add(this.lblOriginalDisclaimer);
            this.Controls.Add(this.lblOriginalTitle);
            this.Controls.Add(this.chkRotate270);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.chkRotate90);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "MouseRotator";
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
        private global::System.Windows.Forms.Label lblOriginalTitle;
        private global::System.Windows.Forms.Label lblOriginalDisclaimer;
        private global::System.Windows.Forms.Label lblWinText1;
        private global::System.Windows.Forms.Label lblHotkey1;
        private global::System.Windows.Forms.Label lblWinText2;
        private global::System.Windows.Forms.Label lblHotkey2;
    }
}
