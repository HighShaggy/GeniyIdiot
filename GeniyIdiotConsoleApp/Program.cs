using System;
using System.IO;
using GeniyIdiot.Common;

namespace GeniyIdiotConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Как вас зовут?");
        string name = Console.ReadLine();
        var table = new FileStream("results.txt", FileMode.OpenOrCreate);
        var quests = new FileStream("questions.txt", FileMode.OpenOrCreate);
        table.Close();
        quests.Close();
        while (true)
        {
            Console.Clear();
            var questions = QuestionStorage.GetQuestions();
            var randomIndex = GetRandomIndex(questions.Count);
            var countRightAnswers = 0.0;
            Console.WriteLine(name + " хотите посмотреть таблицу с предыдущими результатами? да/нет(yes/no)");
            string agreementViewResults = Console.ReadLine().ToLower();
            if (agreementViewResults == "да" || agreementViewResults == "yes")
            {
                string[] emptyFile = File.ReadAllLines("results.txt");

                if (emptyFile.Length == 0)
                {
                    Console.WriteLine("Предыдущих результатов нет");
                }
                else
                {
                    ShowStats();
                }
            }
            Console.WriteLine("Хотите пройти тест? да/нет(yes/no)");
            while (true)
            {
                string agreementStartTest = Console.ReadLine().ToLower();
                if (agreementStartTest == "да" || agreementStartTest == "yes")
                {
                    break;
                }
                if ((agreementStartTest == "нет" || agreementStartTest == "no"))
                {
                    return;
                }
                else
                {
                    Console.WriteLine("Ошибка, введите один из предложенных вариантов");
                }
            }
            for (int i = 0; i < questions.Count; i++)
            {
                Console.WriteLine("Вопрос №" + (i + 1));
                Console.WriteLine(questions[randomIndex[i]].NameQuestion);
                while (true)
                {
                    Console.Write("Введите число: ");
                    var userAnswer = Validation.GetNumber();
                    int rightAnswer = questions[randomIndex[i]].CountAnswer;
                    if (userAnswer == rightAnswer)
                    {
                        countRightAnswers++;
                    }
                    break;
                }
            }
            var percentRightAnswers = Convert.ToDouble((countRightAnswers / questions.Count) * 100);
            Console.WriteLine("Процент правильных ответов: " + Math.Round(percentRightAnswers));
            Console.WriteLine("Уважаемый " + name + " Ваш диагноз: " + GetFinalDiagnosis(percentRightAnswers));
            User user = new User(name, Convert.ToInt32(countRightAnswers), GetFinalDiagnosis(percentRightAnswers));
            UserResult.SaveResult(user);
            Console.WriteLine(user.Name + ", если хотите ознакомиться с результами напишите да/yes");
            string agreementWatchStatsAgain = Console.ReadLine();
            if (agreementWatchStatsAgain == "да" || agreementWatchStatsAgain == "yes")
            {
                Console.WriteLine();
                ShowStats();
                Console.WriteLine("Нажмите любую кнопку чтобы продолжить");
                Console.ReadKey();
            }
            Console.WriteLine(user.Name + ",хотите добавить новый вопрос? да/yes");
            string agreementAddQuestion = Console.ReadLine().ToLower();
            if (agreementAddQuestion == "да" || agreementAddQuestion == "yes")
            {
                QuestionStorage.AddNewQuestion();
            }
            Console.WriteLine(user.Name + "хотите удалить существующий вопрос? да/yes");
            string agreementRemoveQuestion = Console.ReadLine().ToLower();
            if (agreementRemoveQuestion == "да" || agreementRemoveQuestion == "yes")
            {
                QuestionStorage.RemoveQuestion();
            }
                Console.WriteLine("вопрос удален, хотите удалить еще один? да/yes");
                string agreementRemoveSecondQuestion = Console.ReadLine().ToLower();
                if (agreementRemoveQuestion == "да" || agreementRemoveQuestion == "yes")
                {
                    QuestionStorage.RemoveQuestion();
                }
            
            Console.WriteLine("Хотите ли пройти тест снова? да/нет(yes/no)");
            while (true)
            {
                string agreement = Console.ReadLine().ToLower();
                if (agreement == "да" || agreement == "yes")
                    break;

                if ((agreement == "нет" || agreement == "no"))
                {
                    Console.Clear();
                    Console.WriteLine("Спасибо за прохождение теста!");
                    return;
                }
                Console.WriteLine("Ошибка, введите один из предложенных вариантов");
            }
        }
    }


    static int[] GetRandomIndex(int length)
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

    public static string[] diagnosesStorage = new string[]
    {

        "Кретин",
        "Идиот",
        "Дурак",
        "Нормальный",
        "Талант",
        "Гений"

    };

    public static void ShowStats()
    {
        var result = UserResult.GetUserResult();

        Console.WriteLine("|{0,-13}|{1,-13}|{2,-13}|", "Имя", "Ответил верно", "Диагноз");
        foreach (User user in result)
        {
            Console.WriteLine("|{0,-13}|{1,-13}|{2,-13}|", user.Name, user.CountRightAnswers, user.Diagnosis);
        }
    }

    static string GetFinalDiagnosis(double percentСorrectAnswers)
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
}