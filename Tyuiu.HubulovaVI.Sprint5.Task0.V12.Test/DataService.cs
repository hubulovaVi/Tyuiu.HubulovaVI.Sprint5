using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.HubulovaVI.Sprint5.Task0.V12.Lib;

namespace Tyuiu.HubulovaVI.Sprint5.Task0.V12.Test
{
    [TestClass]
    public class DataService
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\valeria\source\repos\Tyuiu.HubulovaVI.Sprint5\Tyuiu.HubulovaVI.Sprint5.Task0.V12\bin\Debug\OutPutFileTask0.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool tyta = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, tyta);
        }
    }
}