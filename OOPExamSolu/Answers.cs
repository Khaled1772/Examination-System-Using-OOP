using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExamSolu
{
    internal class Answers
    {
        #region Constructors

        public Answers()
        {

        }

        public Answers(int answerId, string answerText)
        {
            AnswerId = answerId;
            AnswerText = answerText;
        }



        #endregion

        #region Properties
        public int AnswerId { get; set; }
        public string AnswerText { get; set; }
        #endregion

        #region Overriding

        public override string ToString()
        {
            return $"{AnswerId} : {AnswerText}";
        }
        #endregion

    }
}
