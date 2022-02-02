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
			this.decodeButton = new System.Windows.Forms.Button();
			this.encodeButton = new System.Windows.Forms.Button();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolstripFile = new System.Windows.Forms.ToolStripDropDownButton();
			this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.encodedLabel = new System.Windows.Forms.Label();
			this.decodedLabel = new System.Windows.Forms.Label();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textInput
			// 
			resources.ApplyResources(this.textInput, "textInput");
			this.textInput.Name = "textInput";
			// 
			// textOutput
			// 
			resources.ApplyResources(this.textOutput, "textOutput");
			this.textOutput.Name = "textOutput";
			this.textOutput.ReadOnly = true;
			// 
			// decodeButton
			// 
			resources.ApplyResources(this.decodeButton, "decodeButton");
			this.decodeButton.Name = "decodeButton";
			this.decodeButton.UseVisualStyleBackColor = true;
			// 
			// encodeButton
			// 
			resources.ApplyResources(this.encodeButton, "encodeButton");
			this.encodeButton.Name = "encodeButton";
			this.encodeButton.UseVisualStyleBackColor = true;
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
            this.openFileToolStripMenuItem});
			resources.ApplyResources(this.toolstripFile, "toolstripFile");
			this.toolstripFile.Name = "toolstripFile";
			// 
			// openFileToolStripMenuItem
			// 
			this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
			resources.ApplyResources(this.openFileToolStripMenuItem, "openFileToolStripMenuItem");
			this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
			// 
			// encodedLabel
			// 
			resources.ApplyResources(this.encodedLabel, "encodedLabel");
			this.encodedLabel.ForeColor = System.Drawing.SystemColors.ControlText;
			this.encodedLabel.Name = "encodedLabel";
			// 
			// decodedLabel
			// 
			resources.ApplyResources(this.decodedLabel, "decodedLabel");
			this.decodedLabel.Name = "decodedLabel";
			// 
			// MainForm
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.decodedLabel);
			this.Controls.Add(this.encodedLabel);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.encodeButton);
			this.Controls.Add(this.decodeButton);
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
		private System.Windows.Forms.Button decodeButton;
		private System.Windows.Forms.Button encodeButton;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripDropDownButton toolstripFile;
		private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
		private System.Windows.Forms.Label encodedLabel;
		private System.Windows.Forms.Label decodedLabel;
	}
}

