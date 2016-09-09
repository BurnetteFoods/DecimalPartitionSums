using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalPartitionSums
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length != 1)
            {
                return;
            }

            string filename = args[0];

            CSVReader c = new CSVReader(filename);
            var tokens = c.read();
            
            Transformer t = new Transformer();
            t.transform(tokens);

            Trial trial = new Trial(t);
            trial.run();
        }
    }
}
