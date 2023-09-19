using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningWinform2
{
    public partial class ImageList : Form
    {
        public ImageList()
        {
            InitializeComponent();
        }

        private void ImageList_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            
        }
        int index = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            index++;
            label1.Text=index.ToString();
            if (index == 5)
            {
                Label lb= new Label();
                lb.Location.X.Equals(320);
                lb.Location.Y.Equals(320);
                lb.Text="khanh dep trai";
                lb.Visible = true ;
                lb.Show();
            }
            
            
        }
    }
}
