using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

using Tyuiu.GorovenkoGV.Sprint5.Task4.V20.Lib;


namespace Tyuiu.GorovenkoGV.Sprint5.Task4.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Arsenal\source\repos\Tyuiu.GorovenkoGV.Sprint5\Tyuiu.GorovenkoGV.Sprint5.Task4.V20\bin\Debug\OutPutFileTask4.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
