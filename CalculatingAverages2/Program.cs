using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatingAverages2
{
    class Averages
    {
        static void Main(string[] args)
        {
            {
                Averages function = new Averages();
                bool selectOption = true;

                while (selectOption)
                {
                    function.MainMenu();
                    string response = Console.ReadLine();
                    switch (response)
                    {
                        case "1":
                            function.SumOfTen();
                            break;
                        case "2":
                            function.TenTests();
                            break;
                        case "3":
                            function.RndNumber();
                            break;
                        case "4":
                            function.UnknowNumber();
                            break;
                        default:
                            Console.WriteLine("Invalid selection.");
                            break;
                    }
                }
            }
        }

        public void MainMenu()
        {
            Console.WriteLine("Make a selection:");
            Console.WriteLine("1. Sum of ten numbers.");
            Console.WriteLine("2. Grade 10 tests.");
            Console.WriteLine("3. Grade a given amount of tests.");
            Console.WriteLine("4. Grade any number of tests.");
        }

        public void SumOfTen()
        {
            Averages function = new Averages();
            bool repeatYesNo = true;
            while(repeatYesNo)
            {
                List<double> tenSum = new List<double>();
                while (tenSum.Count() < 9)
                {
                    try
                    {
                        Console.Write("Enter value: ");
                        var grade = Convert.ToDouble(Console.ReadLine());
                        if (grade < 0 || grade > 100)
                        {
                            Console.WriteLine("Invalid entry.");
                        }
                        else
                            tenSum.Add(grade);
                    }
                    catch (System.FormatException)
                    {
                        Console.WriteLine("Numbers only");
                    }
                }
                double sum = tenSum.Count();
                Console.WriteLine("The sum of the values is {0}", sum);
                repeatYesNo = function.ResponseYesNo();
            }
            
        }
        public void TenTests()
        {
            Averages calcResults = new Averages();
            bool repeatYesNo = true;
            while(repeatYesNo)
            {
                List<double> testScores = new List<double>();
                while (testScores.Count() < 9)
                {
                    try
                    {
                        Console.Write("Enter grade: ");
                        var grade = Convert.ToDouble(Console.ReadLine());
                        if (grade < 0 || grade > 100)
                        {
                            Console.WriteLine("Invalid entry.");
                        }
                        else
                            testScores.Add(grade);
                    }
                    catch (System.FormatException)
                    {
                        Console.WriteLine("Numbers only");
                    }
                }
                calcResults.TestResult(testScores.Count(), testScores.Sum());
                repeatYesNo = calcResults.ResponseYesNo();
            }
            
        }

        public void RndNumber()
        {
            Averages calcResults = new Averages();
            bool repeatYesNo = true;
            while(repeatYesNo)
            {
                Console.WriteLine("How many tests need to be graded?");
                double number = Convert.ToDouble(Console.ReadLine());
                List<double> testScores = new List<double>();

                while (testScores.Count() < number)
                {
                    try
                    {
                        Console.Write("Enter grade: ");
                        var grade = Convert.ToDouble(Console.ReadLine());
                        if (grade < 0 || grade > 100)
                        {
                            Console.WriteLine("Invalid entry.");
                        }
                        else
                            testScores.Add(grade);
                    }
                    catch (System.FormatException)
                    {
                        Console.WriteLine("Numbers only");
                    }
                }
                calcResults.TestResult(testScores.Count(), testScores.Sum());
                repeatYesNo = calcResults.ResponseYesNo();
            }  
        }

        public void UnknowNumber()
        {
            Averages function = new Averages();
            bool repeatYesNo = true;
            while(repeatYesNo)
            {
                List<double> totals = new List<double>();
                bool test = true;
                while (test)
                {
                    try
                    {
                        Console.Write("Enter grade: ");
                        var grade = Convert.ToDouble(Console.ReadLine());
                        if (grade < 0 || grade > 100)
                        {
                            Console.WriteLine("Invalid entry.");
                        }
                        else
                            totals.Add(grade);
                    }
                    catch (System.FormatException)
                    {
                        Console.WriteLine("Invalid entry.");
                    }
                    test = function.AnotherGrade();
                }
                function.UnknowTestResult(totals.Count(), totals.Sum());
                repeatYesNo = function.ResponseYesNo();
            }
            
        }

        public bool AnotherGrade()
        {
            while (true)
            {
                Console.Write("Enter another grade? ");
                string response = Console.ReadLine();
                switch (response.ToLower())
                {
                    case "yes":
                        return true;
                    case "y":
                        return true;
                    case "no":
                        return false;
                    case "n":
                        return false;
                    default:
                        Console.WriteLine("Invalid Entry.");
                        break;
                }
            }
        }
        public double TestResult(double value1, double value2 )
        {
            double testTotal = value1;
            double testAverage = Math.Round(value2 / value1, 2);
            Console.WriteLine("Class average: {0}", testAverage);
            return Math.Round(testAverage, 2); 
        }
        public double UnknowTestResult(double value1, double value2)
        {
            double testTotal = value1;
            double testAverage = Math.Round(value2 / value1, 2);
            Console.WriteLine("Class average is a {0}", testAverage);
            if (testAverage < 70)
                Console.WriteLine("Class average is an F.");
            else if (testAverage >= 70 && testAverage < 80)
                Console.WriteLine("Class average is a C.");
            else if (testAverage >= 80 && testAverage < 90)
                Console.WriteLine("Class average is a B.");
            else if (testAverage >= 90)
                Console.WriteLine("Class average is an A.");
            return Math.Round(testAverage, 2);
        }
        public bool ResponseYesNo()
        {
            while (true)
            {
                Console.Write("Grade another set? ");
                string response = Console.ReadLine();
                switch (response.ToLower())
                {
                    case "yes":
                        return true;
                    case "y":
                        return true;
                    case "no":
                        return false;
                    case "n":
                        return false;
                    default:
                        Console.WriteLine("Invalid Entry.");
                        break;
                }
            }
        }
    }
}
