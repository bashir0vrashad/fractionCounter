using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Counter
    {
        private int max;
        private int min;
        private int currentData;

        public int Min
        {
            get { return min; }
            set { min = value; }
        }


        public int Max
        {
            get { return max; }
            set { 
                if (value != min) max = value;
                else throw new Exception("min max ferqli olmalidi...");
            }
        }


        public int CurrentData
        {
            get { return currentData; }
        }


        public void Increment()
        {
            if (currentData == max) currentData = min;
            else currentData++;
        }

        public Counter()
        {
            max = 7;
            min = 0;
            currentData = min;
        }

        public Counter(int min , int max)
        {
            Min = min;
            Max = max;
            currentData = min;
        }


        public override string ToString()
        {
            return $"min: {Min} \nmax: {Max} \ncurrent: {CurrentData}\n";
        }


    }
}
