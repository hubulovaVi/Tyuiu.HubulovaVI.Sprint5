﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.HubulovaVI.Sprint5.Task6.V16.Lib
{
    public class DataService : ISprint5Task6V16
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        if ((line[i] >= 'A') && (line[i] <= 'z'))
                        {
                            if ((line[i + 1] == ' ') || (line[i + 1] == '.') || (line[i + 1] == ','))
                            {
                                count++;
                            }
                        }
                    }
                }

            }
            return count;
        }
    }
}