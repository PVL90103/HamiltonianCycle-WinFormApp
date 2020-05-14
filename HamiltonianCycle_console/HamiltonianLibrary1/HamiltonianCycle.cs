using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamiltonianLibrary1
{
    public class HamiltonianCycle
    {
        public static bool Find_cycle(int current, ref Graph graph, ref List<int> path, ref bool[] visited)
        {
            path.Add(current);

            // Случай, когда путь уже прошёл по всем вершинам
            if (path.Count == graph.Size)
            {
                // Смотрим, есть ли ребро от последней вершины пути к первой
                if (graph[path[0], path[path.Count - 1]] == 1)
                {
                    // Гамильтонов цикл построен
                    return true;
                }
                else
                {
                    // Построен гамильтонов путь, но не цикл
                    path.RemoveAt(path.Count - 1);
                    return false;
                }
            }

            // Отмечаем текущую вершину посещённой
            visited[current] = true;
            // Console.WriteLine(current);

            // Переираем все возможные вершины
            for (int next = 0; next < graph.Size; ++next)
            {
                // Если есть смежная вершина, в которой мы ещё не были
                if (graph[current, next] == 1 && !visited[next])
                {
                    // Рекурсивный вызов алгоритма для следующей вершины
                    if (Find_cycle(next, ref graph, ref path, ref visited))
                    {
                        return true;
                    }
                }
            }

            // Из вершины некуда было идти. Отмечаем её как непосещённую, удаляем из пути
            visited[current] = false;
            path.RemoveAt(path.Count - 1);
            return false;
        }



        public static bool IsHamiltonianGraph(ref Graph graph)
        {

            // Теорема Дирака: если для каждой вершины х n-вершинного графа G
            // выполняется: d(x) >= n/2 => граф G гамильтонов
            // n >= 3

            int n = graph.Size;
            if (n < 3)
            {
                return false;
            }

            bool answer = true;
            for (int i = 0; i < n; i++)
            {
                // Степень вершины i
                int degree = 0;
                for (int j = 0; j < n; j++)
                {
                    if (graph[i, j] == 1)
                    {
                        degree++;
                    }
                }
                if (degree < n / 2)
                {
                    answer &= false;
                }
            }
            return answer;
        }
    }
}
