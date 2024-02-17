using GeniyIdiot.Common;

namespace GeniyIdiot.Common
{
    public class Question
    {
        public string NameQuestion;

        public int CountAnswer;
        public Question(string nameQuestion, int countAnswer)
        {
            NameQuestion = nameQuestion;
            CountAnswer = countAnswer;
        }
    }
}