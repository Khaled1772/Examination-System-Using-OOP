using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExamSolu
{
    internal class Subject
    {
        #region Constructors
        public Subject(int id, string name)
        {
            Id = id;
            Name = name;
        } 
        #endregion

        #region Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public Exam EXAM { get; set; }
        #endregion

        #region Methods

        //عاوز هنا اعمل فانكشن تكريت الامتحان

        public void CreateExam() 
        {
            int time;
            int NoOfQuestion ;
            int Type;
            do
            {
            Console.WriteLine( " Enter the time of your Exam " );

            } while (!int.TryParse(Console.ReadLine(), out time));

            do
            {
                Console.WriteLine(" Enter the Number of Questions of your Exam ");

            } while (!int.TryParse(Console.ReadLine(), out NoOfQuestion));

            do
            {
                Console.WriteLine(" Enter the TYpe  of your Exam : 1)Practical OR 2)Final ");

            } while (!int.TryParse(Console.ReadLine(), out Type)&&Type<1||Type>2);

            if (Type==1) 
            {
                EXAM=new PracticalExam(time, NoOfQuestion);
            }
            else  
            {
                EXAM=new FinalExam(time, NoOfQuestion);
            }
            EXAM.CreateExamQuestions();


        } 



        #endregion
    }
}
