using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deque
{
    class Deque
    {
        int[] Array;
        int[] Array2;
        int L = 0;
        int H = 0;
        int N = 0;
        int DH = 0;
        int DL = 0;
        int Head = 0;
        int Tail = 0;
        int GF = 0;
        int GR=0;
        public Deque(int size)
        {
            Array = new int[size];
            Array2 = new int[Array.Length + 1];
            L = size - 1;
            DL = size - 1;
            Tail = size - 1;
            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = 0;
            }
        }
        public void InsertFront(int x)
        {
            GF = x;
            if (H < L || H == L)
            {
                if (Array[H] == 0)
                {
                    Array[H] = x;
                    H++;
                }
            }
            else
                Console.WriteLine("OverFlow");

        }
        public void InsertLast(int x)
        {
            GR = x;
            if (L > H || L == H)
            {
                if (Array[L] == 0)
                {
                    Array[L] = x;
                    L--;
                    
                }
            }
            else
                Console.WriteLine("Overflow");
        }
        public void DeleteFront()
        {
            if (DH < DL || DH == DL)
            {
                int N = 0;
                N = Array[DH];
                Array[DH] = 0;
                DH++;
            }
            else
                Console.WriteLine("UnderFlow");
        }
        public void DeleteLast()
        {
            if (DL > DH || DL == DH)
            {
                int N = 0;
                N = Array[DL];
                Array[DL] = 0;
                DL--;
            }
            else
                Console.WriteLine("Underflow");
        }
        public int GetFront()
        {
            return GF;
        }
        public int GetRear()
        {
            return GR;
        }
        public bool IsEmpty()
        {
            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i] != 0)
                {
                    return false;
                }
            }
                    return true;

        }
        public bool IsFull()
        {
            if (L < H || H > L)
            {
                return true;
            }
            else
                return false;
        }
        public void Print()
        {
            for (int i = 0; i < Array.Length; i++)
            {
                Console.WriteLine(Array[i]);
            }
        }
       /* public void add(int i, int x)
        {
            for (int j = 0; j < Array.Length; j++)
            {
                if (Array[j] != 0)
                {
                    N = N + 1;
                }
                else
                    N = N + 0;
            }
            int A = 0;

            if (i < N / 2)
            {
                if (H == 0)
                {
                   H= Array.Length-1;
                }
                else
                {
                    H = H - 1;
                }
                //int a = 0;
                for (int a = 0; a <= i - 1; a++)
                {
                    Array[(H + a) % Array.Length] = Array[(H + a + 1) % Array.Length];
                    // a++;
                }
            }
            else
            {
                int b=0;
                for (int a = N; a > i; a--)
                {
                    Array[(H + a) % Array.Length] = Array[(H + a - 1) % Array.Length];
                    //  a--;
                }
            }
            Array[(H + i) % Array.Length] = x;
            N++;

        }*/
        public void add(int i, int x)
        {
            int A = 0;
            for (int j1 = 0; j1 < Array.Length; j1++)
            {
                if (Array[j1] != 0)
                {
                    N = N + 1;
                }
                else
                    N = N + 0;
            }
                if (i < N / 2)
                {
                    H = 1;
                    A = H;
                    if(A==0)
                    {
                        A = Array.Length - 1;
                    }
                    else
                    {
                        A = A - 1;
                    }
                    int z = 0;
                    while (z<=i)
                    {
                        Array[(A + z) % Array.Length] = Array[(A + z + 1) % Array.Length];
                        z++;
                    }
                   
                }
                else
                { 
                    int z = N;
                    do
                    {
                        Array[(A + z) % Array.Length] = Array[(A + z - 1) % Array.Length];
                        z--;
                    } while ( z > i);
                }
                Array[(A + i) % Array.Length] = x;
                N++;
            }
       

        }
        }
    


        
    

