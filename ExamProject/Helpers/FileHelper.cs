﻿using ExamProject.Extentions;

namespace ExamProject.Helpers
{
    public static class FileHelper
    {
        public static string ReadFromFile(string filePath)
        {
            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }
            return File.ReadAllText(filePath);
        }

        public static void WriteToFile<T>(string filePath, List<T> models)
        {
            File.WriteAllLines(filePath, models.ToStringList());
        }
    }
}
