using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maze_Game
{
    public partial class Form1 : Form
    {
        
        
        public Form1()
        {
            InitializeComponent();
            MoveToStart();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void finishlabel_MouseEnter(object sender, EventArgs e)
        {
            //finish.Play();
            MessageBox.Show("Congratulations ");
            Close();
        }
        private void MoveToStart()
        {
            //start.Play();
            Point startingpoint = panel1.Location;
            startingpoint.Offset(10, 10);
            Cursor.Position = PointToScreen(startingpoint);
        }

        private void wall_MouseEnter(object sender, EventArgs e)
        {
            MoveToStart();
        }
    }
}
