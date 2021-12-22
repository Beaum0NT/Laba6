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

namespace SOBAKICH
{
    public partial class blank : Form
    {
        public bool IsSaved = false;
        public String DocName;
        private String BufferText;
        public blank()

        {
            InitializeComponent();

        }
        public void font(string fontRR)
        {
            richTextBox1.SelectionFont = new Font(fontRR, 9);
        }
        public void FontColor(string FontColorRR)
        {
            switch (FontColorRR)
            {
                case ("Black"): richTextBox1.SelectionColor = System.Drawing.Color.Black; break;
                case ("Green"): richTextBox1.SelectionColor = System.Drawing.Color.Green; break;             
                case ("Blue"): richTextBox1.SelectionColor = System.Drawing.Color.Blue; break;
                case ("Purple"): richTextBox1.SelectionColor = System.Drawing.Color.Purple; break;
            }
        }
        public void fonts(string fontSS)
        {
            richTextBox1.SelectionFont = new Font(fontSS, 14);
        }
        public void Cut()
        { 
            this.BufferText = richTextBox1.SelectedText;
            richTextBox1.SelectedText = "";
        }
        public void Copy()
        { 
            this.BufferText = richTextBox1.SelectedText;
        }
        public void Paste()
        { 
            richTextBox1.SelectedText = this.BufferText;
        }
        public void SelectAll()
        {
            richTextBox1.SelectAll();
        }
        public void Delete()
        { 
            richTextBox1.SelectedText = "";
            this.BufferText = "";
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void cmnuCut_Click(object sender, EventArgs e)
        {
            Cut();
        }
        private void cmnuCopy_Click(object sender, EventArgs e)
        {
            Copy();
        }
        private void cmnuPaste_Click(object sender, EventArgs e)
        {
            Paste();
        }
        private void cmnuDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }
        private void cmnuSelectAll_Click(object sender, EventArgs e)
        {
            SelectAll();
        }
        public void Open(String OpenFileName)
        {
            if (OpenFileName == null) { return; }
            else
            {
                StreamReader sr = new StreamReader(OpenFileName);
                richTextBox1.Text = sr.ReadToEnd(); sr.Close();
                DocName = OpenFileName;
            }
        }
        public void Save(String SaveFileName)
        {
            if (SaveFileName == null) { return; }
            else
            {
                StreamWriter sw = new StreamWriter(SaveFileName);
                sw.WriteLine(richTextBox1.Text); sw.Close();
                DocName = SaveFileName;
            }
        }
        private void blank_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (IsSaved == true)
                if (MessageBox.Show("Do you want save changes in "
                + this.DocName + "?", "Message", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Save(this.DocName);
                }
        }
    }
}
