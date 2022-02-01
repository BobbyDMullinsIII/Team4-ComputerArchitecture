using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team4_Project1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initiates assemble process into machine code
        /// </summary>
        /// <param name="sender">object that raised the event (auto-generated, unused here)</param>
        /// <param name="e">arguments for event (auto-generated, unused here)</param>
        private void assembleButton_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Initiates disassemble process into assembly language instruction set
        /// </summary>
        /// <param name="sender">object that raised the event (auto-generated, unused here)</param>
        /// <param name="e">arguments for event (auto-generated, unused here)</param>
        private void disassembleButton_Click(object sender, EventArgs e)
        {
            ProgramController.disassemble();
        }

        /// <summary>
        /// Opens instruction set information
        /// </summary>
        /// <param name="sender">object that raised the event (auto-generated, unused here)</param>
        /// <param name="e">arguments for event (auto-generated, unused here)</param>
        private void instructionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProgramController.openInformation();
        }
    }
}
