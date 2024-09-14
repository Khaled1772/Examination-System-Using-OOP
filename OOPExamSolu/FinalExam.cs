using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExamSolu
{
    internal class FinalExam : Exam
    {
        #region Constructors

            public FinalExam(int _time, int _nO_Of_Questions):base(_time, _nO_Of_Questions)
            {

            }

        #endregion
        public override void CreateExamQuestions()
        {
            ExamQuestions = new Question[NO_Of_Questions];
            int type;
            for (int i = 0; i < ExamQuestions.Length; i++)
            {
                do
                {
                    Console.WriteLine($"Enter The Type of Question NO.({i + 1}) : 1 for MCQ and 2 for True|False");
                } while ((!int.TryParse(Console.ReadLine(),out type )) || (type < 1|| type>2));
                if(type==1 ) 
                {
                    ExamQuestions[i] = new MCQ();
                    ExamQuestions[i].CreateQuestion();
                }
                else 
                {
                    ExamQuestions[i]=new TrueOrFalse();
                    ExamQuestions[i].CreateQuestion();
                }
                //else 
                //{
                //    Console.WriteLine("Please Choose a correct Type ");
                //}
            }

        }

        public override void ShowExam()
        {
            int UsRSelection;
            int TotalMark=0, GRADE=0;
            for (int i = 0; i < ExamQuestions?.Length; i++)
            {
                Console.WriteLine(ExamQuestions[i]);
            
                for (int j = 0; j < ExamQuestions[i].AnswerList?.Length; j++) //length of Answers of Current Question 
                {
                    Console.WriteLine(ExamQuestions[i]?.AnswerList[j]);
                }
                Console.WriteLine("_______________________________________________________");

                do
                {
                    Console.WriteLine("Enter the number of your Answer ");
                } while (!int.TryParse(Console.ReadLine(), out UsRSelection) );

                ExamQuestions[i].UserAnswer.AnswerId = UsRSelection;
                ExamQuestions[i].UserAnswer.AnswerText = ExamQuestions[i].AnswerList[UsRSelection-1].AnswerText;
                Console.WriteLine("._._._.........................................................................._.._.._._._.");
               


            }

            for (int i = 0; i < ExamQuestions?.Length; i++)
            {

                TotalMark += ExamQuestions[i].Mark;
                if (ExamQuestions[i].UserAnswer.AnswerId == ExamQuestions[i].RightAnswer.AnswerId)
                {
                    GRADE += ExamQuestions[i].Mark;
                }
                Console.WriteLine($"Question ({i + 1}) : {ExamQuestions[i].Body_of_the_question}");
                Console.WriteLine($"Your Answer is : {ExamQuestions[i].UserAnswer.AnswerText}");
                Console.WriteLine($"The Right Answer is : {ExamQuestions[i].RightAnswer.AnswerText}");

            }



            Console.WriteLine($"Your Grade is {GRADE} form {TotalMark}");


        }
    }
}
