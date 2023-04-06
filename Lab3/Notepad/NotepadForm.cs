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

namespace Notepad
{
    public partial class NotepadForm : Form
    {
        protected bool changed { get; set; } = false;
        protected bool haspath { get; set; } = false;
        protected string filepath { get; set; } = "untitled.txt";

        public NotepadForm()
        {
            InitializeComponent();
        }

        private void fileChangedCheck()
        {
            if (changed)
            {
                DialogResult result = MessageBox.Show("Do you want to save?", "Unsaved changes!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
                if (result == DialogResult.Yes)
                {
                    saveToolStripMenuItem_Click(this, EventArgs.Empty);
                }
                else if (result == DialogResult.Cancel)
                {
                    throw new Exception("Cancel was pressed");
                }
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                fileChangedCheck();
                TextBox.Text = string.Empty;
                filepath = "untitled.txt";
                this.Text = "Notepad: " + Path.GetFileName(filepath);
                haspath = false;
                changed = false;
            }
            catch (Exception)
            {
                //Do nothing
            }
        }

        private void newWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo() {FileName = Application.ExecutablePath});
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                fileChangedCheck();
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Text Files|*.txt";
                DialogResult result = dialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    haspath= true;
                    filepath = dialog.FileName;
                    TextBox.Text = File.ReadAllText(filepath);
                    changed = false;
                    this.Text = "Notepad: " + Path.GetFileName(filepath);
                }
            }
            catch (Exception)
            {
                //Do nothing
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!haspath)
            {
                saveAsToolStripMenuItem_Click(sender, EventArgs.Empty);
                return;
            }
            File.WriteAllText(filepath, TextBox.Text);
            this.Text = "Notepad: " + Path.GetFileName(filepath);
            changed = false;
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Text Files|*.txt";
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                haspath = true;
                filepath = dialog.FileName;
                File.WriteAllText(filepath, TextBox.Text);
                this.Text = "Notepad: " + Path.GetFileName(filepath);
                changed = false;
            }
            
            if (sender == this)
            {
                throw new Exception("Cancel was pressed");
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            changed = true;
            this.Text = "Notepad: *" + Path.GetFileName(filepath);
            updateStats();
        }

        private void updateStats()
        {
            int lines = 1, spaces = 0;
            
            for (int i = 0; i < TextBox.Text.Length; i++)
            {
                if (TextBox.Text[i] == '\n')
                {
                    lines++;
                }
                else if (TextBox.Text[i] == ' ')
                {
                    spaces++;
                }
            }
            CharacterLabel.Text = "Characters: " + (TextBox.Text.Length - (lines - 1) * 2).ToString();
            CharacterNoSpaceLabel.Text = "Characters No Space: " + (TextBox.Text.Length - (lines - 1) * 2 - spaces).ToString();
            LinesLabel.Text = "Lines: " + lines.ToString();
            char[] delimiters = new char[] {' ', '\r', '\n' }; //https://stackoverflow.com/questions/8784517/counting-number-of-words-in-c-sharp
            WordLabel.Text = "Words: " + TextBox.Text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).Length.ToString(); 
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            try
            {
                fileChangedCheck();
            }
            catch (Exception)
            {
                e.Cancel = true;
            }
            base.OnFormClosing(e);
        }
    }
}
