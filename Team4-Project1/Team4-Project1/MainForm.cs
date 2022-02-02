///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  Team4_Project1/Team4_Project1
//	File Name:         ProgramController.cs
//	Description:       ProgramController class for controlling majority of program functionality
//	Course:            CSCI-4717-201 - Software Engineering I
//	Authors:           Zachary Lykins, lykinsz@etsu.edu            
//	                   Bobby Mullins, mullinsbd@etsu.edu
//	                   Christopher Poteet, poteetc1@etsu.edu
//	                   William Simmons, simmonswa@etsu.edu
//	Created:           Monday, January 31, 2022
//	Copyright:         Team 4
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

		private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFileDialog fd = new OpenFileDialog();
			StreamReader reader;

			String Path;
			String FileContent;

			fd.InitialDirectory = "c:\\";

			if(fd.ShowDialog() == DialogResult.OK)
			{
				Path = fd.FileName;

				var FileStream = fd.OpenFile();

				reader = new StreamReader(FileStream);

				FileContent = reader.ReadToEnd();

				textInput.Text = FileContent;
			}
		}
	}
}
