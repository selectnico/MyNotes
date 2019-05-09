using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyNotes.Classes;
using MyNotes.Controles;

namespace MyNotes
{
    public partial class Form1 : Form
    {
        public List<notePreviewControle> previewNotes;
        public Form1()
        {
            InitializeComponent();
        }

        #region menu hover
        private void panelUpgrade_MouseHover(object sender, EventArgs e)
        {
            Color bc = new Color();
            bc = Color.FromArgb(255, 237, 160, 0);
            panelUpgrade.BackColor = bc;
        }

        private void pbUpgradeIcon_MouseHover(object sender, EventArgs e)
        {
            Color bc = new Color();
            bc = Color.FromArgb(255, 237, 160, 0);
            panelUpgrade.BackColor = bc;
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            Color bc = new Color();
            bc = Color.FromArgb(255, 237, 160, 0);
            panelUpgrade.BackColor = bc;
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            Color bc = new Color();
            bc = Color.FromArgb(255, 237, 160, 0);
            panelUpgrade.BackColor = bc;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            Color bc = new Color();
            bc = Color.FromArgb(255, 254, 173, 2);
            panelUpgrade.BackColor = bc;
        }

        private void pbUpgradeIcon_MouseLeave(object sender, EventArgs e)
        {
            Color bc = new Color();
            bc = Color.FromArgb(255, 254, 173, 2);
            panelUpgrade.BackColor = bc;
        }

        private void pbUpgradeIcon_MouseEnter(object sender, EventArgs e)
        {
            Color bc = new Color();
            bc = Color.FromArgb(255, 237, 160, 0);
            panelUpgrade.BackColor = bc;
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            Color bc = new Color();
            bc = Color.White;
            labelNewNote.ForeColor = bc;
        }

        private void labelNewNote_MouseLeave(object sender, EventArgs e)
        {
            Color bc = new Color();
            bc = Color.Silver;
            labelNewNote.ForeColor = bc;
        }

        private void labelNewNote_MouseEnter(object sender, EventArgs e)
        {
            Color bc = new Color();
            bc = Color.White;
            labelNewNote.ForeColor = bc;
        }

        private void panelNewNote_MouseEnter(object sender, EventArgs e)
        {
            Color bc = new Color();
            bc = Color.White;
            labelNewNote.ForeColor = bc;
        }

        private void panelNewNote_MouseHover(object sender, EventArgs e)
        {
            Color bc = new Color();
            bc = Color.White;
            labelNewNote.ForeColor = bc;
        }

        private void panelNewNote_MouseLeave(object sender, EventArgs e)
        {
            Color bc = new Color();
            bc = Color.Silver;
            labelNewNote.ForeColor = bc;
        }

        private void panelTop_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panelTop.ClientRectangle, Color.Silver, ButtonBorderStyle.Solid);
        }

        private void panelTop_SizeChanged(object sender, EventArgs e)
        {
            panelTop.Invalidate();
        }

        private void panel1_ParentChanged(object sender, EventArgs e)
        {
            
        }

        private void flowLayoutPanel1_SizeChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Here");
            panelFavoriten.Width = flowLayoutPanel1.Width;
        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            Color bc = new Color();
            bc = Color.Gray;
            panelFavoriten.BackColor = bc;
        }

        private void panelFavoriten_MouseLeave(object sender, EventArgs e)
        {
            Color bc = new Color();
            bc = Color.Transparent;
            panelFavoriten.BackColor = bc;
        }

        private void panelFavoriten_MouseEnter(object sender, EventArgs e)
        {
            Color bc = new Color();
            bc = Color.Gray;
            panelFavoriten.BackColor = bc;
        }

        private void labelFavoriten_MouseEnter(object sender, EventArgs e)
        {
            Color bc = new Color();
            bc = Color.Gray;
            panelFavoriten.BackColor = bc;
        }

        private void labelFavoriten_MouseHover(object sender, EventArgs e)
        {
            Color bc = new Color();
            bc = Color.Gray;
            panelFavoriten.BackColor = bc;
        }

        private void labelFavoriten_MouseLeave(object sender, EventArgs e)
        {
            Color bc = new Color();
            bc = Color.Transparent;
            panelFavoriten.BackColor = bc;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            Color bc = new Color();
            bc = Color.Gray;
            panelFavoriten.BackColor = bc;
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            Color bc = new Color();
            bc = Color.Gray;
            panelFavoriten.BackColor = bc;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            Color bc = new Color();
            bc = Color.Transparent;
            panelFavoriten.BackColor = bc;
        }

        private void panel2_MouseEnter(object sender, EventArgs e)
        {
            Color bc = new Color();
            bc = Color.Gray;
            panelNote.BackColor = bc;
        }

        private void panel2_MouseHover(object sender, EventArgs e)
        {
            Color bc = new Color();
            bc = Color.Gray;
            panelNote.BackColor = bc;
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            Color bc = new Color();
            bc = Color.Transparent;
            panelNote.BackColor = bc;
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            Color bc = new Color();
            bc = Color.Gray;
            panelNote.BackColor = bc;
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            Color bc = new Color();
            bc = Color.Gray;
            panelNote.BackColor = bc;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            Color bc = new Color();
            bc = Color.Transparent;
            panelNote.BackColor = bc;
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            Color bc = new Color();
            bc = Color.Gray;
            panelNote.BackColor = bc;
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            Color bc = new Color();
            bc = Color.Gray;
            panelNote.BackColor = bc;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            Color bc = new Color();
            bc = Color.Transparent;
            panelNote.BackColor = bc;
        }

        private void panel3_MouseEnter(object sender, EventArgs e)
        {
            Color bc = new Color();
            bc = Color.Gray;
            panelBuch.BackColor = bc;
        }

        private void panel3_MouseHover(object sender, EventArgs e)
        {
            Color bc = new Color();
            bc = Color.Gray;
            panelBuch.BackColor = bc;
        }

        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            Color bc = new Color();
            bc = Color.Transparent;
            panelBuch.BackColor = bc;
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            Color bc = new Color();
            bc = Color.Gray;
            panelBuch.BackColor = bc;
        }

        private void label4_MouseHover(object sender, EventArgs e)
        {
            Color bc = new Color();
            bc = Color.Gray;
            panelBuch.BackColor = bc;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            Color bc = new Color();
            bc = Color.Transparent;
            panelBuch.BackColor = bc;
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            Color bc = new Color();
            bc = Color.Gray;
            panelBuch.BackColor = bc;
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            Color bc = new Color();
            bc = Color.Gray;
            panelBuch.BackColor = bc;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            Color bc = new Color();
            bc = Color.Transparent;
            panelBuch.BackColor = bc;
        }

        private void panel4_MouseEnter(object sender, EventArgs e)
        {
            Color bc = new Color();
            bc = Color.Gray;
            panelFrei.BackColor = bc;
        }

        private void panel4_MouseHover(object sender, EventArgs e)
        {
            Color bc = new Color();
            bc = Color.Gray;
            panelFrei.BackColor = bc;
        }

        private void panel4_MouseLeave(object sender, EventArgs e)
        {
            Color bc = new Color();
            bc = Color.Transparent;
            panelFrei.BackColor = bc;
        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            Color bc = new Color();
            bc = Color.Gray;
            panelFrei.BackColor = bc;
        }

        private void label5_MouseHover(object sender, EventArgs e)
        {
            Color bc = new Color();
            bc = Color.Gray;
            panelFrei.BackColor = bc;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            Color bc = new Color();
            bc = Color.Transparent;
            panelFrei.BackColor = bc;
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            Color bc = new Color();
            bc = Color.Gray;
            panelFrei.BackColor = bc;
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            Color bc = new Color();
            bc = Color.Gray;
            panelFrei.BackColor = bc;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            Color bc = new Color();
            bc = Color.Transparent;
            panelFrei.BackColor = bc;
        }

        private void panel5_MouseEnter(object sender, EventArgs e)
        {
            Color bc = new Color();
            bc = Color.Gray;
            panelBin.BackColor = bc;
        }

        private void panel5_MouseHover(object sender, EventArgs e)
        {
            Color bc = new Color();
            bc = Color.Gray;
            panelBin.BackColor = bc;
        }

        private void panel5_MouseLeave(object sender, EventArgs e)
        {
            Color bc = new Color();
            bc = Color.Transparent;
            panelBin.BackColor = bc;
        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            Color bc = new Color();
            bc = Color.Gray;
            panelBin.BackColor = bc;
        }

        private void label6_MouseHover(object sender, EventArgs e)
        {
            Color bc = new Color();
            bc = Color.Gray;
            panelBin.BackColor = bc;
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            Color bc = new Color();
            bc = Color.Transparent;
            panelBin.BackColor = bc;
        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            Color bc = new Color();
            bc = Color.Gray;
            panelBin.BackColor = bc;
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            Color bc = new Color();
            bc = Color.Gray;
            panelBin.BackColor = bc;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            Color bc = new Color();
            bc = Color.Transparent;
            panelBin.BackColor = bc;
        }
        #endregion

        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {
            pictureBox6.Height = pictureBox6.Height + 1;
            pictureBox6.Width = pictureBox6.Width + 1;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.Height = pictureBox6.Height - 1;
            pictureBox6.Width = pictureBox6.Width - 1;
        }

        private void flowLayoutPanel3_SizeChanged(object sender, EventArgs e)
        {
            adjustNoteSizes();
            adjustSearchBarSizes();
        }

        private void adjustSearchBarSizes()
        {
            searchBar.Width = panel1.Width - 13;
        }

        private void adjustNoteSizes()
        {
            foreach (var note in previewNotes)
            {
                note.Width = flowLayoutPanel3.Width-8;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            previewNotes = new List<notePreviewControle>();
        }

        private void labelNewNote_Click(object sender, EventArgs e)
        {
            Note tempNote = new Note();
            tempNote.title = textBox2.Text;
            tempNote.content = richTextBox1.Text;
            tempNote.startDate = dateTimePicker1.Value;
            notePreviewControle tempControle = new notePreviewControle(tempNote);
            flowLayoutPanel3.Controls.Add(tempControle);
            previewNotes.Add(tempControle);
            tempControle.Width = flowLayoutPanel3.Width - 8;
        }

        private void pbNewNote_Click(object sender, EventArgs e)
        {
            Note tempNote = new Note();
            tempNote.title = textBox2.Text;
            tempNote.content = richTextBox1.Text;
            tempNote.startDate = dateTimePicker1.Value;
            notePreviewControle tempControle = new notePreviewControle(tempNote);
            flowLayoutPanel3.Controls.Add(tempControle);
            previewNotes.Add(tempControle);
            tempControle.Width = flowLayoutPanel3.Width - 8;
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox2.Text != "" && richTextBox1.Text != "")
                textBox2.Clear();
                richTextBox1.Clear();
        }

        private void colorPanel(Panel panel, string color)
        {
            Color bc = new Color();
            switch (color)
            {
                case "orange-light":
                    bc = Color.FromArgb(255, 254, 173, 2);
                    break;
                case "orange-dark":
                    bc = Color.FromArgb(255, 237, 160, 0);
                    break;
                case "light-grey":
                    bc = Color.FromArgb(255)
            }
            panel.BackColor = bc;
        }
    }
}
