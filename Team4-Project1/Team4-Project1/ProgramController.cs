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
        /// <param name="assemblyString"> Custom instruction set assembly language string to be assembled</param>
        /// <returns>Final assemble output (Machine Code)</returns>
        public static string assemble(string assemblyString)
        {
            string assembleOutput = "";

            //============================//
            //INSERT CODE TO ASSEMBLE HERE//
            //============================//

            return assembleOutput;
        }//end assemble()
        #endregion

        #region disassemble() Method
        /// <summary>
        /// Master Method for disassembling machine code into custom assembly language instruction set
        /// </summary>
        /// <param name="machineString">Machine code string to be disassembled</param>
        /// <returns>Final disassemble output (Assembly Language)</returns>
        public static string disassemble(string machineString)
        {
            string disassembleOutput = "";

            //===============================//
            //INSERT CODE TO DISASSEMBLE HERE//
            //===============================//

            string yadayadayada = "6F";
            sbyte instruct = Convert.ToSByte(yadayadayada, 16);
            sbyte register = 0;

            switch(instruct)
            {
                case sbyte n when (n > 0 && n <= 7):    //1 to 111
                    register = instruct;
                    break;
                case sbyte n when (n > 7 && n <= 15):   //1000 to 1111
                    register = (sbyte)(instruct >> 1);
                    break;
                case sbyte n when (n > 15 && n <= 31):  //10000 to 11111
                    register = (sbyte)(instruct >> 2);
                    break;
                case sbyte n when (n > 31 && n <= 63):  //100000 to 111111
                    register = (sbyte)(instruct >> 3);
                    break;
                case sbyte n when (n > 63 && n <= 127): //1000000 to 1111111
                    register = (sbyte)(instruct >> 4);
                    break;
                case sbyte n when (n > 127):            //10000000 to 11111111
                    register = (sbyte)(instruct >> 5);
                    break;
            }

            sbyte opcode = (sbyte)(instruct << 3);

            disassembleOutput = "Opcode: " + opcode;
            disassembleOutput += "\r\nRegister: " + register;

            return disassembleOutput;
        }//end disassemble()
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

               if(sf.FileName != "")
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
