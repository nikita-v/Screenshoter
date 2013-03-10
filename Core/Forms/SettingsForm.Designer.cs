namespace Core.Forms
{
    partial class SettingsForm
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
            System.Windows.Forms.GroupBox fileNameGroupBox;
            System.Windows.Forms.Label filenamePatternLabel;
            System.Windows.Forms.GroupBox selectedAreaGroupBox;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label borderColorLabel;
            System.Windows.Forms.Label backgroundColorLabel;
            System.Windows.Forms.GroupBox paintingGroupBox;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label penWidthLabel;
            System.Windows.Forms.Label penColorLabel;
            this.filenamePatternTextBox = new System.Windows.Forms.TextBox();
            this.borderAlpha = new System.Windows.Forms.NumericUpDown();
            this.penAlpha = new System.Windows.Forms.NumericUpDown();
            this.penWidthTextBox = new System.Windows.Forms.NumericUpDown();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.generalPage = new System.Windows.Forms.TabPage();
            this.modulesPage = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.moduleUrl = new System.Windows.Forms.LinkLabel();
            this.moduleVersion = new System.Windows.Forms.Label();
            this.moduleAuthor = new System.Windows.Forms.Label();
            this.moduleDescription = new System.Windows.Forms.Label();
            this.moduleName = new System.Windows.Forms.Label();
            this.moduleSettingsButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.modulesList = new System.Windows.Forms.CheckedListBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.penColorView = new Core.Controls.ColorViewControl();
            this.borderColorView = new Core.Controls.ColorViewControl();
            this.backgroundColorView = new Core.Controls.ColorViewControl();
            fileNameGroupBox = new System.Windows.Forms.GroupBox();
            filenamePatternLabel = new System.Windows.Forms.Label();
            selectedAreaGroupBox = new System.Windows.Forms.GroupBox();
            label7 = new System.Windows.Forms.Label();
            borderColorLabel = new System.Windows.Forms.Label();
            backgroundColorLabel = new System.Windows.Forms.Label();
            paintingGroupBox = new System.Windows.Forms.GroupBox();
            label8 = new System.Windows.Forms.Label();
            penWidthLabel = new System.Windows.Forms.Label();
            penColorLabel = new System.Windows.Forms.Label();
            fileNameGroupBox.SuspendLayout();
            selectedAreaGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.borderAlpha)).BeginInit();
            paintingGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.penAlpha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.penWidthTextBox)).BeginInit();
            this.tabControl.SuspendLayout();
            this.generalPage.SuspendLayout();
            this.modulesPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileNameGroupBox
            // 
            fileNameGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            fileNameGroupBox.Controls.Add(this.filenamePatternTextBox);
            fileNameGroupBox.Controls.Add(filenamePatternLabel);
            fileNameGroupBox.Location = new System.Drawing.Point(6, 6);
            fileNameGroupBox.Name = "fileNameGroupBox";
            fileNameGroupBox.Size = new System.Drawing.Size(290, 47);
            fileNameGroupBox.TabIndex = 0;
            fileNameGroupBox.TabStop = false;
            fileNameGroupBox.Text = "Filename";
            // 
            // filenamePatternTextBox
            // 
            this.filenamePatternTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filenamePatternTextBox.Location = new System.Drawing.Point(109, 17);
            this.filenamePatternTextBox.Name = "filenamePatternTextBox";
            this.filenamePatternTextBox.Size = new System.Drawing.Size(175, 20);
            this.filenamePatternTextBox.TabIndex = 1;
            // 
            // filenamePatternLabel
            // 
            filenamePatternLabel.AutoSize = true;
            filenamePatternLabel.Location = new System.Drawing.Point(6, 20);
            filenamePatternLabel.Name = "filenamePatternLabel";
            filenamePatternLabel.Size = new System.Drawing.Size(88, 13);
            filenamePatternLabel.TabIndex = 0;
            filenamePatternLabel.Text = "Filename pattern:";
            // 
            // selectedAreaGroupBox
            // 
            selectedAreaGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            selectedAreaGroupBox.Controls.Add(label7);
            selectedAreaGroupBox.Controls.Add(this.borderAlpha);
            selectedAreaGroupBox.Controls.Add(this.borderColorView);
            selectedAreaGroupBox.Controls.Add(this.backgroundColorView);
            selectedAreaGroupBox.Controls.Add(borderColorLabel);
            selectedAreaGroupBox.Controls.Add(backgroundColorLabel);
            selectedAreaGroupBox.Location = new System.Drawing.Point(6, 59);
            selectedAreaGroupBox.Name = "selectedAreaGroupBox";
            selectedAreaGroupBox.Size = new System.Drawing.Size(290, 76);
            selectedAreaGroupBox.TabIndex = 1;
            selectedAreaGroupBox.TabStop = false;
            selectedAreaGroupBox.Text = "Selected area";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(197, 51);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(37, 13);
            label7.TabIndex = 11;
            label7.Text = "Alpha:";
            // 
            // borderAlpha
            // 
            this.borderAlpha.Location = new System.Drawing.Point(240, 47);
            this.borderAlpha.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.borderAlpha.Name = "borderAlpha";
            this.borderAlpha.Size = new System.Drawing.Size(44, 20);
            this.borderAlpha.TabIndex = 10;
            // 
            // borderColorLabel
            // 
            borderColorLabel.AutoSize = true;
            borderColorLabel.Location = new System.Drawing.Point(6, 49);
            borderColorLabel.Name = "borderColorLabel";
            borderColorLabel.Size = new System.Drawing.Size(67, 13);
            borderColorLabel.TabIndex = 3;
            borderColorLabel.Text = "Border color:";
            // 
            // backgroundColorLabel
            // 
            backgroundColorLabel.AutoSize = true;
            backgroundColorLabel.Location = new System.Drawing.Point(6, 23);
            backgroundColorLabel.Name = "backgroundColorLabel";
            backgroundColorLabel.Size = new System.Drawing.Size(97, 13);
            backgroundColorLabel.TabIndex = 0;
            backgroundColorLabel.Text = "Background color: ";
            // 
            // paintingGroupBox
            // 
            paintingGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            paintingGroupBox.Controls.Add(label8);
            paintingGroupBox.Controls.Add(this.penAlpha);
            paintingGroupBox.Controls.Add(this.penColorView);
            paintingGroupBox.Controls.Add(this.penWidthTextBox);
            paintingGroupBox.Controls.Add(penWidthLabel);
            paintingGroupBox.Controls.Add(penColorLabel);
            paintingGroupBox.Location = new System.Drawing.Point(6, 141);
            paintingGroupBox.Name = "paintingGroupBox";
            paintingGroupBox.Size = new System.Drawing.Size(290, 74);
            paintingGroupBox.TabIndex = 2;
            paintingGroupBox.TabStop = false;
            paintingGroupBox.Text = "Painting";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(197, 24);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(37, 13);
            label8.TabIndex = 11;
            label8.Text = "Alpha:";
            // 
            // penAlpha
            // 
            this.penAlpha.Location = new System.Drawing.Point(240, 20);
            this.penAlpha.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.penAlpha.Name = "penAlpha";
            this.penAlpha.Size = new System.Drawing.Size(44, 20);
            this.penAlpha.TabIndex = 10;
            // 
            // penWidthTextBox
            // 
            this.penWidthTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.penWidthTextBox.Location = new System.Drawing.Point(109, 46);
            this.penWidthTextBox.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.penWidthTextBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.penWidthTextBox.Name = "penWidthTextBox";
            this.penWidthTextBox.Size = new System.Drawing.Size(175, 20);
            this.penWidthTextBox.TabIndex = 4;
            this.penWidthTextBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // penWidthLabel
            // 
            penWidthLabel.AutoSize = true;
            penWidthLabel.Location = new System.Drawing.Point(6, 48);
            penWidthLabel.Name = "penWidthLabel";
            penWidthLabel.Size = new System.Drawing.Size(57, 13);
            penWidthLabel.TabIndex = 3;
            penWidthLabel.Text = "Pen width:";
            // 
            // penColorLabel
            // 
            penColorLabel.AutoSize = true;
            penColorLabel.Location = new System.Drawing.Point(6, 22);
            penColorLabel.Name = "penColorLabel";
            penColorLabel.Size = new System.Drawing.Size(55, 13);
            penColorLabel.TabIndex = 2;
            penColorLabel.Text = "Pen color:";
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.generalPage);
            this.tabControl.Controls.Add(this.modulesPage);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(310, 264);
            this.tabControl.TabIndex = 0;
            // 
            // generalPage
            // 
            this.generalPage.Controls.Add(paintingGroupBox);
            this.generalPage.Controls.Add(selectedAreaGroupBox);
            this.generalPage.Controls.Add(fileNameGroupBox);
            this.generalPage.Location = new System.Drawing.Point(4, 22);
            this.generalPage.Name = "generalPage";
            this.generalPage.Padding = new System.Windows.Forms.Padding(3);
            this.generalPage.Size = new System.Drawing.Size(302, 238);
            this.generalPage.TabIndex = 0;
            this.generalPage.Text = "General settings";
            this.generalPage.UseVisualStyleBackColor = true;
            // 
            // modulesPage
            // 
            this.modulesPage.Controls.Add(this.groupBox1);
            this.modulesPage.Controls.Add(this.modulesList);
            this.modulesPage.Location = new System.Drawing.Point(4, 22);
            this.modulesPage.Name = "modulesPage";
            this.modulesPage.Padding = new System.Windows.Forms.Padding(3);
            this.modulesPage.Size = new System.Drawing.Size(302, 238);
            this.modulesPage.TabIndex = 1;
            this.modulesPage.Text = "Modules";
            this.modulesPage.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.moduleUrl);
            this.groupBox1.Controls.Add(this.moduleVersion);
            this.groupBox1.Controls.Add(this.moduleAuthor);
            this.groupBox1.Controls.Add(this.moduleDescription);
            this.groupBox1.Controls.Add(this.moduleName);
            this.groupBox1.Controls.Add(this.moduleSettingsButton);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 127);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Module info";
            // 
            // moduleUrl
            // 
            this.moduleUrl.AutoSize = true;
            this.moduleUrl.Location = new System.Drawing.Point(78, 108);
            this.moduleUrl.Name = "moduleUrl";
            this.moduleUrl.Size = new System.Drawing.Size(0, 13);
            this.moduleUrl.TabIndex = 10;
            // 
            // moduleVersion
            // 
            this.moduleVersion.AutoSize = true;
            this.moduleVersion.Location = new System.Drawing.Point(78, 85);
            this.moduleVersion.Name = "moduleVersion";
            this.moduleVersion.Size = new System.Drawing.Size(0, 13);
            this.moduleVersion.TabIndex = 9;
            // 
            // moduleAuthor
            // 
            this.moduleAuthor.AutoSize = true;
            this.moduleAuthor.Location = new System.Drawing.Point(78, 61);
            this.moduleAuthor.Name = "moduleAuthor";
            this.moduleAuthor.Size = new System.Drawing.Size(0, 13);
            this.moduleAuthor.TabIndex = 8;
            // 
            // moduleDescription
            // 
            this.moduleDescription.AutoSize = true;
            this.moduleDescription.Location = new System.Drawing.Point(78, 38);
            this.moduleDescription.Name = "moduleDescription";
            this.moduleDescription.Size = new System.Drawing.Size(0, 13);
            this.moduleDescription.TabIndex = 7;
            // 
            // moduleName
            // 
            this.moduleName.AutoSize = true;
            this.moduleName.Location = new System.Drawing.Point(78, 16);
            this.moduleName.Name = "moduleName";
            this.moduleName.Size = new System.Drawing.Size(0, 13);
            this.moduleName.TabIndex = 6;
            // 
            // moduleSettingsButton
            // 
            this.moduleSettingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.moduleSettingsButton.Enabled = false;
            this.moduleSettingsButton.Location = new System.Drawing.Point(181, 98);
            this.moduleSettingsButton.Name = "moduleSettingsButton";
            this.moduleSettingsButton.Size = new System.Drawing.Size(103, 23);
            this.moduleSettingsButton.TabIndex = 5;
            this.moduleSettingsButton.Text = "Module settings";
            this.moduleSettingsButton.UseVisualStyleBackColor = true;
            this.moduleSettingsButton.Click += new System.EventHandler(this.ModuleSettingsButtonClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Url: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Version: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Author: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name: ";
            // 
            // modulesList
            // 
            this.modulesList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modulesList.FormattingEnabled = true;
            this.modulesList.Location = new System.Drawing.Point(6, 6);
            this.modulesList.Name = "modulesList";
            this.modulesList.Size = new System.Drawing.Size(290, 79);
            this.modulesList.TabIndex = 0;
            this.modulesList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ModulesListItemCheck);
            this.modulesList.SelectedIndexChanged += new System.EventHandler(this.ModulesListSelectionChanged);
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Location = new System.Drawing.Point(163, 282);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 5;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.OkButtonClick);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(244, 282);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButtonClick);
            // 
            // penColorView
            // 
            this.penColorView.CurrentColor = System.Drawing.Color.Empty;
            this.penColorView.Location = new System.Drawing.Point(109, 20);
            this.penColorView.Name = "penColorView";
            this.penColorView.Size = new System.Drawing.Size(82, 20);
            this.penColorView.TabIndex = 5;
            this.penColorView.Click += new System.EventHandler(this.SelectColorButtonClick);
            // 
            // borderColorView
            // 
            this.borderColorView.CurrentColor = System.Drawing.Color.Empty;
            this.borderColorView.Location = new System.Drawing.Point(109, 47);
            this.borderColorView.Name = "borderColorView";
            this.borderColorView.Size = new System.Drawing.Size(82, 20);
            this.borderColorView.TabIndex = 7;
            this.borderColorView.Click += new System.EventHandler(this.SelectColorButtonClick);
            // 
            // backgroundColorView
            // 
            this.backgroundColorView.CurrentColor = System.Drawing.Color.Empty;
            this.backgroundColorView.Location = new System.Drawing.Point(109, 19);
            this.backgroundColorView.Name = "backgroundColorView";
            this.backgroundColorView.Size = new System.Drawing.Size(175, 20);
            this.backgroundColorView.TabIndex = 6;
            this.backgroundColorView.Click += new System.EventHandler(this.SelectColorButtonClick);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.tabControl);
            this.MinimumSize = new System.Drawing.Size(350, 350);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            fileNameGroupBox.ResumeLayout(false);
            fileNameGroupBox.PerformLayout();
            selectedAreaGroupBox.ResumeLayout(false);
            selectedAreaGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.borderAlpha)).EndInit();
            paintingGroupBox.ResumeLayout(false);
            paintingGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.penAlpha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.penWidthTextBox)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.generalPage.ResumeLayout(false);
            this.modulesPage.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage generalPage;
        private System.Windows.Forms.TabPage modulesPage;
        private System.Windows.Forms.CheckedListBox modulesList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button moduleSettingsButton;
        private System.Windows.Forms.LinkLabel moduleUrl;
        private System.Windows.Forms.Label moduleVersion;
        private System.Windows.Forms.Label moduleAuthor;
        private System.Windows.Forms.Label moduleDescription;
        private System.Windows.Forms.Label moduleName;
        private System.Windows.Forms.TextBox filenamePatternTextBox;
        private System.Windows.Forms.NumericUpDown penWidthTextBox;
        private Controls.ColorViewControl borderColorView;
        private Controls.ColorViewControl backgroundColorView;
        private Controls.ColorViewControl penColorView;
        private System.Windows.Forms.NumericUpDown borderAlpha;
        private System.Windows.Forms.NumericUpDown penAlpha;
    }
}