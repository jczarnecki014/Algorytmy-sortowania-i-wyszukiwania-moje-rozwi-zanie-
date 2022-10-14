using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    public interface IExerciseONE
    {
        public string subPoint{ get;}
        public Random RandomSystem{ get; set;}
        public int CountOfAttempt{ get; set;}
        public bool LoopCondition { get; set;}
        public int RealizeTask(int value);
        public static bool Compare(int x, int y)
        {
                return x==y;  
        }
    }
}
