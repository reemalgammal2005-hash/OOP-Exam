using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Exam
{
    public  class Question : ICloneable, IComparable
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public double Mark {  get; set; }
        public Answer[] Answers { get; set; }
        public Answer RightAnswer { get; set; }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        public int CompareTo(object obj)
        {
            Question other = (Question)obj;

            return Mark.CompareTo(other.Mark);
        }
        public override string ToString()
        {
            return Header + " - " + Body + " - Mark: " + Mark;
        }
        public Question() : this("", "", 0)
        {
        }

        public Question(string header, string body, double mark)
        {
            Header = header;
            Body = body;
            Mark = mark;
        }

    }
}
