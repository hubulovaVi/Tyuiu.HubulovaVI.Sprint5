using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.HubulovaVI.Sprint5.Task1.V2.Lib;
using System.IO;

namespace Tyuiu.HubulovaVI.Sprint5.Task1.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckSaveToFileTextDataValid()
        {
            string path = @"C:\Users\valeria\source\repos\Tyuiu.HubulovaVI.Sprint5\Tyuiu.HubulovaVI.Sprint5.Task1.V2\bin\Debug\OutPutFileTask1.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}