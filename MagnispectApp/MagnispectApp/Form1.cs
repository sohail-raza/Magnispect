using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagnispectApp
{
    public partial class Form1 : Form

       
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        // Test function for image resizing
        private static Image ResizeImage(Image img, Size newSize) //img is the src, newSize is the dimensions of the image
        {
            Image newImg = new Bitmap(newSize.Width, newSize.Height);


            using (Graphics graph = Graphics.FromImage((Bitmap)newImg)) //Bitmap cast
            {
                graph.DrawImage(img, new Rectangle(Point.Empty, newSize));
            }
            return newImg;

        }

   

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void loadImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }
    }
}
