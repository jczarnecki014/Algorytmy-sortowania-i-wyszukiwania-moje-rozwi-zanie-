using System;

namespace Exercise_1
{
    public class SubPointA:IExerciseONE
    {
            public string subPoint{ get; } = "A";
            public Random RandomSystem{ get; set;}
            public int CountOfAttempt{ get; set;} = 0;
            public bool LoopCondition { get; set;}
            public SubPointA()
            {
                RandomSystem = new Random();
                LoopCondition = true;
            }
            public int RealizeTask(int value)
            {
                int userValue = value;
                int RandedNumber;

                while(this.LoopCondition)
                {
                    RandedNumber = RandomSystem.Next(1,1000+1);

                    if(IExerciseONE.Compare(userValue,RandedNumber))
                    {
                        LoopCondition = false;
                    }
                    else
                    {
                        CountOfAttempt++;
                    }
                }
                return this.CountOfAttempt;
            }//Rozwiązanie podpunktu A
    }
}
