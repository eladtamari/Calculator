using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculator
    {
        [TestFixture]

        class MyTestCase
        {
            [TestCase]
            public void Add()
            {
                myMath math = new myMath();
                Assert.AreEqual(31, math.Add(11, 20));
            }

            [TestCase]
            public void Add_negetive()
            {
                myMath math = new myMath();
                Assert.AreEqual(31, math.Add(111, 20));
            }
        }
    }
}
