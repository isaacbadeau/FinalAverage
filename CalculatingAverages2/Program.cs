using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//I could have used a list.Average() but using the Sum()/Count() allowed me to play with using
//a list method with multiple parameters.
namespace CalculatingAverages2
{
    public class Averages
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
                            Console.Clear();
                            function.SumOfTen();
                            break;
                        case "2":
                            Console.Clear();
                            function.TenTests();
                            break;
                        case "3":
                            Console.Clear();
                            function.RndNumber();
                            break;
                        case "4":
                            Console.Clear();
                            function.UnknowNumber();
                            break;
                        case "5":
                            Console.Clear();
                            selectOption = false;
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
            Console.WriteLine("5. Quit.");
            Console.Write("Selection:  ");
        }

        public void SumOfTen()
        {
            Averages function = new Averages();
            bool repeatYesNo = true;
            while(repeatYesNo)
            {
                List<double> tenSum = new List<double>();
                while (tenSum.Count() < 10)
                {
                    try
                    {
                        Console.Write("Enter sum #{0}: ", tenSum.Count()+1);
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
                double sum = tenSum.Sum();
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
                while (testScores.Count() < 10)
                {
                    try
                    {
                        Console.Write("Enter grade #{0}: ", testScores.Count()+1);
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
                calcResults.TestResults(testScores.Count(), testScores.Sum());
                repeatYesNo = calcResults.ResponseYesNo();
            } 
        }

        public void RndNumber()
        {
            Averages calcResults = new Averages();
            bool repeatYesNo = true;
            while(repeatYesNo)
            {
                Console.Write("How many tests need to be graded? ");
                double number = Convert.ToDouble(Console.ReadLine());
                List<double> testScores = new List<double>();
                while (testScores.Count() < number)
                {
                    try
                    {
                        Console.Write("Enter grade #{0}: ", testScores.Count()+1);
                        var grade = Convert.ToDouble(Console.ReadLine());
                        Console.Clear();
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
                calcResults.TestResults(testScores.Count(), testScores.Sum());
                calcResults.ReviewGrades(testScores);
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
                        Console.Write("Enter grade #{0} (Type quit to end): ", totals.Count() + 1);
                        string grade = Console.ReadLine().ToLower();
                        if (grade == "quit")
                        {
                            test = false;
                        }
                        else if (Convert.ToDouble(grade) < 0 || Convert.ToDouble(grade) > 100)
                        {
                            Console.WriteLine("Invalid");
                        }
                        else
                        {
                            totals.Add(Convert.ToDouble(grade));
                            Console.Clear();
                        }       
                    }
                    catch (System.FormatException)
                    {
                        Console.WriteLine("Invalid entry.");
                    }
                }
                function.TestResults(totals.Count(), totals.Sum());
                function.ReviewGrades(totals);
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
                        Console.Clear();
                        return true;
                    case "y":
                        Console.Clear();
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

        public double TestResults(double value1, double value2)
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
                Console.Write("Evaluate another set? ");
                string response = Console.ReadLine();
                switch (response.ToLower())
                {
                    case "yes":
                        Console.Clear();
                        return true;
                    case "y":
                        Console.Clear();
                        return true;
                    case "no":
                        Console.Clear();
                        return false;
                    case "n":
                        Console.Clear();
                        return false;
                    default:
                        Console.WriteLine("Invalid Entry.");
                        break;
                }
            }
        }

        public bool ReviewGrades(List<double> value1)
        {
            while(true)
            {
                Console.Write("Would you like to review your grades? ");
                string response = Console.ReadLine().ToLower();
                switch (response)
                {
                    case "yes":
                        int x = 0;
                        for (x = 0; x < value1.Count; x++)
                        {
                            Console.WriteLine($"{x + 1}: {value1[x]}");
                        }
                        return true;
                    case "y":
                        for (x = 0; x < value1.Count; x++)
                        {
                            Console.WriteLine($"{x + 1}: {value1[x]}");
                        }
                        return true;
                    case "no":
                        return false;
                    case "n":
                        return false;
                    default:
                        Console.WriteLine("Invalid.");
                        break;
                }
            
            }

        }
    }
}
