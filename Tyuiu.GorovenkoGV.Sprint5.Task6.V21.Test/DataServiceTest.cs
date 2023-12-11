using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.GorovenkoGV.Sprint5.Task6.V21.Lib;


namespace Tyuiu.GorovenkoGV.Sprint5.Task6.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc ()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\Arsenal\source\repos\Tyuiu.GorovenkoGV.Sprint5\Tyuiu.GorovenkoGV.Sprint5.Task6.V21\bin\Debug\InPutDataFileTask6V21.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            var res = ds.LoadFromDataFile(path);
            int wait = 3;
            Assert.AreEqual(wait, fileExists);
        }
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\Arsenal\source\repos\Tyuiu.GorovenkoGV.Sprint5\Tyuiu.GorovenkoGV.Sprint5.Task6.V21\bin\Debug\InPutDataFileTask6V21.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
