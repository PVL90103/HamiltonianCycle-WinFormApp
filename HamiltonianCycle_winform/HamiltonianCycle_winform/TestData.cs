using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HamiltonianLibrary1;

namespace HamiltonianCycle_winform
{
    class TestData
    {
        private static String s;

        public static string S { get => s; set => s = value; }

        public static void Test(Graph graph)
        {
            if (!(graph.isConnected()))
            {
                s = "Граф несвязный";
            }
            else
            {
                // Массив, в котором каждый элемент отвечает на вопрос, о том
                // посещали мы соответствующую вершину или нет
                bool[] visited = new bool[graph.Size];
                for (int i = 0; i < visited.Length; i++)
                {
                    visited[i] = false;
                }

                List<int> path = new List<int>(graph.Size);

                bool answer = HamiltonianCycle.Find_cycle(0, ref graph, ref path, ref visited);
                if (answer)
                {
                    s = "Гамильтонов цикл проходит по вершинам: ";
                    for (int i = 0; i < path.Count; i++)
                    {
                        s += (path[i]);
                    }
                    s += (path[0]);
                    //Console.WriteLine();
                    //Console.ReadKey();
                }
                else
                {
                    s = "Гамильтонов цикл не найден";
                }
            }
        }

        // Полный граф
        public static Graph TestGraph_complete(int size)
        {
            Graph graph = new Graph(size);
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    graph[i, j] = 1;
                }
            }
            return graph;
        }

        // Несвязный граф с одной изолированной вершиной
        public static Graph TestGraph_disconnected(int size)
        {
            Graph graph = new Graph(size);
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (j == size - 1)
                    {
                        graph[i, j] = 0;
                    }
                    else
                    {
                        graph[i, j] = 1;
                    }
                }
            }
            return graph;
        }

        public static Graph TestGraph_withCycle()
        {
            Graph graph = new Graph(5);

            // Первая строка
            graph[0, 0] = 0;
            graph[0, 1] = 0;
            graph[0, 2] = 1;
            graph[0, 3] = 1;
            graph[0, 4] = 1;

            // Вторая строка
            graph[1, 0] = 0;
            graph[1, 1] = 0;
            graph[1, 2] = 0;
            graph[1, 3] = 1;
            graph[1, 4] = 1;

            // Третья строка
            graph[2, 0] = 1;
            graph[2, 1] = 0;
            graph[2, 2] = 0;
            graph[2, 3] = 1;
            graph[2, 4] = 1;

            // Четвертая строка
            graph[3, 0] = 1;
            graph[3, 1] = 1;
            graph[3, 2] = 1;
            graph[3, 3] = 0;
            graph[3, 4] = 0;

            // Пятая строка
            graph[4, 0] = 1;
            graph[4, 1] = 1;
            graph[4, 2] = 1;
            graph[4, 3] = 0;
            graph[4, 4] = 0;
            return graph;
        }

        // Простой трёхвершинный граф из файла
        public static Graph TestGraph_file()
        {
            GraphReader reader = new GraphReader("../../Resourses/test_graph.txt");
            Graph graph = reader.read();
            reader.close();
            return graph;
        }

        // Рандомный граф. Не проходит теорему Дирака. 
        // todo: подумать как переделать
        public static Graph TestGraph_random(int size)
        {
            Graph graph = new Graph(size);
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    graph[i, j] = random.Next(0, 2);
                }
            }
            return graph;
        }

        // Граф, у которого в матрице смежности единицы стоят в шахматном порядке. Гамильтонов цикл есть при чётном размере
        public static Graph TestGraph_chess(int size)
        {
            Graph graph = new Graph(size);
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    graph[i, j] = 0;
                    if ((i % 2 == 1 & j % 2 == 0) | (i % 2 == 0 & j % 2 == 1))
                    {
                        graph[i, j] = 1;
                    }
                }
            }
            return graph;
        }

        // Большой граф размерности 10, из файла
        public static Graph TestGraph_big()
        {
            GraphReader reader = new GraphReader("../../Resourses/test_big_graph.txt");
            Graph graph = reader.read();
            reader.close();
            return graph;
        }

        public static Graph TestGraph_string()
        {
            GraphStringReader reader = new GraphStringReader("4\r\n1 1 1 1\r\n1 1 1 1\r\n1 1 1 1\r\n1 1 1 1");
            Graph graph = reader.read();
            reader.close();
            return graph;
        }
    }
}
