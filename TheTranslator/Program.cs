﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheTranslator
{
    static class Program
    {
        static void Main()
        {
            test();
        }

        public static void test()
        {
            Tester t = new Tester();
            t.Init(@"C:\studies\project\DB\Big\17_new");
            t.testLenX(@"C:\studies\project\DB\Big\17_new", 4);

        }

        
    }
}
