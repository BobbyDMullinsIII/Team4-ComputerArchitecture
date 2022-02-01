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
            this.disassembleButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instructionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.assembleButton = new System.Windows.Forms.Button();
            this.loadFileButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // disassembleButton
            // 
            this.disassembleButton.BackColor = System.Drawing.Color.DimGray;
            this.disassembleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.disassembleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disassembleButton.ForeColor = System.Drawing.Color.Black;
            this.disassembleButton.Location = new System.Drawing.Point(12, 509);
            this.disassembleButton.Name = "disassembleButton";
            this.disassembleButton.Size = new System.Drawing.Size(200, 40);
            this.disassembleButton.TabIndex = 0;
            this.disassembleButton.Text = "Disassemble";
            this.disassembleButton.UseVisualStyleBackColor = false;
            this.disassembleButton.Click += new System.EventHandler(this.disassembleButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DimGray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 29);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instructionsToolStripMenuItem});
            this.menuToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(62, 25);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // instructionsToolStripMenuItem
            // 
            this.instructionsToolStripMenuItem.Name = "instructionsToolStripMenuItem";
            this.instructionsToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.instructionsToolStripMenuItem.Text = "Instructions";
            this.instructionsToolStripMenuItem.Click += new System.EventHandler(this.instructionsToolStripMenuItem_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(218, 32);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(554, 517);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // assembleButton
            // 
            this.assembleButton.BackColor = System.Drawing.Color.DimGray;
            this.assembleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.assembleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assembleButton.ForeColor = System.Drawing.Color.Black;
            this.assembleButton.Location = new System.Drawing.Point(12, 463);
            this.assembleButton.Name = "assembleButton";
            this.assembleButton.Size = new System.Drawing.Size(200, 40);
            this.assembleButton.TabIndex = 3;
            this.assembleButton.Text = "Assemble";
            this.assembleButton.UseVisualStyleBackColor = false;
            this.assembleButton.Click += new System.EventHandler(this.assembleButton_Click);
            // 
            // loadFileButton
            // 
            this.loadFileButton.BackColor = System.Drawing.Color.DimGray;
            this.loadFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadFileButton.ForeColor = System.Drawing.Color.Black;
            this.loadFileButton.Location = new System.Drawing.Point(12, 116);
            this.loadFileButton.Name = "loadFileButton";
            this.loadFileButton.Size = new System.Drawing.Size(200, 40);
            this.loadFileButton.TabIndex = 4;
            this.loadFileButton.Text = "Load File";
            this.loadFileButton.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.loadFileButton);
            this.Controls.Add(this.assembleButton);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.disassembleButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button disassembleButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instructionsToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button assembleButton;
        private System.Windows.Forms.Button loadFileButton;
    }
}

