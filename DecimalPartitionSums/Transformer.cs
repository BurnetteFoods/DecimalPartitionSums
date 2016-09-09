using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalPartitionSums
{
    public class Transformer
    {
        public decimal Total { get; set; }

        public List<Tuple<int, decimal>> Rows { get; set; }

        public Transformer()
        {
            Total = 0.0m;
            Rows = null;
        }

        public void transform(List<string[]> tokens)
        {
            if(tokens == null || tokens.Count < 2)
            {
                throw new ArgumentException("You must have at least two lines in the CSV.");
            }

            string[] totalLine = tokens[0];
            var othTokens = tokens.Skip(1);

            int key;
            decimal val;

            Rows = new List<Tuple<int, decimal>>();

            if(totalLine == null || totalLine.Length < 1)
            {
                throw new ArgumentException("You must have at least one value in the total line.");
            }

            Total = decimal.Parse(totalLine[0]);

            foreach(var line in othTokens)
            {
                if (line == null || line.Length < 2)
                {
                    throw new ArgumentException("You must have at least two values in each line, other than the total line.");
                }

                key = int.Parse(line[0]);
                val = decimal.Parse(line[1]);
            }
        }
    }
}
