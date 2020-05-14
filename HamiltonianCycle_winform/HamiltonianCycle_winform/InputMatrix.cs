using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using HamiltonianLibrary1;

namespace HamiltonianCycle_winform
{
    public partial class InputMatrix : Form
    {
        public Graph graph;
        public int n;
        public String s;
        public InputMatrix()
        {
            InitializeComponent();
        }

        private void ImputMatrix_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //int size;
            int.TryParse(textBox1.Text, out n);
            //label4.Text = textBox1.Text;
            //GraphStringReader reader = new GraphStringReader(textBox1.Text);
            //Graph graph = reader.read();
            // reader.close();


        }

        //private void textBox2_TextChanged(object sender, EventArgs e)
        //{
            // Graph graph = new Graph(size);
            //int[] mas = textBox2.Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(n => int.Parse(n.Trim())).ToArray();
            //int size;
            //int.TryParse(textBox1.Text, out size);
            //label4.Text = textBox1.Text;
            //graph = new Graph(size);
            //for (int i = 0; i < size; ++i)
            //    for (int j = 0; j < size; ++j)
             //   {
             //       graph[i, j] = mas[i];
             //   }

            
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            //int[] mas = textBox2.Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(n => int.Parse(n.Trim())).ToArray();

            StringReader reader = new StringReader(textBox2.Text);

            string line;
            line = reader.ReadLine();
            graph = new Graph(n);
       

            for (int i = 0; i < n; i++)
            {
                string[] edges = line.Split(' ');
                for (int j = 0; j < n; j++)
                {
                    graph[i, j] = Int32.Parse(edges[j]);
                }
            }
            

            if ((textBox1.Text != "") && (textBox2.Text != ""))
            {
                TestData.Test(graph);
                s = TestData.S;
                Template template = new Template(s);
                template.Show();
             
            }
                

        }
    }
}
