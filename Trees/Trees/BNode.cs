using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    class BNode
    {
        public int Data;
        public BNode left;
        public BNode right;
        public BNode()
        {
            Initialize();
        }
        public BNode(int x)
        {
            this.Data = x;
            Initialize();
        }
        public void Initialize()
        {
            left = null;
            right = null;
        }
    }
}
