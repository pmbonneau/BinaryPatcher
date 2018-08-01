using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinaryPatcherUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        string FilePath = "";
        string PatchContainerPath = "";
        BinaryPatcherLib.BinaryPatcher Patcher;

        private void btnPatchFile_Click(object sender, EventArgs e)
        {
            Patcher = new BinaryPatcherLib.BinaryPatcher(FilePath, PatchContainerPath);
            Patcher.ApplyPatchToFile();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog vOpenFileDialog = new OpenFileDialog();
            DialogResult result = vOpenFileDialog.ShowDialog();
            FilePath = vOpenFileDialog.FileName;
            txtFilePath.Text = vOpenFileDialog.FileName;
        }

        private void btnOpenContainer_Click(object sender, EventArgs e)
        {
            OpenFileDialog vOpenFileDialog = new OpenFileDialog();
            DialogResult result = vOpenFileDialog.ShowDialog();
            PatchContainerPath = vOpenFileDialog.FileName;
            txtContainerPath.Text = vOpenFileDialog.FileName;
        }

        private void btnCheckAvailablePatches_Click(object sender, EventArgs e)
        {
            string[] AvailablePatches;
            Patcher = new BinaryPatcherLib.BinaryPatcher(FilePath, PatchContainerPath);
            AvailablePatches = Patcher.GetPatchListID();
        }
    }
}
