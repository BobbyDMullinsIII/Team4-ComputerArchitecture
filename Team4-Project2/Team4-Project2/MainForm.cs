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
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Team4_Project2
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

            // int count = disassembledText.Count(f => f == '#');
            // int testLen = disassembledText.Length;
            // int previousReplace = 0;
            //  string convert = "";
            // string converted = "";
            // string holder1 = "";
            // string holder2 = "";
            //  string print = "";
            //  string[] split;
            // for (int i = 0; i < count; i++)
            //  {
            //      if (previousReplace > 0 && previousReplace < testLen - 5)
            //      {
            //          previousReplace += convert.Length;                                     //goes past previous altered values
            //          holder1 = print.Substring(print.IndexOf("#", previousReplace), 3);     //gets next index starting from last value found
            //          convert = Regex.Match(holder1, @"[#]\d+").ToString();                  //finds next character
            //
            //          split = convert.Split('#');
            //          converted = "#" + Convert.ToInt32(split[1]).ToString("X");             //convert to hex
            //
            //          previousReplace = print.IndexOf('#', previousReplace);                 //get position of value replaced
            //          holder2 = print.Substring(0, previousReplace);                         //first part of new string 
            //          print = holder2 + " " + converted + " " + print.Substring(print.IndexOf(convert) + convert.Length); //add changed part and remaining string
            //
            //      }
            //      else
            //      {
            //          convert = Regex.Match(disassembledText, @"[#]\d+").ToString();
            //         split = convert.Split('#');
            //          converted = "#" + Convert.ToInt32(split[1]).ToString("X");

            //         previousReplace = disassembledText.IndexOf('#', previousReplace + 1);
            //         holder2 = disassembledText.Substring(0, previousReplace);
            //         print = holder2 + " " + converted + " " + disassembledText.Substring(previousReplace + converted.Length);
            //     }

            // }

            machineTextBox.Text = "";//Clears machine code text box before disassembling
            string disassembledText = assemblyTextBox.Text;


            disassembledText = Regex.Replace(disassembledText, @"\d{4}[\t]*\s+", "");
            disassembledText = Regex.Replace(disassembledText, @"\s+", "");
            int numConverts = disassembledText.Count(f => f == '#');


            int wFlag = 0;
            int counter = 0;
            //machineTextBox.Text += disassembledText;
            while (wFlag == 0)
            {
                Int32 macInstruct = 0;
                string instruction = string.Empty;
                instruction += disassembledText[counter];
                counter++;
                instruction += disassembledText[counter];
                counter++;
                instruction += disassembledText[counter];
                counter++;
                instruction += disassembledText[counter];
                counter++;
                switch (instruction)
                {
                    case string n when (n == "LDRE"):

                        counter += 3;
                        if (disassembledText[counter] == 'R')
                        {
                            macInstruct += 0;
                        }
                        else if (disassembledText[counter] == '#')
                        {
                            macInstruct += 8;
                        }
                        else
                        {
                            macInstruct += 16;
                        }

                        counter -= 3;
                        break;
                    case string n when (n == "STRE"):
                        macInstruct += 24;
                        break;
                    case string n when (n == "MOVE"):
                        macInstruct += 32;
                        break;
                    case string n when (n == "COMP"):
                        macInstruct += 40;
                        break;
                    case string n when (n == "ANDD"):
                        macInstruct += 48;
                        break;
                    case string n when (n == "OORR"):
                        macInstruct += 56;
                        break;
                    case string n when (n == "BRLT"):
                        macInstruct += 64;
                        break;
                    case string n when (n == "BRGT"):
                        macInstruct += 72;
                        break;
                    case string n when (n == "BREQ"):
                        macInstruct += 80;
                        break;
                    case string n when (n == "BRAN"):
                        macInstruct += 88;
                        break;
                    case string n when (n == "ADDI"):
                        macInstruct += 96;
                        break;
                    case string n when (n == "SUBT"):
                        macInstruct += 104;
                        break;
                    case string n when (n == "STOP"):
                        macInstruct += 255;
                        string hexValue = macInstruct.ToString("X2");
                        hexValue = hexValue.Insert(2, " ");
                        machineTextBox.Text += hexValue;
                        wFlag = 1;
                        break;
                    default:
                        wFlag = 1;
                        MessageBox.Show("There was an invalid Mnemonic", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;

                }

                if (wFlag == 0)
                {
                    string register = "";
                    register += disassembledText[counter];
                    counter++;
                    register += disassembledText[counter];
                    counter++;
                    switch (register)
                    {
                        case string n when (n == "R0"):
                            macInstruct += 0;
                            break;
                        case string n when (n == "R1"):
                            macInstruct += 1;
                            break;
                        case string n when (n == "R2"):
                            macInstruct += 2;
                            break;
                        case string n when (n == "R3"):
                            macInstruct += 3;
                            break;
                        case string n when (n == "R4"):
                            macInstruct += 4;
                            break;
                        case string n when (n == "R5"):
                            macInstruct += 5;
                            break;
                        case string n when (n == "R6"):
                            macInstruct += 6;
                            break;
                        case string n when (n == "R7"):
                            macInstruct += 7;
                            break;

                    }
                    counter++;
                    string hexValue = macInstruct.ToString("X2");
                    hexValue = hexValue.Insert(2, " ");
                    machineTextBox.Text += hexValue;
                    Int32 dataInstruct = 0;
                    string addressingMode = "";
                    addressingMode = Convert.ToString(disassembledText[counter]);
                    switch (addressingMode)
                    {
                        case string n when (n == "R"):
                            counter += 2;
                            if (disassembledText[counter] == 'R')
                            {
                                counter--;
                                counter--;
                                dataInstruct += 3;
                                switch (disassembledText[counter])
                                {
                                    case char i when (i == '0'):
                                        dataInstruct += 0;
                                        break;
                                    case char i when (i == '1'):
                                        dataInstruct += 2097152;
                                        break;
                                    case char i when (i == '2'):
                                        dataInstruct += 4194304;
                                        break;
                                    case char i when (i == '3'):
                                        dataInstruct += 6291456;
                                        break;
                                    case char i when (i == '4'):
                                        dataInstruct += 8388608;
                                        break;
                                    case char i when (i == '5'):
                                        dataInstruct += 10485760;
                                        break;
                                    case char i when (i == '6'):
                                        dataInstruct += 12582912;
                                        break;
                                    case char i when (i == '7'):
                                        dataInstruct += 14680064;
                                        break;

                                }
                                counter++;
                                counter++;
                                counter++;
                                switch (disassembledText[counter])
                                {
                                    case char i when (i == '0'):
                                        dataInstruct += 0;
                                        break;
                                    case char i when (i == '1'):
                                        dataInstruct += 262144;
                                        break;
                                    case char i when (i == '2'):
                                        dataInstruct += 524288;
                                        break;
                                    case char i when (i == '3'):
                                        dataInstruct += 786432;
                                        break;
                                    case char i when (i == '4'):
                                        dataInstruct += 1048576;
                                        break;
                                    case char i when (i == '5'):
                                        dataInstruct += 1310720;
                                        break;
                                    case char i when (i == '6'):
                                        dataInstruct += 1572864;
                                        break;
                                    case char i when (i == '7'):
                                        dataInstruct += 1835008;
                                        break;

                                }
                                counter--;
                            }
                            else
                            {
                                counter--;
                                dataInstruct += 0;
                                switch (disassembledText[counter])
                                {
                                    case char i when (i == '0'):
                                        dataInstruct += 0;
                                        break;
                                    case char i when (i == '1'):
                                        dataInstruct += 2097152;
                                        break;
                                    case char i when (i == '2'):
                                        dataInstruct += 4194304;
                                        break;
                                    case char i when (i == '3'):
                                        dataInstruct += 6291456;
                                        break;
                                    case char i when (i == '4'):
                                        dataInstruct += 8388608;
                                        break;
                                    case char i when (i == '5'):
                                        dataInstruct += 10485760;
                                        break;
                                    case char i when (i == '6'):
                                        dataInstruct += 12582912;
                                        break;
                                    case char i when (i == '7'):
                                        dataInstruct += 14680064;
                                        break;

                                }
                                counter++;

                            }
                            counter -= 2;
                            break;
                        case string n when (n == "#"):
                            dataInstruct += 1;
                            counter++;
                            string immediate = "";
                            int counter2 = 0;
                            while (Char.IsNumber(disassembledText, counter) == true)
                            {
                                immediate += disassembledText[counter];
                                counter++;
                                counter2++;
                            }
                            dataInstruct += Int32.Parse(immediate);
                            counter -= counter2;
                            counter--;
                            break;
                        case string n when (n == "&"):
                            dataInstruct += 2;
                            counter++;
                            string memory = "";
                            counter2 = 0;
                            while (Char.IsNumber(disassembledText, counter) == true)
                            {
                                memory += disassembledText[counter];
                                counter++;
                                counter2++;
                            }
                            dataInstruct += Int32.Parse(memory);
                            counter -= counter2;
                            counter--;
                            break;
                    }
                    hexValue = dataInstruct.ToString("X6");

                    hexValue = hexValue.Insert(2, " ");
                    hexValue = hexValue.Insert(5, " ");
                    hexValue = hexValue.Insert(8, " ");
                    machineTextBox.Text += hexValue;
                }
                counter += 2;



            }

        }

        /// <summary>
        /// Initiates disassemble process into assembly language instruction set
        /// </summary>
        /// <param name="sender">object that raised the event (auto-generated, unused here)</param>
        /// <param name="e">arguments for event (auto-generated, unused here)</param>
        private void disassembleButton_Click(object sender, EventArgs e)
        {
            assemblyTextBox.Text = "";//Clears assembly text box before disassembling

            Int32[] opTokens = new Int32[2];
            string[] machineCode = machineTextBox.Text.Split(' ');

            int wFlag = 0;
            int counter = 0;
            while (wFlag == 0)
            {
                string opcode = machineCode[counter];
                counter++;

                opTokens = ProgramController.disassemble(opcode);
                string counterOutput = counter.ToString("D4");

                switch (opTokens[0])
                {
                    case Int32 n when (n == 0):     //  LDRE    R,R
                        assemblyTextBox.Text += counterOutput + "\tLDRE";
                        break;
                    case Int32 n when (n == 8):     //  LDRE    R, Immediate
                        assemblyTextBox.Text += counterOutput + "\tLDRE";
                        break;
                    case Int32 n when (n == 16):    //  LDRE    R, Memory
                        assemblyTextBox.Text += counterOutput + "\tLDRE";
                        break;
                    case Int32 n when (n == 24):    //  STRE    &R, R
                        assemblyTextBox.Text += counterOutput + "\tSTRE";
                        break;
                    case Int32 n when (n == 32):    //  MOVE    R, R
                        assemblyTextBox.Text += counterOutput + "\tMOVE";
                        break;
                    case Int32 n when (n == 40):    //  COMP    R, R, R
                        assemblyTextBox.Text += counterOutput + "\tCOMP";
                        break;
                    case Int32 n when (n == 48):    //  ANDD    R, R, R
                        assemblyTextBox.Text += counterOutput + "\tANDD";
                        break;
                    case Int32 n when (n == 56):    //  OORR    R, R
                        assemblyTextBox.Text += counterOutput + "\tOORR";
                        break;
                    case Int32 n when (n == 64):    //  BRLT    R, R
                        assemblyTextBox.Text += counterOutput + "\tBRLT";
                        break;
                    case Int32 n when (n == 72):    //  BRGT    R, R
                        assemblyTextBox.Text += counterOutput + "\tBRGT";
                        break;
                    case Int32 n when (n == 80):    //  BREQ    R, R
                        assemblyTextBox.Text += counterOutput + "\tBREQ";
                        break;
                    case Int32 n when (n == 88):    //  BRAN    R, R
                        assemblyTextBox.Text += counterOutput + "\tBRAN";
                        break;
                    case Int32 n when (n == 96):    //  ADDI    R, R, R
                        assemblyTextBox.Text += counterOutput + "\tADDI";
                        break;
                    case Int32 n when (n == 104):   //  SUBT    R, R, R
                        assemblyTextBox.Text += counterOutput + "\tSUBT";
                        break;
                    case Int32 n when (n == 248):   //  STOP 
                        assemblyTextBox.Text += counterOutput + "\tSTOP";
                        wFlag = 1;
                        break;
                    default:                        // Nothing matches invalid instruction
                        wFlag = 1;
                        assemblyTextBox.Text += counterOutput + "\tERROR: INVALID INSTRUCTION";
                        MessageBox.Show("There was an invalid machine code instruction.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
                if (wFlag == 0)
                {
                    switch (opTokens[1])
                    {
                        case Int32 n when (n == 0):     // R0
                            assemblyTextBox.Text += "   R0";
                            break;
                        case Int32 n when (n == 1):     // R1
                            assemblyTextBox.Text += "   R1";
                            break;
                        case Int32 n when (n == 2):     // R2
                            assemblyTextBox.Text += "   R2";
                            break;
                        case Int32 n when (n == 3):     // R3
                            assemblyTextBox.Text += "   R3";
                            break;
                        case Int32 n when (n == 4):     // R4
                            assemblyTextBox.Text += "   R4";
                            break;
                        case Int32 n when (n == 5):     // R5
                            assemblyTextBox.Text += "   R5";
                            break;
                        case Int32 n when (n == 6):     // R6
                            assemblyTextBox.Text += "   R6";
                            break;
                        case Int32 n when (n == 7):     // R7
                            assemblyTextBox.Text += "   R7";
                            break;
                    }

                    Int32[] dataTokens = new Int32[3];
                    string data = string.Empty;

                    data = machineCode[counter];
                    counter++;
                    data += machineCode[counter];
                    counter++;
                    data += machineCode[counter];
                    counter++;

                    dataTokens = ProgramController.disassembleData(data);
                    switch (dataTokens[0])
                    {
                        case Int32 n when (n == 0):
                            assemblyTextBox.Text += $", R{dataTokens[1] >> 21} \r\n";
                            break;
                        case Int32 n when (n == 1):
                            assemblyTextBox.Text += $", #{dataTokens[1] >> 6}\r\n";
                            break;
                        case Int32 n when (n == 2):
                            assemblyTextBox.Text += $", &{dataTokens[1] >> 2}\r\n";
                            break;
                        case Int32 n when (n == 3):
                            assemblyTextBox.Text += $", R{dataTokens[1] >> 21}";
                            assemblyTextBox.Text += $", R{dataTokens[2] >> 18} \r\n";
                            break;
                    }
                }
            }

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

        private void machineTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
