using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.Win32;

namespace Preparator_GUI
{
    public partial class Main : Form
    {
        // For Editing SkyrimPrefs.ini
        [DllImport("kernel32.dll", EntryPoint = "WritePrivateProfileString")]
        public static extern long WriteValueA(string strSection, string strKeyName, 
            string strValue, string strFilePath);
        // Set System Directories
        private string AppData = 
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        private string AppDataLocal = 
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        private string ProgramFiles86 = 
            Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
        private string SteamFolder;
        private string LexyDir;
        private string GameDir;

        //Set Steam Library Directory List
        List<string> SteamLibraries = new List<string>();

        public Main()
        {
            InitializeComponent();
            this.Text = "Lexy Wabbajack Preparator GUI";
            // Set Steam Folder
            RegistryKey Steam = Registry.CurrentUser.OpenSubKey(@"Software\\Valve\\Steam", false);
            SteamFolder = (string)Steam.GetValue("SteamPath");

            // Search for Steam Libraries
            // This library always exists when installing Steam, and is not in libraryfolders.vdf, so adding it manually
            SteamLibraries.Add(Path.Combine(SteamFolder, "steamapps", "common"));
            foreach (string line in File.ReadLines(Path.Combine(SteamFolder, "steamapps", "libraryfolders.vdf")))
            {
                string a = line.Trim();
                if (a.Length > 2)
                {
                    if (Char.IsDigit(a[1]))
                    {
                        string[] b = a.Split('"');
                        SteamLibraries.Add(Path.Combine(b[3], "steamapps", "common"));
                    }
                }
            }

            // Display Steam Libraries
            listBox1.Items.Add("Looking For Steam Libraries".ToString());
            listBox1.Items.Add("-----------------------------------------------------------".ToString());
            listBox1.TopIndex = listBox1.Items.Count - 1;

            // Search for all Steam Libraries on this computer
            listBox1.Items.Add("Detected Steam Libraries: ".ToString());
            listBox1.TopIndex = listBox1.Items.Count - 1;
            foreach (string SteamLibrary in SteamLibraries)
            {
                listBox1.Items.Add(SteamLibrary);
                listBox1.TopIndex = listBox1.Items.Count - 1;
            }
            listBox1.Items.Add("-----------------------------------------------------------".ToString());

            //Locate Game Directory
            foreach (string SteamLibrary in SteamLibraries)
            {
                if (Directory.Exists(Path.Combine(SteamLibrary, "Skyrim Special Edition")))
                {
                    GameDir = Path.Combine(SteamLibrary, "Skyrim Special Edition");
                    // Display Game Directory
                    listBox1.Items.Add("Detected Game Folder".ToString());
                    listBox1.Items.Add(GameDir.ToString());
                    listBox1.Items.Add("-----------------------------------------------------------".ToString());
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Change Skip Button
            Next.Enabled = false;

            progressBar1.PerformStep();

            // Skyrim Uninstallation
            if (list.GetItemChecked(0))
            {
                listBox1.Items.Add("Prompting user to uninstall Skyrim Special Edition.".ToString());
                listBox1.TopIndex = listBox1.Items.Count - 1;
                Process.Start("steam://uninstall/489830");
                listBox1.Items.Add("Waiting for uninstallation...".ToString());
                listBox1.TopIndex = listBox1.Items.Count - 1;
                Thread.Sleep(6500);
                listBox1.Items.Add("Prompting user to install Skyrim Special Edition.".ToString());
                listBox1.TopIndex = listBox1.Items.Count - 1;
                Process.Start("steam://install/489830");
            }
            progressBar1.PerformStep();

            // SkyrimSE Mods Folder
            if (list.GetItemChecked(1))
            {
                string SSEModsFolder = "";
                // Search each Steam Library for the SSE Mods folder
                foreach (string SteamLibrary in SteamLibraries)
                {
                    if (Directory.Exists(Path.Combine(SteamLibrary, "Skyrim Special Edition Mods")))
                    {
                        SSEModsFolder = Path.Combine(SteamLibrary, "Skyrim Special Edition Mods");
                    }
                }

                if (SSEModsFolder.Length > 1)
                {
                    listBox1.Items.Add("Deleting Skyrim Special Edition Mods folder...".ToString());
                    listBox1.TopIndex = listBox1.Items.Count - 1;
                    Delete.DeleteToRecyclingBin(SSEModsFolder);
                }
                else
                {
                    listBox1.Items.Add("Skyrim Special Edition Mods folder not found.".ToString());
                    listBox1.TopIndex = listBox1.Items.Count - 1;
                }
                listBox1.Items.Add("-----------------------------------------------------------".ToString());

            }
            progressBar1.PerformStep();

            // My Documents SSE Config Folder
            if (list.GetItemChecked(2))
            {
                string SSEConfigFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "My Games", "Skyrim Special Edition");
                if (Directory.Exists(SSEConfigFolder))
                {
                    listBox1.Items.Add("Deleting Skyrim Special Edition Config folder...".ToString());
                    listBox1.TopIndex = listBox1.Items.Count - 1;
                    Delete.DeleteToRecyclingBin(SSEConfigFolder);
                }
                else
                {
                    listBox1.Items.Add("Skyrim Special Edition Config folder not found".ToString());
                    listBox1.TopIndex = listBox1.Items.Count - 1;
                }
                listBox1.Items.Add("-----------------------------------------------------------".ToString());

            }
            progressBar1.PerformStep();

            // AppData LOOT
            if (list.GetItemChecked(3))
            {
                if (Directory.Exists(Path.Combine(AppDataLocal, "LOOT")))
                {
                    listBox1.Items.Add("Deleting LOOT AppData folder...".ToString());
                    listBox1.TopIndex = listBox1.Items.Count - 1;
                    Delete.DeleteToRecyclingBin(Path.Combine(AppDataLocal, "LOOT"));
                }
                else
                {
                    listBox1.Items.Add("LOOT AppData folder not found".ToString());
                    listBox1.TopIndex = listBox1.Items.Count - 1;
                }
                listBox1.Items.Add("-----------------------------------------------------------".ToString());

            }

            // Appdata SSE
            if (list.GetItemChecked(4))
            {
                if (Directory.Exists(Path.Combine(AppDataLocal, "Skyrim Special Edition")))
                {
                    listBox1.Items.Add("Deleting Skyrim Special Edition AppData folder...".ToString());
                    listBox1.TopIndex = listBox1.Items.Count - 1;
                    Delete.DeleteToRecyclingBin(Path.Combine(AppDataLocal, "Skyrim Special Edition"));
                }
                else
                {
                    listBox1.Items.Add("Skyrim Special Edition AppData folder not found".ToString());
                    listBox1.TopIndex = listBox1.Items.Count - 1;
                }
                listBox1.Items.Add("-----------------------------------------------------------".ToString());

            }

            // Appdata zEdit
            if (list.GetItemChecked(5))
            {
                if (Directory.Exists(Path.Combine(AppData, "zEdit")))
                {
                    listBox1.Items.Add("Deleting zEdit AppData folder...".ToString());
                    listBox1.TopIndex = listBox1.Items.Count - 1;
                    Delete.DeleteToRecyclingBin(Path.Combine(AppData, "zEdit"));
                }
                else
                {
                    listBox1.Items.Add("zEdit AppData folder not found".ToString());
                    listBox1.TopIndex = listBox1.Items.Count - 1;
                }
                listBox1.Items.Add("-----------------------------------------------------------".ToString());

            }
            progressBar1.PerformStep();
            listBox1.Items.Add("Preparation for modlist install complete!".ToString());
            listBox1.Items.Add("Now you can go and use Wabbajack :)".ToString());
            listBox1.Items.Add("-----------------------------------------------------------".ToString());
            listBox1.Items.Add("Come back here after and complete the next steps by pressing next".ToString());
            listBox1.Items.Add("-----------------------------------------------------------".ToString());
            listBox1.TopIndex = listBox1.Items.Count - 1;

            Next.Text = "Next";
            Next.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            folderBrowserDialog2.ShowDialog();
            if (folderBrowserDialog2.SelectedPath.Length < 1)
            {
                label3.Text = "No Directory Selected!";
                label3.Enabled = false;
                panel3.Enabled = false;
            }
            else
            {
                LexyDir = folderBrowserDialog2.SelectedPath;
                label3.Text = "Lexy LOTD Directory: " + folderBrowserDialog2.SelectedPath;
                label3.Enabled = true;
                panel3.Enabled = true;
            }
        }

        private void folderBrowserDialog2_HelpRequest(object sender, EventArgs e)
        {

        }
        void Copy(string sourceDir, string targetDir)
        {
            Directory.CreateDirectory(targetDir);

            foreach (var file in Directory.GetFiles(sourceDir))
                File.Copy(file, Path.Combine(targetDir, Path.GetFileName(file)));

            foreach (var directory in Directory.GetDirectories(sourceDir))
                Copy(directory, Path.Combine(targetDir, Path.GetFileName(directory)));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(Path.Combine(LexyDir, "Game Folder Files")))
            {
                string dir = Path.Combine(LexyDir, "Game Folder Files");
                Copy(dir, GameDir);
                listBox1.Items.Add("Copied Game Folder Files");
                listBox1.Items.Add("-----------------------------------------------------------".ToString());
                listBox1.TopIndex = listBox1.Items.Count - 1;
            }
            else
            {
                listBox1.Items.Add("Game Folder Files not found!".ToString());
                listBox1.Items.Add("Check LOTD Folder is correct and that is contains a folder called 'Game Folder Files'".ToString());
                listBox1.Items.Add("-----------------------------------------------------------".ToString());
                listBox1.TopIndex = listBox1.Items.Count - 1;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Writing Resolution to SkyrimPrefs.ini");
            listBox1.Items.Add("-----------------------------------------------------------".ToString());
            listBox1.TopIndex = listBox1.Items.Count - 1;
            WriteValueA("Display", "iSize H", numericUpDown3.Value.ToString(), Path.Combine(LexyDir, "profiles", "Lexys LOTD SE Unofficial Autoinstaller", "SkyrimPrefs.ini"));
            WriteValueA("Display", "iSize W", numericUpDown2.Value.ToString(), Path.Combine(LexyDir, "profiles", "Lexys LOTD SE Unofficial Autoinstaller", "SkyrimPrefs.ini"));
        }

        private void Next_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Show();
            progressBar1.Hide();
            panel6.Hide();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void progressBar1_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
    
}
