using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijkstra_s_Algorithm
{
    class Dijkstra
    {
        public int[,] CostMatrix;
        public int NumberOfNodes;
        public int Infinity = 999;
        public Dijkstra(int Numofnodes)
        {
            NumberOfNodes = Numofnodes;
            CostMatrix = new int[Numofnodes, Numofnodes];
            for (int i = 0; i < Numofnodes; i++)
            {
                for (int j = 0; j < Numofnodes; j++)
                {
                    CostMatrix[i, j] = Infinity;
                }
            }
        }
        public void AddEdge(int source, int destination, int cost)
        {
            CostMatrix[source, destination] = cost;
            CostMatrix[destination, source] = cost;
        }
        public int[] GetNeighbours(int vertex)
        {
            int n = -1;
            int[] Neighbours = new int[NumberOfNodes];
            for (int i = 0; i < Neighbours.Length; i++)
            {
                if (CostMatrix[vertex, i] == 1)
                    Neighbours[++n] = i;
            }
            return Neighbours;
        }
        public void Print()
        {
            for (int i = 0; i < NumberOfNodes; i++)
            {
                for (int j = 0; j < NumberOfNodes; j++)
                {
                    Console.Write(" {0}", CostMatrix[i, j]);
                }
                Console.WriteLine();
            }
        }
        public void DijkstraShortestPath(int source)
        {
            PriorityQueue pq = new PriorityQueue();
            Vertex[] distanceVector = new Vertex[NumberOfNodes];
            int[] visited = new int[NumberOfNodes];

            // intialization
            for (int i = 0; i < NumberOfNodes; i++)
            {
                distanceVector[i] = new Vertex(i, int.MaxValue);
            }
            distanceVector[source].distance = 0;

            // addign in queue
            for (int i = 0; i < NumberOfNodes; i++)
                pq.Enqueue(distanceVector[i]);

            while (!pq.IsEmpty())
            {
                Vertex v = pq.ExtractMin();
                int[] neg = GetNeighbours(v.id);

                foreach (int n in neg)
                {
                    if (distanceVector[n].distance > v.distance + CostMatrix[v.id, n])
                        distanceVector[n].distance = v.distance + CostMatrix[v.id, n];
                }
            }

            foreach (Vertex x in distanceVector)
                Console.WriteLine(" {0}, {1}", x.id, x.distance);
        }
    }
    public class Vertex
    {
        public int id=0;
        public int distance=0;
        public bool visited = false;

        public Vertex(int id, int distance)
        {
            this.id = id;
            this.distance = distance;
        }
    }

    public class PriorityQueue
    {
        List<Vertex> list = new List<Vertex>();

        public void Enqueue(Vertex e)
        {
            list.Add(e);
        }

        public Vertex ExtractMin()
        {
            int minLoc = FindMin();
            Vertex v = list[minLoc];
            list.RemoveAt(minLoc);

            return v;
        }

        private int FindMin()
        {
            if (list.Count < 1)
                return -1;

            Vertex min = list[0];

            int loc = 0;

            for (int i = 1; i < list.Count; i++)
            {
                if (list[i].distance < min.distance)
                {
                    min = list[i];
                    loc = i;
                }
            }

            return loc;
        }

        public bool IsEmpty()
        {
            return list.Count() == 0;
        }
    }
}