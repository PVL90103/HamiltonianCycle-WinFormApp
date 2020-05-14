using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HamiltonianLibrary1;

namespace HamiltonianCycle_winform
{
    public partial class WorkPage : UserControl
    {
        public WorkPage()
        {
            InitializeComponent();

            ReadFromFile_label.Click += ReadFromFile_label_Click;
            
        }

        private void ReadFromFile_label_Click(object sender, EventArgs e)
        {
            
     
            
        }

        private void ReadFromFile_text_Click(object sender, EventArgs e)
        {

        }

        private void ManualInput_text_Click(object sender, EventArgs e)
        {

        }

        private void EnterPath_button_Click(object sender, EventArgs e)
        {

        }
    }
}
