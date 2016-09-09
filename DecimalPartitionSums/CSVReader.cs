using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DecimalPartitionSums
{
    public class CSVReader
    {
        private string filename;

        public CSVReader(string filename)
        {
            this.filename = filename;
        }

        public List<string[]> read()
        {
            string line;
            string[] lineTokens;

            List<string[]> tokens = new List<string[]>();

            using(var sr = File.OpenText(filename))
            {
                while((line = sr.ReadLine()) != null)
                {
                    lineTokens = line.Split(',');
                    tokens.Add(lineTokens);
                }
            }

            return tokens;
        }
    }
}
