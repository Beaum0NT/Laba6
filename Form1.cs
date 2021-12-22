using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOBAKICH
{
    public partial class Frmmain : Form

    {
        private int openDoc;

        public Frmmain()
        {
            InitializeComponent();
        }
        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void theToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }
        private void theVertkalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }
        private void arrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }
        private void Frmmain_Load(object sender, EventArgs e)
        {

        }
        private void mnuNew_Click(object sender, EventArgs e)
        {
            blank frm = new blank();
            frm.DocName = "Документ " + ++openDoc;
            frm.Text = frm.DocName; frm.MdiParent = this;
            frm.Show();
        }
        private void mnuWindow_Click(object sender, EventArgs e)
        {

        }
        private void mnuCascade_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }
        private void mnuCut_Click(object sender, EventArgs e)
        {
            blank frm = (blank)(this.ActiveMdiChild);
            frm.Cut();
        }
        private void mnuCopy_Click(object sender, EventArgs e)
        {
            blank frm = (blank)(this.ActiveMdiChild);
            frm.Copy();
        }
        private void mnuPaste_Click(object sender, EventArgs e)
        {
            blank frm = (blank)(this.ActiveMdiChild);
            frm.Paste();
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blank frm = (blank)(this.ActiveMdiChild);
            frm.Delete();
        }
        private void mnuSelectAll_Click(object sender, EventArgs e)
        {
            blank frm = (blank)(this.ActiveMdiChild);
            frm.SelectAll();
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blank frm = (blank)(this.ActiveMdiChild);
            frm.FontColor("Black");
        }
        private void greenToolStripMenuItem_Click(object sender, EventArgs e) // добовляет зеленый цвет
        {
            blank frm = (blank)(this.ActiveMdiChild);
            frm.FontColor("Green");
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blank frm = (blank)(this.ActiveMdiChild);
            frm.FontColor("Blue");
        }
        private void purpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blank frm = (blank)(this.ActiveMdiChild);
            frm.FontColor("Purple");
        }
        private void timesNewRomanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blank frm = (blank)(this.ActiveMdiChild);
            frm.fonts("TimesNewRoman");
        }

        private void arialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blank frm = (blank)(this.ActiveMdiChild);
            frm.fonts("Arial");
        }

        private void calibriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blank frm = (blank)(this.ActiveMdiChild);
            frm.fonts("Calibri");
        }
        private void impactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blank frm = (blank)(this.ActiveMdiChild);
            frm.fonts("Impact");
        }
        private void mnuOpen_Click(object sender, EventArgs e)
        {
            mnuSave.Enabled = true;
            openFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files(*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                blank frm = new blank(); frm.Open(openFileDialog1.FileName);
                frm.MdiParent = this;                                    
                frm.DocName = openFileDialog1.FileName;
                frm.Text = frm.DocName;
                frm.Show();
            }
        }

        private void mnuSave_Click(object sender, EventArgs e)
        {
            
            mnuSave.Enabled = false;
            saveFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files(*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                blank frm = (blank)(this.ActiveMdiChild);
                frm.Save(saveFileDialog1.FileName); frm.MdiParent = this;
                frm.DocName = saveFileDialog1.FileName; frm.Text = frm.DocName;
            }
            {
                blank frm = (blank)(this.ActiveMdiChild);
                frm.Save(frm.DocName);
                frm.IsSaved = true;
            }
        }

        private void mnuSaveAs_Click(object sender, EventArgs e)
        {
            mnuSave.Enabled = true;
            saveFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files(*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                blank frm = (blank)(this.ActiveMdiChild);
                frm.Save(saveFileDialog1.FileName); frm.MdiParent = this;
                frm.DocName = saveFileDialog1.FileName; frm.Text = frm.DocName;
                frm.IsSaved = true;
            }
        }

        private void mnuFont_Click(object sender, EventArgs e)
        {

        } 
    }
}
