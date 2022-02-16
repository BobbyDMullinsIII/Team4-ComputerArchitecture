///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  Team4_Project2/Team4_Project2
//	File Name:         MainForm.cs
//	Description:       MainForm class for program GUI
//	Course:            CSCI-4717-201 - Comp Architecture
//	Authors:           Zachary Lykins, lykinsz@etsu.edu            
//	                   Bobby Mullins, mullinsbd@etsu.edu
//	                   Christopher Poteet, poteetc1@etsu.edu
//	                   William Simmons, simmonswa@etsu.edu
//                     Isaiah Jayne, jaynei@etsu.edu
//	Created:           Monday, February  14, 2022
//	Copyright:         Team 4
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Windows.Forms;


namespace Team4_Project2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        #region Assemble Button
        /// <summary>
        /// Initiates assemble process into machine code
        /// </summary>
        /// <param name="sender">object that raised the event (auto-generated, unused here)</param>
        /// <param name="e">arguments for event (auto-generated, unused here)</param>
        private void assembleButton_Click(object sender, EventArgs e)
        {
            machineTextBox.Text = "";//Clears machine code text box before assembling
            machineTextBox.Text = ProgramController.assemble(assemblyTextBox.Text);
        }
        #endregion

        #region Disassemble Button
        /// <summary>
        /// Initiates disassemble process into assembly language instruction set
        /// </summary>
        /// <param name="sender">object that raised the event (auto-generated, unused here)</param>
        /// <param name="e">arguments for event (auto-generated, unused here)</param>
        private void disassembleButton_Click(object sender, EventArgs e)
        {
            assemblyTextBox.Text = "";//Clears assembly text box before disassembling
            assemblyTextBox.Text = ProgramController.disassemble(machineTextBox.Text);
        }
        #endregion

        #region Information Dropdown Menu Button
        /// <summary>
        /// Opens instruction set information
        /// </summary>
        /// <param name="sender">object that raised the event (auto-generated, unused here)</param>
        /// <param name="e">arguments for event (auto-generated, unused here)</param>
        private void instructionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProgramController.openInformation();
        }
        #endregion

        #region Clear Buttons
        /// <summary>
        /// Clears machine code text box
        /// </summary>
        /// <param name="sender">object that raised the event (auto-generated, unused here)</param>
        /// <param name="e">arguments for event (auto-generated, unused here)</param>
        private void clearMachineCodeButton_Click(object sender, EventArgs e)
        {
            machineTextBox.Text = "";
        }

        /// <summary>
        /// Clears assembly language text box
        /// </summary>
        /// <param name="sender">object that raised the event (auto-generated, unused here)</param>
        /// <param name="e">arguments for event (auto-generated, unused here)</param>
        private void clearAssemblyButton_Click(object sender, EventArgs e)
        {
            assemblyTextBox.Text = "";
        }
        #endregion

        #region Save Buttons
        /// <summary>
        /// Saves content inside of machine code text box into a file
        /// </summary>
        /// <param name="sender">object that raised the event (auto-generated, unused here)</param>
        /// <param name="e">arguments for event (auto-generated, unused here)</param>
        private void saveMachineCodeButton_Click(object sender, EventArgs e)
        {
            ProgramController.saveFile(machineTextBox.Text);
        }

        /// <summary>
        /// Saves content inside of assembly language text box into a file
        /// </summary>
        /// <param name="sender">object that raised the event (auto-generated, unused here)</param>
        /// <param name="e">arguments for event (auto-generated, unused here)</param>
        private void saveAssemblyButton_Click(object sender, EventArgs e)
        {
            ProgramController.saveFile(assemblyTextBox.Text);
        }
        #endregion

        #region Load Buttons
        /// <summary>
        /// Loads content from file to machine code text box
        /// </summary>
        /// <param name="sender">object that raised the event (auto-generated, unused here)</param>
        /// <param name="e">arguments for event (auto-generated, unused here)</param>
        private void loadMachineCodeButton_Click(object sender, EventArgs e)
        {
            machineTextBox.Text = ProgramController.openFile();
        }

        /// <summary>
        /// Loads content from file to assembly language text box
        /// </summary>
        /// <param name="sender">object that raised the event (auto-generated, unused here)</param>
        /// <param name="e">arguments for event (auto-generated, unused here)</param>
        private void loadAssemblyButton_Click(object sender, EventArgs e)
        {
            assemblyTextBox.Text = ProgramController.openFile();
        }
        #endregion
    }
}
