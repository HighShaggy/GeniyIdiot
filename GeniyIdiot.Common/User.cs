using GeniyIdiot.Common;

namespace GeniyIdiot.Common
{
    public class User
    {
        public string Name;

        public int CountRightAnswers;

        public string Diagnosis = "";

        public User(string name, int countRightAnswers, string diagnosis)
        {
            Name = name;
            CountRightAnswers = countRightAnswers;
            Diagnosis = diagnosis;
        }
        public User(string name)
        {
            Name = name;
        }
    }
}