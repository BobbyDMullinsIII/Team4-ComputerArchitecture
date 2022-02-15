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

        #region assemble() Method
        /// <summary>
        /// Master Method for assembling custom assembly language instruction set into machine code
        /// </summary>
        /// <returns>Final assemble output (Machine Code)</returns>
        public static string assemble()
        {
            string assembleOutput = "";

            

            return assembleOutput;
        }//end assemble()
        #endregion

        #region disassemble() Method
        /// <summary>
        /// Master Method for disassembling opcode into assembly
        /// </summary>
        /// <returns>Final disassemble output (Assembly Language)</returns>
        public static Int32 [] disassemble(string machineString)
        {
            Int32[] tokens = new Int32[2];
          
            Int32 inp = Convert.ToInt32(machineString, 16);
            tokens[0] = (inp & 248);                            // AND with binary (11111000) to keep all 1 and get 5 bytes of opcode
            tokens[1] = (inp & 7);                              // AND  with binary (00000111) to keep all 1 and get 3 bytes for registers

            return tokens;
                 
        }//end disassemble()
            #endregion

        #region dissassembleData() Method
        /// <summary>
        /// Method for calculating tokens based on instruction parameters/registers
        /// </summary>
        /// <param name="machineString">Input machine code line after instruction to convert to tokens</param>
        /// <returns>Int32 token array from instruction parameters/registers</returns>
        public static Int32[] disassembleData(string machineString)
        {
            Int32[] tokens = new Int32[3];
            Int32 data = Convert.ToInt32(machineString, 16);
            tokens[0] = (data & 3);
            switch (tokens[0])
            {
                case Int32 n when (n == 0):
                    tokens[1] = (data & 14680064);
                    break;
                case Int32 n when (n == 1):
                    tokens[1] = (data & 16777152);
                    break;
                case Int32 n when (n == 2):
                    tokens[1] = (data & 16777212);
                    break;
                case Int32 n when (n == 3):
                    tokens[1] = (data & 14680064);
                    tokens[2] = (data & 1835008);
                    break;

            }
            return tokens;
        }
        #endregion

        #region openFile() Method
        /// <summary>
        /// Method for inputting an entire text file into one string
        /// </summary>
        /// <returns>Input string from entire text file</returns>
        public static string openFile()
        {
            OpenFileDialog fd = new OpenFileDialog();
            StreamReader reader;

            String Path;
            String FileContent = "";

            fd.InitialDirectory = "c:\\";

            if (fd.ShowDialog() == DialogResult.OK)
            {
                Path = fd.FileName;

                var FileStream = fd.OpenFile();

                reader = new StreamReader(FileStream);

                FileContent = reader.ReadToEnd();

                return FileContent;
            }

            return FileContent;

        }//end openFile()
        #endregion

        #region saveFile() Method
        /// <summary>
        /// Method for outputting a text file from a string
        /// </summary>
        /// <param name="outputString">String to be output to a text file</param>
        public static void saveFile(string outputString)
        {
            SaveFileDialog sf = new SaveFileDialog();

            sf.ShowDialog();

            if (sf.FileName != "")
            {
                File.WriteAllText(sf.FileName, outputString);
            }

        }//end saveFile()
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
