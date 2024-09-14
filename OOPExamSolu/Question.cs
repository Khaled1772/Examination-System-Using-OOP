using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExamSolu
{
    internal abstract class Question
    {
        // a.Header of the question Specified later in (TrueOrfalse,MCQ) classes 
        //b.Body of the question
        //c.Mark

        #region Constructor

        public Question()
        {
            RightAnswer=new Answers();
            UserAnswer=new Answers();
        }

        #endregion

        #region Properties

        public abstract string Header_the_question { get;  } // Read Only Property

        public string Body_of_the_question { get; set; }
        public int Mark { get; set; }


        
        public Answers[] AnswerList { get; set; }
        public Answers RightAnswer { get; set; }
        public Answers UserAnswer { get; set; }

        #endregion

        #region Overriding
        public override string ToString()
        {
            return $"{Header_the_question}                  Mark :{Mark}\n----------------------------\n{Body_of_the_question} ";
        }
        #endregion

        #region Methods

        public abstract void CreateQuestion();

        #endregion







    }
}
