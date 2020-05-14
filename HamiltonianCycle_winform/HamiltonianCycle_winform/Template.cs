using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HamiltonianLibrary1;

namespace HamiltonianCycle_winform
{
    public partial class Template : Form
    {
        public Template(String s)
        {
            InitializeComponent();
            label1.Text = s;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void HamiltonianCycle_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
