namespace OOP_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {


            
            Subject subject = new Subject();

            subject.Subject_Id = 1;
            subject.Subject_Name = "C# OOP";

            
            subject.CreateExam(true);// can take a test by wtiting (true or false)

            // ---------------- Question 1 ----------------

            Answer answer1 = new Answer();
            answer1.AnswerID = 1;
            answer1.AnswerText = "Object Oriented Programming";

            Answer answer2 = new Answer();
            answer2.AnswerID = 2;
            answer2.AnswerText = "Online Object Programming";

            Answer answer3 = new Answer();
            answer3.AnswerID = 3;
            answer3.AnswerText = "Open Operating Program";

            Question question1 = new MCQ_Question();

            question1.Header = "Question 1";
            question1.Body = "What is OOP?";
            question1.Mark = 10;

            question1.Answers = new Answer[]
            {
        answer1,
        answer2,
        answer3
            };

            question1.RightAnswer = answer1;


            // ---------------- Question 2 ----------------

            Answer answer4 = new Answer();
            answer4.AnswerID = 1;
            answer4.AnswerText = "class";

            Answer answer5 = new Answer();
            answer5.AnswerID = 2;
            answer5.AnswerText = "new";

            Answer answer6 = new Answer();
            answer6.AnswerID = 3;
            answer6.AnswerText = "object";

            Question question2 = new MCQ_Question();

            question2.Header = "Question 2";
            question2.Body = "Which keyword is used to create an object in C#?";
            question2.Mark = 15;

            question2.Answers = new Answer[]
            {
        answer4,
        answer5,
        answer6
            };

            question2.RightAnswer = answer5;


            // ---------------- Question 3 ----------------

            Answer answer7 = new Answer();
            answer7.AnswerID = 1;
            answer7.AnswerText = "Encapsulation";

            Answer answer8 = new Answer();
            answer8.AnswerID = 2;
            answer8.AnswerText = "Inheritance";

            Answer answer9 = new Answer();
            answer9.AnswerID = 3;
            answer9.AnswerText = "Abstraction";

            Question question3 = new MCQ_Question();

            question3.Header = "Question 3";
            question3.Body = "Which concept allows a class to inherit from another class?";
            question3.Mark = 20;

            question3.Answers = new Answer[]
            {
        answer7,
        answer8,
        answer9
            };

            question3.RightAnswer = answer8;


            

            subject.Exam.Questions = new Question[]
            {
        question1,
        question2,
        question3
            };


            subject.Exam.Time = 20;
            subject.Exam.Number_Of_Question = 3;


            subject.Exam.ShowExam();

            Console.ReadLine();
        }
        }
    }

