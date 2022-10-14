using System;
using System.Collections.Generic;
using System.IO;
namespace Exercise_3
{
    public class ExerciseTHREE
    {
        private StreamReader streamFileOne;
        private StreamReader streamFileTwo;

        private List<int>OnlyFileOne;
        private List<int>OnlyFileTwo;
        private List<int>BothFileOneAndFileTwo;
        public ExerciseTHREE(string FirstfilePath,string SecondfilePath)
        {
            streamFileOne = new StreamReader(FirstfilePath);
            streamFileTwo = new StreamReader(SecondfilePath);
            OnlyFileOne = new List<int>();
            OnlyFileTwo = new List<int>();
            BothFileOneAndFileTwo = new List<int>();
        }
        public ExerciseTHREE()
        {
            streamFileOne = new StreamReader(@"..\..\..\..\FileOne.txt");
            streamFileTwo = new StreamReader(@"..\..\..\..\FileTwo.txt");
            OnlyFileOne = new List<int>();
            OnlyFileTwo = new List<int>();
            BothFileOneAndFileTwo = new List<int>();
        }
        public void RealizeExercise(out List<int>FileOneElements,out List<int>FileTwoElements)
        {
            Dictionary<int,bool> ExistInList = new Dictionary<int,bool>();
            FileOneElements = this.GetListFromFile(streamFileOne);
            FileTwoElements = this.GetListFromFile(streamFileTwo);
            /*FileOneElements = new List<int>(){53,41,65,21,33 };
            FileTwoElements = new List<int>(){76,43,67,53,11,91,87,100,41,534,76,33,82,71};*/
            bool isOnlyTest = true;
            foreach(int ElementOne in FileOneElements)
            { 
                isOnlyTest = true;
                if(!ExistInList.ContainsKey(ElementOne))
                {
                    foreach(int ElementTwo in FileTwoElements)
                    {
                        if(ElementOne == ElementTwo && !ExistInList.ContainsKey(ElementTwo))
                        {
                            BothFileOneAndFileTwo.Add(ElementOne);
                            ExistInList.Add(ElementOne,true);
                            isOnlyTest = false;
                            break;
                        }
                    }
                    if(isOnlyTest)
                    {
                        OnlyFileOne.Add(ElementOne);
                        ExistInList.Add(ElementOne,true);
                    }
                }
            }
            foreach(int ElementTwo in FileTwoElements)
            {
                if(!ExistInList.ContainsKey(ElementTwo))
                {
                    OnlyFileTwo.Add(ElementTwo);
                }
            }
        }
        private List<int> GetListFromFile(StreamReader file)
        {
            List<int> elementsList = new List<int>();
            while(!file.EndOfStream)
            {
                int value = Int32.Parse(file.ReadLine());
                elementsList.Add(value);
            }
            return elementsList;
        }
        public List<int> GetList(string type)
        {
            switch (type)
            {
                case "OnlyFileOne":
                    return OnlyFileOne;
                break;
                case "OnlyFileTwo":
                    return OnlyFileTwo;
                break;
                case "BothFileOneAndFileTwo":
                    return BothFileOneAndFileTwo;
                break;
                default:
                    throw new FormatException();
                break;
            }
        }
    }
}
