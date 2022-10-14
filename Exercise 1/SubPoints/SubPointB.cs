using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    public class SubPointB:IExerciseONE
    {
            public string subPoint{ get; } = "B";
            public Random RandomSystem{ get; set;}
            public int CountOfAttempt{ get; set;} = 0;
            public bool LoopCondition { get; set;}
            public SubPointB()
            {
                RandomSystem = new Random();
                LoopCondition = true;
            }
            public int RealizeTask(int value)
            {
                int userValue = value;
                int RandedNumber;
                int minScope = 1;
                int maxScope = 1000+1;
                while(LoopCondition)
                {
                    CountOfAttempt++;
                    RandedNumber = RandomSystem.Next(minScope,maxScope);
                    if (!IExerciseONE.Compare(userValue,RandedNumber))
                    {
                        switch (RandedNumber > userValue) // Stosuje switch ze względu na optymalizacje kodu ( szybszy od if )
                        {
                            case true:
                                maxScope = RandedNumber - 1;
                            break;
                            case false:
                                minScope = RandedNumber + 1; 
                            break;
                        }
                    }
                    else
                    {
                        LoopCondition = false;
                    }
                }
                return CountOfAttempt;
            }//Rozwiązanie podpunktu B
    }
}
