namespace Pinger
{
    partial class PingTarget
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
            this.PingTargetBox = new System.Windows.Forms.TextBox();
            this.PingButton = new System.Windows.Forms.Button();
            this.PingResponseLabel = new System.Windows.Forms.Label();
            this.DeletePingButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PingTargetBox
            // 
            this.PingTargetBox.Location = new System.Drawing.Point(3, 3);
            this.PingTargetBox.Name = "PingTargetBox";
            this.PingTargetBox.Size = new System.Drawing.Size(200, 20);
            this.PingTargetBox.TabIndex = 0;
            // 
            // PingButton
            // 
            this.PingButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PingButton.Location = new System.Drawing.Point(223, 0);
            this.PingButton.Name = "PingButton";
            this.PingButton.Size = new System.Drawing.Size(61, 26);
            this.PingButton.TabIndex = 1;
            this.PingButton.Text = "Start";
            this.PingButton.UseVisualStyleBackColor = true;
            this.PingButton.Click += new System.EventHandler(this.PingButton_Click);
            // 
            // PingResponseLabel
            // 
            this.PingResponseLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PingResponseLabel.Location = new System.Drawing.Point(306, 0);
            this.PingResponseLabel.Name = "PingResponseLabel";
            this.PingResponseLabel.Size = new System.Drawing.Size(319, 26);
            this.PingResponseLabel.TabIndex = 2;
            this.PingResponseLabel.Text = " ";
            this.PingResponseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DeletePingButton
            // 
            this.DeletePingButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeletePingButton.Location = new System.Drawing.Point(631, 0);
            this.DeletePingButton.Name = "DeletePingButton";
            this.DeletePingButton.Size = new System.Drawing.Size(61, 26);
            this.DeletePingButton.TabIndex = 3;
            this.DeletePingButton.Text = "Delete";
            this.DeletePingButton.UseVisualStyleBackColor = true;
            this.DeletePingButton.Click += new System.EventHandler(this.DeletePingButton_Click);
            // 
            // PingTarget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DeletePingButton);
            this.Controls.Add(this.PingResponseLabel);
            this.Controls.Add(this.PingButton);
            this.Controls.Add(this.PingTargetBox);
            this.Name = "PingTarget";
            this.Size = new System.Drawing.Size(695, 26);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PingTargetBox;
        private System.Windows.Forms.Button PingButton;
        private System.Windows.Forms.Label PingResponseLabel;
        private System.Windows.Forms.Button DeletePingButton;
    }
}
