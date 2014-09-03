namespace Pinger
{
    partial class PingControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PingTargetBox = new System.Windows.Forms.TextBox();
            this.PingButton = new System.Windows.Forms.Button();
            this.DeletePingButton = new System.Windows.Forms.Button();
            this.PingResponseLabel = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.onErrorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onSuccessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alertActionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playSoundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendMailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PingTargetBox
            // 
            this.PingTargetBox.Location = new System.Drawing.Point(3, 3);
            this.PingTargetBox.Name = "PingTargetBox";
            this.PingTargetBox.Size = new System.Drawing.Size(154, 20);
            this.PingTargetBox.TabIndex = 0;
            // 
            // PingButton
            // 
            this.PingButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PingButton.Location = new System.Drawing.Point(163, 0);
            this.PingButton.Name = "PingButton";
            this.PingButton.Size = new System.Drawing.Size(61, 26);
            this.PingButton.TabIndex = 1;
            this.PingButton.Text = "Start";
            this.PingButton.UseVisualStyleBackColor = true;
            this.PingButton.Click += new System.EventHandler(this.PingButton_Click);
            // 
            // DeletePingButton
            // 
            this.DeletePingButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeletePingButton.Location = new System.Drawing.Point(492, -1);
            this.DeletePingButton.Name = "DeletePingButton";
            this.DeletePingButton.Size = new System.Drawing.Size(62, 26);
            this.DeletePingButton.TabIndex = 2;
            this.DeletePingButton.Text = "Delete";
            this.DeletePingButton.UseVisualStyleBackColor = true;
            this.DeletePingButton.Click += new System.EventHandler(this.DeletePingButton_Click);
            // 
            // PingResponseLabel
            // 
            this.PingResponseLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PingResponseLabel.Location = new System.Drawing.Point(231, 3);
            this.PingResponseLabel.MaximumSize = new System.Drawing.Size(240, 26);
            this.PingResponseLabel.MinimumSize = new System.Drawing.Size(240, 20);
            this.PingResponseLabel.Name = "PingResponseLabel";
            this.PingResponseLabel.ReadOnly = true;
            this.PingResponseLabel.Size = new System.Drawing.Size(240, 13);
            this.PingResponseLabel.TabIndex = 4;
            this.PingResponseLabel.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.alertActionToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 70);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onErrorToolStripMenuItem,
            this.onSuccessToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem1.Text = "Alert";
            // 
            // onErrorToolStripMenuItem
            // 
            this.onErrorToolStripMenuItem.CheckOnClick = true;
            this.onErrorToolStripMenuItem.Name = "onErrorToolStripMenuItem";
            this.onErrorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.onErrorToolStripMenuItem.Text = "On Error";
            // 
            // onSuccessToolStripMenuItem
            // 
            this.onSuccessToolStripMenuItem.CheckOnClick = true;
            this.onSuccessToolStripMenuItem.Name = "onSuccessToolStripMenuItem";
            this.onSuccessToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.onSuccessToolStripMenuItem.Text = "On Success";
            // 
            // alertActionToolStripMenuItem
            // 
            this.alertActionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playSoundToolStripMenuItem,
            this.sendMailToolStripMenuItem});
            this.alertActionToolStripMenuItem.Name = "alertActionToolStripMenuItem";
            this.alertActionToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.alertActionToolStripMenuItem.Text = "Alert Action";
            // 
            // playSoundToolStripMenuItem
            // 
            this.playSoundToolStripMenuItem.CheckOnClick = true;
            this.playSoundToolStripMenuItem.Name = "playSoundToolStripMenuItem";
            this.playSoundToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.playSoundToolStripMenuItem.Text = "Play Sound";
            // 
            // sendMailToolStripMenuItem
            // 
            this.sendMailToolStripMenuItem.CheckOnClick = true;
            this.sendMailToolStripMenuItem.Name = "sendMailToolStripMenuItem";
            this.sendMailToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sendMailToolStripMenuItem.Text = "Send Mail";
            // 
            // PingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.PingResponseLabel);
            this.Controls.Add(this.DeletePingButton);
            this.Controls.Add(this.PingButton);
            this.Controls.Add(this.PingTargetBox);
            this.Name = "PingControl";
            this.Size = new System.Drawing.Size(557, 26);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PingTargetBox;
        private System.Windows.Forms.Button PingButton;
        private System.Windows.Forms.Button DeletePingButton;
        private System.Windows.Forms.TextBox PingResponseLabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem onErrorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onSuccessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alertActionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playSoundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendMailToolStripMenuItem;
    }
}
