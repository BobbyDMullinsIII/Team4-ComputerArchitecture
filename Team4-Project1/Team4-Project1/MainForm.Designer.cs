namespace Team4_Project1
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.textInput = new System.Windows.Forms.TextBox();
            this.textOutput = new System.Windows.Forms.TextBox();
            this.disassembleButton = new System.Windows.Forms.Button();
            this.assembleButton = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolstripFile = new System.Windows.Forms.ToolStripDropDownButton();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.machineCodeLabel = new System.Windows.Forms.Label();
            this.assemblyLanguageLabel = new System.Windows.Forms.Label();
            this.instructionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textInput
            // 
            this.textInput.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.textInput, "textInput");
            this.textInput.Name = "textInput";
            // 
            // textOutput
            // 
            this.textOutput.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.textOutput, "textOutput");
            this.textOutput.Name = "textOutput";
            this.textOutput.ReadOnly = true;
            // 
            // disassembleButton
            // 
            this.disassembleButton.BackColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this.disassembleButton, "disassembleButton");
            this.disassembleButton.ForeColor = System.Drawing.Color.Black;
            this.disassembleButton.Name = "disassembleButton";
            this.disassembleButton.UseVisualStyleBackColor = false;
            this.disassembleButton.Click += new System.EventHandler(this.disassembleButton_Click);
            // 
            // assembleButton
            // 
            this.assembleButton.BackColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this.assembleButton, "assembleButton");
            this.assembleButton.ForeColor = System.Drawing.Color.Black;
            this.assembleButton.Name = "assembleButton";
            this.assembleButton.UseVisualStyleBackColor = false;
            this.assembleButton.Click += new System.EventHandler(this.assembleButton_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstripFile});
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.Name = "toolStrip1";
            // 
            // toolstripFile
            // 
            this.toolstripFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolstripFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.instructionsToolStripMenuItem});
            resources.ApplyResources(this.toolstripFile, "toolstripFile");
            this.toolstripFile.Name = "toolstripFile";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            resources.ApplyResources(this.openFileToolStripMenuItem, "openFileToolStripMenuItem");
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // machineCodeLabel
            // 
            resources.ApplyResources(this.machineCodeLabel, "machineCodeLabel");
            this.machineCodeLabel.BackColor = System.Drawing.Color.Black;
            this.machineCodeLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.machineCodeLabel.ForeColor = System.Drawing.Color.White;
            this.machineCodeLabel.Name = "machineCodeLabel";
            // 
            // assemblyLanguageLabel
            // 
            resources.ApplyResources(this.assemblyLanguageLabel, "assemblyLanguageLabel");
            this.assemblyLanguageLabel.BackColor = System.Drawing.Color.Black;
            this.assemblyLanguageLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.assemblyLanguageLabel.ForeColor = System.Drawing.Color.White;
            this.assemblyLanguageLabel.Name = "assemblyLanguageLabel";
            // 
            // instructionsToolStripMenuItem
            // 
            this.instructionsToolStripMenuItem.Name = "instructionsToolStripMenuItem";
            resources.ApplyResources(this.instructionsToolStripMenuItem, "instructionsToolStripMenuItem");
            this.instructionsToolStripMenuItem.Click += new System.EventHandler(this.instructionsToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.Controls.Add(this.assemblyLanguageLabel);
            this.Controls.Add(this.machineCodeLabel);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.assembleButton);
            this.Controls.Add(this.disassembleButton);
            this.Controls.Add(this.textOutput);
            this.Controls.Add(this.textInput);
            this.Name = "MainForm";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.TextBox textInput;
		private System.Windows.Forms.TextBox textOutput;
		private System.Windows.Forms.Button disassembleButton;
		private System.Windows.Forms.Button assembleButton;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripDropDownButton toolstripFile;
		private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
		private System.Windows.Forms.Label machineCodeLabel;
		private System.Windows.Forms.Label assemblyLanguageLabel;
        private System.Windows.Forms.ToolStripMenuItem instructionsToolStripMenuItem;
    }
}

