using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExamSolu
{
    internal class TrueOrFalse : Question
    {
        #region Properties
        public TrueOrFalse()
        {
            AnswerList = new Answers[2];
            AnswerList[0] = new Answers(1, "True");
            AnswerList[1] = new Answers(2, "False");
        } 
        #endregion
        public override string Header_the_question => "True Or False Question ";

        public override void CreateQuestion()
        {
            //For Header
            Console.WriteLine(Header_the_question);
            //for Body Question
            Console.WriteLine("Please Enter The Question You want ");
            Body_of_the_question = Console.ReadLine();
            //for Mark of The Question
            int m;
            do
            {
                Console.WriteLine("Please Enter the mark of your Question ");


            } while (!int.TryParse(Console.ReadLine(), out m));
            Mark = m;
            //For Right Answer 
            int Right;
            do
            {
                Console.WriteLine("Please Enter Number The Right Answer");
            } while (!int.TryParse(Console.ReadLine(),out Right) && (Right < 1 || Right > 2));
            RightAnswer.AnswerId = Right;
            RightAnswer.AnswerText = AnswerList[Right-1].AnswerText;



        }
    }
}
