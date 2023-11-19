using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PimenovaTS.Sprint5.Task1.V12.Lib;
using System.IO;

namespace Tyuiu.PimenovaTS.Sprint5.Task1.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void SaveToFileTextDataalidSaveToFileTextData()
        {
            string path = @"C:\Users\User\source\repos\Tyuiu.PimenovaTS.Sprint5\Tyuiu.PimenovaTS.Sprint5.Task1.V12\bin\Debug\OutPutFileTask1.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
