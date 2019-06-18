using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject;
namespace TopDanmark
{
    [TestClass]
    public class TestCases
    {
        [TestMethod]
        public void TestCase1()
        {
            UnitTest1 test1 = new UnitTest1();
            test1.TC_1_verifyTopDanmarkIsAppearingFirstInSearch();
        }

        [TestMethod]
        public void Testcase2()
        {
            UnitTest1 test2 = new UnitTest1();
            test2.TC_2_verifyAccessibleViaDifferentBrowsers();
        }        
    }
}
