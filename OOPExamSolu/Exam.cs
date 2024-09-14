using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExamSolu
{
    internal abstract class Exam
    {
        #region Constructors
        public Exam()
        {

        }
        public Exam(int time, int nO_Of_Questions)
        {
            Time = time;
            NO_Of_Questions = nO_Of_Questions;
        } 
        #endregion

        #region Properties
        public int Time { get; set; }
        public int NO_Of_Questions { get; set; }
        public Question[] ExamQuestions { get; set; }


        #endregion

        #region Methods


        public abstract void CreateExamQuestions(); // trueOrFalse OR MCQ
        public abstract void ShowExam(); // trueOrFalse OR MCQ



        #endregion



    }


}
