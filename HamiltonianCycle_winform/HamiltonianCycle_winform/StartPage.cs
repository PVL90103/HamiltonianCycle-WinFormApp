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
    public partial class StartPage : Form
    {
        public List<Panel> panels = new List<Panel>();
        public String str;
        public StartPage()
        {
            InitializeComponent();
        }

        private void StartPage_Load(object sender, EventArgs e)
        {
            /*panels.Add(SP_back_panel);
            panels.Add(MenuPanel);
            panels.Add(WorkingPanel);
            panels[0].BringToFront();//*/
            WorkingPanel.Hide();
            MenuPanel.Hide();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
           // Hide();
           /* GraphReader reader = new GraphReader("../../Resourses/test_big_graph.txt");
            Graph graph = reader.read();
            reader.close();
            String result = "";
            List<int> path = Solver.Solve(ref graph);
            foreach (int vertex in path)
            {
                result += vertex;
                result += ' ';
            }
            MessageBox.Show(result, "Result");*/
            WorkingPanel.Show();
            MenuPanel.Show();
        }

        private void EnterPath_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog OPF = new OpenFileDialog();
            OPF.Filter = "Файлы txt|*.txt|Файлы cs|*.cs";
            if (OPF.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(OPF.FileName);
            }

            GraphReader reader = new GraphReader(OPF.FileName);
            Graph graph = reader.read();
            reader.close();

            TestData.Test(graph);
            str = TestData.S;
            Template template = new Template(str);
            template.Show();
            

        }

        private void WorkingPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void InputMatrix_button_Click(object sender, EventArgs e)
        {
            InputMatrix inputMatrix = new InputMatrix();
            inputMatrix.Show();
        }
    }
}
