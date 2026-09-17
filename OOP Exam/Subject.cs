using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Exam
{
    public  class Subject
    {
        public int Subject_Id {  get; set; }
        public string Subject_Name {  get; set; }
        public Exam Exam { get; set; }

        public void CreateExam(bool isFinal)
        {
            if (isFinal)
            {
                Exam = new FinalExam();
            }
            else
            {
                Exam = new ParticalExam();
            }
        }

    }
}
