using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.PimenovaTS.Sprint5.Task3.V2.Lib;

namespace Tyuiu.PimenovaTS.Sprint5.Task3.V2.Test
{
    [TestClass]
    public class DataSrviceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = @"C:\Users\User\source\repos\Tyuiu.PimenovaTS.Sprint5\Tyuiu.PimenovaTS.Sprint5.Task3.V2\bin\Debug\OutPutFileTask3.bin";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
