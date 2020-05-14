using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamiltonianCycle_console
{
    // Класс для хранения графа
    // Структура, используемая для хранения, - матрица смежности.
    // Размер матрицы N x N. Если элемент Aij = 1, значит вершины i и j соединяет ребро.
    class Graph
    {
        private int size;
        private List<List<int>> matrix;

        // Конструктор по умолчанию
        // Создаёт пустой граф
        public Graph(int n)
        {
            size = n;
            matrix = new List<List<int>>();
            for (int i = 0; i < size; i++)
            {
                matrix.Add(new List<int>());
                for (int j = 0; j < size; j++)
                {
                    matrix[i].Add(0);
                }
            }
        }

        // Конструктор копирования
        public Graph(List<List<int>> matrix)
        {
            size = matrix.Count;
            this.matrix = matrix.GetRange(0, matrix.Count);
        }

        // Геттеры для размера матрицы и самой матрицы
        public int Size
        {
            get { return size; }
        }

        public List<List<int>> Matrix
        {
            get { return matrix; }
        }

        // Геттер для элемента матрицы по номерам строки и столбца
        // todo: проверку на неотрицательность индексов
        public int Get(int i, int j)
        {
            return matrix[i][j];
            
        }

        // Индексатор
        public int this[int i, int j]
        {
            get { return Get(i, j); }
            set { matrix[i][j] = value; }
        }

        //public bool hasCycle(ref Graph graph)
        //{
            // Проверяет граф на наличие циклов
            // 
        //    return false;
        //}

        public bool isConnected()
        {
            // Проверка графа на связность
            // Если есть хоть одна строка или столбец, в которых стоят только нули, возвращается false
            for (int i = 0; i < size; i++)
            {
                int sum = 0;
                for (int j = 0; j < size; j++)
                {
                    sum += matrix[i][j];
                }

                if (sum == 0)
                {
                    return false;
                }
            }

            for (int j = 0; j < size; j++)
            {
                int sum = 0;
                for (int i = 0; i < size; i++)
                {
                    sum += matrix[i][j];
                }

                if (sum == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

