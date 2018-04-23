using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MyWinExplorerView.Properties;

namespace MyXtraGrid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Image image = Resources.img;            
            for (int i = 0; i < 10; i++)
            {
                dataTable1.Rows.Add("Item" + i, image);
            }
        }
    }
}
