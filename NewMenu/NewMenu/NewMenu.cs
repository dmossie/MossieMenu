/*
"NewMenu" - "A Program Launcher"
Created By: Daniel Mossie
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic;


namespace NewMenu
{
    public partial class NewMenu : Form
    {
        //User32 function for selecting window
        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(String sClassName, String sAppName);

        //IntPtr to form
        private IntPtr thisWindow;

        //Show/Hide hot key
        private Hotkey hotkey;

        //Path to settings file
        String filePath;

        //Number of paths in the list
        int pathNum;

        //Array of all file paths
        String[] paths;
        String[] names;

        //Constructor
        public NewMenu()
        {
            InitializeComponent();
        }

        //Menu Loaded
        private void NewMenu_Load(object sender, EventArgs e)
        {
            //Set file path, create the hotkey, populate the menu
            filePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            filePath += "/menuSettings.txt";

            thisWindow = FindWindow(null, "Menu");
            hotkey = new Hotkey(thisWindow);
            hotkey.RegisterHotKeys();
            populateMenu();
        }

        //Form Closed
        private void NewMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Remove the hot key
            hotkey.UnRegisterHotKeys();
        }

        //Windows Processes
        protected override void WndProc(ref Message keyPressed)
        {
            //If a hotkey was triggered
            if (keyPressed.Msg == 0x0312)
            {
                Keys key = (Keys)(((int)keyPressed.LParam >> 16) & 0xFFFF);
                int modifier = ((int)keyPressed.LParam & 0xFFFF);
                //Test for CTRL+M
                if (key.ToString() == "Oemcomma" && modifier == 2)
                {

                    //Minimize or maximize the form
                    if (this.WindowState == FormWindowState.Minimized)
                    {
                        this.WindowState = FormWindowState.Normal;
                    }
                    else if (this.Visible == true) this.Hide();
                    else this.Show();
                }

            }
            base.WndProc(ref keyPressed);
        }


        //Add an item to a list
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int newPathNum;
            String text;
            String pathName = "";
            bool pathExists = false;

            //Get path name of new file
            OpenFileDialog pathPicker = new OpenFileDialog();
            pathPicker.DereferenceLinks = false;
            if (pathPicker.ShowDialog() == DialogResult.OK)
            {
                pathName = pathPicker.FileName;
            }

            if (pathName == "") return;

            //Add to the file if it exists
            if (File.Exists(filePath))
            {
                //Make sure path isn't there already
                string[] lines = System.IO.File.ReadAllLines(filePath);
                for (int i = 0; i < lines.Length; i++)
                {
                    if (lines[i] == pathName)
                    {
                        pathExists = true;
                        break;
                    }
                }

                if (pathExists == false)
                {
                    //Find number of paths
                    StreamReader fileIn = new StreamReader(filePath, true);
                    text = fileIn.ReadLine();
                    String[] lineNum = text.Split('=');
                    if (int.TryParse(lineNum[1], out newPathNum))
                        newPathNum += 1;
                    fileIn.Close();

                    //Add path to file
                    StreamWriter fileOut = new StreamWriter(filePath, true);
                    String fileName = Path.GetFileNameWithoutExtension(pathName);
                    fileOut.WriteLine(pathName + "$" + fileName);
                    fileOut.Close();

                    //Increment path count
                    lines = System.IO.File.ReadAllLines(filePath);
                    lines[0] = "paths=" + newPathNum;
                    File.WriteAllLines(filePath, lines);

                    pathNum = newPathNum;
                    populateMenu();
                }
                else
                {
                    MessageBox.Show("That file is already listed!");
                }
            }
        }

        //Remove an item in a list
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            String selectedPath;
            int selectedIndex;
            int indexPosition = 0;
            if (listBoxPaths.SelectedItem != null)
            {
                //Find path that needs to be removed
                selectedIndex = listBoxPaths.SelectedIndex;
                selectedPath = paths[selectedIndex] + "$" + names[selectedIndex];

                //Remove the path
                string[] lines = System.IO.File.ReadAllLines(filePath);
                string[] newLines = new string[lines.Length - 1];
                newLines[0] = "paths=" + (pathNum - 1);
                pathNum -= 1;
                int x = 1;
                for (int i = 1; i < lines.Length; i++)
                {
                    if (lines[i] != selectedPath)
                    {
                        newLines[x] = lines[i];
                        x += 1;
                    }
                    else indexPosition = i - 1;
                }
                File.WriteAllLines(filePath, newLines);
                populateMenu();

                //Select new item
                if (lines.Length - 2 == indexPosition && lines.Length > 2)
                    listBoxPaths.SetSelected(indexPosition - 1, true);
                else if (lines.Length - 2 > indexPosition)
                    listBoxPaths.SetSelected(indexPosition, true);

            }
            else
            {
                MessageBox.Show("Please select an item to delete!");
            }
        }

        //Move an item up in the list
        private void buttonUp_Click(object sender, EventArgs e)
        {
            int selectedIndex;
            String selectedPath;

            if (File.Exists(filePath))
            {
                if (listBoxPaths.SelectedItem != null)
                {
                    //Find path that needs to be moved up
                    selectedIndex = listBoxPaths.SelectedIndex;
                    selectedPath = paths[selectedIndex] + "$" + names[selectedIndex];

                    //Put lines in file into an array
                    string[] lines = System.IO.File.ReadAllLines(filePath);
                    string[] newLines = new string[lines.Length];
                    String backup;
                    int placeBackup = 0;

                    if (lines[1] != selectedPath)
                    {
                        //Make the switch
                        for (int i = 0; i < lines.Length; i++)
                        {
                            if (lines[i] == selectedPath)
                            {
                                backup = newLines[i - 1];
                                newLines[i - 1] = lines[i];
                                newLines[i] = backup;
                                placeBackup = i - 2;
                            }
                            else
                            {
                                newLines[i] = lines[i];
                            }
                        }
                        //Write the changes
                        File.WriteAllLines(filePath, newLines);
                        populateMenu();
                        listBoxPaths.SetSelected(placeBackup, true);

                    }
                    else
                    {
                        MessageBox.Show("You can not move the first item up!");
                    }

                }
                else
                {
                    MessageBox.Show("Please select an item to move up!");
                }
            }
        }


        //Move an item down in the list
        private void buttonDown_Click(object sender, EventArgs e)
        {
            int selectedIndex;
            String selectedPath;

            if (File.Exists(filePath))
            {
                if (listBoxPaths.SelectedItem != null)
                {
                    //Find path that needs to be moved down
                    selectedIndex = listBoxPaths.SelectedIndex;
                    selectedPath = paths[selectedIndex] + "$" + names[selectedIndex];

                    //Put lines in file into an array
                    string[] lines = System.IO.File.ReadAllLines(filePath);
                    string[] newLines = new string[lines.Length];
                    int placeBackup = 0;

                    if (lines[lines.Length - 1] != selectedPath)
                    {
                        //Make the switch
                        for (int i = 0; i < lines.Length; i++)
                        {
                            if (lines[i] == selectedPath)
                            {
                                newLines[i] = lines[i + 1];
                                newLines[i + 1] = lines[i];
                                placeBackup = i;
                                i += 1;
                            }
                            else
                            {
                                newLines[i] = lines[i];
                            }
                        }
                        //Write the changes
                        File.WriteAllLines(filePath, newLines);
                        populateMenu();
                        listBoxPaths.SetSelected(placeBackup, true);
                    }
                    else
                    {
                        MessageBox.Show("You can not move the last item down!");
                    }

                }
                else
                {
                    MessageBox.Show("Please select an item to move down!");
                }
            }
        }

        //Add items to the lisbox
        private void populateMenu()
        {
            //Create the file if it doesn't exist
            if (!File.Exists(filePath))
            {
                StreamWriter fileOut = new StreamWriter(filePath, true);
                fileOut.WriteLine("paths=0");
                fileOut.Close();
            }
            else
            {
                //Find the number of paths to read in
                String text;
                StreamReader fileIn = new StreamReader(filePath);
                text = fileIn.ReadLine();
                String[] lineNum = text.Split('=');
                //Add the paths to an array, put the paths in a list box
                if (lineNum.Length == 2 && lineNum[0] == "paths")
                {
                    if (int.TryParse(lineNum[1], out pathNum))
                    {
                        names = new String[pathNum];
                        paths = new String[pathNum];
                        String line;
                        String[] lineParts;
                        for (int i = 0; i < pathNum; i++)
                        {
                            line = fileIn.ReadLine();
                            lineParts = line.Split('$');
                            paths[i] = lineParts[0];
                            names[i] = lineParts[1];
                        }
                        listBoxPaths.Items.Clear();
                        listBoxPaths.Items.AddRange(names);
                    }
                }
                fileIn.Close();
            }
        }

        //Rename a file
        private void buttonRename_Click(object sender, EventArgs e)
        {
            if (listBoxPaths.SelectedItem != null)
            {
                int selectedIndex;
                String selectedPath, newName;

                this.TopMost = false;
                newName = Interaction.InputBox("Rename this file", "Rename", listBoxPaths.SelectedItem.ToString());
                this.TopMost = true;

                if (newName.Length > 0 && newName.Length < 21)
                {

                    selectedIndex = listBoxPaths.SelectedIndex;
                    selectedPath = paths[selectedIndex] + "$" + newName;

                    string[] lines = System.IO.File.ReadAllLines(filePath);
                    lines[selectedIndex + 1] = selectedPath;
                    File.WriteAllLines(filePath, lines);

                    populateMenu();
                }
                else MessageBox.Show("Please pick a name that is 1-20 characters long!");
            }
            else
            {
                MessageBox.Show("Please select an item to rename!");
            }
        }

        private void listBoxPaths_KeyPress(object sender, KeyPressEventArgs e)
        {
            launchProgram();
        }
        
        private void listBoxPaths_DoubleClick(object sender, EventArgs e)
        {
            launchProgram();
        }

        //Start a program
        private void launchProgram()
        {
            int selectedIndex;
            if (listBoxPaths.SelectedItem != null)
            {
                selectedIndex = listBoxPaths.SelectedIndex;
                if (File.Exists(paths[selectedIndex]))
                {
                    Process.Start(paths[selectedIndex]);
                }
                else
                {
                    MessageBox.Show("File not found!");
                }
            }
        }
    }
}