using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    public class SubPointC:IExerciseONE
    {
            public string subPoint{ get; } = "C";
            public Random RandomSystem{ get; set;}
            public int CountOfAttempt{ get; set;} = 0;
            public bool LoopCondition { get; set;} = true;
            public int RealizeTask(int value)
            { 
                int userValue = value;
                int[] BinaryArray = this.CreateNelementsArray(1000);

                int minIndex = 0;
                int maxIndex = BinaryArray.Length-1;
                int midIndex = (maxIndex-minIndex)/2;

                while(LoopCondition)
                {
                    CountOfAttempt++;
                    if(!IExerciseONE.Compare(BinaryArray[midIndex],userValue))
                    {
                       switch (BinaryArray[midIndex] > userValue)
                       {
                            case true:
                                maxIndex = midIndex;
                                midIndex = (minIndex == maxIndex-1) ? midIndex-1:midIndex - (maxIndex-minIndex)/2;
                            break;
                            case false:
                                minIndex = midIndex;
                               midIndex = (maxIndex == minIndex+1) ? midIndex+1:midIndex + (maxIndex-minIndex)/2;
                            break;
                       }
                    }
                    else
                    {
                        LoopCondition = false;
                    }
                }
                return CountOfAttempt;
            }//Rozwiązanie podpunktu C
            private int[] CreateNelementsArray(int elements)
            {
                int[] BinaryArray = new int[elements];
                int iterator = 0;
                while(iterator < BinaryArray.Length)
                {
                    BinaryArray[iterator++] = iterator;
                }
                return BinaryArray;
            }
    }
}
