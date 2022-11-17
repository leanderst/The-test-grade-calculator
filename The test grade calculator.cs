using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace idk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] Points = new double[9999], MaxPoints = new double[9999], Grades = new double[9999];
            double AllPoints, EndGrade, EndPoints, AllGrades, Points3, MaxPoints3;
            int Cunt, i, EndGrade2;
            string Points2, MaxPoints2 = "", jn;
            do
            {
                AllPoints = 0;
                AllGrades = 0;
                EndGrade = 0;
                EndPoints = 0;
                Cunt = 0;
                i = 0;
                EndGrade2 = 0;
                Points3 = 0;
                MaxPoints3 = 0;
                Console.Clear();
                Console.WriteLine("                          #############################");
                Console.WriteLine("                          # THE TEST GRADE CALCULATOR #");
                Console.WriteLine("                          #############################");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Enter all test points:");
                Console.WriteLine("     (Type \"stop\" to stop)");
                Console.WriteLine();

                do
                {
                    i++;
                    do
                    {
                        Console.Write(i + ". test points: ");
                        Points2 = Console.ReadLine();
                        Points2 = Points2.ToLower();
                        if (Points2 != "stop")
                        {
                            double.TryParse(Points2, out Points3);
                            if (Points3 == 0)
                            {
                                Console.WriteLine("Only valid number.");
                                Console.WriteLine();
                            }
                        }
                    } while (Points3 == 0 && Points2 != "stop");

                    if (Points2 != "stop")

                    {
                        Cunt++;
                        Points[i] = Points3;
                        AllPoints = AllPoints + Points3;
                        do
                        {
                            Console.Write(i + ". test max points: ");
                            MaxPoints2 = Console.ReadLine();
                            if (MaxPoints2 != "stop")
                            {
                                double.TryParse(MaxPoints2, out MaxPoints3);
                                if (MaxPoints3 == 0)
                                {
                                    Console.WriteLine("Only valid number.");
                                    Console.WriteLine();
                                }
                            }
                        } while (MaxPoints3 == 0 && MaxPoints2 != "stop");
                        if (MaxPoints3 < Points[i])
                        {
                            do
                            {
                                Console.WriteLine("     (The max points have to be as big as your points or higher.)");
                                Console.Write(i + ". test points: ");
                                Points2 = Console.ReadLine();
                                if (Points2 != "stop")
                                {
                                    Points[i] = Points3;
                                    AllPoints = AllPoints + Points3;
                                    do
                                    {
                                        Console.Write(i + ". test max points: ");
                                        MaxPoints2 = Console.ReadLine();
                                        double.TryParse(MaxPoints2, out MaxPoints3);
                                        if (MaxPoints3 == 0)
                                        {
                                            Console.WriteLine("Only valid number.");
                                            Console.WriteLine();
                                        }
                                    } while (MaxPoints3 == 0);
                                    if (MaxPoints3 != 0)
                                    {
                                        MaxPoints[i] = MaxPoints3;
                                    }
                                    Console.WriteLine();
                                }
                            } while (MaxPoints3 < Points[i]);
                        }
                        else
                        {
                            if (MaxPoints2 != "stop")
                            {
                                MaxPoints[i] = MaxPoints3;
                            }
                            Console.WriteLine();
                        }
                    }
                } while (Points2 != "stop" && MaxPoints2 != "stop");

                for (i = 1; i < (Cunt + 1); i++)
                {
                    Grades[i] = 1;
                    if (Points[i] == 0)
                    {
                        Grades[i] = 5;
                    }
                    else
                    {
                        if ((MaxPoints[i] / Points[i]) >= 1.111111111)
                        {
                            Grades[i] = 2;
                            if ((MaxPoints[i] / Points[i]) >= 1.25)
                            {
                                Grades[i] = 3;
                                if ((MaxPoints[i] / Points[i]) >= 1.538461538461538)
                                {
                                    Grades[i] = 4;
                                    if ((MaxPoints[i] /Points[i]) > 2)
                                    {
                                        Grades[i] = 5;
                                    }
                                }
                            }
                        }
                    }
                    AllGrades = AllGrades + Grades[i];
                }
                EndGrade = AllGrades / Cunt;
                EndPoints = AllPoints / Cunt;
                if (Cunt > 0)
                {
                    EndGrade2 = Convert.ToInt32(EndGrade);
                }
                Console.WriteLine(Cunt + " ");
                Console.Clear();
                Console.WriteLine("                          #############################");
                Console.WriteLine("                          # THE TEST GRADE CALCULATOR #");
                Console.WriteLine("                          #############################");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Your average grade is " + EndGrade2 + ". (" + EndGrade + ")");
                Console.WriteLine("Your average Points are " + EndPoints + ".");
                Console.WriteLine("All your points are " + AllPoints);
                Console.WriteLine();
                Console.WriteLine("Your individual test grades:");
                for (i = 1; i < (Cunt + 1); i++)
                {
                    Console.WriteLine(i + ". Test = " + Grades[i] + ".");
                }
                Console.ReadKey();
                Console.WriteLine();
                Console.WriteLine("Do you want to restart?");
                Console.WriteLine("     (j | n)");
                do
                {
                    jn = Console.ReadLine();
                    if (jn != "j" && jn != "n")
                    {
                        Console.WriteLine("Please Enter \"j\" or \"n\".");
                        Console.WriteLine();
                    }
                } while (jn != "j" && jn != "n");
            } while (jn == "j");
            Console.Clear();
            Console.WriteLine("         |THE TEST GRADE CALCULATOR|");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Nice grades shithead!");
            Thread.Sleep(2000);
        }
    }
}
