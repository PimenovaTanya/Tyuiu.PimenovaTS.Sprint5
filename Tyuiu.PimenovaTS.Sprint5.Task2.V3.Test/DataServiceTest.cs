using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.PimenovaTS.Sprint5.Task2.V3.Lib;

namespace Tyuiu.PimenovaTS.Sprint5.Task2.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = @"C:\Users\User\source\repos\Tyuiu.PimenovaTS.Sprint5\Tyuiu.PimenovaTS.Sprint5.Task2.V3\bin\Debug\OutPutFileTask2.csv";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
