using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    class Graph
    {
        private int numVertices;
        public LinkedList<int>[] adjLists = new LinkedList<int>[50];
        public Graph(int vertices)
        {
            numVertices = vertices;

            for (int i = 0; i < vertices; i++)
                adjLists[i] = new LinkedList<int>();
        }
        public void addEdge(int src, int dest)
        {
            adjLists[src].AddLast(dest);
            adjLists[dest].AddLast(src);
        }
        public int[] getNeighbours(int vertex)
        {
            List<int> neg = new List<int>();

            foreach (int n in adjLists[vertex])
            {
                neg.Add(n);
            }
            return neg.ToArray();
        }
        public void PrintList()
        {
            for (int i = 0; i < numVertices; i++)
            {
                foreach (int n in getNeighbours(i))
                    Console.WriteLine("{0} --> {1}", i, n);
            }
        }


        //----------------------------------By Matrix-------------
        
   //     public bool IsVisited;
     /*   public int[,] AdjMatrix;
        public int NumberOfNodes;
        int source =0;
     
        public Graph(int NumOfNodes)
        {
            AdjMatrix = new int[NumOfNodes, NumOfNodes];
            NumberOfNodes = NumOfNodes;
            for (int i = 0; i < NumberOfNodes; i++)
            {
                for (int j = 0; j < NumberOfNodes; j++)
                {
                    AdjMatrix[i, j] = 0;
                }
            }
        }
        public void PrintMatrix()
        {
            for (int i = 0; i < NumberOfNodes; i++)
            {
                for (int j = 0; j <NumberOfNodes ; j++)
                {
                    Console.Write(AdjMatrix[i,j]);
                }
                Console.WriteLine();
            }
        }
        public void AddEdge(int source, int destination)
        {
            AdjMatrix[source, destination] = 1;
            AdjMatrix[destination, source] = 1;
        }
        public int[] getNeighbours(int vertex)
        {
            int[] Neighbours=new int[NumberOfNodes];
            for (int i = 0; i < NumberOfNodes; i++)
            {
                if (AdjMatrix[vertex, i] == 1)
                    Neighbours[i] = i;
            }
            return Neighbours;
        }
        public void print(int[] array )
        { 
            for(int i=0;i<array.Length;i++)
                Console.WriteLine(array[i]);
        }*/
        public void DFS(int Source)
        {
            Stack<int> Stk = new Stack<int>();
            List<int> Visited = new List<int>();
            Stk.Push(Source);
            Visited.Add(Source);
            while(Stk.Count>0)
            {
                int ThisVertex = Stk.Pop();
                Console.WriteLine("Visited:{0}",ThisVertex);
                int[] neg = getNeighbours(ThisVertex);
                foreach (int n in neg)
                {
                    if (!Visited.Contains(n))
                    {
                        Stk.Push(n);
                        Visited.Add(n);
                    }
                }
            }
        }
        public void BFS(int Source)
        {
            Queue<int> Q = new Queue<int>();
            List<int> Visited = new List<int>();
            Q.Enqueue(Source);
            Visited.Add(Source);
            while (Q.Count > 0)
            {
                int ThisVertex = Q.Dequeue();
                Console.WriteLine("Visited:{0}", ThisVertex);
                int[] neg = getNeighbours(ThisVertex);
                foreach (int n in neg)
                {
                    if (!Visited.Contains(n))
                    {
                        Q.Enqueue(n);
                        Visited.Add(n);
                    }
                }
            }
        }


    
    }
}
