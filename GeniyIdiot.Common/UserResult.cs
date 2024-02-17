using System;
using System.Collections.Generic;
using System.IO;
using GeniyIdiot.Common;

namespace GeniyIdiot.Common
{
    public class UserResult
    {
        public static List<User> GetUserResult()
        {
            
            var lines = FileReaderBase.GetValue("results.txt");
            var result = new List<User>();

            foreach (var line in lines)
            {
                var values = line.Split('#');
                var name = values[0];

                var countrRightAnswers = values[1];
                string finalDiagnos = values[2];

                var user = new User(name, Convert.ToInt32(countrRightAnswers), finalDiagnos);
                result.Add(user);
            }
            return result;
        }
        public static void SaveResult(User user)
        {
            string value = $"{user.Name}#{user.CountRightAnswers}#{user.Diagnosis}";
            FileReaderBase.Append("results.txt", value);
        }
    }
}