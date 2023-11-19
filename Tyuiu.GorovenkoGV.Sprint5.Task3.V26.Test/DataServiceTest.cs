using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.GorovenkoGV.Sprint5.Task3.V26.Lib;

namespace Tyuiu.GorovenkoGV.Sprint5.Task3.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Arsenal\source\repos\Tyuiu.GorovenkoGV.Sprint5\Tyuiu.GorovenkoGV.Sprint5.Task3.V26\bin\Debug\OutPutFileTask3.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
