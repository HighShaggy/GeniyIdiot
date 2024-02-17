using System.Collections.Generic;
using System;
using System.IO;

namespace GeniyIdiot.Common
{
    public class QuestionHub
    {
        public static List<Question> GetHub()
        {
            var quests = new FileStream("questions.txt", FileMode.OpenOrCreate);
            quests.Close();

            var questions = new List<Question>();
            var lines = FileReaderBase.GetValue("questions.txt");
            foreach (var line in lines)
            {
                var values = line.Split('#');
                string text = values[0];
                int answer = Convert.ToInt32(values[1]);
                var question = new Question(text, answer);
                questions.Add(question);
            }
            string[] emptyFile = File.ReadAllLines("questions.txt");
            if (emptyFile.Length == 0)
            {
                questions.Add(new Question("Сколько будет два плюс два умноженное на два?", 6));
                questions.Add(new Question("Бревно нужно распилить на 10 частей. Сколько распилов нужно сделать?", 9));
                questions.Add(new Question("На двух руках 10 пальцев. Сколько пальцев на 5 руках?", 25));
                questions.Add(new Question("Укол делают каждые полчаса. Сколько нужно минут, чтобы сделать три укола?", 60));
                questions.Add(new Question("Пять свечей горело, две потухли. Сколько свечей осталось?", 2));
                foreach (var question in questions)
                {
                    Add(question);
                }
            }
            return questions;
        }
        public static void Add(Question question)
        {
            var value = $"{question.NameQuestion}#{question.CountAnswer}";
            FileReaderBase.Append("questions.txt", value);
        }
        public static string GetFinalDiagnosis(double percentСorrectAnswers)
        {
            if (percentСorrectAnswers == 0 || percentСorrectAnswers <= 10)
            {
                return diagnosesStorage[0];
            }
            else if (percentСorrectAnswers <= 25)
            {
                return diagnosesStorage[1];
            }
            else if (percentСorrectAnswers <= 40)
            {
                return diagnosesStorage[2];
            }
            else if (percentСorrectAnswers <= 60)
            {
                return diagnosesStorage[3];
            }
            else if (percentСorrectAnswers <= 80)
            {
                return diagnosesStorage[4];
            }
            else
                return diagnosesStorage[5];
        }
        public static string[] diagnosesStorage = new string[]
    {

        "Кретин",
        "Идиот",
        "Дурак",
        "Нормальный",
        "Талант",
        "Гений"

    };

    }

}
