using System.Diagnostics;

namespace OOPExamSolu
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Subject subject1 = new Subject(1,"C#");
            subject1.CreateExam();
            Console.WriteLine("Do you want to start Exam (Y|N) : ");
            char Choice=char.Parse(Console.ReadLine());
            if (Choice=='Y'|| Choice == 'y')
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                subject1.EXAM.ShowExam();
                Console.WriteLine($"You take time equal: {sw.Elapsed}");

            }
            else
            {
                Console.WriteLine("Thank You :)");
            }
        }
    }
}