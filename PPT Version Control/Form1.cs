using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPT_Version_Control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int pixles = getPixles();
            pixelsLabel.Text = "This window contains " + pixles + "pixles";

        }
        private int getPixles()
        {

        int height = this.Size.Height;
        int width = this.Size.Width;
        int pixles = height * width;
        return pixles;
          }
        private void Form_Resize (object sender , EventArgs e)
        {
            int pixles = getPixles();
            pixelsLabel.Text = "After resizing , this windows contains " + pixles + "pixles";
        }
    }
}
