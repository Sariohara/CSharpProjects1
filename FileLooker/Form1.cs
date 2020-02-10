using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileLooker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitProgram();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExitProgram();
        }

        private void ExitProgram()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                Application.Exit();
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                System.Environment.Exit(0);
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                System.Environment.Exit(0);
            }
            else
            {
                Application.Exit();
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {

        }

        private void BtnClear_Click_1(object sender, EventArgs e)
        {
            ClearContents();
        }

        private void ClearContents()
        {
            txtDirectory.Clear();
            lstdata.Items.Clear();
            lstsearchfile.Items.Clear();
        }
    }
}
