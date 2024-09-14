using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExamSolu
{
    internal class PracticalExam : Exam
    {
        
        public PracticalExam(int _time, int _nO_Of_Questions) : base(_time, _nO_Of_Questions)
        {

        }
        public override void CreateExamQuestions()
        {
            ExamQuestions = new MCQ[NO_Of_Questions];

            for (int i = 0; i < ExamQuestions.Length; i++)
            {
                ExamQuestions[i] = new MCQ();
                ExamQuestions[i].CreateQuestion();
            }


        }

        public override void ShowExam()
        {
            int UsRSelection;
            for (int i = 0; i < ExamQuestions.Length; i++)
            {
                Console.WriteLine(ExamQuestions[i]);

                for (int j = 0; j < ExamQuestions[i].AnswerList.Length; j++) //length of Answers of Current Question 
                {
                    Console.WriteLine(ExamQuestions[i].AnswerList[j]);
                }
                Console.WriteLine("_______________________________________________________");

                do
                {
                    Console.WriteLine("Enter the number of your Answer ");
                } while (!int.TryParse(Console.ReadLine(), out UsRSelection));

                ExamQuestions[i].UserAnswer.AnswerId = UsRSelection;
                ExamQuestions[i].UserAnswer.AnswerText = ExamQuestions[i].AnswerList[UsRSelection - 1].AnswerText;
                Console.WriteLine("-----------------------------------------------------------------------------------");

                Console.WriteLine($"Question ({i + 1}) : {ExamQuestions[i].Body_of_the_question}");
                Console.WriteLine($"Your Answer is : {ExamQuestions[i].UserAnswer.AnswerText}");
                Console.WriteLine($"The Right Answer is : {ExamQuestions[i].RightAnswer.AnswerText}");


            }





            }
    }
}
