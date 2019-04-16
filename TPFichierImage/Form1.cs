using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TPFichierImage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.RestoreDirectory = true ;
            if (this.openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.pictureBox1.ImageLocation = openFileDialog1.FileName ;
            }
        }

        private void btnSaveGG_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(System.IO.Path.GetDirectoryName(pictureBox1.ImageLocation));
            GGBitmap.SavePictureGGFormat(pictureBox1.Image, System.IO.Path.GetDirectoryName(pictureBox1.ImageLocation)+"\\toto.gg");
        }

        private void btnLoadGG_Click(object sender, EventArgs e)
        {

            this.openFileDialog1.RestoreDirectory = true;
            this.openFileDialog1.Filter = "Images format GG | *.gg";
            if (this.openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.pictureBox1.Image = GGBitmap.LoadPictureGGFormat(openFileDialog1.FileName);
            }

        }
    }
}
