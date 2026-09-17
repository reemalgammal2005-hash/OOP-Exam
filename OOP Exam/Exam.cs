using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Exam
{
   public  abstract class Exam
    { 
        public int Time {  get; set; }
        public int Number_Of_Question { get; set; }
        public abstract void ShowExam();

        public Subject Subject { get; set; }
        public Question[] Questions { get; set; }



    }
}
