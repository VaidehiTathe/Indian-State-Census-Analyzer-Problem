﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace StateCensusAnalyser
{
    public class StateCensusAnalyser
    {
        private readonly string filePath;
        public StateCensusAnalyser(string filePath)
        {
            this.filePath = filePath;

        }
        public static int GetStateCensusRecords(string filepath)
        {
            try
            {
                string[] numOfRecords = File.ReadAllLines(filepath);
                return numOfRecords.Length - 1;
            }
            catch (StateCensusAnalyserException)
            {
                throw new StateCensusAnalyserException("Enter correct directory path");
            }
            catch (FileNotFoundException)
            {
                throw new StateCensusAnalyserException("Enter correct directory path");
            }
        } 
    }
}
