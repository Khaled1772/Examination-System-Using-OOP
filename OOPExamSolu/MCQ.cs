using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExamSolu
{
    internal class MCQ : Question
    {
        #region Constructors
        public MCQ()
        {
            AnswerList = new Answers[3];
        } 
        #endregion
        public override string Header_the_question { get { return "MCQ Question "; } }
        public override void CreateQuestion()
        { 
            //for Header
            Console.WriteLine(Header_the_question);
            // For body Question
            Console.WriteLine("Please Enter The Question You want ");
            Body_of_the_question = Console.ReadLine();
            //for Mark of The Question
            int m;
            do
            {
                Console.WriteLine("Please Enter the mark of your Question ");
                

            } while (!int.TryParse(Console.ReadLine(), out m));
            Mark = m;

            //For Chooses
            for (int i = 0; i < 3; i++)
            {
                AnswerList[i] = new Answers()
                {
                    AnswerId = i+1 ,
                
                };
                Console.WriteLine($"Please Enter your Choice Number {i+1} ");
                AnswerList[i].AnswerText = Console.ReadLine();

            }

            //For Right Choose 
            int Right;
            do
            {
                Console.WriteLine("Please Enter Number The Right Answer");
            } while (!int.TryParse(Console.ReadLine(),out Right ) && (Right<1||Right>3));

            RightAnswer.AnswerId = Right;
            RightAnswer.AnswerText = AnswerList[Right-1].AnswerText; 

        }
    }
}
