using System;
using System.Collections.Generic;
using System.IO;
using GeniyIdiot.Common;

namespace GeniyIdiot.Common
{
    public class QuestionStorage
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
        public static int[] GetRandomIndex(int length)
        {
            var array = new int[length];

            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }
            for (int i = array.Length - 1; i >= 1; i--)
            {
                int j = random.Next(i + 1);
                int temp = array[j];
                array[j] = array[i];
                array[i] = temp;
            }
            return array;
        }

        public static List<Question> GetQuestions()
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
        } //}
        public static void AddNewQuestion()
        {
            Console.WriteLine("Введите вопрос");
            string text = Console.ReadLine().ToLower();
            Console.WriteLine("Введите ответ");
            int answer = Validation.GetNumber();
            var question = new Question(text, answer);
            Add(question);
        }

        public static void Remove(Question removeQuestion)
        {
            var questions = GetQuestions();
            for (int i = 0; i < questions.Count; i++)
            {
                if (questions[i].NameQuestion == removeQuestion.NameQuestion)
                {
                    questions.RemoveAt(i);
                    break;
                }
            }
            FileReaderBase.Clear("questions.txt");
            foreach (var question in questions)
            {
                Add(question);
            }
        }
        public static void RemoveQuestion()
        {
            Console.WriteLine("Введите номер вопрос, который хотите удалить");
            var questions = QuestionStorage.GetQuestions();
            for (int i = 0; i < questions.Count; i++)
            {
                Console.WriteLine(i + 1 + ". " + questions[i].NameQuestion);
            }
            var removeQuestionNumber = Validation.GetNumber();
            while (removeQuestionNumber < 1 || removeQuestionNumber > questions.Count)
            {
                Console.WriteLine("Введите число от 1 до " + questions.Count);
                removeQuestionNumber = Validation.GetNumber();
            }
            var removeQuestion = questions[removeQuestionNumber - 1];
            Remove(removeQuestion);
        }
    }

}