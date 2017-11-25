using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if(btnStart.Text.Contains("On"))
            {
                btnStart.Text = "Turn Off Manager";
                pictureBox1.Image = new Bitmap("C:\\Users\\User\\Documents\\Visual Studio 2015\\Projects\\ManagementApplication\\ManagementApplication\\green.png");

                




            }
            else
            {
                btnStart.Text = "Turn On Manager";
                pictureBox1.Image = new Bitmap("C:\\Users\\User\\Documents\\Visual Studio 2015\\Projects\\ManagementApplication\\ManagementApplication\\red.png");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
