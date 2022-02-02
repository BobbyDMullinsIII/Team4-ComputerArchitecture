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
            this.machineTextBox = new System.Windows.Forms.TextBox();
            this.assemblyTextBox = new System.Windows.Forms.TextBox();
            this.disassembleButton = new System.Windows.Forms.Button();
            this.assembleButton = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolstripFile = new System.Windows.Forms.ToolStripDropDownButton();
            this.instructionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.machineCodeLabel = new System.Windows.Forms.Label();
            this.assemblyLanguageLabel = new System.Windows.Forms.Label();
            this.disassembleLabel = new System.Windows.Forms.Label();
            this.assembleLabell = new System.Windows.Forms.Label();
            this.clearMachineCodeButton = new System.Windows.Forms.Button();
            this.clearAssemblyButton = new System.Windows.Forms.Button();
            this.saveMachineCodeButton = new System.Windows.Forms.Button();
            this.saveAssemblyButton = new System.Windows.Forms.Button();
            this.loadMachineCodeButton = new System.Windows.Forms.Button();
            this.loadAssemblyButton = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // machineTextBox
            // 
            this.machineTextBox.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.machineTextBox, "machineTextBox");
            this.machineTextBox.Name = "machineTextBox";
            // 
            // assemblyTextBox
            // 
            this.assemblyTextBox.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.assemblyTextBox, "assemblyTextBox");
            this.assemblyTextBox.Name = "assemblyTextBox";
            this.assemblyTextBox.ReadOnly = true;
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
            this.instructionsToolStripMenuItem});
            resources.ApplyResources(this.toolstripFile, "toolstripFile");
            this.toolstripFile.Name = "toolstripFile";
            // 
            // instructionsToolStripMenuItem
            // 
            this.instructionsToolStripMenuItem.Name = "instructionsToolStripMenuItem";
            resources.ApplyResources(this.instructionsToolStripMenuItem, "instructionsToolStripMenuItem");
            this.instructionsToolStripMenuItem.Click += new System.EventHandler(this.instructionsToolStripMenuItem_Click);
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
            // disassembleLabel
            // 
            resources.ApplyResources(this.disassembleLabel, "disassembleLabel");
            this.disassembleLabel.ForeColor = System.Drawing.Color.Black;
            this.disassembleLabel.Name = "disassembleLabel";
            // 
            // assembleLabell
            // 
            resources.ApplyResources(this.assembleLabell, "assembleLabell");
            this.assembleLabell.ForeColor = System.Drawing.Color.Black;
            this.assembleLabell.Name = "assembleLabell";
            // 
            // clearMachineCodeButton
            // 
            this.clearMachineCodeButton.BackColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this.clearMachineCodeButton, "clearMachineCodeButton");
            this.clearMachineCodeButton.ForeColor = System.Drawing.Color.Black;
            this.clearMachineCodeButton.Name = "clearMachineCodeButton";
            this.clearMachineCodeButton.UseVisualStyleBackColor = false;
            this.clearMachineCodeButton.Click += new System.EventHandler(this.clearMachineCodeButton_Click);
            // 
            // clearAssemblyButton
            // 
            this.clearAssemblyButton.BackColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this.clearAssemblyButton, "clearAssemblyButton");
            this.clearAssemblyButton.ForeColor = System.Drawing.Color.Black;
            this.clearAssemblyButton.Name = "clearAssemblyButton";
            this.clearAssemblyButton.UseVisualStyleBackColor = false;
            this.clearAssemblyButton.Click += new System.EventHandler(this.clearAssemblyButton_Click);
            // 
            // saveMachineCodeButton
            // 
            this.saveMachineCodeButton.BackColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this.saveMachineCodeButton, "saveMachineCodeButton");
            this.saveMachineCodeButton.ForeColor = System.Drawing.Color.Black;
            this.saveMachineCodeButton.Name = "saveMachineCodeButton";
            this.saveMachineCodeButton.UseVisualStyleBackColor = false;
            this.saveMachineCodeButton.Click += new System.EventHandler(this.saveMachineCodeButton_Click);
            // 
            // saveAssemblyButton
            // 
            this.saveAssemblyButton.BackColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this.saveAssemblyButton, "saveAssemblyButton");
            this.saveAssemblyButton.ForeColor = System.Drawing.Color.Black;
            this.saveAssemblyButton.Name = "saveAssemblyButton";
            this.saveAssemblyButton.UseVisualStyleBackColor = false;
            this.saveAssemblyButton.Click += new System.EventHandler(this.saveAssemblyButton_Click);
            // 
            // loadMachineCodeButton
            // 
            this.loadMachineCodeButton.BackColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this.loadMachineCodeButton, "loadMachineCodeButton");
            this.loadMachineCodeButton.ForeColor = System.Drawing.Color.Black;
            this.loadMachineCodeButton.Name = "loadMachineCodeButton";
            this.loadMachineCodeButton.UseVisualStyleBackColor = false;
            this.loadMachineCodeButton.Click += new System.EventHandler(this.loadMachineCodeButton_Click);
            // 
            // loadAssemblyButton
            // 
            this.loadAssemblyButton.BackColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this.loadAssemblyButton, "loadAssemblyButton");
            this.loadAssemblyButton.ForeColor = System.Drawing.Color.Black;
            this.loadAssemblyButton.Name = "loadAssemblyButton";
            this.loadAssemblyButton.UseVisualStyleBackColor = false;
            this.loadAssemblyButton.Click += new System.EventHandler(this.loadAssemblyButton_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.Controls.Add(this.loadAssemblyButton);
            this.Controls.Add(this.loadMachineCodeButton);
            this.Controls.Add(this.saveAssemblyButton);
            this.Controls.Add(this.saveMachineCodeButton);
            this.Controls.Add(this.clearAssemblyButton);
            this.Controls.Add(this.clearMachineCodeButton);
            this.Controls.Add(this.assembleLabell);
            this.Controls.Add(this.disassembleLabel);
            this.Controls.Add(this.assemblyLanguageLabel);
            this.Controls.Add(this.machineCodeLabel);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.assembleButton);
            this.Controls.Add(this.disassembleButton);
            this.Controls.Add(this.assemblyTextBox);
            this.Controls.Add(this.machineTextBox);
            this.Name = "MainForm";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.TextBox machineTextBox;
		private System.Windows.Forms.TextBox assemblyTextBox;
		private System.Windows.Forms.Button disassembleButton;
		private System.Windows.Forms.Button assembleButton;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripDropDownButton toolstripFile;
		private System.Windows.Forms.Label machineCodeLabel;
		private System.Windows.Forms.Label assemblyLanguageLabel;
        private System.Windows.Forms.ToolStripMenuItem instructionsToolStripMenuItem;
        private System.Windows.Forms.Label disassembleLabel;
        private System.Windows.Forms.Label assembleLabell;
        private System.Windows.Forms.Button clearMachineCodeButton;
        private System.Windows.Forms.Button clearAssemblyButton;
        private System.Windows.Forms.Button saveMachineCodeButton;
        private System.Windows.Forms.Button saveAssemblyButton;
        private System.Windows.Forms.Button loadMachineCodeButton;
        private System.Windows.Forms.Button loadAssemblyButton;
    }
}

