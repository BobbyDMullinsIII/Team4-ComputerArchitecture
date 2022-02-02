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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Team4_Project1
{
    /// <summary>
    ///  ProgramController class for controlling majority of program functionality
    /// </summary>
    public class ProgramController
    {
        public static MainForm mainForm;    //MainForm instance to open program to

        #region startProgram() Method
        /// <summary>
        /// Method for starting program
        /// </summary>
        public static void startProgram()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Opens application to mainForm
            mainForm = new MainForm();
            Application.Run(mainForm);

        }//end startProgram()
        #endregion

        #region disassemble() Method
        /// <summary>
        /// Master Method for disassembling machine code into custon assembly language instruction set
        /// </summary>
        /// <param name="input">Full machine code input in single string</param>
        /// <returns>Full instruction set assembly language output in single string</returns>
        public static void disassemble()
        {
            string input = inputFile(); //Inputs file text into single string

            string output = ""; //Variable for text output of disassemble process

            //=====================================================================================================//
            //Insert code for disassembling 'input' machine code string into 'output' assembly language string here//
            //=====================================================================================================//

            outputFile(output); //Outputs string contents into file

        }//end disassemble()
        #endregion

        #region inputFile() Method
        /// <summary>
        /// Method for inputting an entire text file into one string
        /// </summary>
        /// <returns>Input string from entire text file</returns>
        public static string inputFile()
        {
            string input = ""; //Variable for storing entire text file input

            //==================================================================================================//
            //Insert code for inputting all text within a text file into a single string here//
            //==================================================================================================//

            return input;

        }//end inputFile()
        #endregion

        #region outputFile() Method
        /// <summary>
        /// Method for outputting an entire text file from one string
        /// </summary>
        /// <param name="output">String to output into single text file</param>
        public static void outputFile(string output)
        {

            //==================================================================================================//
            //Insert code for creating file to write to and writing to that file from input string here//
            //==================================================================================================/

        }//end outputFile()
        #endregion

        #region openInformation() Method
        /// <summary>
        /// Method for opening instruction set information
        /// </summary>
        public static void openInformation()
        {
            //Get the current directory
            string filePath = Directory.GetCurrentDirectory();

            //Move up two parent directories
            filePath = Directory.GetParent(filePath).FullName;
            filePath = Directory.GetParent(filePath).FullName;

            filePath += "\\Files\\Information.txt";

            //Open the file located at filePath (which is InstructionSet.txt
            Process.Start(filePath);

        }//end openInformation()
        #endregion

    }//end ProgramController class

}//end Team4_Project1 namespace
