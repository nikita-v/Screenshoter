namespace Core.Forms
{
    partial class EditScreenshotForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.screenshotControl = new Core.Controls.ScreenshotControl();
            ((System.ComponentModel.ISupportInitialize)(this.screenshotControl)).BeginInit();
            this.SuspendLayout();
            // 
            // screenshotControl
            // 
            this.screenshotControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.screenshotControl.Location = new System.Drawing.Point(0, 0);
            this.screenshotControl.Name = "screenshotControl";
            this.screenshotControl.Size = new System.Drawing.Size(300, 300);
            this.screenshotControl.TabIndex = 0;
            this.screenshotControl.TabStop = false;
            // 
            // EditScreenshotForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.screenshotControl);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditScreenshotForm";
            this.Text = "EditScreenshotForm";
            this.TopMost = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EditScreenshotFormKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.screenshotControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ScreenshotControl screenshotControl;

    }
}