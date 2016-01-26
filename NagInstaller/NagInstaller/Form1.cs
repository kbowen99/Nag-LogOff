using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace NagInstaller
{
    public partial class Frm_Install : Form
    {
        public Frm_Install()
        {
            InitializeComponent();
        }

        private void Btn_Install_Click(object sender, EventArgs e)
        {
            string dest = @"C:\Users\" + txt_Usr.Text + @"\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup";
            string[] batchlines = { //if a string array & .WriteAllLines are used, each string is its own line
                                          "@echo off",
                                          "title Don't Close - Moving Files",
                                          "color a",
                                          "@echo on",
                                          "cls",
                                          "Xcopy \"" + "LogOff.exe" + "\" \"" + dest + "\" /w /g /s /r /-y /z /j /d /v",//add /v to verify
                                          "( del /q /f \"%~f0\" >nul 2>&1 & exit /b 0  )"
                                      };
            writeFile(batchlines, @"", "install.bat");
        }
        private void writeFile(string[] toWrite, string Spath, string filename)
        {
            string path = Spath + filename;

            if (File.Exists(path)) //if the temp file already exists, delete it
            {
                File.Delete(path);
            }
            using (FileStream fs = File.Create(path, 1024)) { } //create the file
            System.IO.File.WriteAllLines(path, toWrite); //write to the file
            Process.Start(path);
        }
    }
}
