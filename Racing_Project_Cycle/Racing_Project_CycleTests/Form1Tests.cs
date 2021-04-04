using Microsoft.VisualStudio.TestTools.UnitTesting;
using Racing_Project_Cycle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racing_Project_Cycle.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void Form1Test()
        {
            Form1 form1 = new Form1();
            form1.onloadGen();
            Assert.IsTrue(true);
        }
        [TestMethod()]
        public void Form2Test()
        {
            better bet = new better();
            int y=bet.rNumber() ;
            Assert.IsTrue(true);
        }
    }
}