using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamiltonianCycle_console
{
    class Program
    {
        static void Test(Graph graph)
        {
            if (!(graph.isConnected()))
            {
                Console.WriteLine("Граф несвязный");
                Console.ReadKey();
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
                    Console.WriteLine("Гамильтонов цикл построен. Он проходит по вершинам:");
                    for (int i = 0; i < path.Count; i++)
                    {
                        Console.Write(path[i]);
                    }
                    Console.Write(path[0]);
                    Console.WriteLine();
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Гамильтонов цикл не найден");
                    Console.ReadKey();
                }
            }
        }


        static void Main(string[] args)
        {
            // Тестовые графы
            // Задаются матрицами смежности в специальном тестовом классе TestData
            Graph completeGraph = TestData.TestGraph_complete(10);
            Graph discGraph = TestData.TestGraph_disconnected(5);
            Graph graph = TestData.TestGraph_withCycle();
            Graph randomGraph = TestData.TestGraph_random(10);
            Graph chessGraph = TestData.TestGraph_chess(6);
            Graph bigGraph = TestData.TestGraph_big();
            Graph fileGraph = TestData.TestGraph_file();
            Graph stringGrap = TestData.TestGraph_string();

            Console.WriteLine("=== 0 ===");
            Console.WriteLine("Полный граф, чтение из строки");
            Test(stringGrap);

            Console.WriteLine("=== 1 ===");
            Console.WriteLine("Полный граф");
            Test(completeGraph);

            Console.WriteLine("=== 2 ===");
            Console.WriteLine("Несвязный граф");
            Test(discGraph);

            Console.WriteLine("=== 3 ===");
            Console.WriteLine("Граф с 5 вершинами");
            Test(graph);

            Console.WriteLine("=== 4 ===");
            Console.WriteLine("Рандомный граф");
            Test(randomGraph);

            Console.WriteLine("=== 5 ===");
            Console.WriteLine("Граф, у которого 1 в матрице в шахматном порядке");
            Test(chessGraph);

            Console.WriteLine("=== 6 ===");
            Console.WriteLine("Граф размерности 3 из файла");
            Test(fileGraph);

            Console.WriteLine("=== 7 ===");
            Console.WriteLine("Граф размерности 10 из файла");
            Test(bigGraph);
        }
    }
}
