using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prog_test_3
{
    class Person
    {
        private string a;
        private string b;
        private int c;
        private int d;

        public Person(string e, string f, int g, int h)
        {
            a=e;
            b=f;
            c=g;
            d=h;
        }

        public string A
        {
            get {return a;}
            set {a = value;}
        }
        public string B
        {
            get {return b;}
            set {b = value;}
        }
        public int C
        {
            get {return c;}
            set {c = value;}
        }
        public int D
        {
            get {return d;}
            set {d = value;}
        }
        

    }


}