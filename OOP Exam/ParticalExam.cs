using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Exam
{
    internal class ParticalExam : Exam
    {
        public override void ShowExam()
        {
            Console.WriteLine("Practical Exam");

            foreach (Question question in Questions)
            {
                Console.WriteLine(question.Header);
                Console.WriteLine(question.Body);

                Console.WriteLine("Right Answer: " + question.RightAnswer.AnswerText);

                Console.WriteLine();
            }
        }
    }
}
