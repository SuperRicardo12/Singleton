using System;
using System.Collections.Generic;

namespace SingletonLib
{
    public class DbManager
    {
        private static DbManager _instance;
        private bool isConnected = false; 

        private DbManager() { }

        public static DbManager GetInstance()
        {
            if (_instance == null)
                _instance = new DbManager();
            return _instance;
        }

        public void Connect()
        {
            isConnected = true; 
            Console.WriteLine("Підключено до бази даних");
        }

        public bool IsConnected()
        {
            return isConnected; 
        }
    }

    public class DocumentSaver
    {
        private static DocumentSaver _instance;
        private DocumentSaver() { }

        public static DocumentSaver GetInstance()
        {
            if (_instance == null)
                _instance = new DocumentSaver();
            return _instance;
        }

        public void SaveDocument(string document)
        {
            if (string.IsNullOrWhiteSpace(document))
            {
                Console.WriteLine("Помилка: Назва документа не може бути порожньою.");
            }
            else
            {
                Console.WriteLine("Документ збережено: " + document);
            }
        }
    }

    public class Logger
    {
        private static Logger _instance;
        private List<string> logs = new List<string>(); 

        private Logger() { }

        public static Logger GetInstance()
        {
            if (_instance == null)
                _instance = new Logger();
            return _instance;
        }

        public void Log(string message)
        {
            string logMessage = DateTime.Now + ": " + message;
            logs.Add(logMessage); 
            Console.WriteLine("Лог: " + logMessage);
        }

        public List<string> GetLogs()
        {
            return logs; 
        }
    }
}




