using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace StateCensusAnalyser
{
    class StateCensusAnalyser
    {
        private readonly string filePath;
        public StateCensusAnalyser(string filePath)
        {
            this.filePath = filePath;

        }
        public static int GetStateCensusRecords(string filepath)
        {
            string[] numOfRecords = File.ReadAllLines(filepath);
            return numOfRecords.Length - 1;
        } 
    }
}
