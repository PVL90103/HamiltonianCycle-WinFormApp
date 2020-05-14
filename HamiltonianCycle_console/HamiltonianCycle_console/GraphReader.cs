using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamiltonianCycle_console
{
    class GraphReader
    {
        public StreamReader reader;

        // Конструкторы: по пути к файлу и по ридеру
        public GraphReader(string path)
        {
            this.reader = new StreamReader(path);
        }

        public GraphReader(StreamReader reader)
        {
            this.reader = reader;
        }

        public Graph read()
        {
            int size = Int32.Parse(reader.ReadLine());
            Graph graph = new Graph(size);
            string line;
            for (int i = 0; i < size; i++)
            {
                line = reader.ReadLine();
                string[] edges = line.Split(' ');
                for (int j = 0; j < size; j++)
                {
                    graph[i, j] = Int32.Parse(edges[j]);
                }
            }
            return graph;
        }

        public void close()
        {
            reader.Close();
        }
    }
}
