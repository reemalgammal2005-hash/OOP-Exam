using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Exam
{
    internal class FinalExam : Exam
    {
        public double Grade { get; set; }
        public override void ShowExam()
        {
            Console.WriteLine("Final Exam");

            foreach (Question question in Questions)
            {
                Console.WriteLine(question.Header);
                Console.WriteLine(question.Body);
                Console.WriteLine("Mark: " + question.Mark);

                foreach (Answer answer in question.Answers)
                {
                    Console.WriteLine(answer.AnswerID + "- " + answer.AnswerText);
                }

                Console.WriteLine("Right Answer: " + question.RightAnswer.AnswerText);
                Console.WriteLine();
            }
            Console.WriteLine("Grade: " + Grade);
        }
    }
}
