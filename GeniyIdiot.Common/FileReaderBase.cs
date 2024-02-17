using System;
using System.Collections.Generic;
using System.IO;
using GeniyIdiot.Common;

namespace GeniyIdiot.Common
{
    public class FileReaderBase
    {
        public static void Append(string filename, string value)
        {
            var writer = new StreamWriter(filename, true, System.Text.Encoding.UTF8);
            writer.WriteLine(value);
            writer.Close();
        }
        public static List<string> GetValue(string filename)
        {
            var reader = new StreamReader(filename);
            var list = new List<string>();
            string value;

            while ((value = reader.ReadLine()) != null)
            {
                list.Add(value);
            }

            reader.Close();
            return list;
        }

        public static void Clear(string filename)
        {
            File.WriteAllText(filename, string.Empty);
        }
    }
}