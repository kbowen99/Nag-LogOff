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

namespace LogOff
{
    public partial class Frm_Nag : Form
    {

        public Frm_Nag()
        {
            InitializeComponent();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Don't Forget to Log Off!", "Forgetful Human is sad");
            string[] delCode =
            {
                "@Echo On",
                "del LogOff.exe",
                "del LogOff.exe",
                "del LogOff.exe",
                "del LogOff.exe",
                "del LogOff.exe",
                "( del /q /f \"%~f0\" >nul 2>&1 & exit /b 0  )",
            };
            writeFile(delCode, @"", "clean.bat");
            Application.Exit();

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
