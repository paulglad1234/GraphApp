using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphApp
{
    public partial class GraphApp : Form
    {
        Graph g = new Graph();
        DrawSet d = new DrawSet(Color.Black, Color.LightSteelBlue, Color.PaleVioletRed,
                                        Color.Black, new Font("Courier New", 10, FontStyle.Bold), 20);
        public GraphApp()
        {
            InitializeComponent();
        }
        private void Draw()
        {
            pictureBox.Image = g.Draw(pictureBox.Height, pictureBox.Width, d);
            labelChecked.Text = "Является ли граф связным?";
        }
        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (addNodeRadioButton.Checked)
                g.AddNode(e.X, e.Y);
            if (deleteNodeRadioButton.Checked)
                g.DeleteNode(e.X, e.Y);
            if (moveNodeRadioButton.Checked)
                g.MoveNode(e.X, e.Y);
            if (addEdgeRadioButton.Checked)
                g.AddEdge(e.X, e.Y);
            if (deleteEdgeRadioButton.Checked)
                g.DeleteEdge(e.X, e.Y);
            Draw();
        }

        private void buttonCheckConnection_Click(object sender, EventArgs e)
        {
            labelChecked.Text = g.IsConnected();
        }
    }
}
