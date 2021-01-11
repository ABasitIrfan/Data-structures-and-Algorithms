using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    class BinarySearchTree
    {
        public BNode Root;
        public BinarySearchTree()
        {
            Initialize();
        }
        public void Initialize()
        {
            this.Root = null;
        }
        public void Add(int x)
        {
            Root = Add(Root, x);
        }
        public BNode Search(int x)
        {
            return Search(Root, x);
        }
        public BNode Add(BNode node,int x)
        {
            if(node==null)
            {
                node = new BNode(x);
                return node;
            }
            else
            {
                if (x < node.Data)
                    node.left = Add(node.left, x);
                else
                    node.right = Add(node.right, x);
                return node;
            }
        }
        public BNode Search(BNode node,int x)
        {
            if (node == null)
                return null;
            if (node.Data == x)
                return node;

            if (x < node.Data)
                return Search(node.left, x);
            else
                return Search(node.right, x); 
        }
        public void InOrder()
        {
             InOrder(Root);
        }
        public void InOrder(BNode x)
        {
            if (x == null)
                return;
            InOrder(x.left);
            Console.WriteLine(x.Data);
            InOrder(x.right);
        }
        public void PreOrder()
        {
            PreOrder(Root);
        }
        public void PreOrder(BNode x)
        {
            if (x == null)
                return;
            Console.WriteLine(x.Data);
            PreOrder(x.left);
            PreOrder(x.right);
        }
        public void PostOrder()
        {
            PostOrder(Root);
        }
        public void PostOrder(BNode x)
        {
            if (x == null)
                return;
            PreOrder(x.left);
            PreOrder(x.right);
            Console.WriteLine(x.Data);
        }
        public int Height()
        {
            return Height(Root);
        }
        public int Height(BNode x)
        {
            if (x == null)
                return -1;
            int l = Height(x.left);
            int r = Height(x.right);
            if (l > r)
                return l + 1;
            else
                return r + 1;
        }
        public int Size()
        {
            return Size(Root);
        }
        public int Size(BNode x)
        {
            if (x == null)
                return 0;
            return 1 + Size(x.left) + Size(x.right);
        }
        public BNode Successor()
        {
            return Successor(Root);
        }
        public BNode Successor(BNode x)
        {
            if (x == null)
                return null;

            return Minimum(x.right);
        }
        public BNode Minimum(BNode x)
        {
            if (x == null)
                return null;
            if (x.left == null)
                return x;
            else
                return Minimum(x.left);
        }
        public BNode Predecessor()
        {
            return Predecessor(Root);
        }
        public BNode Predecessor(BNode x)
        {
            if (x == null)
                return null;

            return Maximum(x.left);
        }
        public BNode Maximum(BNode x)
        {
            if (x == null)
                return null;

            if (x.right == null)
                return x;
            else
                return Maximum(x.right);
        }
        public void Delete(int e)
        {
            Root = Delete(Root, e);
        }

        public BNode Delete(BNode node, int e)
        {
            if (node == null)
                return null;

            if (node.Data == e)
            {
                // case 1
                if (node.left == null && node.right == null)
                    return null;
                // case 2 - left child is not empty - connect parent with left child
                if (node.left != null && node.right == null)
                    return node.left;
                // case 2 - right child is not empty - connect parent with right child
                if (node.right != null && node.left == null)
                    return node.right;
                // nothing like above then
                // both children are not empty
                if (node.right != null)
                {
                    BNode succ = Successor(node);
                    node.Data = succ.Data;
                    node.right = Delete(node.right, succ.Data);
                }
                else
                {
                    BNode pred = Predecessor(node);
                    node.Data = pred.Data;
                    node.left = Delete(node.left, pred.Data);
                }

                return node;
            }

            if (e < node.Data)
                node.left = Delete(node.left, e);
            else
                node.right = Delete(node.right, e);

            return node;
        }
    }

    }   

