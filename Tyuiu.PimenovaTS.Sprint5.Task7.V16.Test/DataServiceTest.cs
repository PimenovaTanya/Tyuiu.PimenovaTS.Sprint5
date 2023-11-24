using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.PimenovaTS.Sprint5.Task7.V16.Lib;

namespace Tyuiu.PimenovaTS.Sprint5.Task7.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadDataAndSave()
        {
            string path = @"C:\Users\User\source\repos\Tyuiu.PimenovaTS.Sprint5\Tyuiu.PimenovaTS.Sprint5.Task7.V16\bin\Debug\InPutDataFileTask7V16.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
