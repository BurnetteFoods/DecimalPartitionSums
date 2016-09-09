using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalPartitionSums
{
    public class Trial
    {
        public decimal Total { get; set; }

        public List<Tuple<int, decimal>> Rows { get; set; }

        public List<bool> RowsUsed { get; set; }
        
        private bool done;

        public Trial(Transformer t)
        {
            Total = t.Total;
            Rows = t.Rows;

            RowsUsed = new List<bool>(Rows.Count);

            for(int i = 0; i < Rows.Count; i++)
            {
                RowsUsed.Add(false);
            }

            done = false;
        }

        public void run()
        {
            while(!done)
            {
                test();
                advance();
            }
        }

        public void advance()
        {
            int i = 0;

            RowsUsed[0] = (RowsUsed[0] ? false : true);

            while(i < RowsUsed.Count && RowsUsed[i] == false)     // we must have carried if we toggled to get to false
            {
                if(i == RowsUsed.Count - 1)
                {
                    done = true;
                    break;
                }
                else
                {
                    i++;
                    RowsUsed[i] = (RowsUsed[i] ? false : true);
                }
            }
        }

        public void test()
        {
            decimal s = 0m;

            for (int i = 0; i < RowsUsed.Count; i++)
            {
                if(RowsUsed[i])
                {
                    s += Rows[i].Item2;
                }
            }

            if(s == Total)
            {
                Console.WriteLine("Successful combination:");

                for(int i = 0; i < RowsUsed.Count; i++)
                {
                    if (RowsUsed[i])
                    {
                        Console.WriteLine(string.Format("({0},{1})", Rows[i].Item1, Rows[i].Item2));
                    }
                }

                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
            }
        }
    }
}
