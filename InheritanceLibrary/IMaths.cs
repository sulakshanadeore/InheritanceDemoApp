using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLibrary
{
    internal interface IMaths
    {
        int Add(int i, int j);
        int Subtract(int i, int j); 
        int Multiply(int i, int j);
        int Divide(int i, int j);                   

    }
    class SimpleClient : IMaths
    {
        public int Add(int i, int j)
        {
          return i + j;
        }

        public int Divide(int i, int j)
        {
            return i / j;
        }

        public int Multiply(int i, int j)
        {
            return i * j;
        }

        public int Subtract(int i, int j)
        {
            return i - j;
        }
    }


    public class OnlyAdd : IMaths
    {
        public int Add(int i, int j)
        {
return i + j;   
        }

        public int Divide(int i, int j)
        {
            throw new NotImplementedException();
        }

        public int Multiply(int i, int j)
        {
            throw new NotImplementedException();
        }

        public int Subtract(int i, int j)
        {
            throw new NotImplementedException();
        }
    }
    public class MulDiv : IMaths
    {
        public int Add(int i, int j)
        {
            throw new NotImplementedException();
        }

        public int Divide(int i, int j)
        {
            return i / j;
        }

        public int Multiply(int i, int j)
        {
            return i * j;
        }

        public int Subtract(int i, int j)
        {
            throw new NotImplementedException();
        }
    }
}
