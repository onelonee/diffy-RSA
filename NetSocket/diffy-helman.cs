using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JLM.NetSocket
{
    public class diffy_helman
    {
        private int a;
        private int b;
        private int p;
        public int A

        {

            get
            {
                return a;
            }
            set
            {
                value = a;
            }
        }
           
        public int B {
            get
            {
                return b;
            }
            set
            {
                value = b;
            }
        }
        public int P
        {
            get
            {
                return p;
            }
            set
            {
                value = p;
            }
        } 

        
        private int Power(int a, int b, int p)
        {
            if (b == 1)
            {
                return a;

    
            }
            else
            {
                return ((int)Math.Pow(a, b) % p);
            }
        }
                   
    }
}
