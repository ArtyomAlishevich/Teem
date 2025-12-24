using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1
{
    internal class Test
    {
        public string NameSubject { get; set; }
        public bool TestPassed { get; set; }
        public Test(string nameSubject, bool testPassed)
        {
            NameSubject = nameSubject;
            TestPassed = testPassed;
        }
        public Test() : this("NoName", false) {}
        public override string ToString() => $"Предмет: {NameSubject}, Зачёт: {TestPassed}";
        public Test DeepCopy() => new Test(this.NameSubject, this.TestPassed);
    }
}
