using System;
using System.Collections.Generic;
using System.Text;

namespace calc
{
    public class calc
    {
        public int Add(int x,int y)
        {
            return x + y;
        }
        public int Sub(int x,int y)
        {
            return x - y;
        }
        public int Mul(int x,int y)
        {
            return x * y;
        }
        public int Div(int x,int y)
        {
            try
            {
                return x / y;
            }
            catch(Exception)
            {
                return 0;
            }
            
        }
    }
}
