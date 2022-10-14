using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using Exercise_1;
using Exercise_3;
namespace User_Console_Interface
{
    internal class Program
    {
        public static void ShowResoult(IExerciseONE obj, int EnteredValue)
        {
            Console.WriteLine($"[Podpunkt {obj.subPoint}] Udało mi się zgadnąć liczbę: {EnteredValue} po {obj.RealizeTask(EnteredValue)} próbach");
        } //Wypisywanie wyników każdego z podpunktów
        public static void ShowResoult(ExerciseTHREE obj,List<int>FileListOne, List<int>FileListTwo)
        {
            Console.WriteLine("Plik 1:");
            foreach(int element in FileListOne)
            {
                foreach (int OnlyFileOneElement in obj.GetList("OnlyFileOne"))
                {
                    if (element == OnlyFileOneElement)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(element + ",");
                    Console.ForegroundColor = ConsoleColor.White;
                }

                }
                foreach (int BothFileOneAndFileTwoElement in obj.GetList("BothFileOneAndFileTwo"))
                {
                    if (element == BothFileOneAndFileTwoElement)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(element + ",");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
            }

            Console.WriteLine("\nPlik 2:");
            foreach(int element in FileListTwo)
            {
                foreach (int OnlyFileTwoElement in obj.GetList("OnlyFileTwo"))
                {
                if (element == OnlyFileTwoElement)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(element + ",");
                    Console.ForegroundColor = ConsoleColor.White;
                }

                }
                foreach (int BothFileOneAndFileTwoElement in obj.GetList("BothFileOneAndFileTwo"))
                {
                    if (element == BothFileOneAndFileTwoElement)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(element + ",");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
            }
        }
        public static void ShowResoult(double subA, double subB, double subC)
        {
            Console.WriteLine($"[Podpunkt A] na odgadnięcie liczby średnio potrzebowałem {subA} prób");
            Console.WriteLine($"[Podpunkt B] na odgadnięcie liczby średnio potrzebowałem {subB} prób");
            Console.WriteLine($"[Podpunkt C] na odgadnięcie liczby średnio potrzebowałem {subC} prób");
        }
        static void Main(string[] args)
        {
            IExerciseONE subPoints;
            int EnteredValue;


            E:
            Console.WriteLine("Zadanie 1 - Zgadywanie liczby");
            try
            {
                Console.Write($"Podaj liczbe z przedziału < 1 - 1000 >: ");
                EnteredValue = Int32.Parse(Console.ReadLine());
                if(EnteredValue > 1000 || EnteredValue < 1 )
                {
                    throw new Exception();
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Wartosc jest nie poprawna");
                Console.Clear();
                goto E;
            }//Validation inputs data
            Console.WriteLine();

            subPoints = new SubPointA();
                ShowResoult(subPoints,EnteredValue); // Rozwiązanie A
            subPoints = new SubPointB();
                ShowResoult(subPoints,EnteredValue); // Rozwiązanie B
            subPoints = new SubPointC();
                ShowResoult(subPoints,EnteredValue); // Rozwiązanie C

            Console.WriteLine("\n\nZadanie 2 - Zgadywanie liczby wylosowanej przez komputer w pętli milion razy");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Proszę pamiętać, że komputer musi wykonać coś MILION razy. Dajmy mu chwilkę :) w tym czasie proszę sprawdzić wynik zadania pierwszego znajdujący się na górze \n\n");
            Console.ForegroundColor = ConsoleColor.White;
            int iterator = 0;
            Random random = new Random();
            int subPointAAttept=0,subPointBAttept=0,subPointCAttept=0;
            while(iterator < 1000000)
            {
                subPoints = new SubPointA();
                   subPointAAttept += subPoints.RealizeTask(random.Next(1,1000+1));
                subPoints = new SubPointB();
                    subPointBAttept += subPoints.RealizeTask(random.Next(1,1000+1));
                subPoints = new SubPointC();
                    subPointCAttept += subPoints.RealizeTask(random.Next(1,1000+1));
                iterator++;
            }
            double subPointAAvg = subPointAAttept/1000000;
            double subPointBAvg = subPointBAttept/1000000;
            double subPointCAvg = subPointCAttept/1000000;

            ShowResoult(subPointAAvg,subPointBAvg,subPointCAvg);

            Console.WriteLine("\n\nZadanie 3 - Porównywanie plików");
            
            
            Console.Write($"Proszę umieścić pliki w katalogu:");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"Zadanie domowe 1 (Jakub Czarnecki WRX75755) ");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Lub poprostu edytować już istniejące tam pliki ");

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(@"FileOne.txt / FileTwo.txt ");
            Console.ForegroundColor = ConsoleColor.White;
                
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(@"Proszę pamiętać, że program jako pliki źródłowe rozpoznaje pliki o nazwie 'FileOne.txt' oraz 'FileTwo.txt' !!");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Nie trzeba edytować plików ( są już wypełnione przezemnie ) można tylko wcisnąć enter");
            Console.WriteLine("Następnie proszę wycisnąc dowolny przycisk na klawiaturze..");
            Console.ReadKey();
           

            ExerciseTHREE testing = new ExerciseTHREE();
            List<int> FileAList;
            List<int> FileBList;
            testing.RealizeExercise(out FileAList,out FileBList);
            ShowResoult(testing,FileAList,FileBList);

            Console.WriteLine();
        }
    }
}
