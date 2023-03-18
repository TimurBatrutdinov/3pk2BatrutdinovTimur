using System.Collections;
using System.Collections.Immutable;
using System.Diagnostics;

bool[,] M = new bool[4, 4]
{
    {false, true, false, true}, // G4
    {true, false, false, false},
    {true, true, false, true},
    {false, true, false, false}
};

Graph graph = new Graph(4, M);
graph.Depth(1);

public class Graph
{
    private int size; // Вершины
    private bool[,] adjacency; // Матрица
    private bool[] vector; // Вектор
    public int Size { get; set; }
    public bool[,] Adjacency { get; set; }
    public bool[] Vector { get; set; }

    public Graph(int size, bool[,] G) // Конструктор 
    {
        Adjacency = new bool[size, size]; // Инициализация матрицы
        Adjacency = G;
        Vector = new bool[size];
        for (int i = 0; i < size; i++)
            Vector[i] = false; // Инициализация вектора
        Size = size;
    }
    public void Depth(int i) //i Начало (Вершина)
    {
        Vector[i] = true;
        Console.Write("{0}" + ' ', i);
        for (int k = 0; k < Size; k++) // Поиск первой 
            if (Adjacency[i, k] && !(Vector[k]))
                Depth(k); // Переход к k
    }
}


