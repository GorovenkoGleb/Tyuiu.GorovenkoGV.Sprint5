using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.GorovenkoGV.Sprint5.Task2.V18.Lib;

namespace Tyuiu.GorovenkoGV.Sprint5.Task2.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Arsenal\source\repos\Tyuiu.GorovenkoGV.Sprint5\Tyuiu.GorovenkoGV.Sprint5.Task2.V18\bin\Debug\OutPutFileTask0.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
