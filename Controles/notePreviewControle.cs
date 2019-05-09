using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyNotes.Classes;

namespace MyNotes.Controles
{
    public partial class notePreviewControle : UserControl
    {
        public Note thisNote;

        public notePreviewControle(Note note)
        {
            InitializeComponent();
            thisNote = note;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void notePreviewControle_Load(object sender, EventArgs e)
        {
            label1.Text = thisNote.title;
            label2.Text = thisNote.content;
            label3.Text = thisNote.startDate.ToShortDateString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                
            }
        }
    }
}
