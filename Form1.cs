using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Bitmap newFile;

        ImageManipulation modifyRBG = new ImageManipulation();
        FileOperations getFile = new FileOperations();

        public Form1()
        {
            InitializeComponent();

            modifyRBG.ImageFinished += OnImageFinished;
        }

        public void DisplayImage(Bitmap b, int window)
        {
            pictureBox1.Image = b;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            newFile = getFile.OpenFile();

            DisplayImage(newFile, 1);
        }

        public void OnImageFinished(object sender, ImageEventArgs e)
        {
            DisplayImage(e.bmap, 1);
            label1.Text = "event handler received";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            modifyRBG.Manipulate(newFile);
        }
    }
}
